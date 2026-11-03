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
        }
    }
}
