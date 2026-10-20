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
    public partial class UC_Vitaminas : UC_InformacaoBase
    {
        public UC_Vitaminas()
        {
            InitializeComponent();

            Titulo = "Vitaminas";

            Descricao = "Compostos orgânicos que atuam como facilitadores de reações químicas. Por exemplo, a Vitamina C ajuda na imunidade e na absorção de ferro; a Vitamina D atua na saúde dos ossos. Participam de diversas reações e funções do organismo. Frutas, verduras e legumes fornecem diferentes vitaminas; por exemplo, frutas cítricas são fontes de vitamina C e cenoura contém betacaroteno, que pode ser convertido em vitamina A.";
        }
    }
}
