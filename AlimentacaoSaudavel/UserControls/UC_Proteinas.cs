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

        private void pnlImagem_Resize(object sender, EventArgs e)
        {
            int novaPosicao = pnlImagem.Width - panel2.Width - 20;

            if (pnlImagem.Width < 1200)
            {
                panel2.Left = pnlImagem.Width - panel2.Width - 20;
            }
            else
            {
                panel2.Left = 1160;
            }
        }

        private const int POSICAO_MAXIMA = 1400;

        private void UC_Proteinas_Resize(object sender, EventArgs e)
        {
            pnlImagem.Left = Math.Min(
                ClientSize.Width - pnlImagem.Width,
                POSICAO_MAXIMA
            );
        }

        private void pnlImagem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
