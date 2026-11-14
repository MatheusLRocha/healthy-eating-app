using AlimentacaoSaudavel.UserControls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.EscolhendoMelhor
{
    public partial class UC_EscolhendoMelhor : UC_IntroducaoSessoes
    {
        public UC_EscolhendoMelhor()
        {
            // InitializeComponent();

            TituloInicio = "Escolhendo o Melhor Alimento";
            DescricaoInicio = "Aprenda a interpretar informações dos alimentos e faça escolhas mais conscientes no dia a dia. Descubra como ler rótulos, comparar produtos e encontrar alternativas para diferentes situações.";

            AdicionarSessao("Leitura de Rótulos", new UC_LerRotulos());
            AdicionarSessao("Comparando Alimentos", new UC_ComparandoAlimentos());
            AdicionarSessao("Substituições Práticas", new UC_SubstituicoesPraticas());
        }
    }
}
