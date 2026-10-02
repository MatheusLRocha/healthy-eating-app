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
            panel1 = new Panel();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(15, 72, 47);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 314);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(107, 143, 11);
            label4.Location = new Point(15, 74);
            label4.Name = "label4";
            label4.Size = new Size(226, 77);
            label4.TabIndex = 4;
            label4.Text = "São os nutrientes que o corpo necessita em grandes quantidades";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 143, 11);
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(236, 43);
            label2.TabIndex = 4;
            label2.Text = "Macronutrientes";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(15, 72, 47);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(263, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 314);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.FromArgb(107, 143, 11);
            label5.Location = new Point(15, 74);
            label5.Name = "label5";
            label5.Size = new Size(230, 77);
            label5.TabIndex = 5;
            label5.Text = "São os nutrientes que o corpo necessita em pequenas doses essenciais";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(107, 143, 11);
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Size = new Size(236, 43);
            label3.TabIndex = 5;
            label3.Text = "Micronutrientes";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(107, 143, 11);
            label1.Location = new Point(63, 91);
            label1.Name = "label1";
            label1.Size = new Size(576, 55);
            label1.TabIndex = 2;
            label1.Text = "Os nutrientes são os compostos químicos contidos nos alimentos que as nossas células usam para viver. Eles são divididos em dois grandes blocos:";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(119, 161);
            tableLayoutPanel1.MaximumSize = new Size(1000, 580);
            tableLayoutPanel1.MinimumSize = new Size(520, 320);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(520, 320);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // UC_Nutrientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_Nutrientes";
            Size = new Size(834, 521);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
    }
}
