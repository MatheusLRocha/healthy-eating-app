using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.Base
{
    public partial class UC_InformacaoBaseNovo : UserControl
    {
        public UC_InformacaoBaseNovo()
        {
            InitializeComponent();
        }

        protected PictureBox ImagemGrupo => picImagem;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TituloInicio
        {
            get => lblTituloInicio.Text;
            set => lblTituloInicio.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string DescricaoInicio
        {
            get => lblDescricaoInicio.Text;
            set => lblDescricaoInicio.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Descricao1
        {
            get => lblDescricao1.Text;
            set => lblDescricao1.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Descricao2
        {
            get => lblDescricao2.Text;
            set => lblDescricao2.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Descricao3
        {
            get => lblDescricao3.Text;
            set => lblDescricao3.Text = value;
        }
    }
}
