using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia;
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


        private void pctBNutrientes_Click(object sender, EventArgs e)
        {
            UC_Nutrientes ucNutrientes = new UC_Nutrientes();
            _main.addUserControl(ucNutrientes);
        }

        private void pctBClasAlimentos_Click(object sender, EventArgs e)
        {
            UC_ClasAlimentos ucClasAlimentos = new UC_ClasAlimentos();
            _main.addUserControl(ucClasAlimentos);
        }

        private void pctBAlimentacaoDiaDia_Click(object sender, EventArgs e)
        {
            UC_AlimentacaoDiaDia ucAlimentacaoDiaDia = new UC_AlimentacaoDiaDia();
            _main.addUserControl(ucAlimentacaoDiaDia);
        }
    }
}
