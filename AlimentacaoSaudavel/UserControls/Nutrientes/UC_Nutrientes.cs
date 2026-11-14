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
    public partial class UC_Nutrientes : UC_IntroducaoSessoes
    {
        public UC_Nutrientes()
        {
            // InitializeComponent();

            TituloInicio = "Nutrientes";
            DescricaoInicio = "Os nutrientes são os compostos químicos contidos nos alimentos que as nossas células usam para viver. Eles são divididos em dois grandes blocos:";

            AdicionarSessao("Macro Nutrientes", new UC_MacroNutrientes());
            AdicionarSessao("Micro Nutrientes", new UC_MicroNutrientes());
        }

        
    }
}
