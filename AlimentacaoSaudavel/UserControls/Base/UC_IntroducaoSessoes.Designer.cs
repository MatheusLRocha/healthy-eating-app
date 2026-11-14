namespace AlimentacaoSaudavel.UserControls.Base
{
    partial class UC_IntroducaoSessoes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlApresentacao = new Panel();
            panel2 = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            tlpSessoes = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            pnlApresentacao.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlApresentacao, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1005, 308);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlApresentacao
            // 
            pnlApresentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlApresentacao.BackColor = Color.FromArgb(227, 238, 220);
            pnlApresentacao.Controls.Add(panel2);
            pnlApresentacao.Location = new Point(8, 8);
            pnlApresentacao.Margin = new Padding(8);
            pnlApresentacao.Name = "pnlApresentacao";
            pnlApresentacao.Size = new Size(989, 292);
            pnlApresentacao.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDescricaoInicio);
            panel2.Controls.Add(txtTitulo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(989, 292);
            panel2.TabIndex = 7;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricaoInicio.Font = new Font("Segoe UI", 12F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(24, 94);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(654, 175);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = "Descrição";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(18, 36);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(108, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Titulo";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1005, 308);
            panel3.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(tlpSessoes);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 308);
            panel4.Name = "panel4";
            panel4.Size = new Size(1005, 373);
            panel4.TabIndex = 14;
            // 
            // tlpSessoes
            // 
            tlpSessoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpSessoes.BackColor = Color.Transparent;
            tlpSessoes.ColumnCount = 1;
            tlpSessoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpSessoes.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tlpSessoes.Location = new Point(55, 103);
            tlpSessoes.Margin = new Padding(8);
            tlpSessoes.Name = "tlpSessoes";
            tlpSessoes.RowCount = 1;
            tlpSessoes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpSessoes.Size = new Size(915, 120);
            tlpSessoes.TabIndex = 0;
            // 
            // UC_IntroducaoSessoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            MinimumSize = new Size(1005, 681);
            Name = "UC_IntroducaoSessoes";
            Size = new Size(1005, 681);
            Load += UC_IntroducaoSessoes_Load;
            Resize += UC_IntroducaoSessoes_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            pnlApresentacao.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlApresentacao;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tlpSessoes;
    }
}
