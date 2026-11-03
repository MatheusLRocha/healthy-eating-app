namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_MicroNutrientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MicroNutrientes));
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlVitaminas = new Panel();
            pctBVitaminas = new PictureBox();
            lblVitaminas = new Label();
            pnlMinerais = new Panel();
            pctBMinerais = new PictureBox();
            lblMinerais = new Label();
            pnlApresentacao = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlVitaminas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBVitaminas).BeginInit();
            pnlMinerais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBMinerais).BeginInit();
            pnlApresentacao.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlVitaminas, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlMinerais, 1, 0);
            tableLayoutPanel1.Location = new Point(40, 470);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(915, 120);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pnlVitaminas
            // 
            pnlVitaminas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlVitaminas.BackColor = Color.FromArgb(227, 238, 220);
            pnlVitaminas.Controls.Add(pctBVitaminas);
            pnlVitaminas.Controls.Add(lblVitaminas);
            pnlVitaminas.Location = new Point(3, 3);
            pnlVitaminas.Name = "pnlVitaminas";
            pnlVitaminas.Size = new Size(451, 114);
            pnlVitaminas.TabIndex = 0;
            pnlVitaminas.Resize += pnlVitaminas_Resize;
            // 
            // pctBVitaminas
            // 
            pctBVitaminas.Image = (Image)resources.GetObject("pctBVitaminas.Image");
            pctBVitaminas.Location = new Point(26, 45);
            pctBVitaminas.Name = "pctBVitaminas";
            pctBVitaminas.Size = new Size(32, 32);
            pctBVitaminas.TabIndex = 12;
            pctBVitaminas.TabStop = false;
            pctBVitaminas.Click += pctBVitaminas_Click;
            // 
            // lblVitaminas
            // 
            lblVitaminas.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblVitaminas.BackColor = Color.FromArgb(227, 238, 220);
            lblVitaminas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitaminas.ForeColor = Color.FromArgb(15, 72, 47);
            lblVitaminas.Location = new Point(285, 39);
            lblVitaminas.Name = "lblVitaminas";
            lblVitaminas.Size = new Size(163, 42);
            lblVitaminas.TabIndex = 4;
            lblVitaminas.Text = "Vitaminas";
            lblVitaminas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMinerais
            // 
            pnlMinerais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMinerais.BackColor = Color.FromArgb(255, 244, 220);
            pnlMinerais.Controls.Add(pctBMinerais);
            pnlMinerais.Controls.Add(lblMinerais);
            pnlMinerais.Location = new Point(460, 3);
            pnlMinerais.Name = "pnlMinerais";
            pnlMinerais.Size = new Size(452, 114);
            pnlMinerais.TabIndex = 1;
            pnlMinerais.Resize += pnlMinerais_Resize;
            // 
            // pctBMinerais
            // 
            pctBMinerais.Image = (Image)resources.GetObject("pctBMinerais.Image");
            pctBMinerais.Location = new Point(26, 45);
            pctBMinerais.Name = "pctBMinerais";
            pctBMinerais.Size = new Size(32, 32);
            pctBMinerais.TabIndex = 13;
            pctBMinerais.TabStop = false;
            pctBMinerais.Click += pctBMinerais_Click;
            // 
            // lblMinerais
            // 
            lblMinerais.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMinerais.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinerais.ForeColor = Color.FromArgb(15, 72, 47);
            lblMinerais.Location = new Point(317, 45);
            lblMinerais.Name = "lblMinerais";
            lblMinerais.Size = new Size(132, 36);
            lblMinerais.TabIndex = 5;
            lblMinerais.Text = "Minerais";
            lblMinerais.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlApresentacao
            // 
            pnlApresentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlApresentacao.BackColor = Color.FromArgb(227, 238, 220);
            pnlApresentacao.Controls.Add(txtDescricaoInicio);
            pnlApresentacao.Controls.Add(txtTitulo);
            pnlApresentacao.Location = new Point(40, 17);
            pnlApresentacao.Name = "pnlApresentacao";
            pnlApresentacao.Size = new Size(915, 314);
            pnlApresentacao.TabIndex = 11;
            pnlApresentacao.Resize += pnlApresentacao_Resize;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Font = new Font("Segoe UI", 14F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(34, 146);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(558, 127);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = resources.GetString("txtDescricaoInicio.Text");
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(34, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(259, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Micronutrientes";
            // 
            // UC_MicroNutrientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlApresentacao);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1005, 681);
            Name = "UC_MicroNutrientes";
            Size = new Size(1005, 681);
            Load += UC_MicroNutrientes_Load;
            Resize += UC_MicroNutrientes_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            pnlVitaminas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBVitaminas).EndInit();
            pnlMinerais.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBMinerais).EndInit();
            pnlApresentacao.ResumeLayout(false);
            pnlApresentacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlVitaminas;
        private Label lblVitaminas;
        private Panel pnlMinerais;
        private Label lblMinerais;
        private Panel pnlApresentacao;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
        private PictureBox pctBVitaminas;
        private PictureBox pctBMinerais;
    }
}
