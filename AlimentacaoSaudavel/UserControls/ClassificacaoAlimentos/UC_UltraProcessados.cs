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
    public partial class UC_UltraProcessados : UC_InformacaoBaseNovo
    {
        public UC_UltraProcessados()
        {
            InitializeComponent();

            TituloInicio = "Ultra Processados";

            DescricaoInicio = "Alimentos ultraprocessados são produtos alimentícios que passaram por múltiplos processos industriais e contêm ingredientes artificiais. Esses alimentos geralmente têm uma vida útil longa e são altamente palatáveis, mas podem ser pobres em nutrientes essenciais e ricos em açúcares, gorduras e sódio. O consumo excessivo de ultraprocessados está associado a diversos problemas de saúde, incluindo obesidade, diabetes tipo 2 e doenças cardiovasculares.";

            ImagemGrupo.Image = Properties.Resources.UltraProcessados;

            Descricao1 = "São formulações industriais feitas principalmente com substâncias extraídas ou derivadas de alimentos, além de aditivos.";

            SubTitulo2 = "Quais são suas características?";
            Descricao2 = "Frequentemente apresentam muitos ingredientes e utilizam substâncias para modificar sabor, textura, cor e conservação.";

            SubTitulo3 = "Exemplos";
            Descricao3 = "Refrigerantes, salgadinhos de pacote, biscoitos recheados, macarrão instantâneo e muitos produtos industrializados prontos para consumo.";
        }
    }
}
