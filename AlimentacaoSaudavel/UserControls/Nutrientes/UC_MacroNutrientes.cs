using AlimentacaoSaudavel.UserControls.Base;
using AlimentacaoSaudavel.UserControls.MacroNutrientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_MacroNutrientes : UC_IntroducaoSessoes
    {
        public UC_MacroNutrientes()
        {
            InitializeComponent();

            TituloInicio = "Macro Nutrientes";
            DescricaoInicio = "Os macronutrientes são os nutrientes que o nosso corpo precisa em maiores quantidades. Eles oferecem energia, constituem estruturas do corpo e participam de diversas funções essenciais para a nossa saúde.";

            AdicionarSessao("Proteínas", new UC_Proteinas());
            AdicionarSessao("Carboidratos", new UC_Carboidratos());
            AdicionarSessao("Gorduras", new UC_Gorduras());
        }

        
    }
}
