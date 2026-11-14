using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.AlimentacaoEquilibrada;
using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.PlanejamentoAlimentar;
using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.RotinaCorrida;
using AlimentacaoSaudavel.UserControls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia
{
    public partial class UC_AlimentacaoDiaDia : UC_IntroducaoSessoes
    {
        public UC_AlimentacaoDiaDia()
        {
            // InitializeComponent();

            TituloInicio = "Alimentação do Dia a Dia";
            DescricaoInicio = "Aprenda sobre alimentação e encontre informações que possam ajudar na sua rotina.";

            AdicionarSessao("Alimentação Equilibrada", new UC_AlimentacaoEquilibrada());
            AdicionarSessao("Planejamento Alimentar", new UC_PlanejamentoAlimentar());
            AdicionarSessao("Refeições no dia a dia", new UC_RefeicoesDia());
        }

        
    }
}
