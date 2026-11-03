using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.AlimentacaoEquilibrada
{
    public partial class UC_AlimentacaoEquilibrada : UserControl
    {
        public UC_AlimentacaoEquilibrada()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

        private void UC_AlimentacaoEquilibrada_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlQualidade, 20);
            panelRound.ArredondarCantos(pnlQuantidade, 20);
            panelRound.ArredondarCantos(pnlVariedade, 20);
            panelRound.ArredondarCantos(pnlHarmonia, 20);
        }

        private void UC_AlimentacaoEquilibrada_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlQualidade, 20);
            panelRound.ArredondarCantos(pnlQuantidade, 20);
            panelRound.ArredondarCantos(pnlVariedade, 20);
            panelRound.ArredondarCantos(pnlHarmonia, 20);
        }
    }
}
