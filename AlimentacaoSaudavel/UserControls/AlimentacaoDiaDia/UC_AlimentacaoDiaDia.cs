using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.AlimentacaoEquilibrada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia
{
    public partial class UC_AlimentacaoDiaDia : UserControl
    {
        public UC_AlimentacaoDiaDia()
        {
            InitializeComponent();
        }

        private void pctBAlimentacaoEquilibrada_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_AlimentacaoEquilibrada());
        }
    }
}
