using AlimentacaoSaudavel.UserControls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_Proteinas : UC_InformacaoBase
    {
        public UC_Proteinas()
        {
            InitializeComponent();

            Titulo = "Proteínas";

            Descricao = "Funcionam como os tijolos do corpo. Elas quebram-se em aminoácidos para construir e reparar os músculos, a pele, o cabelo e produzir hormônios e anticorpos.";

        }
    }
}
