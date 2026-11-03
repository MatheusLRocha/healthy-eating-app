using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.RotinaCorrida
{
    public partial class UC_RefeicoesDia : UserControl
    {
        public UC_RefeicoesDia()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

        private void UC_RefeicoesDia_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlCafeManha, 20);
            panelRound.ArredondarCantos(pnlAlmoco, 20);
            panelRound.ArredondarCantos(pnlJanta, 20);
            panelRound.ArredondarCantos(pnlLanches, 20);
            panelRound.ArredondarCantos(pnlDica, 20);
        }

        private void UC_RefeicoesDia_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlCafeManha, 20);
            panelRound.ArredondarCantos(pnlAlmoco, 20);
            panelRound.ArredondarCantos(pnlJanta, 20);
            panelRound.ArredondarCantos(pnlLanches, 20);
            panelRound.ArredondarCantos(pnlDica, 20);
        }
    }
}
