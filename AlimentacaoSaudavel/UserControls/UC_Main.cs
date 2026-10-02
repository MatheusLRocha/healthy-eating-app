using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_Main : UserControl
    {
        private Main _main;

        public UC_Main(Main main)
        {
            InitializeComponent();
            _main = main;
        }



        private void pnlNutrientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNutrientes_Click_1(object sender, EventArgs e)
        {
            UC_Nutrientes ucNutrientes = new UC_Nutrientes();
            _main.addUserControl(ucNutrientes);
        }

        private void pnlClasAlimentos_Click(object sender, EventArgs e)
        {
            UC_ClasAlimentos ucClasAlimentos = new UC_ClasAlimentos();
            _main.addUserControl(ucClasAlimentos);
        }
    }
}
