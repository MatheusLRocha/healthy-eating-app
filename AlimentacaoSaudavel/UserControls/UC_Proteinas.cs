using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_Proteinas : UserControl
    {
        public UC_Proteinas()
        {
            InitializeComponent();
        }

        private void pnlConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Resize(object sender, EventArgs e)
        {

        }

        private void pnlImagem_Resize(object sender, EventArgs e)
        {
            if (pnlImagem.Width < 1200)
            {
                panel2.Left = pnlImagem.Width - panel2.Width - 20;
            }
            else
            {
                panel2.Left = 1160;
            }
        }
    }
}
