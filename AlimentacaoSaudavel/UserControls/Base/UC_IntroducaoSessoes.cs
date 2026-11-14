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

        public void AdicionarSessao(string titulo, UserControl tela)
        {
            int coluna = tlpSessoes.Controls.Count;

            tlpSessoes.ColumnCount++;

            tlpSessoes.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent, 100f
                )
            );

            float largura = 100f / tlpSessoes.ColumnCount;

            foreach (ColumnStyle style in tlpSessoes.ColumnStyles)
            {
                style.SizeType = SizeType.Percent;
                style.Width = largura;
            }

            UC_Sessao sessao = new UC_Sessao
            {
                TituloSessao = titulo,
                TelaResponsavel = tela,
                Dock = DockStyle.Fill
            };

            panelRound.ArredondarCantos(sessao, 20);

            sessao.SessaoClicada += (sender, e) =>
            {
                Main main = (Main)this.FindForm();

                if (sessao.TelaResponsavel != null)
                {
                    main.addUserControl(sessao.TelaResponsavel);
                }
            };

            tlpSessoes.Controls.Add(sessao, coluna, 0);
        }

        private void UC_IntroducaoSessoes_Resize(object sender, EventArgs e)
        {
            AlterarBordas();
        }

        private void UC_IntroducaoSessoes_Load(object sender, EventArgs e)
        {
            AlterarBordas();
        }
    }
}
