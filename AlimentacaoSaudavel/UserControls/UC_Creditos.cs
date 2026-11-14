using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_Creditos : UserControl
    {
        public UC_Creditos()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

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

        private void AlterarTamanhoFonte(float proporcao)
        {
            label1.Font = new Font(label1.Font.FontFamily, CalcularTamanhoFonte(proporcao, 16f, 18f), FontStyle.Bold);
            label2.Font = new Font(label2.Font.FontFamily, CalcularTamanhoFonte(proporcao, 16f, 18f), FontStyle.Bold);
            label3.Font = new Font(label3.Font.FontFamily, CalcularTamanhoFonte(proporcao, 16f, 18f), FontStyle.Bold);
            label4.Font = new Font(label4.Font.FontFamily, CalcularTamanhoFonte(proporcao, 16f, 18f), FontStyle.Bold);

            lblDescricao1.Font = new Font(lblDescricao1.Font.FontFamily, CalcularTamanhoFonte(proporcao, 12f, 16f));
            lblDescricao2.Font = new Font(lblDescricao1.Font.FontFamily, CalcularTamanhoFonte(proporcao, 12f, 16f));
            lblDescricao3.Font = new Font(lblDescricao1.Font.FontFamily, CalcularTamanhoFonte(proporcao, 12f, 16f));
            lblDescricao4.Font = new Font(lblDescricao4.Font.FontFamily, CalcularTamanhoFonte(proporcao, 12f, 16f));
        }

        private void UC_Creditos_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 15);

            panelRound.ArredondarCantos(panel1, 15);
            panelRound.ArredondarCantos(panel2, 15);
            panelRound.ArredondarCantos(panel3, 15);
            panelRound.ArredondarCantos(panel4, 15);

            float proporcao = this.Width / 1005f;

            AlterarTamanhoFonte(proporcao);
        }

        private void UC_Creditos_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 15);

            panelRound.ArredondarCantos(panel1, 15);
            panelRound.ArredondarCantos(panel2, 15);
            panelRound.ArredondarCantos(panel3, 15);
            panelRound.ArredondarCantos(panel4, 15);
        }
    }
}
