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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlUltraProcessados = new Panel();
            label9 = new Label();
            pnlMinProcessados = new Panel();
            label6 = new Label();
            pnlProcessados = new Panel();
            label4 = new Label();
            pnlNatura = new Panel();
            label7 = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlUltraProcessados.SuspendLayout();
            pnlMinProcessados.SuspendLayout();
            pnlProcessados.SuspendLayout();
            pnlNatura.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(107, 143, 11);
            label1.Location = new Point(65, 95);
            label1.Name = "label1";
            label1.Size = new Size(576, 33);
            label1.TabIndex = 3;
            label1.Text = "Os alimentos podem ser divididos em grandes 4 áreas, sendo elas:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlUltraProcessados, 1, 1);
            tableLayoutPanel1.Controls.Add(pnlMinProcessados, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlProcessados, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlNatura, 0, 0);
            tableLayoutPanel1.Location = new Point(65, 131);
            tableLayoutPanel1.MaximumSize = new Size(1000, 580);
            tableLayoutPanel1.MinimumSize = new Size(580, 300);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(580, 300);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // pnlUltraProcessados
            // 
            pnlUltraProcessados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlUltraProcessados.BackColor = Color.FromArgb(15, 72, 47);
            pnlUltraProcessados.Controls.Add(label9);
            pnlUltraProcessados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlUltraProcessados.ForeColor = Color.FromArgb(107, 143, 11);
            pnlUltraProcessados.Location = new Point(295, 155);
            pnlUltraProcessados.Margin = new Padding(5);
            pnlUltraProcessados.MaximumSize = new Size(450, 240);
            pnlUltraProcessados.MinimumSize = new Size(250, 120);
            pnlUltraProcessados.Name = "pnlUltraProcessados";
            pnlUltraProcessados.Size = new Size(280, 140);
            pnlUltraProcessados.TabIndex = 7;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.Location = new Point(4, 4);
            label9.Name = "label9";
            label9.Size = new Size(193, 64);
            label9.TabIndex = 0;
            label9.Text = "Ultra Processados";
            // 
            // pnlMinProcessados
            // 
            pnlMinProcessados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMinProcessados.BackColor = Color.FromArgb(15, 72, 47);
            pnlMinProcessados.Controls.Add(label6);
            pnlMinProcessados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlMinProcessados.ForeColor = Color.FromArgb(107, 143, 11);
            pnlMinProcessados.Location = new Point(5, 155);
            pnlMinProcessados.Margin = new Padding(5);
            pnlMinProcessados.MaximumSize = new Size(450, 240);
            pnlMinProcessados.MinimumSize = new Size(250, 120);
            pnlMinProcessados.Name = "pnlMinProcessados";
            pnlMinProcessados.Size = new Size(280, 140);
            pnlMinProcessados.TabIndex = 6;
            pnlMinProcessados.Click += pnlMinProcessados_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(4, 4);
            label6.Name = "label6";
            label6.Size = new Size(249, 25);
            label6.TabIndex = 0;
            label6.Text = "Minimamente Processados";
            // 
            // pnlProcessados
            // 
            pnlProcessados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProcessados.BackColor = Color.FromArgb(15, 72, 47);
            pnlProcessados.Controls.Add(label4);
            pnlProcessados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlProcessados.ForeColor = Color.FromArgb(107, 143, 11);
            pnlProcessados.Location = new Point(295, 5);
            pnlProcessados.Margin = new Padding(5);
            pnlProcessados.MaximumSize = new Size(450, 240);
            pnlProcessados.MinimumSize = new Size(250, 120);
            pnlProcessados.Name = "pnlProcessados";
            pnlProcessados.Size = new Size(280, 140);
            pnlProcessados.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(4, 4);
            label4.Name = "label4";
            label4.Size = new Size(193, 64);
            label4.TabIndex = 0;
            label4.Text = "Processados";
            // 
            // pnlNatura
            // 
            pnlNatura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlNatura.BackColor = Color.FromArgb(15, 72, 47);
            pnlNatura.Controls.Add(label7);
            pnlNatura.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlNatura.ForeColor = Color.FromArgb(107, 143, 11);
            pnlNatura.Location = new Point(5, 5);
            pnlNatura.Margin = new Padding(5);
            pnlNatura.MaximumSize = new Size(450, 240);
            pnlNatura.MinimumSize = new Size(250, 120);
            pnlNatura.Name = "pnlNatura";
            pnlNatura.Size = new Size(280, 140);
            pnlNatura.TabIndex = 5;
            pnlNatura.Click += pnlNatura_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(4, 4);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 0;
            label7.Text = "In Natura";
            label7.Click += label7_Click;
            // 
            // UC_ClasAlimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "UC_ClasAlimentos";
            Size = new Size(834, 521);
            tableLayoutPanel1.ResumeLayout(false);
            pnlUltraProcessados.ResumeLayout(false);
            pnlMinProcessados.ResumeLayout(false);
            pnlMinProcessados.PerformLayout();
            pnlProcessados.ResumeLayout(false);
            pnlNatura.ResumeLayout(false);
            pnlNatura.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlMinProcessados;
        private Label label6;
        private Panel pnlProcessados;
        private Label label4;
        private Panel pnlNatura;
        private Label label7;
        private Panel pnlUltraProcessados;
        private Label label9;
    }
}
