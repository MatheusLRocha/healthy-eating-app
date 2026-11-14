using AlimentacaoSaudavel.UserControls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.PlanejamentoAlimentar
{
    public partial class UC_PlanejamentoAlimentar : UC_IntroducaoSessoes
    {
        public UC_PlanejamentoAlimentar()
        {
            // InitializeComponent();

            TituloInicio = "Planejamento Alimentar";
            DescricaoInicio = "O planejamento alimentar ajuda a organizar refeições de acordo com a rotina, o tempo disponível, as preferências e as possibilidades de cada pessoa. Não significa seguir um cardápio rígido, mas pensar com antecedência em maneiras de facilitar a alimentação.";

            AdicionarSessao("Organizando a Semana", new UC_OrganizandoSemana());
            AdicionarSessao("Praticidade", new UC_Praticidade());
        }

        
    }
}
