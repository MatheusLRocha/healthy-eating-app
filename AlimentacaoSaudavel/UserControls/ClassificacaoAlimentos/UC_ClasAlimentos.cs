using AlimentacaoSaudavel.UserControls.ClassificacaoAlimentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_ClasAlimentos : UserControl
    {
        public UC_ClasAlimentos()
        {
            InitializeComponent();
        }

        PanelRound panelRound = new PanelRound();

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pctBNatura_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_InNatura());
        }

        private void pctBMinProcessados_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_MinProcessados());
        }

        private void pctBProcessados_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_Processados());
        }

        private void pctBUltraprocessados_Click(object sender, EventArgs e)
        {
            Main main = (Main)this.FindForm();
            main.addUserControl(new UC_UltraProcessados());
        }

        private void pnlNatura_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlNatura, 20);
        }

        private void pnlProcessados_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlProcessados, 20);
        }

        private void pnlMinProcessados_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlMinProcessados, 20);
        }

        private void pnlUltraProcessados_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlUltraProcessados, 20);
        }

        private void pnlApresentacao_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
        }
    }
}
