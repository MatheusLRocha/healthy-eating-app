using AlimentacaoSaudavel.UserControls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.MacroNutrientes
{
    public partial class UC_Carboidratos : UC_InformacaoBaseNovo
    {
        public UC_Carboidratos()
        {
            InitializeComponent();

            TituloInicio = "Carboidratos";

            DescricaoInicio = "São a moeda de energia preferida do organismo. Quando consumidos, transformam-se em glicose, que abastece o cérebro e os músculos rapidamente. Fornecem energia para as atividades do organismo. Estão presentes em alimentos como arroz, batata, mandioca, aveia, milho, pães, massas e frutas.";

            ImagemGrupo.Image = Properties.Resources.Carboidratos;

            Descricao1 = "São nutrientes que fornecem energia para o funcionamento do organismo.";

            Descricao2 = "Fornecem energia para atividades cotidianas e para o funcionamento do cérebro e dos músculos.";

            Descricao3 = "Arroz, batata, mandioca, aveia, milho, pães, massas e frutas.";
        }
    }
}
