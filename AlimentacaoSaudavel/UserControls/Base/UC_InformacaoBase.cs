using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.Base
{
    public partial class UC_InformacaoBase : UserControl
    {
        public UC_InformacaoBase()
        {
            InitializeComponent();
        }
        protected PictureBox ImagemGrupo => picImagem;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Titulo
        {
            get => lblTitulo.Text;
            set => lblTitulo.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Descricao
        {
            get => lblDescricao.Text;
            set => lblDescricao.Text = value;
        }

        protected int POSICAO_MAXIMA = 1400;

        private void UC_InformacaoBase_Resize(object sender, EventArgs e)
        {
            pnlImagem.Left = Math.Min(
                ClientSize.Width - pnlImagem.Width,
                POSICAO_MAXIMA
            );
        }
    }
}
