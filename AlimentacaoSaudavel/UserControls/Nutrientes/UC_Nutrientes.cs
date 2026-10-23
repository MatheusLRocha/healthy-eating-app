using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_Nutrientes : UserControl
    {
        public UC_Nutrientes()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

        private void pctBMacro_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_MacroNutrientes());
        }

        private void pctBMicro_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_MicroNutrientes());
        }

        private void pnlMacro_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlMacro, 20);
        }

        private void pnlMicro_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlMicro, 20);
        }

        private void pnlApresentacao_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
        }
    }
}
