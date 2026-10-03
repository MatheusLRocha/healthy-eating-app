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
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlGorduras = new Panel();
            label6 = new Label();
            pnlCarboidratos = new Panel();
            label2 = new Label();
            pnlProteinas = new Panel();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlGorduras.SuspendLayout();
            pnlCarboidratos.SuspendLayout();
            pnlProteinas.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(pnlGorduras, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlCarboidratos, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlProteinas, 0, 0);
            tableLayoutPanel1.Location = new Point(26, 145);
            tableLayoutPanel1.MaximumSize = new Size(1524, 640);
            tableLayoutPanel1.MinimumSize = new Size(762, 320);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(762, 320);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlGorduras
            // 
            pnlGorduras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGorduras.BackColor = Color.FromArgb(15, 72, 47);
            pnlGorduras.Controls.Add(label6);
            pnlGorduras.Location = new Point(511, 3);
            pnlGorduras.Name = "pnlGorduras";
            pnlGorduras.Size = new Size(248, 314);
            pnlGorduras.TabIndex = 7;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(107, 143, 11);
            label6.Location = new Point(15, 15);
            label6.Name = "label6";
            label6.Size = new Size(236, 43);
            label6.TabIndex = 5;
            label6.Text = "Gorduras";
            // 
            // pnlCarboidratos
            // 
            pnlCarboidratos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCarboidratos.BackColor = Color.FromArgb(15, 72, 47);
            pnlCarboidratos.Controls.Add(label2);
            pnlCarboidratos.Location = new Point(257, 3);
            pnlCarboidratos.Name = "pnlCarboidratos";
            pnlCarboidratos.Size = new Size(248, 314);
            pnlCarboidratos.TabIndex = 6;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 143, 11);
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(236, 43);
            label2.TabIndex = 5;
            label2.Text = "Carboidratos";
            // 
            // pnlProteinas
            // 
            pnlProteinas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProteinas.BackColor = Color.FromArgb(15, 72, 47);
            pnlProteinas.Controls.Add(label3);
            pnlProteinas.Location = new Point(3, 3);
            pnlProteinas.Name = "pnlProteinas";
            pnlProteinas.Size = new Size(248, 314);
            pnlProteinas.TabIndex = 2;
            pnlProteinas.Click += pnlProteinas_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(107, 143, 11);
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Size = new Size(236, 43);
            label3.TabIndex = 5;
            label3.Text = "Proteínas";
            // 
            // UC_MacroNutrientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(tableLayoutPanel1);
            Name = "UC_MacroNutrientes";
            Size = new Size(834, 521);
            tableLayoutPanel1.ResumeLayout(false);
            pnlGorduras.ResumeLayout(false);
            pnlCarboidratos.ResumeLayout(false);
            pnlProteinas.ResumeLayout(false);
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
    }
}
