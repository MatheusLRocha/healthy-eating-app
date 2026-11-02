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
    public partial class UC_Carboidratos : UC_InformacaoBase
    {
        public UC_Carboidratos()
        {
            InitializeComponent();

            Titulo = "Carboidratos";

            Descricao = "São a moeda de energia preferida do organismo. Quando consumidos, transformam-se em glicose, que abastece o cérebro e os músculos rapidamente. Fornecem energia para as atividades do organismo. Estão presentes em alimentos como arroz, batata, mandioca, aveia, milho, pães, massas e frutas.";

            ImagemGrupo.Image = Properties.Resources.Carboidratos;
        }
    }
}
