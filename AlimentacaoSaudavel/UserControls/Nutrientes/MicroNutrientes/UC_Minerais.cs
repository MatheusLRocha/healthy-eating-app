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
    public partial class UC_Minerais : UC_InformacaoBaseNovo
    {
        public UC_Minerais()
        {
            InitializeComponent();

            TituloInicio = "Minerais";

            DescricaoInicio = "Elementos inorgânicos com funções estruturais e reguladoras. Exemplos incluem o Cálcio (ossos e dentes), o Ferro (transporte de oxigênio no sangue) e o Potássio (contração muscular e ritmo cardíaco). Têm funções estruturais e reguladoras. Leite e derivados fornecem cálcio; carnes e feijões podem fornecer ferro; banana, feijão e batata contêm potássio.";

            ImagemGrupo.Image = Properties.Resources.Minerais;

            Descricao1 = "São nutrientes inorgânicos que desempenham funções estruturais e reguladoras no organismo.";

            Descricao2 = "Participam da formação dos ossos e dentes, do transporte de oxigênio e da contração muscular.";

            Descricao3 = "Leite e derivados (cálcio), carnes e feijões (ferro), banana, feijão e batata (potássio).";
        }
    }
}
