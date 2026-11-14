using AlimentacaoSaudavel.UserControls.Base;
using AlimentacaoSaudavel.UserControls.ClassificacaoAlimentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_ClasAlimentos : UC_IntroducaoSessoes
    {
        public UC_ClasAlimentos()
        {
            // InitializeComponent();

            TituloInicio = "Classificação dos Alimentos";
            DescricaoInicio = "Os alimentos podem ser divididos em grandes 4 áreas, sendo elas:";

            AdicionarSessao("In natura", new UC_InNatura());
            AdicionarSessao("Minimamente Processados", new UC_MinProcessados());
            AdicionarSessao("Processados", new UC_Processados());
            AdicionarSessao("Ultraprocessados", new UC_UltraProcessados());
        }

        
    }
}
