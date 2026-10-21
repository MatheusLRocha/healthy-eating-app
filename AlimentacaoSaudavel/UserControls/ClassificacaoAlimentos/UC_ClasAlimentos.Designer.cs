namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_ClasAlimentos
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
            pnlUltraProcessados = new Panel();
            label9 = new Label();
            pnlMinProcessados = new Panel();
            label6 = new Label();
            pnlProcessados = new Panel();
            label4 = new Label();
            pnlNatura = new Panel();
            label7 = new Label();
            panel1 = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlUltraProcessados.SuspendLayout();
            pnlMinProcessados.SuspendLayout();
            pnlProcessados.SuspendLayout();
            pnlNatura.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pnlUltraProcessados, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlMinProcessados, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlProcessados, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlNatura, 0, 0);
            tableLayoutPanel1.Location = new Point(40, 470);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1190, 120);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // pnlUltraProcessados
            // 
            pnlUltraProcessados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlUltraProcessados.BackColor = Color.FromArgb(227, 238, 220);
            pnlUltraProcessados.Controls.Add(label9);
            pnlUltraProcessados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlUltraProcessados.ForeColor = Color.FromArgb(107, 143, 11);
            pnlUltraProcessados.Location = new Point(896, 5);
            pnlUltraProcessados.Margin = new Padding(5);
            pnlUltraProcessados.Name = "pnlUltraProcessados";
            pnlUltraProcessados.Size = new Size(289, 110);
            pnlUltraProcessados.TabIndex = 7;
            pnlUltraProcessados.Click += pnlUltraProcessados_Click;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(15, 72, 47);
            label9.Location = new Point(14, 38);
            label9.Name = "label9";
            label9.Size = new Size(193, 30);
            label9.TabIndex = 0;
            label9.Text = "Ultra Processados";
            // 
            // pnlMinProcessados
            // 
            pnlMinProcessados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMinProcessados.BackColor = Color.FromArgb(227, 238, 220);
            pnlMinProcessados.Controls.Add(label6);
            pnlMinProcessados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlMinProcessados.ForeColor = Color.FromArgb(107, 143, 11);
            pnlMinProcessados.Location = new Point(599, 5);
            pnlMinProcessados.Margin = new Padding(5);
            pnlMinProcessados.Name = "pnlMinProcessados";
            pnlMinProcessados.Size = new Size(287, 110);
            pnlMinProcessados.TabIndex = 6;
            pnlMinProcessados.Click += pnlMinProcessados_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(15, 72, 47);
            label6.Location = new Point(14, 43);
            label6.Name = "label6";
            label6.Size = new Size(249, 25);
            label6.TabIndex = 0;
            label6.Text = "Minimamente Processados";
            // 
            // pnlProcessados
            // 
            pnlProcessados.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlProcessados.BackColor = Color.FromArgb(227, 238, 220);
            pnlProcessados.Controls.Add(label4);
            pnlProcessados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlProcessados.ForeColor = Color.FromArgb(107, 143, 11);
            pnlProcessados.Location = new Point(302, 5);
            pnlProcessados.Margin = new Padding(5);
            pnlProcessados.Name = "pnlProcessados";
            pnlProcessados.Size = new Size(287, 110);
            pnlProcessados.TabIndex = 6;
            pnlProcessados.Click += pnlProcessados_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(15, 72, 47);
            label4.Location = new Point(18, 43);
            label4.Name = "label4";
            label4.Size = new Size(193, 30);
            label4.TabIndex = 0;
            label4.Text = "Processados";
            // 
            // pnlNatura
            // 
            pnlNatura.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlNatura.BackColor = Color.FromArgb(227, 238, 220);
            pnlNatura.Controls.Add(label7);
            pnlNatura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlNatura.ForeColor = Color.FromArgb(107, 143, 11);
            pnlNatura.Location = new Point(5, 5);
            pnlNatura.Margin = new Padding(5);
            pnlNatura.Name = "pnlNatura";
            pnlNatura.Size = new Size(287, 110);
            pnlNatura.TabIndex = 5;
            pnlNatura.Click += pnlNatura_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(15, 72, 47);
            label7.Location = new Point(16, 43);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 0;
            label7.Text = "In Natura";
            label7.Click += label7_Click;
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
            panel1.TabIndex = 13;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Font = new Font("Segoe UI", 14F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(34, 146);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(558, 127);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = "Os alimentos podem ser divididos em grandes 4 áreas, sendo elas:";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(34, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(426, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Classificação dos alimentos";
            // 
            // UC_ClasAlimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1280, 720);
            Name = "UC_ClasAlimentos";
            Size = new Size(1280, 720);
            tableLayoutPanel1.ResumeLayout(false);
            pnlUltraProcessados.ResumeLayout(false);
            pnlMinProcessados.ResumeLayout(false);
            pnlMinProcessados.PerformLayout();
            pnlProcessados.ResumeLayout(false);
            pnlNatura.ResumeLayout(false);
            pnlNatura.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlMinProcessados;
        private Label label6;
        private Panel pnlProcessados;
        private Label label4;
        private Panel pnlNatura;
        private Label label7;
        private Panel pnlUltraProcessados;
        private Label label9;
        private Panel panel1;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
    }
}
