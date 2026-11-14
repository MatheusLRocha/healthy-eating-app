namespace AlimentacaoSaudavel.UserControls
{
    partial class UCCreditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCreditos));
            pnlApresentacao = new Panel();
            pnlJoãoPedro = new Panel();
            label8 = new Label();
            label7 = new Label();
            pnlGuilherme = new Panel();
            label6 = new Label();
            label5 = new Label();
            pnlAndré = new Panel();
            label3 = new Label();
            label4 = new Label();
            pnlMatheues = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            txtCrédito = new Label();
            pnlApresentacao.SuspendLayout();
            pnlJoãoPedro.SuspendLayout();
            pnlGuilherme.SuspendLayout();
            pnlAndré.SuspendLayout();
            pnlMatheues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlApresentacao
            // 
            pnlApresentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlApresentacao.BackColor = Color.FromArgb(227, 238, 220);
            pnlApresentacao.Controls.Add(pnlJoãoPedro);
            pnlApresentacao.Controls.Add(pnlGuilherme);
            pnlApresentacao.Controls.Add(pnlAndré);
            pnlApresentacao.Controls.Add(pnlMatheues);
            pnlApresentacao.Controls.Add(pictureBox1);
            pnlApresentacao.Controls.Add(txtCrédito);
            pnlApresentacao.Location = new Point(43, 50);
            pnlApresentacao.Name = "pnlApresentacao";
            pnlApresentacao.Size = new Size(901, 579);
            pnlApresentacao.TabIndex = 15;
            pnlApresentacao.Paint += pnlApresentacao_Paint;
            // 
            // pnlJoãoPedro
            // 
            pnlJoãoPedro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlJoãoPedro.BackColor = Color.FromArgb(240, 232, 247);
            pnlJoãoPedro.Controls.Add(label8);
            pnlJoãoPedro.Controls.Add(label7);
            pnlJoãoPedro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlJoãoPedro.ForeColor = Color.FromArgb(107, 143, 11);
            pnlJoãoPedro.Location = new Point(315, 386);
            pnlJoãoPedro.Margin = new Padding(5);
            pnlJoãoPedro.MaximumSize = new Size(345, 420);
            pnlJoãoPedro.Name = "pnlJoãoPedro";
            pnlJoãoPedro.Size = new Size(304, 161);
            pnlJoãoPedro.TabIndex = 10;
            pnlJoãoPedro.Paint += pnlVariedade_Paint;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(15, 72, 47);
            label8.Location = new Point(18, 22);
            label8.Name = "label8";
            label8.Size = new Size(269, 65);
            label8.TabIndex = 13;
            label8.Text = "João Pedro Berger Gonçalves Busamante";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.FromArgb(102, 128, 120);
            label7.Location = new Point(13, 83);
            label7.Name = "label7";
            label7.Size = new Size(288, 51);
            label7.TabIndex = 5;
            label7.Text = "Ficou responsável pela criação dos créditos do aplicativo.";
            label7.Click += label7_Click;
            // 
            // pnlGuilherme
            // 
            pnlGuilherme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlGuilherme.BackColor = Color.FromArgb(227, 242, 243);
            pnlGuilherme.Controls.Add(label6);
            pnlGuilherme.Controls.Add(label5);
            pnlGuilherme.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlGuilherme.ForeColor = Color.FromArgb(107, 143, 11);
            pnlGuilherme.Location = new Point(17, 386);
            pnlGuilherme.Margin = new Padding(5);
            pnlGuilherme.MaximumSize = new Size(345, 420);
            pnlGuilherme.Name = "pnlGuilherme";
            pnlGuilherme.Size = new Size(288, 161);
            pnlGuilherme.TabIndex = 9;
            pnlGuilherme.Paint += pnlHarmonia_Paint;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(15, 72, 47);
            label6.Location = new Point(16, 19);
            label6.Name = "label6";
            label6.Size = new Size(250, 66);
            label6.TabIndex = 11;
            label6.Text = "Guilherme Cegielkowski De Menezes";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.FromArgb(102, 128, 120);
            label5.Location = new Point(16, 85);
            label5.Name = "label5";
            label5.Size = new Size(250, 49);
            label5.TabIndex = 4;
            label5.Text = "Ficou resonsável pela codificação e arquitetura do software do aplicativo.";
            label5.Click += label5_Click;
            // 
            // pnlAndré
            // 
            pnlAndré.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAndré.BackColor = Color.FromArgb(255, 244, 220);
            pnlAndré.Controls.Add(label3);
            pnlAndré.Controls.Add(label4);
            pnlAndré.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlAndré.ForeColor = Color.FromArgb(107, 143, 11);
            pnlAndré.Location = new Point(315, 228);
            pnlAndré.Margin = new Padding(5);
            pnlAndré.MaximumSize = new Size(345, 420);
            pnlAndré.Name = "pnlAndré";
            pnlAndré.Size = new Size(304, 148);
            pnlAndré.TabIndex = 8;
            pnlAndré.Paint += pnlQuantidade_Paint;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.FromArgb(102, 128, 120);
            label3.Location = new Point(3, 72);
            label3.Name = "label3";
            label3.Size = new Size(284, 57);
            label3.TabIndex = 3;
            label3.Text = "Ficou responsável pela pesquisa e o aprofundamento das informações que foram utilizadas na criação do aplicativo.";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(15, 72, 47);
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(266, 74);
            label4.TabIndex = 0;
            label4.Text = "André Victor Medeiros Da Silva";
            label4.Click += label4_Click;
            // 
            // pnlMatheues
            // 
            pnlMatheues.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMatheues.BackColor = Color.FromArgb(227, 238, 220);
            pnlMatheues.Controls.Add(label1);
            pnlMatheues.Controls.Add(label2);
            pnlMatheues.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlMatheues.ForeColor = Color.FromArgb(107, 143, 11);
            pnlMatheues.Location = new Point(17, 228);
            pnlMatheues.Margin = new Padding(5);
            pnlMatheues.MaximumSize = new Size(345, 420);
            pnlMatheues.Name = "pnlMatheues";
            pnlMatheues.Size = new Size(288, 148);
            pnlMatheues.TabIndex = 7;
            pnlMatheues.Paint += pnlQualidade_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(15, 72, 47);
            label1.Location = new Point(16, 17);
            label1.Name = "label1";
            label1.Size = new Size(170, 57);
            label1.TabIndex = 12;
            label1.Text = "Matheus Luiz Da Rocha";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.FromArgb(102, 128, 120);
            label2.Location = new Point(16, 72);
            label2.Name = "label2";
            label2.Size = new Size(201, 45);
            label2.TabIndex = 1;
            label2.Text = "Ficou responsável pelo Frontend/Design do aplicativo.";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(403, 115);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtCrédito
            // 
            txtCrédito.AutoSize = true;
            txtCrédito.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtCrédito.ForeColor = Color.FromArgb(15, 72, 47);
            txtCrédito.Location = new Point(17, 178);
            txtCrédito.Name = "txtCrédito";
            txtCrédito.Size = new Size(154, 45);
            txtCrédito.TabIndex = 4;
            txtCrédito.Text = "Créditos:";
            txtCrédito.Click += txtTitulo_Click;
            // 
            // UCCreditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlApresentacao);
            Name = "UCCreditos";
            Size = new Size(1005, 681);
            Load += UCCreditos_Load;
            pnlApresentacao.ResumeLayout(false);
            pnlApresentacao.PerformLayout();
            pnlJoãoPedro.ResumeLayout(false);
            pnlGuilherme.ResumeLayout(false);
            pnlAndré.ResumeLayout(false);
            pnlMatheues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlApresentacao;
        private Label txtCrédito;
        private PictureBox pictureBox1;
        private Panel pnlMatheues;
        private Label label2;
        private Panel pnlAndré;
        private Label label3;
        private Label label4;
        private Panel pnlGuilherme;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label1;
        private Panel pnlJoãoPedro;
        private Label label7;
    }
}
