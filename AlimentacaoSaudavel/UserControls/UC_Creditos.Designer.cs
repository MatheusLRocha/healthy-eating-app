namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_Creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Creditos));
            pnlApresentacao = new Panel();
            pictureBox1 = new PictureBox();
            txtCreditos = new Label();
            tlpAlunos = new TableLayoutPanel();
            panel3 = new Panel();
            lblDescricao3 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            lblDescricao4 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            lblDescricao2 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblDescricao1 = new Label();
            label1 = new Label();
            pnlApresentacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tlpAlunos.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlApresentacao
            // 
            pnlApresentacao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlApresentacao.BackColor = Color.FromArgb(227, 238, 220);
            pnlApresentacao.Controls.Add(pictureBox1);
            pnlApresentacao.Controls.Add(txtCreditos);
            pnlApresentacao.Controls.Add(tlpAlunos);
            pnlApresentacao.Location = new Point(49, 43);
            pnlApresentacao.Name = "pnlApresentacao";
            pnlApresentacao.Size = new Size(900, 580);
            pnlApresentacao.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(407, 112);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtCreditos
            // 
            txtCreditos.AutoSize = true;
            txtCreditos.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtCreditos.ForeColor = Color.FromArgb(15, 72, 47);
            txtCreditos.Location = new Point(120, 158);
            txtCreditos.Name = "txtCreditos";
            txtCreditos.Size = new Size(145, 45);
            txtCreditos.TabIndex = 5;
            txtCreditos.Text = "Créditos";
            // 
            // tlpAlunos
            // 
            tlpAlunos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpAlunos.ColumnCount = 2;
            tlpAlunos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAlunos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpAlunos.Controls.Add(panel3, 0, 1);
            tlpAlunos.Controls.Add(panel4, 1, 1);
            tlpAlunos.Controls.Add(panel2, 1, 0);
            tlpAlunos.Controls.Add(panel1, 0, 0);
            tlpAlunos.Location = new Point(82, 206);
            tlpAlunos.Name = "tlpAlunos";
            tlpAlunos.RowCount = 2;
            tlpAlunos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAlunos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAlunos.Size = new Size(734, 360);
            tlpAlunos.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(227, 242, 243);
            panel3.Controls.Add(lblDescricao3);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 174);
            panel3.TabIndex = 7;
            // 
            // lblDescricao3
            // 
            lblDescricao3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao3.Font = new Font("Segoe UI", 12F);
            lblDescricao3.ForeColor = Color.FromArgb(102, 128, 120);
            lblDescricao3.Location = new Point(23, 69);
            lblDescricao3.Name = "lblDescricao3";
            lblDescricao3.Size = new Size(322, 93);
            lblDescricao3.TabIndex = 8;
            lblDescricao3.Text = "Ficou resonsável pela codificação e arquitetura do software do aplicativo.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(15, 72, 47);
            label3.Location = new Point(8, 1);
            label3.Name = "label3";
            label3.Size = new Size(352, 68);
            label3.TabIndex = 9;
            label3.Text = "Guilherme Cegielkowski De Menezes";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 232, 247);
            panel4.Controls.Add(lblDescricao4);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(370, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 174);
            panel4.TabIndex = 8;
            // 
            // lblDescricao4
            // 
            lblDescricao4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao4.Font = new Font("Segoe UI", 12F);
            lblDescricao4.ForeColor = Color.FromArgb(102, 128, 120);
            lblDescricao4.Location = new Point(24, 69);
            lblDescricao4.Name = "lblDescricao4";
            lblDescricao4.Size = new Size(322, 93);
            lblDescricao4.TabIndex = 10;
            lblDescricao4.Text = "Ficou responsável pela criação dos créditos do aplicativo. ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(15, 72, 47);
            label4.Location = new Point(7, 1);
            label4.Name = "label4";
            label4.Size = new Size(352, 68);
            label4.TabIndex = 10;
            label4.Text = "João Pedro Berger Gonçalves Busamante";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 244, 220);
            panel2.Controls.Add(lblDescricao2);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(370, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 174);
            panel2.TabIndex = 6;
            // 
            // lblDescricao2
            // 
            lblDescricao2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao2.Font = new Font("Segoe UI", 12F);
            lblDescricao2.ForeColor = Color.FromArgb(102, 128, 120);
            lblDescricao2.Location = new Point(24, 49);
            lblDescricao2.Name = "lblDescricao2";
            lblDescricao2.Size = new Size(322, 93);
            lblDescricao2.TabIndex = 10;
            lblDescricao2.Text = "Ficou responsável pela pesquisa e o aprofundamento das informações que foram utilizadas na criação do aplicativo.";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(15, 72, 47);
            label2.Location = new Point(8, 4);
            label2.Name = "label2";
            label2.Size = new Size(352, 46);
            label2.TabIndex = 8;
            label2.Text = "André Victor Medeiros Da Silva";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 72, 47);
            panel1.Controls.Add(lblDescricao1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 174);
            panel1.TabIndex = 0;
            // 
            // lblDescricao1
            // 
            lblDescricao1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao1.Font = new Font("Segoe UI", 12F);
            lblDescricao1.ForeColor = Color.FromArgb(102, 128, 120);
            lblDescricao1.Location = new Point(23, 50);
            lblDescricao1.Name = "lblDescricao1";
            lblDescricao1.Size = new Size(322, 93);
            lblDescricao1.TabIndex = 7;
            lblDescricao1.Text = "Ficou responsável pelo Frontend/Design do aplicativo.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(227, 238, 220);
            label1.Location = new Point(7, 5);
            label1.Name = "label1";
            label1.Size = new Size(353, 45);
            label1.TabIndex = 7;
            label1.Text = "Matheus Luiz da Rocha";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_Creditos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlApresentacao);
            MinimumSize = new Size(1005, 681);
            Name = "UC_Creditos";
            Size = new Size(1005, 681);
            Load += UC_Creditos_Load;
            Resize += UC_Creditos_Resize;
            pnlApresentacao.ResumeLayout(false);
            pnlApresentacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tlpAlunos.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlApresentacao;
        private TableLayoutPanel tlpAlunos;
        private Label txtCreditos;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblDescricao1;
        private Label lblDescricao2;
        private Label lblDescricao3;
        private Label lblDescricao4;
    }
}
