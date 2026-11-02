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
            label1 = new Label();
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDescricaoInicio);
            panel1.Controls.Add(txtTitulo);
            panel1.Location = new Point(57, 28);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1307, 523);
            panel1.TabIndex = 13;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Font = new Font("Segoe UI", 14F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(49, 243);
            txtDescricaoInicio.Margin = new Padding(4, 0, 4, 0);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(797, 212);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = "Resumo sobre a sessão";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(49, 63);
            txtTitulo.Margin = new Padding(4, 0, 4, 0);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(598, 65);
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
            tableLayoutPanel1.Location = new Point(57, 783);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1307, 200);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // pnlPlanejamentoAlimentar
            // 
            pnlPlanejamentoAlimentar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPlanejamentoAlimentar.BackColor = Color.FromArgb(240, 232, 247);
            pnlPlanejamentoAlimentar.Controls.Add(pctBPlanejamentoAlimentar);
            pnlPlanejamentoAlimentar.Controls.Add(label6);
            pnlPlanejamentoAlimentar.Location = new Point(874, 5);
            pnlPlanejamentoAlimentar.Margin = new Padding(4, 5, 4, 5);
            pnlPlanejamentoAlimentar.Name = "pnlPlanejamentoAlimentar";
            pnlPlanejamentoAlimentar.Size = new Size(429, 190);
            pnlPlanejamentoAlimentar.TabIndex = 7;
            // 
            // pctBPlanejamentoAlimentar
            // 
            pctBPlanejamentoAlimentar.Image = (Image)resources.GetObject("pctBPlanejamentoAlimentar.Image");
            pctBPlanejamentoAlimentar.Location = new Point(37, 75);
            pctBPlanejamentoAlimentar.Margin = new Padding(4, 5, 4, 5);
            pctBPlanejamentoAlimentar.Name = "pctBPlanejamentoAlimentar";
            pctBPlanejamentoAlimentar.Size = new Size(46, 53);
            pctBPlanejamentoAlimentar.TabIndex = 8;
            pctBPlanejamentoAlimentar.TabStop = false;
            pctBPlanejamentoAlimentar.Click += pctBPlanejamentoAlimentar_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(15, 72, 47);
            label6.Location = new Point(136, 35);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(289, 123);
            label6.TabIndex = 5;
            label6.Text = "Planejamento Alimentar";
            // 
            // pnlRefeicoesDia
            // 
            pnlRefeicoesDia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRefeicoesDia.BackColor = Color.FromArgb(255, 244, 220);
            pnlRefeicoesDia.Controls.Add(pctBRefeicoesDia);
            pnlRefeicoesDia.Controls.Add(label2);
            pnlRefeicoesDia.Location = new Point(439, 5);
            pnlRefeicoesDia.Margin = new Padding(4, 5, 4, 5);
            pnlRefeicoesDia.Name = "pnlRefeicoesDia";
            pnlRefeicoesDia.Size = new Size(427, 190);
            pnlRefeicoesDia.TabIndex = 6;
            // 
            // pctBRefeicoesDia
            // 
            pctBRefeicoesDia.Image = (Image)resources.GetObject("pctBRefeicoesDia.Image");
            pctBRefeicoesDia.Location = new Point(37, 75);
            pctBRefeicoesDia.Margin = new Padding(4, 5, 4, 5);
            pctBRefeicoesDia.Name = "pctBRefeicoesDia";
            pctBRefeicoesDia.Size = new Size(46, 53);
            pctBRefeicoesDia.TabIndex = 7;
            pctBRefeicoesDia.TabStop = false;
            pctBRefeicoesDia.Click += pctBRefeicoesDia_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(137, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(286, 125);
            label2.TabIndex = 5;
            label2.Text = "Refeições ao longo do dia";
            // 
            // pnlAlimentacaoEquilibrada
            // 
            pnlAlimentacaoEquilibrada.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAlimentacaoEquilibrada.BackColor = Color.FromArgb(227, 238, 220);
            pnlAlimentacaoEquilibrada.Controls.Add(pctBAlimentacaoEquilibrada);
            pnlAlimentacaoEquilibrada.Controls.Add(label3);
            pnlAlimentacaoEquilibrada.Location = new Point(4, 5);
            pnlAlimentacaoEquilibrada.Margin = new Padding(4, 5, 4, 5);
            pnlAlimentacaoEquilibrada.Name = "pnlAlimentacaoEquilibrada";
            pnlAlimentacaoEquilibrada.Size = new Size(427, 190);
            pnlAlimentacaoEquilibrada.TabIndex = 2;
            // 
            // pctBAlimentacaoEquilibrada
            // 
            pctBAlimentacaoEquilibrada.Image = (Image)resources.GetObject("pctBAlimentacaoEquilibrada.Image");
            pctBAlimentacaoEquilibrada.Location = new Point(37, 75);
            pctBAlimentacaoEquilibrada.Margin = new Padding(4, 5, 4, 5);
            pctBAlimentacaoEquilibrada.Name = "pctBAlimentacaoEquilibrada";
            pctBAlimentacaoEquilibrada.Size = new Size(46, 53);
            pctBAlimentacaoEquilibrada.TabIndex = 6;
            pctBAlimentacaoEquilibrada.TabStop = false;
            pctBAlimentacaoEquilibrada.Click += pctBAlimentacaoEquilibrada_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(166, 33);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(257, 125);
            label3.TabIndex = 5;
            label3.Text = "Alimentação Equilibrada";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(102, 128, 120);
            label1.Location = new Point(49, 243);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(797, 212);
            label1.TabIndex = 7;
            label1.Text = "Aprenda sobre alimentação e encontre informações que possam ajudar na sua rotina.";
            // 
            // UC_AlimentacaoDiaDia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1436, 1135);
            Name = "UC_AlimentacaoDiaDia";
            Size = new Size(1436, 1135);
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
        private Label label1;
    }
}
