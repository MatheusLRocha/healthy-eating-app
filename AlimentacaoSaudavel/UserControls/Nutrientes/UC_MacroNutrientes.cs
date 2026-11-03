using AlimentacaoSaudavel.UserControls.MacroNutrientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_MacroNutrientes : UserControl
    {
        public UC_MacroNutrientes()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

        private void pctBProteinas_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_Proteinas());
        }

        private void pctBCarboidratos_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_Carboidratos());
        }

        private void pctBGorduras_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_Gorduras());
        }

        private void pnlProteinas_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlProteinas, 20);
        }

        private void pnlCarboidratos_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlCarboidratos, 20);
        }

        private void pnlGorduras_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlGorduras, 20);
        }

        private void pnlApresentacao_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
        }

        private void UC_MacroNutrientes_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlProteinas, 20);
            panelRound.ArredondarCantos(pnlCarboidratos, 20);
            panelRound.ArredondarCantos(pnlGorduras, 20);
            panelRound.ArredondarCantos(pnlApresentacao, 20);
        }
    }
}
