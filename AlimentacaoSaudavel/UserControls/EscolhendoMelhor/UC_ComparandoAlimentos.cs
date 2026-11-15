using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.EscolhendoMelhor
{
    public partial class UC_ComparandoAlimentos : UserControl
    {
        public UC_ComparandoAlimentos()
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

        private void UC_ComparandoAlimentos_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlDicasRapidas, 20);

            panelRound.ArredondarCantos(pnlDica1, 20);
            panelRound.ArredondarCantos(pnlDica2, 20);
            panelRound.ArredondarCantos(pnlDica3, 20);
            panelRound.ArredondarCantos(pnlDica4, 20);

            float proporcao = this.Width / 1000f;

            txtDescricaoInicio.Font = new Font(txtDescricaoInicio.Font.FontFamily, CalcularTamanhoFonte(proporcao, 14f, 16f, 10f), txtDescricaoInicio.Font.Style);
            label29.Font = new Font(label29.Font.FontFamily, CalcularTamanhoFonte(proporcao, 14f, 16f, 10f), label29.Font.Style);

            label2.Font = new Font(label2.Font.FontFamily, CalcularTamanhoFonte(proporcao, 9f, 12f, 8f), label2.Font.Style);
            label3.Font = new Font(label3.Font.FontFamily, CalcularTamanhoFonte(proporcao, 9f, 12f, 8f), label3.Font.Style);
            label7.Font = new Font(label7.Font.FontFamily, CalcularTamanhoFonte(proporcao, 9f, 12f, 8f), label7.Font.Style);
            label11.Font = new Font(label11.Font.FontFamily, CalcularTamanhoFonte(proporcao, 9f, 12f, 8f), label11.Font.Style);
        }

        

        private void UC_ComparandoAlimentos_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlDicasRapidas, 20);

            panelRound.ArredondarCantos(pnlDica1, 20);
            panelRound.ArredondarCantos(pnlDica2, 20);
            panelRound.ArredondarCantos(pnlDica3, 20);
            panelRound.ArredondarCantos(pnlDica4, 20);
        }
    }
}
