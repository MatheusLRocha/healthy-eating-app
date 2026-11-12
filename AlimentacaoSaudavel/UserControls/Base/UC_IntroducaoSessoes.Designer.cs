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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_IntroducaoSessoes));
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlApresentacao = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlGorduras = new Panel();
            pctBGorduras = new PictureBox();
            label6 = new Label();
            pnlCarboidratos = new Panel();
            pctBCarboidratos = new PictureBox();
            label2 = new Label();
            pnlProteinas = new Panel();
            pctBProteinas = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            pnlApresentacao.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlGorduras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBGorduras).BeginInit();
            pnlCarboidratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBCarboidratos).BeginInit();
            pnlProteinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBProteinas).BeginInit();
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
            pnlApresentacao.Controls.Add(panel1);
            pnlApresentacao.Location = new Point(8, 8);
            pnlApresentacao.Margin = new Padding(8);
            pnlApresentacao.Name = "pnlApresentacao";
            pnlApresentacao.Size = new Size(989, 292);
            pnlApresentacao.TabIndex = 11;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricaoInicio.Font = new Font("Segoe UI", 14F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(38, 108);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(514, 157);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = "Descrição";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(38, 40);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(108, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Titulo";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(pnlGorduras, 2, 0);
            tableLayoutPanel2.Controls.Add(pnlCarboidratos, 1, 0);
            tableLayoutPanel2.Controls.Add(pnlProteinas, 0, 0);
            tableLayoutPanel2.Location = new Point(24, 130);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(959, 120);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // pnlGorduras
            // 
            pnlGorduras.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlGorduras.BackColor = Color.FromArgb(240, 232, 247);
            pnlGorduras.Controls.Add(pctBGorduras);
            pnlGorduras.Controls.Add(label6);
            pnlGorduras.Location = new Point(641, 3);
            pnlGorduras.Name = "pnlGorduras";
            pnlGorduras.Size = new Size(315, 114);
            pnlGorduras.TabIndex = 7;
            // 
            // pctBGorduras
            // 
            pctBGorduras.Image = (Image)resources.GetObject("pctBGorduras.Image");
            pctBGorduras.Location = new Point(26, 45);
            pctBGorduras.Name = "pctBGorduras";
            pctBGorduras.Size = new Size(32, 32);
            pctBGorduras.TabIndex = 8;
            pctBGorduras.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 72, 47);
            label6.Location = new Point(155, 39);
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
            pnlCarboidratos.Location = new Point(322, 3);
            pnlCarboidratos.Name = "pnlCarboidratos";
            pnlCarboidratos.Size = new Size(313, 114);
            pnlCarboidratos.TabIndex = 6;
            // 
            // pctBCarboidratos
            // 
            pctBCarboidratos.Image = (Image)resources.GetObject("pctBCarboidratos.Image");
            pctBCarboidratos.Location = new Point(26, 45);
            pctBCarboidratos.Name = "pctBCarboidratos";
            pctBCarboidratos.Size = new Size(32, 32);
            pctBCarboidratos.TabIndex = 7;
            pctBCarboidratos.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(101, 39);
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
            pnlProteinas.Size = new Size(313, 114);
            pnlProteinas.TabIndex = 2;
            // 
            // pctBProteinas
            // 
            pctBProteinas.Image = (Image)resources.GetObject("pctBProteinas.Image");
            pctBProteinas.Location = new Point(26, 45);
            pctBProteinas.Name = "pctBProteinas";
            pctBProteinas.Size = new Size(32, 32);
            pctBProteinas.TabIndex = 6;
            pctBProteinas.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(149, 39);
            label3.Name = "label3";
            label3.Size = new Size(140, 43);
            label3.TabIndex = 5;
            label3.Text = "Proteínas";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(589, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 292);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDescricaoInicio);
            panel2.Controls.Add(txtTitulo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 292);
            panel2.TabIndex = 7;
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
            panel4.Controls.Add(tableLayoutPanel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 308);
            panel4.Name = "panel4";
            panel4.Size = new Size(1005, 373);
            panel4.TabIndex = 14;
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
            tableLayoutPanel1.ResumeLayout(false);
            pnlApresentacao.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            pnlGorduras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBGorduras).EndInit();
            pnlCarboidratos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBCarboidratos).EndInit();
            pnlProteinas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBProteinas).EndInit();
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
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnlGorduras;
        private PictureBox pctBGorduras;
        private Label label6;
        private Panel pnlCarboidratos;
        private PictureBox pctBCarboidratos;
        private Label label2;
        private Panel pnlProteinas;
        private PictureBox pctBProteinas;
        private Label label3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
    }
}
