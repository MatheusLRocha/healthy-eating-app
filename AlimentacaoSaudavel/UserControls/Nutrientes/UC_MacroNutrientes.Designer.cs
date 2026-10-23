namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_MacroNutrientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MacroNutrientes));
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlGorduras = new Panel();
            pctBGorduras = new PictureBox();
            label6 = new Label();
            pnlCarboidratos = new Panel();
            pctBCarboidratos = new PictureBox();
            label2 = new Label();
            pnlProteinas = new Panel();
            pctBProteinas = new PictureBox();
            label3 = new Label();
            pnlApresentacao = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlGorduras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBGorduras).BeginInit();
            pnlCarboidratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBCarboidratos).BeginInit();
            pnlProteinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBProteinas).BeginInit();
            pnlApresentacao.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(pnlGorduras, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlCarboidratos, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlProteinas, 0, 0);
            tableLayoutPanel1.Location = new Point(40, 470);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(915, 120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlGorduras
            // 
            pnlGorduras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlGorduras.BackColor = Color.FromArgb(240, 232, 247);
            pnlGorduras.Controls.Add(pctBGorduras);
            pnlGorduras.Controls.Add(label6);
            pnlGorduras.Location = new Point(613, 3);
            pnlGorduras.Name = "pnlGorduras";
            pnlGorduras.Size = new Size(299, 114);
            pnlGorduras.TabIndex = 7;
            pnlGorduras.Resize += pnlGorduras_Resize;
            // 
            // pctBGorduras
            // 
            pctBGorduras.Image = (Image)resources.GetObject("pctBGorduras.Image");
            pctBGorduras.Location = new Point(26, 45);
            pctBGorduras.Name = "pctBGorduras";
            pctBGorduras.Size = new Size(32, 32);
            pctBGorduras.TabIndex = 8;
            pctBGorduras.TabStop = false;
            pctBGorduras.Click += pctBGorduras_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 72, 47);
            label6.Location = new Point(150, 39);
            label6.Name = "label6";
            label6.Size = new Size(146, 43);
            label6.TabIndex = 5;
            label6.Text = "Gorduras";
            // 
            // pnlCarboidratos
            // 
            pnlCarboidratos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCarboidratos.BackColor = Color.FromArgb(255, 244, 220);
            pnlCarboidratos.Controls.Add(pctBCarboidratos);
            pnlCarboidratos.Controls.Add(label2);
            pnlCarboidratos.Location = new Point(308, 3);
            pnlCarboidratos.Name = "pnlCarboidratos";
            pnlCarboidratos.Size = new Size(299, 114);
            pnlCarboidratos.TabIndex = 6;
            pnlCarboidratos.Resize += pnlCarboidratos_Resize;
            // 
            // pctBCarboidratos
            // 
            pctBCarboidratos.Image = (Image)resources.GetObject("pctBCarboidratos.Image");
            pctBCarboidratos.Location = new Point(26, 45);
            pctBCarboidratos.Name = "pctBCarboidratos";
            pctBCarboidratos.Size = new Size(32, 32);
            pctBCarboidratos.TabIndex = 7;
            pctBCarboidratos.TabStop = false;
            pctBCarboidratos.Click += pctBCarboidratos_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(96, 39);
            label2.Name = "label2";
            label2.Size = new Size(200, 43);
            label2.TabIndex = 5;
            label2.Text = "Carboidratos";
            // 
            // pnlProteinas
            // 
            pnlProteinas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlProteinas.BackColor = Color.FromArgb(227, 238, 220);
            pnlProteinas.Controls.Add(pctBProteinas);
            pnlProteinas.Controls.Add(label3);
            pnlProteinas.Location = new Point(3, 3);
            pnlProteinas.Name = "pnlProteinas";
            pnlProteinas.Size = new Size(299, 114);
            pnlProteinas.TabIndex = 2;
            pnlProteinas.Resize += pnlProteinas_Resize;
            // 
            // pctBProteinas
            // 
            pctBProteinas.Image = (Image)resources.GetObject("pctBProteinas.Image");
            pctBProteinas.Location = new Point(26, 45);
            pctBProteinas.Name = "pctBProteinas";
            pctBProteinas.Size = new Size(32, 32);
            pctBProteinas.TabIndex = 6;
            pctBProteinas.TabStop = false;
            pctBProteinas.Click += pctBProteinas_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(156, 39);
            label3.Name = "label3";
            label3.Size = new Size(140, 43);
            label3.TabIndex = 5;
            label3.Text = "Proteínas";
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
            pnlApresentacao.TabIndex = 10;
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
            txtTitulo.Size = new Size(267, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Macronutrientes";
            // 
            // UC_MacroNutrientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlApresentacao);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1005, 681);
            Name = "UC_MacroNutrientes";
            Size = new Size(1005, 681);
            tableLayoutPanel1.ResumeLayout(false);
            pnlGorduras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBGorduras).EndInit();
            pnlCarboidratos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBCarboidratos).EndInit();
            pnlProteinas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBProteinas).EndInit();
            pnlApresentacao.ResumeLayout(false);
            pnlApresentacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlGorduras;
        private Label label6;
        private Panel pnlCarboidratos;
        private Label label2;
        private Panel pnlProteinas;
        private Label label3;
        private Panel pnlApresentacao;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
        private PictureBox pctBCarboidratos;
        private PictureBox pctBProteinas;
        private PictureBox pctBGorduras;
    }
}
