namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia.PlanejamentoAlimentar
{
    partial class UC_PlanejamentoAlimentar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PlanejamentoAlimentar));
            pnlApresentacao = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlPraticidade = new Panel();
            pctBPraticidade = new PictureBox();
            label2 = new Label();
            pnlOrganizandoSemana = new Panel();
            pctBOrganizandoSemana = new PictureBox();
            label3 = new Label();
            pnlApresentacao.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlPraticidade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBPraticidade).BeginInit();
            pnlOrganizandoSemana.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBOrganizandoSemana).BeginInit();
            SuspendLayout();
            // 
            // pnlApresentacao
            // 
            pnlApresentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlApresentacao.BackColor = Color.FromArgb(227, 238, 220);
            pnlApresentacao.Controls.Add(txtDescricaoInicio);
            pnlApresentacao.Controls.Add(txtTitulo);
            pnlApresentacao.Location = new Point(40, 17);
            pnlApresentacao.Name = "pnlApresentacao";
            pnlApresentacao.Size = new Size(915, 314);
            pnlApresentacao.TabIndex = 15;
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
            txtTitulo.Size = new Size(382, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Planejamento Alimentar";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(pnlPraticidade, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlOrganizandoSemana, 0, 0);
            tableLayoutPanel1.Location = new Point(40, 470);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(915, 120);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // pnlPraticidade
            // 
            pnlPraticidade.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPraticidade.BackColor = Color.FromArgb(255, 244, 220);
            pnlPraticidade.Controls.Add(pctBPraticidade);
            pnlPraticidade.Controls.Add(label2);
            pnlPraticidade.Location = new Point(460, 3);
            pnlPraticidade.Name = "pnlPraticidade";
            pnlPraticidade.Size = new Size(452, 114);
            pnlPraticidade.TabIndex = 6;
            // 
            // pctBPraticidade
            // 
            pctBPraticidade.Image = (Image)resources.GetObject("pctBPraticidade.Image");
            pctBPraticidade.Location = new Point(26, 45);
            pctBPraticidade.Name = "pctBPraticidade";
            pctBPraticidade.Size = new Size(32, 32);
            pctBPraticidade.TabIndex = 7;
            pctBPraticidade.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(285, 45);
            label2.Name = "label2";
            label2.Size = new Size(164, 43);
            label2.TabIndex = 5;
            label2.Text = "Praticidade";
            // 
            // pnlOrganizandoSemana
            // 
            pnlOrganizandoSemana.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlOrganizandoSemana.BackColor = Color.FromArgb(227, 238, 220);
            pnlOrganizandoSemana.Controls.Add(pctBOrganizandoSemana);
            pnlOrganizandoSemana.Controls.Add(label3);
            pnlOrganizandoSemana.Location = new Point(3, 3);
            pnlOrganizandoSemana.Name = "pnlOrganizandoSemana";
            pnlOrganizandoSemana.Size = new Size(451, 114);
            pnlOrganizandoSemana.TabIndex = 2;
            // 
            // pctBOrganizandoSemana
            // 
            pctBOrganizandoSemana.Image = (Image)resources.GetObject("pctBOrganizandoSemana.Image");
            pctBOrganizandoSemana.Location = new Point(26, 45);
            pctBOrganizandoSemana.Name = "pctBOrganizandoSemana";
            pctBOrganizandoSemana.Size = new Size(32, 32);
            pctBOrganizandoSemana.TabIndex = 6;
            pctBOrganizandoSemana.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(264, 23);
            label3.Name = "label3";
            label3.Size = new Size(184, 75);
            label3.TabIndex = 5;
            label3.Text = "Organizando a semana";
            // 
            // UC_PlanejamentoAlimentar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlApresentacao);
            MinimumSize = new Size(1005, 681);
            Name = "UC_PlanejamentoAlimentar";
            Size = new Size(1005, 681);
            pnlApresentacao.ResumeLayout(false);
            pnlApresentacao.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pnlPraticidade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBPraticidade).EndInit();
            pnlOrganizandoSemana.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBOrganizandoSemana).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlApresentacao;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlPraticidade;
        private PictureBox pctBPraticidade;
        private Label label2;
        private Panel pnlOrganizandoSemana;
        private PictureBox pctBOrganizandoSemana;
        private Label label3;
    }
}
