using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.PlanejamentoAlimentar
{
    public partial class UC_PlanejamentoAlimentar : UserControl
    {
        public UC_PlanejamentoAlimentar()
        {
            InitializeComponent();
        }

        private void pctBOrganizandoSemana_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_OrganizandoSemana());
        }

        private void pctBPraticidade_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_Praticidade());
        }
    }
}
