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

        private void pctBRotulo_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_LerRotulos());
        }
    }
}
