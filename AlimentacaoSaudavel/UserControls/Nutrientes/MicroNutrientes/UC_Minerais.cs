using AlimentacaoSaudavel.UserControls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.MicroNutrientes
{
    public partial class UC_Minerais : UC_InformacaoBase
    {
        public UC_Minerais()
        {
            InitializeComponent();

            Titulo = "Minerais";

            Descricao = "Elementos inorgânicos com funções estruturais e reguladoras. Exemplos incluem o Cálcio (ossos e dentes), o Ferro (transporte de oxigênio no sangue) e o Potássio (contração muscular e ritmo cardíaco). Têm funções estruturais e reguladoras. Leite e derivados fornecem cálcio; carnes e feijões podem fornecer ferro; banana, feijão e batata contêm potássio.";

            ImagemGrupo.Image = Properties.Resources.Minerais;
        }
    }
}
