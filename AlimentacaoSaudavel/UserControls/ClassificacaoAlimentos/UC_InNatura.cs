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
    public partial class UC_InNatura : UC_InformacaoBase
    {
        public UC_InNatura()
        {
            InitializeComponent();

            Titulo = "In Natura";

            Descricao = "Alimentos in natura são aqueles que não passaram por nenhum tipo de processamento industrial. São consumidos em seu estado natural, sem adição de ingredientes ou alterações significativas. Exemplos incluem frutas, verduras, legumes, grãos e carnes frescas. Esses alimentos são ricos em nutrientes essenciais e devem ser a base de uma alimentação saudável.";

            ImagemGrupo.Image = Properties.Resources.InNatura;
        }
    }
}
