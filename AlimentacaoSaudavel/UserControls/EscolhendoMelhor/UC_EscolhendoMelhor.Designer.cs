namespace AlimentacaoSaudavel.UserControls.EscolhendoMelhor
{
    partial class UC_EscolhendoMelhor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_EscolhendoMelhor));
            pnlApresentacao = new Panel();
            label1 = new Label();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlSubstituicoes = new Panel();
            pctBSubstituicoes = new PictureBox();
            label6 = new Label();
            pnlComparandoAlimentos = new Panel();
            pctBComparandoAlimentos = new PictureBox();
            label2 = new Label();
            pnlRotulo = new Panel();
            pctBRotulo = new PictureBox();
            label3 = new Label();
            pnlApresentacao.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlSubstituicoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBSubstituicoes).BeginInit();
            pnlComparandoAlimentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBComparandoAlimentos).BeginInit();
            pnlRotulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBRotulo).BeginInit();
            SuspendLayout();
            // 
            // pnlApresentacao
            // 
            pnlApresentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlApresentacao.BackColor = Color.FromArgb(227, 238, 220);
            pnlApresentacao.Controls.Add(label1);
            pnlApresentacao.Controls.Add(txtDescricaoInicio);
            pnlApresentacao.Controls.Add(txtTitulo);
            pnlApresentacao.Location = new Point(40, 17);
            pnlApresentacao.Name = "pnlApresentacao";
            pnlApresentacao.Size = new Size(915, 314);
            pnlApresentacao.TabIndex = 15;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(102, 128, 120);
            label1.Location = new Point(34, 140);
            label1.Name = "label1";
            label1.Size = new Size(558, 127);
            label1.TabIndex = 6;
            label1.Text = "Aprenda a interpretar informações dos alimentos e faça escolhas mais conscientes no dia a dia. Descubra como ler rótulos, comparar produtos e encontrar alternativas para diferentes situações. ";
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Font = new Font("Segoe UI", 14F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(34, 146);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(558, 127);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = "Resumo sobre a sessão";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(34, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(308, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Escolhendo Melhor";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(pnlSubstituicoes, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlComparandoAlimentos, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlRotulo, 0, 0);
            tableLayoutPanel1.Location = new Point(40, 470);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(915, 120);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // pnlSubstituicoes
            // 
            pnlSubstituicoes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSubstituicoes.BackColor = Color.FromArgb(240, 232, 247);
            pnlSubstituicoes.Controls.Add(pctBSubstituicoes);
            pnlSubstituicoes.Controls.Add(label6);
            pnlSubstituicoes.Location = new Point(613, 3);
            pnlSubstituicoes.Name = "pnlSubstituicoes";
            pnlSubstituicoes.Size = new Size(299, 114);
            pnlSubstituicoes.TabIndex = 7;
            // 
            // pctBSubstituicoes
            // 
            pctBSubstituicoes.Image = (Image)resources.GetObject("pctBSubstituicoes.Image");
            pctBSubstituicoes.Location = new Point(26, 45);
            pctBSubstituicoes.Name = "pctBSubstituicoes";
            pctBSubstituicoes.Size = new Size(32, 32);
            pctBSubstituicoes.TabIndex = 8;
            pctBSubstituicoes.TabStop = false;
            pctBSubstituicoes.Click += pctBSubstituicoes_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 72, 47);
            label6.Location = new Point(96, 27);
            label6.Name = "label6";
            label6.Size = new Size(200, 80);
            label6.TabIndex = 5;
            label6.Text = "Substituições práticas";
            // 
            // pnlComparandoAlimentos
            // 
            pnlComparandoAlimentos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlComparandoAlimentos.BackColor = Color.FromArgb(255, 244, 220);
            pnlComparandoAlimentos.Controls.Add(pctBComparandoAlimentos);
            pnlComparandoAlimentos.Controls.Add(label2);
            pnlComparandoAlimentos.Location = new Point(308, 3);
            pnlComparandoAlimentos.Name = "pnlComparandoAlimentos";
            pnlComparandoAlimentos.Size = new Size(299, 114);
            pnlComparandoAlimentos.TabIndex = 6;
            // 
            // pctBComparandoAlimentos
            // 
            pctBComparandoAlimentos.Image = (Image)resources.GetObject("pctBComparandoAlimentos.Image");
            pctBComparandoAlimentos.Location = new Point(26, 45);
            pctBComparandoAlimentos.Name = "pctBComparandoAlimentos";
            pctBComparandoAlimentos.Size = new Size(32, 32);
            pctBComparandoAlimentos.TabIndex = 7;
            pctBComparandoAlimentos.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(96, 27);
            label2.Name = "label2";
            label2.Size = new Size(200, 75);
            label2.TabIndex = 5;
            label2.Text = "Comparando alimentos";
            // 
            // pnlRotulo
            // 
            pnlRotulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRotulo.BackColor = Color.FromArgb(227, 238, 220);
            pnlRotulo.Controls.Add(pctBRotulo);
            pnlRotulo.Controls.Add(label3);
            pnlRotulo.Location = new Point(3, 3);
            pnlRotulo.Name = "pnlRotulo";
            pnlRotulo.Size = new Size(299, 114);
            pnlRotulo.TabIndex = 2;
            // 
            // pctBRotulo
            // 
            pctBRotulo.Image = (Image)resources.GetObject("pctBRotulo.Image");
            pctBRotulo.Location = new Point(26, 45);
            pctBRotulo.Name = "pctBRotulo";
            pctBRotulo.Size = new Size(32, 32);
            pctBRotulo.TabIndex = 6;
            pctBRotulo.TabStop = false;
            pctBRotulo.Click += pctBRotulo_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(132, 27);
            label3.Name = "label3";
            label3.Size = new Size(164, 75);
            label3.TabIndex = 5;
            label3.Text = "Leitura de rótulos";
            // 
            // UC_EscolhendoMelhor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlApresentacao);
            MinimumSize = new Size(1005, 681);
            Name = "UC_EscolhendoMelhor";
            Size = new Size(1005, 681);
            Load += UC_EscolhendoMelhor_Load;
            Resize += UC_EscolhendoMelhor_Resize;
            pnlApresentacao.ResumeLayout(false);
            pnlApresentacao.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pnlSubstituicoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBSubstituicoes).EndInit();
            pnlComparandoAlimentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBComparandoAlimentos).EndInit();
            pnlRotulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBRotulo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlApresentacao;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlSubstituicoes;
        private PictureBox pctBSubstituicoes;
        private Label label6;
        private Panel pnlComparandoAlimentos;
        private PictureBox pctBComparandoAlimentos;
        private Label label2;
        private Panel pnlRotulo;
        private PictureBox pctBRotulo;
        private Label label3;
        private Label label1;
    }
}
