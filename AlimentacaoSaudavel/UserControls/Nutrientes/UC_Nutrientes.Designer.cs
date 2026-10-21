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
            pctBMicro = new PictureBox();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            pnlMacro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBMacro).BeginInit();
            pnlMicro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBMicro).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMacro
            // 
            pnlMacro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMacro.BackColor = Color.FromArgb(227, 238, 220);
            pnlMacro.Controls.Add(pctBMacro);
            pnlMacro.Controls.Add(label2);
            pnlMacro.Location = new Point(3, 3);
            pnlMacro.Name = "pnlMacro";
            pnlMacro.Size = new Size(589, 114);
            pnlMacro.TabIndex = 0;
            // 
            // pctBMacro
            // 
            pctBMacro.Image = (Image)resources.GetObject("pctBMacro.Image");
            pctBMacro.Location = new Point(22, 44);
            pctBMacro.Name = "pctBMacro";
            pctBMacro.Size = new Size(32, 32);
            pctBMacro.TabIndex = 7;
            pctBMacro.TabStop = false;
            pctBMacro.Click += pctBMacro_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(339, 44);
            label2.Name = "label2";
            label2.Size = new Size(236, 43);
            label2.TabIndex = 4;
            label2.Text = "Macronutrientes";
            // 
            // pnlMicro
            // 
            pnlMicro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMicro.BackColor = Color.FromArgb(227, 238, 220);
            pnlMicro.Controls.Add(pctBMicro);
            pnlMicro.Controls.Add(label3);
            pnlMicro.Location = new Point(598, 3);
            pnlMicro.Name = "pnlMicro";
            pnlMicro.Size = new Size(589, 114);
            pnlMicro.TabIndex = 1;
            // 
            // pctBMicro
            // 
            pctBMicro.Image = (Image)resources.GetObject("pctBMicro.Image");
            pctBMicro.Location = new Point(22, 44);
            pctBMicro.Name = "pctBMicro";
            pctBMicro.Size = new Size(32, 32);
            pctBMicro.TabIndex = 8;
            pctBMicro.TabStop = false;
            pctBMicro.Click += pctBMicro_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(339, 44);
            label3.Name = "label3";
            label3.Size = new Size(236, 43);
            label3.TabIndex = 5;
            label3.Text = "Micronutrientes";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlMacro, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlMicro, 1, 0);
            tableLayoutPanel1.Location = new Point(40, 470);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1190, 120);
            tableLayoutPanel1.TabIndex = 3;
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
            panel1.TabIndex = 12;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Font = new Font("Segoe UI", 14F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(34, 146);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(558, 127);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = "Os nutrientes são os compostos químicos contidos nos alimentos que as nossas células usam para viver. Eles são divididos em dois grandes blocos:";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(34, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(177, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Nutrientes";
            // 
            // UC_Nutrientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1280, 720);
            Name = "UC_Nutrientes";
            Size = new Size(1280, 720);
            pnlMacro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBMacro).EndInit();
            pnlMicro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBMicro).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMacro;
        private Panel pnlMicro;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
        private PictureBox pctBMacro;
        private PictureBox pctBMicro;
    }
}
