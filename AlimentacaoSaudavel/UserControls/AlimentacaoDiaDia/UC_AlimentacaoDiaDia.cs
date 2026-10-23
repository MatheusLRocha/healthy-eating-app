using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.AlimentacaoEquilibrada;
using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.PlanejamentoAlimentar;
using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.RotinaCorrida;
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

        private void pctBRefeicoesDia_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_RefeicoesDia());
        }

        private void pctBPlanejamentoAlimentar_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_PlanejamentoAlimentar());
        }
    }
}
