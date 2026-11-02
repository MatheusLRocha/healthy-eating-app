using AlimentacaoSaudavel.UserControls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.ClassificacaoAlimentos
{
    public partial class UC_UltraProcessados : UC_InformacaoBase
    {
        public UC_UltraProcessados()
        {
            InitializeComponent();

            Titulo = "Ultra Processados";

            Descricao = "Alimentos ultraprocessados são produtos alimentícios que passaram por múltiplos processos industriais e contêm ingredientes artificiais, como corantes, aromatizantes, emulsificantes e conservantes. Esses alimentos geralmente têm uma vida útil longa e são altamente palatáveis, mas podem ser pobres em nutrientes essenciais e ricos em açúcares, gorduras e sódio. Exemplos incluem refrigerantes, salgadinhos industrializados, biscoitos recheados e refeições prontas congeladas. O consumo excessivo de ultraprocessados está associado a diversos problemas de saúde, incluindo obesidade, diabetes tipo 2 e doenças cardiovasculares.";

            ImagemGrupo.Image = Properties.Resources.UltraProcessados;  
        }
    }
}
