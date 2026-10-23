namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.RotinaCorrida
{
    partial class UC_RefeicoesDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_RefeicoesDia));
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlLanches = new Panel();
            pctBLanches = new PictureBox();
            label4 = new Label();
            pnlJantar = new Panel();
            pctBJantar = new PictureBox();
            label6 = new Label();
            pnlAlmoco = new Panel();
            pctBAlmoco = new PictureBox();
            label2 = new Label();
            pnlCafeManha = new Panel();
            pctBCafeManha = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlLanches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBLanches).BeginInit();
            pnlJantar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBJantar).BeginInit();
            pnlAlmoco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBAlmoco).BeginInit();
            pnlCafeManha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBCafeManha).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pnlLanches, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlJantar, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlAlmoco, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlCafeManha, 0, 0);
            tableLayoutPanel1.Location = new Point(40, 470);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1190, 120);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // pnlLanches
            // 
            pnlLanches.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLanches.BackColor = Color.FromArgb(240, 232, 247);
            pnlLanches.Controls.Add(pctBLanches);
            pnlLanches.Controls.Add(label4);
            pnlLanches.Location = new Point(894, 3);
            pnlLanches.Name = "pnlLanches";
            pnlLanches.Size = new Size(293, 114);
            pnlLanches.TabIndex = 9;
            // 
            // pctBLanches
            // 
            pctBLanches.Image = (Image)resources.GetObject("pctBLanches.Image");
            pctBLanches.Location = new Point(26, 45);
            pctBLanches.Name = "pctBLanches";
            pctBLanches.Size = new Size(32, 32);
            pctBLanches.TabIndex = 8;
            pctBLanches.TabStop = false;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(15, 72, 47);
            label4.Location = new Point(168, 45);
            label4.Name = "label4";
            label4.Size = new Size(122, 36);
            label4.TabIndex = 5;
            label4.Text = "Lanches";
            // 
            // pnlJantar
            // 
            pnlJantar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlJantar.BackColor = Color.FromArgb(240, 232, 247);
            pnlJantar.Controls.Add(pctBJantar);
            pnlJantar.Controls.Add(label6);
            pnlJantar.Location = new Point(597, 3);
            pnlJantar.Name = "pnlJantar";
            pnlJantar.Size = new Size(291, 114);
            pnlJantar.TabIndex = 7;
            // 
            // pctBJantar
            // 
            pctBJantar.Image = (Image)resources.GetObject("pctBJantar.Image");
            pctBJantar.Location = new Point(26, 45);
            pctBJantar.Name = "pctBJantar";
            pctBJantar.Size = new Size(32, 32);
            pctBJantar.TabIndex = 8;
            pctBJantar.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 72, 47);
            label6.Location = new Point(188, 45);
            label6.Name = "label6";
            label6.Size = new Size(100, 36);
            label6.TabIndex = 5;
            label6.Text = "Jantar";
            // 
            // pnlAlmoco
            // 
            pnlAlmoco.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAlmoco.BackColor = Color.FromArgb(255, 244, 220);
            pnlAlmoco.Controls.Add(pctBAlmoco);
            pnlAlmoco.Controls.Add(label2);
            pnlAlmoco.Location = new Point(300, 3);
            pnlAlmoco.Name = "pnlAlmoco";
            pnlAlmoco.Size = new Size(291, 114);
            pnlAlmoco.TabIndex = 6;
            // 
            // pctBAlmoco
            // 
            pctBAlmoco.Image = (Image)resources.GetObject("pctBAlmoco.Image");
            pctBAlmoco.Location = new Point(26, 45);
            pctBAlmoco.Name = "pctBAlmoco";
            pctBAlmoco.Size = new Size(32, 32);
            pctBAlmoco.TabIndex = 7;
            pctBAlmoco.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(170, 39);
            label2.Name = "label2";
            label2.Size = new Size(118, 38);
            label2.TabIndex = 5;
            label2.Text = "Almoço";
            // 
            // pnlCafeManha
            // 
            pnlCafeManha.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCafeManha.BackColor = Color.FromArgb(227, 238, 220);
            pnlCafeManha.Controls.Add(pctBCafeManha);
            pnlCafeManha.Controls.Add(label3);
            pnlCafeManha.Location = new Point(3, 3);
            pnlCafeManha.Name = "pnlCafeManha";
            pnlCafeManha.Size = new Size(291, 114);
            pnlCafeManha.TabIndex = 2;
            // 
            // pctBCafeManha
            // 
            pctBCafeManha.Image = (Image)resources.GetObject("pctBCafeManha.Image");
            pctBCafeManha.Location = new Point(26, 45);
            pctBCafeManha.Name = "pctBCafeManha";
            pctBCafeManha.Size = new Size(32, 32);
            pctBCafeManha.TabIndex = 6;
            pctBCafeManha.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(170, 23);
            label3.Name = "label3";
            label3.Size = new Size(118, 75);
            label3.TabIndex = 5;
            label3.Text = "Café da manhã";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(227, 238, 220);
            panel1.Controls.Add(txtDescricaoInicio);
            panel1.Controls.Add(txtTitulo);
            panel1.Location = new Point(40, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(1190, 314);
            panel1.TabIndex = 15;
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
            txtTitulo.Size = new Size(408, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Refeições ao longo do dia";
            // 
            // UC_RefeicoesDia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "UC_RefeicoesDia";
            Size = new Size(1280, 720);
            tableLayoutPanel1.ResumeLayout(false);
            pnlLanches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBLanches).EndInit();
            pnlJantar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBJantar).EndInit();
            pnlAlmoco.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBAlmoco).EndInit();
            pnlCafeManha.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBCafeManha).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlJantar;
        private PictureBox pctBJantar;
        private Label label6;
        private Panel pnlAlmoco;
        private PictureBox pctBAlmoco;
        private Label label2;
        private Panel pnlCafeManha;
        private PictureBox pctBCafeManha;
        private Label label3;
        private Panel panel1;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
        private Panel pnlLanches;
        private PictureBox pctBLanches;
        private Label label4;
    }
}
