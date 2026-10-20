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
    public partial class UC_Processados : UC_InformacaoBase
    {
        public UC_Processados()
        {
            InitializeComponent();

            Titulo = "Processados";

            Descricao = "Alimentos processados são aqueles que passaram por algum tipo de processamento industrial, como a adição de sal, açúcar, óleos ou conservantes. Esses alimentos podem ter uma vida útil mais longa e podem ser mais convenientes para o consumo. Exemplos incluem pães, queijos, enlatados e produtos congelados. Embora possam ser parte de uma dieta equilibrada, é importante consumi-los com moderação devido ao seu conteúdo de sódio, açúcares e gorduras.";
        }
    }
}
