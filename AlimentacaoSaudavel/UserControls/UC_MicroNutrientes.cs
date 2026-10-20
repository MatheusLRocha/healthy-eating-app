using AlimentacaoSaudavel.UserControls.MicroNutrientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_MicroNutrientes : UserControl
    {
        public UC_MicroNutrientes()
        {
            InitializeComponent();
        }

        private void pnlVitaminas_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();

            main.addUserControl(new UC_Vitaminas());
        }

        private void pnlMinerais_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();

            main.addUserControl(new UC_Minerais());
        }

        private void lblVitaminas_Click(object sender, EventArgs e)
        {
            pnlVitaminas_Click(sender, e);
        }

        private void lblMinerais_Click(object sender, EventArgs e)
        {
            pnlMinerais_Click(sender, e);
        }
    }
}
