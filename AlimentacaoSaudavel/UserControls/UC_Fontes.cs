using AlimentacaoSaudavel.UserControls.Base;
using AlimentacaoSaudavel.UserControls.ClassificacaoAlimentos;
using AlimentacaoSaudavel.UserControls.MacroNutrientes;
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
    public partial class UC_Fontes : UC_IntroducaoSessoes
    {
        public UC_Fontes()
        {
            InitializeComponent();

            TituloInicio = "Macro Nutrientes";
            DescricaoInicio = "Os macronutrientes são nutrientes que fornecem energia e são necessários em grandes quantidades para o funcionamento adequado do corpo humano. Eles incluem carboidratos, proteínas e gorduras. Cada um desses nutrientes desempenha funções específicas no organismo e é essencial para a manutenção da saúde e do bem-estar.";

            AdicionarSessao("Proteínas", new UC_Proteinas());
            AdicionarSessao("Carboidratos", new UC_Carboidratos());
            AdicionarSessao("Gorduras", new UC_Gorduras());
            AdicionarSessao("Minimamente Processados", new UC_MinProcessados());

        }


    }
}
