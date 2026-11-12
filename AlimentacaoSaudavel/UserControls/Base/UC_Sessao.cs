using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.Base
{
    public partial class UC_Sessao : UserControl
    {
        

        public UC_Sessao()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string TituloSessao
        {
            get => lblSessao.Text;
            set => lblSessao.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Type? TelaResponsavel
        {
            get;
            set;
        }

        public event EventHandler? SessaoClicada;
        private void pctBSessao_Click(object sender, EventArgs e)
        {
            SessaoClicada?.Invoke(this, EventArgs.Empty);
        }
    }
}
