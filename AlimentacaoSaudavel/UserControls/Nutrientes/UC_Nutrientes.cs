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

        private void pnlMacro_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();

            main.addUserControl(new UC_MacroNutrientes());
        }

        private void pnlMicro_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();

            main.addUserControl(new UC_MicroNutrientes());
        }
    }
}
