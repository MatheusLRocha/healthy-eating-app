using AlimentacaoSaudavel.UserControls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.ClassificacaoAlimentos
{
    public partial class UC_MinProcessados : UC_InformacaoBaseNovo
    {
        public UC_MinProcessados()
        {
            InitializeComponent();

            TituloInicio = "Minimamente Processados";

            DescricaoInicio = "Alimentos minimamente processados são aqueles que passaram por processos simples de conservação. Esses alimentos mantêm a maior parte de suas características naturais e nutrientes. Eles são uma opção saudável para quem busca praticidade sem comprometer a qualidade nutricional.";

            ImagemGrupo.Image = Properties.Resources.MiniProcessados;

            Descricao1 = "São alimentos obtidos de plantas ou animais, que passaram por alterações mínimas, como limpeza, secagem, moagem e congelamento.";

            SubTitulo2 = "Quais são suas características?";
            Descricao2 = "Geralmente não recebem ingredientes como sal, açúcar ou óleos para modificar sua composição.";

            SubTitulo3 = "Exemplos";
            Descricao3 = "frutas e vegetais frescos embalados, leite pasteurizado e arroz integral";
        }
    }
}
