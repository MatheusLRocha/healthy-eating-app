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
    public partial class UC_Gorduras : UC_InformacaoBaseNovo
    {
        public UC_Gorduras()
        {
            InitializeComponent();

            TituloInicio = "Gorduras";

            DescricaoInicio = "São o estoque de energia de longo prazo. Além disso, protegem os órgãos contra impactos, mantêm a temperatura corporal e são indispensáveis para a absorção das vitaminas lipossolúveis (A, D, E e K). Estão presentes em azeite, abacate, castanhas, sementes, peixes, manteiga e outros alimentos. ";

            ImagemGrupo.Image = Properties.Resources.Gorduras;

            Descricao1 = "São nutrientes que fornecem energia a longo prazo e participam de diversas funções do organismo.";

            Descricao2 = "Participam da formação das células, protegem órgãos e auxiliam na absorção das vitaminas A, D, E e K.";

            Descricao3 = "Azeite, abacate, castanhas, sementes, peixes e manteiga.";
        }
    }
}
