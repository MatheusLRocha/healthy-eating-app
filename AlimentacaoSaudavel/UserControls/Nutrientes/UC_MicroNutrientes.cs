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

        private void pctBVitaminas_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_Vitaminas());
        }

        private void pctBMinerais_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_Minerais());
        }
    }
}
