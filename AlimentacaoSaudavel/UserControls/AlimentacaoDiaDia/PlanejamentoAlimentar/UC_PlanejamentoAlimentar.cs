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

        PanelRound panelRound = new PanelRound();

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

        private void UC_PlanejamentoAlimentar_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlOrganizandoSemana, 20);
            panelRound.ArredondarCantos(pnlPraticidade, 20);
        }

        private void UC_PlanejamentoAlimentar_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlOrganizandoSemana, 20);
            panelRound.ArredondarCantos(pnlPraticidade, 20);
        }
    }
}
