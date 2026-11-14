using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.Base
{
    public partial class UC_IntroducaoSessoes : UserControl
    {
        public UC_IntroducaoSessoes()
        {
            InitializeComponent();

            // ConfigurarSessoes(new List<string> { "Sessão1", "Sessão2", "Sessão3" });
        }

        PanelRound panelRound = new PanelRound();

        private void AlterarBordas()
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TituloInicio
        {
            get => txtTitulo.Text;
            set => txtTitulo.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DescricaoInicio
        {
            get => txtDescricaoInicio.Text;
            set => txtDescricaoInicio.Text = value;
        }

        private static float CalcularTamanhoFonte(float proporcao, float tamanhoMinimo, float tamanhoMaximo)
        {
            float tamanhoOriginal = 10f * proporcao;
            

            float tamanhoFonte = Math.Clamp(
                tamanhoOriginal,
                tamanhoMinimo,
                tamanhoMaximo
            );

            return tamanhoFonte;
        }

        public void AdicionarSessao(string titulo, UserControl tela)
        {
            int coluna = tlpSessoes.Controls.Count;

            tlpSessoes.ColumnCount = coluna + 1;
            tlpSessoes.ColumnStyles.Clear();

            float largura = 100f / tlpSessoes.ColumnCount;

            for (int i = 0; i < tlpSessoes.ColumnCount; i++)
            {
                tlpSessoes.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, largura)
                );
            }

            UC_Sessao sessao = new UC_Sessao
            {
                TituloSessao = titulo,
                TelaResponsavel = tela,
                Dock = DockStyle.Fill,
                Margin = new Padding(3)
            };

            sessao.Resize += (sender, e) =>
            {
                panelRound.ArredondarCantos(sessao, 20);
            };

            sessao.SessaoClicada += (sender, e) =>
            {
                Main main = (Main)this.FindForm();

                if (sessao.TelaResponsavel != null)
                {
                    main.addUserControl(sessao.TelaResponsavel);
                }
            };

            sessao.Resize += (sender, e) =>
            {
                sessao.LabelSessao.Font = new Font(sessao.LabelSessao.Font.FontFamily, CalcularTamanhoFonte(this.Width / 1000f, 13f, 16f), FontStyle.Bold);
            };

            tlpSessoes.Controls.Add(sessao, coluna, 0);

            panelRound.ArredondarCantos(sessao, 20);
        }

        private void UC_IntroducaoSessoes_Resize(object sender, EventArgs e)
        {
            AlterarBordas();

            float proporcao = this.Width / 1000f;

            txtDescricaoInicio.Font = new Font(txtDescricaoInicio.Font.FontFamily, CalcularTamanhoFonte(proporcao, 12f, 18f));
        }

        private void UC_IntroducaoSessoes_Load(object sender, EventArgs e)
        {
            AlterarBordas();
        }
    }
}
