namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_Nutrientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Nutrientes));
            pnlMacro = new Panel();
            pctBMacro = new PictureBox();
            label2 = new Label();
            pnlMicro = new Panel();
            label3 = new Label();
            pctBMicro = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlApresentacao = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            pnlMacro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBMacro).BeginInit();
            pnlMicro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBMicro).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlApresentacao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMacro
            // 
            pnlMacro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMacro.BackColor = Color.FromArgb(227, 238, 220);
            pnlMacro.Controls.Add(pctBMacro);
            pnlMacro.Controls.Add(label2);
            pnlMacro.Location = new Point(4, 5);
            pnlMacro.Margin = new Padding(4, 5, 4, 5);
            pnlMacro.Name = "pnlMacro";
            pnlMacro.Size = new Size(645, 190);
            pnlMacro.TabIndex = 0;
            pnlMacro.Resize += pnlMacro_Resize;
            // 
            // pctBMacro
            // 
            pctBMacro.Image = (Image)resources.GetObject("pctBMacro.Image");
            pctBMacro.Location = new Point(27, 72);
            pctBMacro.Margin = new Padding(4, 5, 4, 5);
            pctBMacro.Name = "pctBMacro";
            pctBMacro.Size = new Size(46, 53);
            pctBMacro.TabIndex = 7;
            pctBMacro.TabStop = false;
            pctBMacro.Click += pctBMacro_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(304, 62);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(337, 72);
            label2.TabIndex = 4;
            label2.Text = "Macronutrientes";
            // 
            // pnlMicro
            // 
            pnlMicro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMicro.BackColor = Color.FromArgb(227, 238, 220);
            pnlMicro.Controls.Add(label3);
            pnlMicro.Controls.Add(pctBMicro);
            pnlMicro.Location = new Point(657, 5);
            pnlMicro.Margin = new Padding(4, 5, 4, 5);
            pnlMicro.Name = "pnlMicro";
            pnlMicro.Size = new Size(646, 190);
            pnlMicro.TabIndex = 1;
            pnlMicro.Resize += pnlMicro_Resize;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(320, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(323, 72);
            label3.TabIndex = 5;
            label3.Text = "Micronutrientes";
            // 
            // pctBMicro
            // 
            pctBMicro.Image = (Image)resources.GetObject("pctBMicro.Image");
            pctBMicro.Location = new Point(26, 72);
            pctBMicro.Margin = new Padding(4, 5, 4, 5);
            pctBMicro.Name = "pctBMicro";
            pctBMicro.Size = new Size(46, 53);
            pctBMicro.TabIndex = 8;
            pctBMicro.TabStop = false;
            pctBMicro.Click += pctBMicro_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlMacro, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlMicro, 1, 0);
            tableLayoutPanel1.Location = new Point(57, 783);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1307, 200);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlApresentacao
            // 
            pnlApresentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlApresentacao.BackColor = Color.FromArgb(227, 238, 220);
            pnlApresentacao.Controls.Add(txtDescricaoInicio);
            pnlApresentacao.Controls.Add(txtTitulo);
            pnlApresentacao.Location = new Point(57, 28);
            pnlApresentacao.Margin = new Padding(4, 5, 4, 5);
            pnlApresentacao.Name = "pnlApresentacao";
            pnlApresentacao.Size = new Size(1307, 523);
            pnlApresentacao.TabIndex = 12;
            pnlApresentacao.Resize += pnlApresentacao_Resize;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Font = new Font("Segoe UI", 14F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(49, 243);
            txtDescricaoInicio.Margin = new Padding(4, 0, 4, 0);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(797, 212);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = "Os nutrientes são os compostos químicos contidos nos alimentos que as nossas células usam para viver. Eles são divididos em dois grandes blocos:";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(49, 63);
            txtTitulo.Margin = new Padding(4, 0, 4, 0);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(268, 65);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Nutrientes";
            // 
            // UC_Nutrientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlApresentacao);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1436, 1135);
            Name = "UC_Nutrientes";
            Size = new Size(1436, 1135);
            pnlMacro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBMacro).EndInit();
            pnlMicro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBMicro).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnlApresentacao.ResumeLayout(false);
            pnlApresentacao.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMacro;
        private Panel pnlMicro;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Panel pnlApresentacao;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
        private PictureBox pctBMicro;
        private PictureBox pctBMacro;
    }
}
