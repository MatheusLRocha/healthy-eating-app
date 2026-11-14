using AlimentacaoSaudavel.UserControls.Base;
using AlimentacaoSaudavel.UserControls.MicroNutrientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_MicroNutrientes : UC_IntroducaoSessoes
    {
        public UC_MicroNutrientes()
        {
            // InitializeComponent();

            TituloInicio = "Micronutrientes";
            DescricaoInicio = "Os micronutrientes são vitaminas e minerais que o organismo precisa em pequenas quantidades, mas que desempenham funções essenciais. Eles ajudam no crescimento, na imunidade, na produção de energia e no bom funcionamento do corpo.";

            AdicionarSessao("Vitaminas", new UC_Vitaminas());
            AdicionarSessao("Minerais", new UC_Minerais());
        }

        
    }
}
