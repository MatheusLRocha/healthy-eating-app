using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_MacroNutrientes : UserControl
    {
        public UC_MacroNutrientes()
        {
            InitializeComponent();
        }

        private void pnlProteinas_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();

            main.addUserControl(new UC_Proteinas());
        }

        private void pnlCarboidratos_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();

            main.addUserControl(new UC_Carboidratos());
        }
    }
}
