namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_Fontes
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
            label = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.FromArgb(107, 143, 11);
            label.Location = new Point(56, 67);
            label.Name = "label";
            label.Size = new Size(558, 25);
            label.TabIndex = 6;
            label.Text = "Nossas principais fontes sobre o conteúdo deste projeto educativo";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(56, 135);
            tableLayoutPanel1.MaximumSize = new Size(600, 240);
            tableLayoutPanel1.MinimumSize = new Size(600, 180);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(600, 180);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(217, 217, 217);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(linkLabel2);
            panel2.Location = new Point(3, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(594, 84);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(107, 143, 11);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(588, 47);
            label2.TabIndex = 12;
            label2.Text = "Núcleo de Pesquisas Epidemiológicas em Nutrição e Saúde (NUPENS/USP) - A classificacao nova";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(107, 143, 11);
            linkLabel2.Location = new Point(0, 57);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(167, 21);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "[Acessar publicação]";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(217, 217, 217);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(594, 84);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(107, 143, 11);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(500, 21);
            label1.TabIndex = 11;
            label1.Text = "Ministério da Saúde - Guia alimentar para a população brasileira";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(107, 143, 11);
            linkLabel1.Location = new Point(0, 57);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(167, 21);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "[Acessar publicação]";
            // 
            // UC_Fontes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label);
            MinimumSize = new Size(1005, 681);
            Name = "UC_Fontes";
            Size = new Size(1005, 681);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private LinkLabel linkLabel2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
    }
}
