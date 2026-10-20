namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_MicroNutrientes
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
            pnlVitaminas = new Panel();
            lblVitaminas = new Label();
            pnlMinerais = new Panel();
            lblMinerais = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlVitaminas.SuspendLayout();
            pnlMinerais.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlVitaminas, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlMinerais, 1, 0);
            tableLayoutPanel1.Location = new Point(157, 100);
            tableLayoutPanel1.MaximumSize = new Size(1000, 580);
            tableLayoutPanel1.MinimumSize = new Size(520, 320);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(966, 519);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pnlVitaminas
            // 
            pnlVitaminas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlVitaminas.BackColor = Color.FromArgb(15, 72, 47);
            pnlVitaminas.Controls.Add(lblVitaminas);
            pnlVitaminas.Location = new Point(3, 3);
            pnlVitaminas.Name = "pnlVitaminas";
            pnlVitaminas.Size = new Size(477, 513);
            pnlVitaminas.TabIndex = 0;
            pnlVitaminas.Click += pnlVitaminas_Click;
            // 
            // lblVitaminas
            // 
            lblVitaminas.Dock = DockStyle.Fill;
            lblVitaminas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitaminas.ForeColor = Color.FromArgb(107, 143, 11);
            lblVitaminas.Location = new Point(0, 0);
            lblVitaminas.Name = "lblVitaminas";
            lblVitaminas.Size = new Size(477, 513);
            lblVitaminas.TabIndex = 4;
            lblVitaminas.Text = "Vitaminas";
            lblVitaminas.TextAlign = ContentAlignment.MiddleCenter;
            lblVitaminas.Click += lblVitaminas_Click;
            // 
            // pnlMinerais
            // 
            pnlMinerais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMinerais.BackColor = Color.FromArgb(15, 72, 47);
            pnlMinerais.Controls.Add(lblMinerais);
            pnlMinerais.Location = new Point(486, 3);
            pnlMinerais.Name = "pnlMinerais";
            pnlMinerais.Size = new Size(477, 513);
            pnlMinerais.TabIndex = 1;
            pnlMinerais.Click += pnlMinerais_Click;
            // 
            // lblMinerais
            // 
            lblMinerais.Dock = DockStyle.Fill;
            lblMinerais.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinerais.ForeColor = Color.FromArgb(107, 143, 11);
            lblMinerais.Location = new Point(0, 0);
            lblMinerais.Name = "lblMinerais";
            lblMinerais.Size = new Size(477, 513);
            lblMinerais.TabIndex = 5;
            lblMinerais.Text = "Minerais";
            lblMinerais.TextAlign = ContentAlignment.MiddleCenter;
            lblMinerais.Click += lblMinerais_Click;
            // 
            // UC_MicroNutrientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1280, 720);
            Name = "UC_MicroNutrientes";
            Size = new Size(1280, 720);
            tableLayoutPanel1.ResumeLayout(false);
            pnlVitaminas.ResumeLayout(false);
            pnlMinerais.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlVitaminas;
        private Label lblVitaminas;
        private Panel pnlMinerais;
        private Label lblMinerais;
    }
}
