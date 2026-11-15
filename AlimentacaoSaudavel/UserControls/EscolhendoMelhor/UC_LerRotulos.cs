using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.EscolhendoMelhor
{
    public partial class UC_LerRotulos : UserControl
    {
        public UC_LerRotulos()
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

        private void MudarBordas()
        {
            panelRound.ArredondarCantos(panel1, 5);
            panelRound.ArredondarCantos(panel2, 5);
            panelRound.ArredondarCantos(panel3, 5);
            panelRound.ArredondarCantos(panel4, 5);
        }

        private void UC_LerRotulos_Resize(object sender, EventArgs e)
        {
            MudarBordas();

            float proporcao = this.Width / 1000f;

            label10.Font = new Font(label10.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), label10.Font.Style);
            label15.Font = new Font(label15.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), label15.Font.Style);
            label16.Font = new Font(label16.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), label16.Font.Style);
            label17.Font = new Font(label17.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), label17.Font.Style);
        }

        private void UC_LerRotulos_Load(object sender, EventArgs e)
        {
            MudarBordas();
        }
    }
}
