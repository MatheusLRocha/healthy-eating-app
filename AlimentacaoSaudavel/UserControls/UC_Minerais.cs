using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_Minerais : UserControl
    {
        public UC_Minerais()
        {
            InitializeComponent();
        }

        private const int POSICAO_MAXIMA = 1400;

        private void UC_Minerais_Resize(object sender, EventArgs e)
        {
            pnlImagem.Left = Math.Min(
                ClientSize.Width - pnlImagem.Width,
                POSICAO_MAXIMA
            );
        }
    }
}
