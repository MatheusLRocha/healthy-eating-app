using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.EscolhendoMelhor
{
    public partial class UC_SubstituicoesPraticas : UserControl
    {
        public UC_SubstituicoesPraticas()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

        private static float CalcularTamanhoFonte(float proporcao)
        {
            float tamanhoOriginal = 10f * proporcao;
            float tamanhoMinimo = 10f;
            float tamanhoMaximo = 14f;

            float tamanhoFonte = Math.Clamp(
                tamanhoOriginal,
                tamanhoMinimo,
                tamanhoMaximo
            );

            return tamanhoFonte;
        }

        private static float CalcularTamanhoFonteExemplos(float proporcao)
        {
            float tamanhoOriginal = 8f * proporcao;
            float tamanhoMinimo = 8f;
            float tamanhoMaximo = 10f;
            float tamanhoFonte = Math.Clamp(
                tamanhoOriginal,
                tamanhoMinimo,
                tamanhoMaximo
            );
            return tamanhoFonte;
        }

        private void AlterarTamanhoFonte(float proporcao)
        {
            label1.Font = new Font(label1.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label2.Font = new Font(label2.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label3.Font = new Font(label3.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            label5.Font = new Font(label5.Font.FontFamily, CalcularTamanhoFonte(proporcao));
        }

        private void AlterarTamanhoFonteExemplos(float proporcao)
        {
            label7.Font = new Font(label7.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label8.Font = new Font(label8.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label9.Font = new Font(label9.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label10.Font = new Font(label10.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label11.Font = new Font(label11.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label12.Font = new Font(label12.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label14.Font = new Font(label14.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label15.Font = new Font(label15.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label16.Font = new Font(label16.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label17.Font = new Font(label17.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label18.Font = new Font(label18.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
            label19.Font = new Font(label19.Font.FontFamily, CalcularTamanhoFonteExemplos(proporcao), FontStyle.Bold);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_SubstituicoesPraticas_Resize(object sender, EventArgs e)
        {
            float proporcao = this.Width / 1000f;

            AlterarTamanhoFonte(proporcao);
            AlterarTamanhoFonteExemplos(proporcao);

            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlDica1, 20);
            panelRound.ArredondarCantos(pnlDica2, 20);
            panelRound.ArredondarCantos(pnlDica3, 20);
        }
    }
}
