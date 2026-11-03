using AlimentacaoSaudavel.UserControls.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls
{
    public partial class UC_Proteinas : UC_InformacaoBaseNovo
    {
        public UC_Proteinas()
        {
            InitializeComponent();

            TituloInicio = "Proteínas";

            DescricaoInicio = "As proteínas funcionam como os tijolos do corpo. Elas quebram-se em aminoácidos para construir e reparar os músculos, a pele, o cabelo e produzir hormônios e anticorpos.";

            ImagemGrupo.Image = Properties.Resources.Proteinas;

            Descricao1 = "São nutrientes formados por aminoácidos, importantes para a estrutura e manutenção do organismo.";

            Descricao2 = "Participam da formação e manutenção dos músculos e tecidos, além de fazerem parte de enzimas e hormônios.";

            Descricao3 = "Carnes, ovos, leite e derivados, feijão, lentilha, ervilha e soja.";

        }
    }
}
