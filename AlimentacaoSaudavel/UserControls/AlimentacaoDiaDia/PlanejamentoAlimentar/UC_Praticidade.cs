using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.PlanejamentoAlimentar
{
    public partial class UC_Praticidade : UserControl
    {
        public UC_Praticidade()
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

        private void AlterarTamanhoFonte(float proporcao)
        {
            label2.Font = new Font(label2.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 14f, 10f));
            label3.Font = new Font(label3.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 14f, 10f));
            label5.Font = new Font(label5.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), FontStyle.Bold);
            label7.Font = new Font(label7.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 14f, 10f));
            label9.Font = new Font(label9.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), FontStyle.Bold);
            label10.Font = new Font(label10.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), FontStyle.Bold);
            label11.Font = new Font(label11.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 14f, 10f));
            label12.Font = new Font(label12.Font.FontFamily, CalcularTamanhoFonte(proporcao, 10f, 12f, 10f), FontStyle.Bold);

            txtDescricaoInicio.Font = new Font(txtDescricaoInicio.Font.FontFamily, CalcularTamanhoFonte(proporcao, 14f, 16f, 14f));
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void UC_Praticidade_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlDica1, 20);
            panelRound.ArredondarCantos(pnlDica2, 20);
            panelRound.ArredondarCantos(pnlDica3, 20);
            panelRound.ArredondarCantos(pnlDica4, 20);
            panelRound.ArredondarCantos(pnlDicasRapidas, 20);
        }

        private void UC_Praticidade_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlDica1, 20);
            panelRound.ArredondarCantos(pnlDica2, 20);
            panelRound.ArredondarCantos(pnlDica3, 20);
            panelRound.ArredondarCantos(pnlDica4, 20);
            panelRound.ArredondarCantos(pnlDicasRapidas, 20);

            float proporcao = this.Width / 1000f;

            AlterarTamanhoFonte(proporcao);
        }
    }
}
