using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_Vitaminas : UserControl
    {
        public UC_Vitaminas()
        {
            InitializeComponent();
        }

        private const int POSICAO_MAXIMA = 1400;

        private void UC_Vitaminas_Resize(object sender, EventArgs e)
        {
            pnlImagem.Left = Math.Min(
                ClientSize.Width - pnlImagem.Width,
                POSICAO_MAXIMA
            );
        }
    }
}
