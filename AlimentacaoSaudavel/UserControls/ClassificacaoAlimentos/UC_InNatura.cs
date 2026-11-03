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
    public partial class UC_InNatura : UC_InformacaoBaseNovo
    {
        public UC_InNatura()
        {
            InitializeComponent();

            TituloInicio = "In Natura";

            DescricaoInicio = "São consumidos em seu estado natural, sem adição de ingredientes ou alterações significativas. Esses alimentos são ricos em nutrientes essenciais e devem ser a base de uma alimentação saudável.";

            ImagemGrupo.Image = Properties.Resources.InNatura;

            Descricao1 = "Alimentos que não passaram por nenhum tipo de processamento industrial, obtidos diretamente de plantas ou animais";

            SubTitulo2 = "Quais são suas características?";
            Descricao2 = "Geralmente não recebem ingredientes como sal, açúcar ou óleos para modificar sua composição.";

            SubTitulo3 = "Exemplos";
            Descricao3 = "frutas, verduras, legumes, grãos e carnes frescas";
        }
    }
}
