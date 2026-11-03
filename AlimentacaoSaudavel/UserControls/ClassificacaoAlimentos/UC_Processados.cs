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
    public partial class UC_Processados : UC_InformacaoBaseNovo
    {
        public UC_Processados()
        {
            InitializeComponent();

            TituloInicio = "Processados";

            DescricaoInicio = "Alimentos processados são aqueles que passaram por algum tipo de processamento industrial. Esses alimentos podem ter uma vida útil mais longa e podem ser mais convenientes para o consumo. Embora possam ser parte de uma dieta equilibrada, é importante consumi-los com moderação devido ao seu conteúdo de sódio, açúcares e gorduras.";

            ImagemGrupo.Image = Properties.Resources.Processados;

            Descricao1 = "São alimentos que recebem sal, açúcar ou outro ingrediente culinário para aumentar sua durabilidade ou modificar seu sabor.";

            SubTitulo2 = "Quais são suas características?";
            Descricao2 = "Geralmente são produzidos a partir de alimentos in natura ou minimamente processados, com adição de ingredientes.";

            SubTitulo3 = "Exemplos";
            Descricao3 = "Queijos, pães tradicionais, conservas de legumes e peixes enlatados.";
        }
    }
}
