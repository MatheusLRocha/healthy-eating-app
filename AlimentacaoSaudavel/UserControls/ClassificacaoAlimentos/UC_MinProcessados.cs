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
    public partial class UC_MinProcessados : UC_InformacaoBase
    {
        public UC_MinProcessados()
        {
            InitializeComponent();

            Titulo = "Minimamente Processados";

            Descricao = "Alimentos minimamente processados são aqueles que passaram por processos simples de conservação, como lavagem, corte, embalagem a vácuo ou refrigeração, sem adição de ingredientes artificiais. Esses alimentos mantêm a maior parte de suas características naturais e nutrientes. Exemplos incluem frutas e vegetais frescos embalados, leite pasteurizado e arroz integral. Eles são uma opção saudável para quem busca praticidade sem comprometer a qualidade nutricional.";

            ImagemGrupo.Image = Properties.Resources.MiniProcessados;
        }
    }
}
