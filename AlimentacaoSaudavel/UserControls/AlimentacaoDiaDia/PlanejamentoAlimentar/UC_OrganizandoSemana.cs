using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.PlanejamentoAlimentar
{
    public partial class UC_OrganizandoSemana : UserControl
    {
        public UC_OrganizandoSemana()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

        private static float CalcularTamanhoFonte(float proporcao)
        {
            float tamanhoOriginal = 10f * proporcao;
            float tamanhoMinimo = 12f;
            float tamanhoMaximo = 14f;

            float tamanhoFonte = Math.Clamp(
                tamanhoOriginal,
                tamanhoMinimo,
                tamanhoMaximo
            );

            return tamanhoFonte;
        }

        private void AlterarTamanhoFonte(float proporcao)
        {
            label2.Font = new Font(label2.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label3.Font = new Font(label3.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label5.Font = new Font(label5.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label7.Font = new Font(label7.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label9.Font = new Font(label9.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label10.Font = new Font(label10.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label11.Font = new Font(label11.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label12.Font = new Font(label12.Font.FontFamily, CalcularTamanhoFonte(proporcao));

            txtDescricaoInicio.Font = new Font(txtDescricaoInicio.Font.FontFamily, CalcularTamanhoFonte(proporcao));
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UC_OrganizandoSemana_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlDica1, 20);
            panelRound.ArredondarCantos(pnlDica2, 20);
            panelRound.ArredondarCantos(pnlDica3, 20);
            panelRound.ArredondarCantos(pnlDica4, 20);
        }

        private void UC_OrganizandoSemana_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlDica1, 20);
            panelRound.ArredondarCantos(pnlDica2, 20);
            panelRound.ArredondarCantos(pnlDica3, 20);
            panelRound.ArredondarCantos(pnlDica4, 20);

            float proporcao = this.Width / 1000f;

            AlterarTamanhoFonte(proporcao);
        }
    }
}
