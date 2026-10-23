namespace AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia
{
    partial class UC_AlimentacaoDiaDia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AlimentacaoDiaDia));
            panel1 = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlPlanejamentoAlimentar = new Panel();
            pctBPlanejamentoAlimentar = new PictureBox();
            label6 = new Label();
            pnlRefeicoesDia = new Panel();
            pctBRefeicoesDia = new PictureBox();
            label2 = new Label();
            pnlAlimentacaoEquilibrada = new Panel();
            pctBAlimentacaoEquilibrada = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlPlanejamentoAlimentar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBPlanejamentoAlimentar).BeginInit();
            pnlRefeicoesDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBRefeicoesDia).BeginInit();
            pnlAlimentacaoEquilibrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctBAlimentacaoEquilibrada).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(227, 238, 220);
            panel1.Controls.Add(txtDescricaoInicio);
            panel1.Controls.Add(txtTitulo);
            panel1.Location = new Point(40, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 314);
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
            txtDescricaoInicio.Text = "Resumo sobre a sessão";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(34, 38);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(399, 45);
            txtTitulo.TabIndex = 4;
            txtTitulo.Text = "Alimentação no Dia a Dia";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(pnlPlanejamentoAlimentar, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlRefeicoesDia, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlAlimentacaoEquilibrada, 0, 0);
            tableLayoutPanel1.Location = new Point(40, 470);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(915, 120);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // pnlPlanejamentoAlimentar
            // 
            pnlPlanejamentoAlimentar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPlanejamentoAlimentar.BackColor = Color.FromArgb(240, 232, 247);
            pnlPlanejamentoAlimentar.Controls.Add(pctBPlanejamentoAlimentar);
            pnlPlanejamentoAlimentar.Controls.Add(label6);
            pnlPlanejamentoAlimentar.Location = new Point(613, 3);
            pnlPlanejamentoAlimentar.Name = "pnlPlanejamentoAlimentar";
            pnlPlanejamentoAlimentar.Size = new Size(299, 114);
            pnlPlanejamentoAlimentar.TabIndex = 7;
            // 
            // pctBPlanejamentoAlimentar
            // 
            pctBPlanejamentoAlimentar.Image = (Image)resources.GetObject("pctBPlanejamentoAlimentar.Image");
            pctBPlanejamentoAlimentar.Location = new Point(26, 45);
            pctBPlanejamentoAlimentar.Name = "pctBPlanejamentoAlimentar";
            pctBPlanejamentoAlimentar.Size = new Size(32, 32);
            pctBPlanejamentoAlimentar.TabIndex = 8;
            pctBPlanejamentoAlimentar.TabStop = false;
            pctBPlanejamentoAlimentar.Click += pctBPlanejamentoAlimentar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 72, 47);
            label6.Location = new Point(94, 21);
            label6.Name = "label6";
            label6.Size = new Size(202, 74);
            label6.TabIndex = 5;
            label6.Text = "Planejamento Alimentar";
            // 
            // pnlRefeicoesDia
            // 
            pnlRefeicoesDia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRefeicoesDia.BackColor = Color.FromArgb(255, 244, 220);
            pnlRefeicoesDia.Controls.Add(pctBRefeicoesDia);
            pnlRefeicoesDia.Controls.Add(label2);
            pnlRefeicoesDia.Location = new Point(308, 3);
            pnlRefeicoesDia.Name = "pnlRefeicoesDia";
            pnlRefeicoesDia.Size = new Size(299, 114);
            pnlRefeicoesDia.TabIndex = 6;
            // 
            // pctBRefeicoesDia
            // 
            pctBRefeicoesDia.Image = (Image)resources.GetObject("pctBRefeicoesDia.Image");
            pctBRefeicoesDia.Location = new Point(26, 45);
            pctBRefeicoesDia.Name = "pctBRefeicoesDia";
            pctBRefeicoesDia.Size = new Size(32, 32);
            pctBRefeicoesDia.TabIndex = 7;
            pctBRefeicoesDia.TabStop = false;
            pctBRefeicoesDia.Click += pctBRefeicoesDia_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(96, 20);
            label2.Name = "label2";
            label2.Size = new Size(200, 75);
            label2.TabIndex = 5;
            label2.Text = "Refeições ao longo do dia";
            // 
            // pnlAlimentacaoEquilibrada
            // 
            pnlAlimentacaoEquilibrada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAlimentacaoEquilibrada.BackColor = Color.FromArgb(227, 238, 220);
            pnlAlimentacaoEquilibrada.Controls.Add(pctBAlimentacaoEquilibrada);
            pnlAlimentacaoEquilibrada.Controls.Add(label3);
            pnlAlimentacaoEquilibrada.Location = new Point(3, 3);
            pnlAlimentacaoEquilibrada.Name = "pnlAlimentacaoEquilibrada";
            pnlAlimentacaoEquilibrada.Size = new Size(299, 114);
            pnlAlimentacaoEquilibrada.TabIndex = 2;
            // 
            // pctBAlimentacaoEquilibrada
            // 
            pctBAlimentacaoEquilibrada.Image = (Image)resources.GetObject("pctBAlimentacaoEquilibrada.Image");
            pctBAlimentacaoEquilibrada.Location = new Point(26, 45);
            pctBAlimentacaoEquilibrada.Name = "pctBAlimentacaoEquilibrada";
            pctBAlimentacaoEquilibrada.Size = new Size(32, 32);
            pctBAlimentacaoEquilibrada.TabIndex = 6;
            pctBAlimentacaoEquilibrada.TabStop = false;
            pctBAlimentacaoEquilibrada.Click += pctBAlimentacaoEquilibrada_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(116, 20);
            label3.Name = "label3";
            label3.Size = new Size(180, 75);
            label3.TabIndex = 5;
            label3.Text = "Alimentação Equilibrada";
            // 
            // UC_AlimentacaoDiaDia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            MinimumSize = new Size(1005, 681);
            Name = "UC_AlimentacaoDiaDia";
            Size = new Size(1005, 681);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            pnlPlanejamentoAlimentar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBPlanejamentoAlimentar).EndInit();
            pnlRefeicoesDia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBRefeicoesDia).EndInit();
            pnlAlimentacaoEquilibrada.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctBAlimentacaoEquilibrada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txtDescricaoInicio;
        private Label txtTitulo;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlPlanejamentoAlimentar;
        private PictureBox pctBPlanejamentoAlimentar;
        private Label label6;
        private Panel pnlRefeicoesDia;
        private PictureBox pctBRefeicoesDia;
        private Label label2;
        private Panel pnlAlimentacaoEquilibrada;
        private PictureBox pctBAlimentacaoEquilibrada;
        private Label label3;
    }
}
