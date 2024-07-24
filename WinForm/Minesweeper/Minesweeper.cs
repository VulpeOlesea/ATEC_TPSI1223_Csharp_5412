using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Minesweeper : Form
    {
        private const int tamanhoCelula = 35;  // Tamanho de cada célula
        private int tamanhoMapa = 8;  // Tamanho inicial do mapa
        private int contadorBombas = 0; // Contador de bombas

        private int[,] mapa;  // Matriz do mapa de jogo
        private CustomButton[,] botoes;  // Matriz de botões

        private Image imgSet;  // Conjunto de imagens

        private bool primeiroPasso;  // Indica se é o primeiro clique

        private Point primeiraCoordenada;  // Coordenada do primeiro clique

        private ToolStripLabel labelContadorBombas;

        public Minesweeper()
        {
            InitializeComponent();
            InicializarComponentes();
            Iniciar();
        }

        // Inicialização dos componentes personalizados
        private void InicializarComponentes()
        {
            // Criação da barra de menu superior
            var menuStrip = new MenuStrip();
            var tamanhoMenu = new ToolStripMenuItem("Tamanho do Campo");

            // Criação das opções de tamanho do campo
            var tamanho8x8 = new ToolStripMenuItem("8 x 8", null, (sender, e) => AlterarTamanhoMapa(8));
            var tamanho12x12 = new ToolStripMenuItem("12 x 12", null, (sender, e) => AlterarTamanhoMapa(12));
            var tamanho15x15 = new ToolStripMenuItem("15 x 15", null, (sender, e) => AlterarTamanhoMapa(15));

            tamanhoMenu.DropDownItems.Add(tamanho8x8);
            tamanhoMenu.DropDownItems.Add(tamanho12x12);
            tamanhoMenu.DropDownItems.Add(tamanho15x15);
            menuStrip.Items.Add(tamanhoMenu);

            // Criação do contador de bombas
            labelContadorBombas = new ToolStripLabel($"Bombas: {contadorBombas}");
            menuStrip.Items.Add(labelContadorBombas);

            this.Controls.Add(menuStrip);
        }

        // Alteração do tamanho do campo
        private void AlterarTamanhoMapa(int novoTamanho)
        {
            tamanhoMapa = novoTamanho;
            this.Controls.Clear();
            InicializarComponentes();
            Iniciar();
        }

        // Inicialização do jogo
        private void Iniciar()
        {
            primeiroPasso = true;
            imgSet = new Bitmap(Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.FullName.ToString(), "Img\\tiles.png"));
            ConfigurarTamanhoMapa();
            IniciarMapa();
            IniciarBotoes();
            AtualizarContadorBombas();
        }

        // Configuração do tamanho do formulário com base no tamanho do mapa
        private void ConfigurarTamanhoMapa()
        {
            this.Width = tamanhoMapa * tamanhoCelula + 20;
            this.Height = (tamanhoMapa + 1) * tamanhoCelula + 50;  // +50 para a barra de menu superior
        }

        // Inicialização da matriz do mapa com zeros
        private void IniciarMapa()
        {
            mapa = new int[tamanhoMapa, tamanhoMapa];
            for (int i = 0; i < tamanhoMapa; i++)
            {
                for (int j = 0; j < tamanhoMapa; j++)
                {
                    mapa[i, j] = 0;
                }
            }
        }

        // Inicialização dos botões no mapa
        private void IniciarBotoes()
        {
            botoes = new CustomButton[tamanhoMapa, tamanhoMapa];
            for (int i = 0; i < tamanhoMapa; i++)
            {
                for (int j = 0; j < tamanhoMapa; j++)
                {
                    CustomButton botao = new CustomButton
                    {
                        Location = new Point(j * tamanhoCelula, i * tamanhoCelula + 30),  // +30 para a barra de menu superior
                        Size = new Size(tamanhoCelula, tamanhoCelula),
                        Image = EncontrarImagem(4, 1)
                    };

                    botao.MouseUp += new MouseEventHandler(BotaoPressionadoRato);
                    this.Controls.Add(botao);
                    botoes[i, j] = botao;
                }
            }
        }

        // Manipulação de eventos de clique do rato nos botões
        private void BotaoPressionadoRato(object sender, MouseEventArgs e)
        {
            var botaoPressionado = sender as CustomButton;
            switch (e.Button)
            {
                case MouseButtons.Right:
                    BotaoDireitoRato(botaoPressionado);
                    break;
                case MouseButtons.Left:
                    BotaoEsquerdoRato(botaoPressionado);
                    break;
            }
            VerificarVitoria();
        }

        // Manipulação do clique do botão direito do rato
        private void BotaoDireitoRato(CustomButton botaoPressionado)
        {
            if (!botaoPressionado.Enabled)
                return;

            botaoPressionado.HasFlag = !botaoPressionado.HasFlag;
            if (botaoPressionado.HasFlag)
            {
                botaoPressionado.Image = EncontrarImagem(0, 2);
                contadorBombas--;
            }
            else
            {
                botaoPressionado.Image = EncontrarImagem(4, 1);
                contadorBombas++;
            }

            AtualizarContadorBombas();
        }

        // Manipulação do clique do botão esquerdo do rato
        private void BotaoEsquerdoRato(CustomButton botaoPressionado)
        {
            int iBotao = botaoPressionado.Location.Y / tamanhoCelula;
            int jBotao = botaoPressionado.Location.X / tamanhoCelula;
            if (primeiroPasso)
            {
                primeiraCoordenada = new Point(jBotao, iBotao);
                SemearMapa();
                ContarBombasCelula();
                primeiroPasso = false;
            }
            AbrirCelulas(iBotao, jBotao);

            if (mapa[iBotao, jBotao] == -1)
            {
                MostrarTodasBombas(iBotao, jBotao);
                int resposta = Convert.ToInt32(MessageBox.Show("BIG BADA BOOM! \n\nGame Over! \n\nQuer jogar novamente?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Stop));

                if (resposta == 7)
                {
                    Application.Exit();
                }
                else
                {
                    this.Controls.Clear();
                    InicializarComponentes();
                    Iniciar();
                }
            }
        }

        // Atualização do contador de bombas
        private void AtualizarContadorBombas()
        {
            labelContadorBombas.Text = $"Bombas: {contadorBombas}";
        }

        // Mostrar todas as bombas no mapa quando o jogador perde
        private void MostrarTodasBombas(int iBomba, int jBomba)
        {
            for (int i = 0; i < tamanhoMapa; i++)
            {
                for (int j = 0; j < tamanhoMapa; j++)
                {
                    if (i == iBomba && j == jBomba)
                        continue;
                    if (mapa[i, j] == -1)
                    {
                        botoes[i, j].Image = EncontrarImagem(3, 2);
                    }
                }
            }
        }

        // Encontrar e retornar a imagem necessária com base nas coordenadas
        public Image EncontrarImagem(int xPos, int yPos)
        {
            Image imagem = new Bitmap(tamanhoCelula, tamanhoCelula);
            Graphics g = Graphics.FromImage(imagem);
            g.DrawImage(imgSet, new Rectangle(new Point(0, 0), new Size(tamanhoCelula, tamanhoCelula)), 0 + 32 * xPos, 0 + 32 * yPos, 33, 33, GraphicsUnit.Pixel);

            return imagem;
        }

        // Semear bombas no mapa
        private void SemearMapa()
        {
            Random r = new Random();
            int number = r.Next(tamanhoMapa, tamanhoMapa * 2);  // Número de bombas proporcional ao tamanho do mapa
            contadorBombas = number; // Inicialização do contador de bombas

            for (int i = 0; i < number; i++)
            {
                int posI = r.Next(0, tamanhoMapa);
                int posJ = r.Next(0, tamanhoMapa);

                while (mapa[posI, posJ] == -1 || (Math.Abs(posI - primeiraCoordenada.Y) <= 1 && Math.Abs(posJ - primeiraCoordenada.X) <= 1))
                {
                    posI = r.Next(0, tamanhoMapa);
                    posJ = r.Next(0, tamanhoMapa);
                }
                mapa[posI, posJ] = -1;
            }

            AtualizarContadorBombas();
        }

        // Contagem de bombas ao redor de cada célula e atualização do mapa
        private void ContarBombasCelula()
        {
            for (int i = 0; i < tamanhoMapa; i++)
            {
                for (int j = 0; j < tamanhoMapa; j++)
                {
                    if (mapa[i, j] == -1)
                    {
                        for (int k = i - 1; k <= i + 1; k++)
                        {
                            for (int l = j - 1; l <= j + 1; l++)
                            {
                                if (EstaNoLimite(k, l) && mapa[k, l] != -1)
                                {
                                    mapa[k, l]++;
                                }
                            }
                        }
                    }
                }
            }
        }

        // Abertura de uma célula específica e atualização da imagem com base no número de bombas ao redor
        private void AbrirCelula(int i, int j)
        {
            botoes[i, j].Enabled = false;

            switch (mapa[i, j])
            {
                case 1:
                    botoes[i, j].Image = EncontrarImagem(1, 0);
                    break;
                case 2:
                    botoes[i, j].Image = EncontrarImagem(2, 0);
                    break;
                case 3:
                    botoes[i, j].Image = EncontrarImagem(3, 0);
                    break;
                case 4:
                    botoes[i, j].Image = EncontrarImagem(4, 0);
                    break;
                case 5:
                    botoes[i, j].Image = EncontrarImagem(0, 1);
                    break;
                case 6:
                    botoes[i, j].Image = EncontrarImagem(1, 1);
                    break;
                case 7:
                    botoes[i, j].Image = EncontrarImagem(2, 1);
                    break;
                case 8:
                    botoes[i, j].Image = EncontrarImagem(3, 1);
                    break;
                case -1:
                    botoes[i, j].Image = EncontrarImagem(1, 2);
                    break;
                case 0:
                    botoes[i, j].Image = EncontrarImagem(0, 0);
                    break;
            }
        }

        // Abertura de células ao redor de uma célula específica, se não houver bombas ao redor
        private void AbrirCelulas(int i, int j)
        {
            if (!EstaNoLimite(i, j) || !botoes[i, j].Enabled)
                return;

            AbrirCelula(i, j);

            if (mapa[i, j] == 0)
            {
                for (int k = i - 1; k <= i + 1; k++)
                {
                    for (int l = j - 1; l <= j + 1; l++)
                    {
                        if ((k != i || l != j) && EstaNoLimite(k, l) && botoes[k, l].Enabled)
                        {
                            AbrirCelulas(k, l);
                        }
                    }
                }
            }
        }

        // Verificação se as coordenadas estão dentro dos limites do mapa
        private bool EstaNoLimite(int i, int j)
        {
            return i >= 0 && j >= 0 && i < tamanhoMapa && j < tamanhoMapa;
        }

        // Verificação se o jogador venceu o jogo
        private void VerificarVitoria()
        {
            for (int i = 0; i < tamanhoMapa; i++)
            {
                for (int j = 0; j < tamanhoMapa; j++)
                {
                    if (mapa[i, j] == -1 && !botoes[i, j].HasFlag)
                    {
                        return;
                    }

                    if (mapa[i, j] != -1 && botoes[i, j].Enabled)
                    {
                        return;
                    }
                }
            }

            int resposta = Convert.ToInt32(MessageBox.Show("Parabéns! \n\nGanhou! \n\nQuer jogar novamente?", "Vitoria", MessageBoxButtons.YesNo, MessageBoxIcon.Information));

            if (resposta == 7)
            {
                Application.Exit();
            }
            else
            {
                this.Controls.Clear();
                InicializarComponentes();
                Iniciar();
            }
        }
    }

    public class CustomButton : Button
    {
        public bool HasFlag { get; set; } = false;

        // Desenha a imagem no botão quando ele está desativado
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (!this.Enabled && this.Image != null)
            {
                pevent.Graphics.DrawImage(this.Image, new Point(0, 0));
            }
        }
    }
}
