using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.EscolhendoMelhor
{
    public partial class UC_EscolhendoMelhor : UserControl
    {
        public UC_EscolhendoMelhor()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

        private void pctBRotulo_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_LerRotulos());
        }

        private void UC_EscolhendoMelhor_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlRotulo, 20);
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlComparandoAlimentos, 20);
            panelRound.ArredondarCantos(pnlSubstituicoes, 20);
        }

        private void UC_EscolhendoMelhor_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlRotulo, 20);
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlComparandoAlimentos, 20);
            panelRound.ArredondarCantos(pnlSubstituicoes, 20);
        }
    }
}
