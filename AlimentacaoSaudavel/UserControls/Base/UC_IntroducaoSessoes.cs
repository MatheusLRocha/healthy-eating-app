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

            ConfigurarSessoes(new List<string> { "Sessão1", "Sessão2", "Sessão3" });
        }

        public void ConfigurarSessoes(List<string> sessoes)
        {
            tlpSessoes.Controls.Clear();
            tlpSessoes.ColumnCount = sessoes.Count;

            for (int i = 0; i < sessoes.Count; i++)
            {
                tlpSessoes.ColumnStyles.Add(
                    new ColumnStyle(SizeType.Percent, 100f / sessoes.Count)
                );

                UC_Sessao sessao = new UC_Sessao();

                sessao.TituloSessao = sessoes[i];
                sessao.Dock = DockStyle.Fill;

                tlpSessoes.Controls.Add(sessao, i, 0);
            }
        }
    }
}
