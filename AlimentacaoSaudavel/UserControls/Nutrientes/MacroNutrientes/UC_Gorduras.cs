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
    public partial class UC_Gorduras : UC_InformacaoBase
    {
        public UC_Gorduras()
        {
            InitializeComponent();

            Titulo = "Gorduras";

            Descricao = "São o estoque de energia de longo prazo. Além disso, protegem os órgãos contra impactos, mantêm a temperatura corporal e são indispensáveis para a absorção das vitaminas lipossolúveis (A, D, E e K). Estão presentes em azeite, abacate, castanhas, sementes, peixes, manteiga e outros alimentos. ";

            ImagemGrupo.Image = Properties.Resources.Gorduras;
        }
    }
}
