using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.AlimentacaoEquilibrada
{
    public partial class UC_AlimentacaoEquilibrada : UserControl
    {
        public UC_AlimentacaoEquilibrada()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

        private static float CalcularTamanhoFonte(float proporcao, float tamanhoMinimo, float tamanhoMaximo, float tamanhoBase)
        {
            float tamanhoOriginal = tamanhoBase * proporcao;


            float tamanhoFonte = Math.Clamp(
                tamanhoOriginal,
                tamanhoMinimo,
                tamanhoMaximo
            );

            return tamanhoFonte;
        }

        private void UC_AlimentacaoEquilibrada_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlQualidade, 20);
            panelRound.ArredondarCantos(pnlQuantidade, 20);
            panelRound.ArredondarCantos(pnlVariedade, 20);
            panelRound.ArredondarCantos(pnlHarmonia, 20);
        }

        private void UC_AlimentacaoEquilibrada_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlQualidade, 20);
            panelRound.ArredondarCantos(pnlQuantidade, 20);
            panelRound.ArredondarCantos(pnlVariedade, 20);
            panelRound.ArredondarCantos(pnlHarmonia, 20);

            float proporcao = (float)this.Width / 1000f;

            txtDescricaoInicio.Font = new Font(txtDescricaoInicio.Font.FontFamily, CalcularTamanhoFonte(proporcao, 14f, 16f, 14f), txtDescricaoInicio.Font.Style);

            label2.Font = new Font(label2.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), label2.Font.Style);
            label3.Font = new Font(label3.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), label3.Font.Style);
            label5.Font = new Font(label5.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), label5.Font.Style);
            label7.Font = new Font(label7.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), label7.Font.Style);
        }
    }
}
