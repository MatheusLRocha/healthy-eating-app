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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MicroNutrientes));
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlVitaminas = new Panel();
            lblVitaminas = new Label();
            pnlMinerais = new Panel();
            lblMinerais = new Label();
            panel1 = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlVitaminas.SuspendLayout();
            pnlMinerais.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlVitaminas, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlMinerais, 1, 0);
            tableLayoutPanel1.Location = new Point(40, 470);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1190, 120);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pnlVitaminas
            // 
            pnlVitaminas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlVitaminas.BackColor = Color.FromArgb(227, 238, 220);
            pnlVitaminas.Controls.Add(lblVitaminas);
            pnlVitaminas.Location = new Point(3, 3);
            pnlVitaminas.Name = "pnlVitaminas";
            pnlVitaminas.Size = new Size(589, 114);
            pnlVitaminas.TabIndex = 0;
            pnlVitaminas.Click += pnlVitaminas_Click;
            // 
            // lblVitaminas
            // 
            lblVitaminas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblVitaminas.BackColor = Color.FromArgb(227, 238, 220);
            lblVitaminas.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVitaminas.ForeColor = Color.FromArgb(15, 72, 47);
            lblVitaminas.Location = new Point(0, 0);
            lblVitaminas.Name = "lblVitaminas";
            lblVitaminas.Size = new Size(589, 114);
            lblVitaminas.TabIndex = 4;
            lblVitaminas.Text = "Vitaminas";
            lblVitaminas.TextAlign = ContentAlignment.MiddleCenter;
            lblVitaminas.Click += lblVitaminas_Click;
            // 
            // pnlMinerais
            // 
            pnlMinerais.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMinerais.BackColor = Color.FromArgb(255, 244, 220);
            pnlMinerais.Controls.Add(lblMinerais);
            pnlMinerais.Location = new Point(598, 3);
            pnlMinerais.Name = "pnlMinerais";
            pnlMinerais.Size = new Size(589, 114);
            pnlMinerais.TabIndex = 1;
            pnlMinerais.Click += pnlMinerais_Click;
            // 
            // lblMinerais
            // 
            lblMinerais.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblMinerais.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinerais.ForeColor = Color.FromArgb(15, 72, 47);
            lblMinerais.Location = new Point(0, 0);
            lblMinerais.Name = "lblMinerais";
            lblMinerais.Size = new Size(589, 114);
            lblMinerais.TabIndex = 5;
            lblMinerais.Text = "Minerais";
            lblMinerais.TextAlign = ContentAlignment.MiddleCenter;
            lblMinerais.Click += lblMinerais_Click;
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
            panel1.TabIndex = 11;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Font = new Font("Segoe UI", 14F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(34, 146);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(558, 127);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = resources.GetString("txtDescricaoInicio.Text");
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(34, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(259, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Micronutrientes";
            // 
            // UC_MicroNutrientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1280, 720);
            Name = "UC_MicroNutrientes";
            Size = new Size(1280, 720);
            tableLayoutPanel1.ResumeLayout(false);
            pnlVitaminas.ResumeLayout(false);
            pnlMinerais.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlVitaminas;
        private Label lblVitaminas;
        private Panel pnlMinerais;
        private Label lblMinerais;
        private Panel panel1;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
    }
}
