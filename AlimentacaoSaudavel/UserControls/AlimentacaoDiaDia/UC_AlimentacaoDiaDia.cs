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

        PanelRound panelRound = new PanelRound();

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

        private void UC_AlimentacaoDiaDia_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlAlimentacaoEquilibrada, 20);
            panelRound.ArredondarCantos(pnlRefeicoesDia, 20);
            panelRound.ArredondarCantos(pnlPlanejamentoAlimentar, 20);
            panelRound.ArredondarCantos(pnlApresentacao, 20);
        }

        private void UC_AlimentacaoDiaDia_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlAlimentacaoEquilibrada, 20);
            panelRound.ArredondarCantos(pnlRefeicoesDia, 20);
            panelRound.ArredondarCantos(pnlPlanejamentoAlimentar, 20);
            panelRound.ArredondarCantos(pnlApresentacao, 20);
        }
    }
}
