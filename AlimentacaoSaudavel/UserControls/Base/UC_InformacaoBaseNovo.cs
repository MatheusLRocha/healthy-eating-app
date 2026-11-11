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

        PanelRound panelRound = new PanelRound();

        private void UC_InformacaoBaseNovo_Load(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlDescricao1, 20);
            panelRound.ArredondarCantos(pnlDescricao2, 20);
            panelRound.ArredondarCantos(pnlDescricao3, 20);
        }

        private static float CalcularTamanhoFonte(float proporcao)
        {
            float tamanhoMinimo = 10f * proporcao;
            float tamanhoIdeal = 12f;
            float tamanhoMaximo = 20f;

            float tamanhoFonte = Math.Clamp(
                tamanhoMinimo,
                tamanhoIdeal,
                tamanhoMaximo
            );

            return tamanhoFonte;
        }

        private void UC_InformacaoBaseNovo_Resize(object sender, EventArgs e)
        {
            panelRound.ArredondarCantos(pnlApresentacao, 20);
            panelRound.ArredondarCantos(pnlDescricao1, 20);
            panelRound.ArredondarCantos(pnlDescricao2, 20);
            panelRound.ArredondarCantos(pnlDescricao3, 20);

            float proporcao = this.Width / 1000f;

            lblDescricao1.Font = new Font(lblDescricao1.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            lblDescricao2.Font = new Font(lblDescricao1.Font.FontFamily, CalcularTamanhoFonte(proporcao));
            lblDescricao3.Font = new Font(lblDescricao1.Font.FontFamily, CalcularTamanhoFonte(proporcao));
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
        public string SubTitulo1
        {
            get => lblSubtitulo1.Text;
            set => lblSubtitulo1.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Descricao1
        {
            get => lblDescricao1.Text;
            set => lblDescricao1.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string SubTitulo2
        {
            get => lblSubtitulo2.Text;
            set => lblSubtitulo2.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Descricao2
        {
            get => lblDescricao2.Text;
            set => lblDescricao2.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string SubTitulo3
        {
            get => lblSubtitulo3.Text;
            set => lblSubtitulo3.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Descricao3
        {
            get => lblDescricao3.Text;
            set => lblDescricao3.Text = value;
        }
    }
}
