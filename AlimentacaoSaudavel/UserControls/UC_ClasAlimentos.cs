using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_ClasAlimentos : UserControl
    {
        public UC_ClasAlimentos()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pnlNatura_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();

            main.addUserControl(new UC_Natura());
        }

        private void pnlMinProcessados_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();

            main.addUserControl(new UC_MinProcessados());
        }

        private void pnlProcessados_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();

            main.addUserControl(new UC_Processados());
        }
    }
}
