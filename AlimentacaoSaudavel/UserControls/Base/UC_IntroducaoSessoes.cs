using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlimentacaoSaudavel.UserControls.Base
{
    public partial class UC_IntroducaoSessoes : UserControl
    {
        public UC_IntroducaoSessoes()
        {
            InitializeComponent();

            // ConfigurarSessoes(new List<string> { "Sessão1", "Sessão2", "Sessão3" });
        }

        public void AdicionarSessao(string titulo, UserControl tela)
        {
            int coluna = tlpSessoes.Controls.Count;

            tlpSessoes.ColumnCount++;

            tlpSessoes.ColumnStyles.Add(
                new ColumnStyle(
                    SizeType.Percent, 100f / tlpSessoes.ColumnCount
                )
            );

            UC_Sessao sessao = new UC_Sessao
            {
                TituloSessao = titulo,
                TelaResponsavel = tela
            };

            sessao.SessaoClicada += (sender, e) =>
            {
                Main main = (Main)this.FindForm();

                if (sessao.TelaResponsavel != null)
                {
                    main.addUserControl(sessao.TelaResponsavel);
                }
            };

            tlpSessoes.Controls.Add(sessao, coluna, 0);
        }
    }
}
