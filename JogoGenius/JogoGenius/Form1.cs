using System.Drawing.Design;

namespace JogoGenius
{
    public partial class Form1 : Form
    {

        int sequenciaSelecionada = -1;
        int sequenciaAtual = 0;
        int aux = 0;
        List<Button> Sequencia;
        Color corPadrao;
        Color corPiscando;
        bool piscando = false;
        int nivel = 0;


        string corVerdePadrão = "#004700";
        string corAmareloPadrão = "#F0B200";
        string corVermelhoPadrão = "#A80A00";
        string corAzulPadrão = "#06006B";

        string corVerdePiscando = "#008A00";
        string corAmareloPiscando = "#FFD047";
        string corVermelhoPiscando = "#F50E00";
        string corAzulPiscando = "#0C00D6";

        public Form1()
        {

            InitializeComponent();

            btVerde.BackColor = ColorTranslator.FromHtml(corVerdePadrão);
            btAmarelo.BackColor = ColorTranslator.FromHtml(corAmareloPadrão);
            btVermelho.BackColor = ColorTranslator.FromHtml(corVermelhoPadrão);
            btAzul.BackColor = ColorTranslator.FromHtml(corAzulPadrão);


            btVerde.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVerdePadrão);
            btAmarelo.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAmareloPadrão);
            btVermelho.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corVermelhoPadrão);
            btAzul.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(corAzulPadrão);

            btVerde.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corVerdePiscando);
            btAmarelo.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAmareloPiscando);
            btVermelho.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corVermelhoPiscando);
            btAzul.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(corAzulPiscando);

            btVerde.Cursor = Cursors.Hand;
            btAmarelo.Cursor = Cursors.Hand;
            btVermelho.Cursor = Cursors.Hand;
            btAzul.Cursor = Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            sequenciaSelecionada = -1;
            Sequencia = new List<Button>();
            btIniciar.Enabled = false;

            nivel++;
            lbNivel1.Text = nivel.ToString();

            GerarSequencia();
            Piscando();
            HabilitaDesabilitaBotao(true);
        }

        private void GerarSequencia()
        {
            Random random = new Random();
            int num = random.Next(0, 4);

            Button bt = null;

            switch (num)
            {
                case 0:
                    bt = btVerde;
                    break;
                case 1:
                    bt = btAmarelo;
                    break;
                case 2:
                    bt = btVermelho;
                    break;
                case 3:
                    bt = btAzul;
                    break;

            }
            Sequencia.Add(bt);

        }

        private void Piscando()
        {
            aux = 0;

            for (int i = 0; i < Sequencia.Count; i++)
            {
                sequenciaAtual = i;

                corPadrao = Sequencia[i].BackColor;

                if (Sequencia[i] == btVerde)
                {
                    corPiscando = ColorTranslator.FromHtml(corVerdePiscando);
                }
                else if (Sequencia[i] == btAmarelo)
                {
                    corPiscando = ColorTranslator.FromHtml(corAmareloPiscando);
                }
                else if (Sequencia[i] == btVermelho)
                {
                    corPiscando = ColorTranslator.FromHtml(corVermelhoPiscando);
                }
                else if (Sequencia[i] == btAzul)
                {
                    corPiscando = ColorTranslator.FromHtml(corAzulPiscando);
                }

                timer1.Start();
                while(aux == i)
                {
                    Application.DoEvents();
                }
            }
        }

        private void HabilitaDesabilitaBotao(bool habilita)
        {
            btVerde.Enabled = habilita;
            btAmarelo.Enabled = habilita;
            btVermelho.Enabled = habilita;
            btAzul.Enabled = habilita;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!piscando)
            {
                Sequencia[sequenciaAtual].BackColor = corPiscando;
                piscando = true;
            }
            else
            {
                Sequencia[sequenciaAtual].BackColor = corPadrao;
                piscando = false;
                aux++;
                timer1.Stop();
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            sequenciaSelecionada++;
            if (Sequencia[sequenciaSelecionada] == (Button)sender)
            {
                if (Sequencia.Count - 1 == sequenciaSelecionada)
                {
                    nivel++;
                    lbNivel1.Text = nivel.ToString();
                    sequenciaSelecionada = -1;
                    HabilitaDesabilitaBotao(false);
                    GerarSequencia();
                    Thread.Sleep(500);
                    Piscando();
                    HabilitaDesabilitaBotao(true);
                }
            }
            else
            {
                btIniciar.Enabled = true;
                HabilitaDesabilitaBotao(false);
                nivel = 0;
                lbNivel1.Text = "";
                MessageBox.Show("Sequencia incorreta! Fim de jogo!!");

            }
        }
    }
}
