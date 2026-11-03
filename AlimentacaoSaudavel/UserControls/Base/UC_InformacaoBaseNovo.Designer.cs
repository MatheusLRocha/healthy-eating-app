namespace AlimentacaoSaudavel.UserControls.Base
{
    partial class UC_InformacaoBaseNovo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_InformacaoBaseNovo));
            panel1 = new Panel();
            picImagem = new PictureBox();
            lblDescricaoInicio = new Label();
            lblTituloInicio = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlDica2 = new Panel();
            lblDescricao2 = new Label();
            pictureBox2 = new PictureBox();
            lblSubtitulo2 = new Label();
            pnlDica1 = new Panel();
            pictureBox1 = new PictureBox();
            lblDescricao1 = new Label();
            lblSubtitulo1 = new Label();
            pnlDica4 = new Panel();
            lblDescricao3 = new Label();
            pictureBox4 = new PictureBox();
            lblSubtitulo3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            pnlDica2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlDica1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlDica4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(227, 238, 220);
            panel1.Controls.Add(picImagem);
            panel1.Controls.Add(lblDescricaoInicio);
            panel1.Controls.Add(lblTituloInicio);
            panel1.Location = new Point(45, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 314);
            panel1.TabIndex = 10;
            // 
            // picImagem
            // 
            picImagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picImagem.Location = new Point(483, 38);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(400, 248);
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            picImagem.TabIndex = 7;
            picImagem.TabStop = false;
            // 
            // lblDescricaoInicio
            // 
            lblDescricaoInicio.Font = new Font("Segoe UI", 14F);
            lblDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            lblDescricaoInicio.Location = new Point(34, 83);
            lblDescricaoInicio.Name = "lblDescricaoInicio";
            lblDescricaoInicio.Size = new Size(422, 203);
            lblDescricaoInicio.TabIndex = 5;
            lblDescricaoInicio.Text = "Resumo rápido";
            // 
            // lblTituloInicio
            // 
            lblTituloInicio.AutoSize = true;
            lblTituloInicio.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTituloInicio.ForeColor = Color.FromArgb(15, 72, 47);
            lblTituloInicio.Location = new Point(34, 38);
            lblTituloInicio.Name = "lblTituloInicio";
            lblTituloInicio.Size = new Size(108, 45);
            lblTituloInicio.TabIndex = 4;
            lblTituloInicio.Text = "Titulo";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pnlDica2, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlDica1, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlDica4, 2, 0);
            tableLayoutPanel1.Location = new Point(3, 343);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(999, 335);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // pnlDica2
            // 
            pnlDica2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDica2.BackColor = Color.FromArgb(255, 244, 220);
            pnlDica2.Controls.Add(lblDescricao2);
            pnlDica2.Controls.Add(pictureBox2);
            pnlDica2.Controls.Add(lblSubtitulo2);
            pnlDica2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlDica2.ForeColor = Color.FromArgb(107, 143, 11);
            pnlDica2.Location = new Point(338, 5);
            pnlDica2.Margin = new Padding(5);
            pnlDica2.MaximumSize = new Size(345, 420);
            pnlDica2.Name = "pnlDica2";
            pnlDica2.Size = new Size(323, 325);
            pnlDica2.TabIndex = 6;
            // 
            // lblDescricao2
            // 
            lblDescricao2.Font = new Font("Segoe UI", 10F);
            lblDescricao2.ForeColor = Color.FromArgb(102, 128, 120);
            lblDescricao2.Location = new Point(16, 124);
            lblDescricao2.Name = "lblDescricao2";
            lblDescricao2.Size = new Size(287, 188);
            lblDescricao2.TabIndex = 3;
            lblDescricao2.Text = "texto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // lblSubtitulo2
            // 
            lblSubtitulo2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSubtitulo2.ForeColor = Color.FromArgb(15, 72, 47);
            lblSubtitulo2.Location = new Point(16, 84);
            lblSubtitulo2.Name = "lblSubtitulo2";
            lblSubtitulo2.Size = new Size(193, 40);
            lblSubtitulo2.TabIndex = 0;
            lblSubtitulo2.Text = "Para que servem?";
            // 
            // pnlDica1
            // 
            pnlDica1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDica1.BackColor = Color.FromArgb(227, 238, 220);
            pnlDica1.Controls.Add(pictureBox1);
            pnlDica1.Controls.Add(lblDescricao1);
            pnlDica1.Controls.Add(lblSubtitulo1);
            pnlDica1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlDica1.ForeColor = Color.FromArgb(107, 143, 11);
            pnlDica1.Location = new Point(5, 5);
            pnlDica1.Margin = new Padding(5);
            pnlDica1.MaximumSize = new Size(345, 420);
            pnlDica1.Name = "pnlDica1";
            pnlDica1.Size = new Size(323, 325);
            pnlDica1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblDescricao1
            // 
            lblDescricao1.Font = new Font("Segoe UI", 10F);
            lblDescricao1.ForeColor = Color.FromArgb(102, 128, 120);
            lblDescricao1.Location = new Point(16, 124);
            lblDescricao1.Name = "lblDescricao1";
            lblDescricao1.Size = new Size(287, 188);
            lblDescricao1.TabIndex = 1;
            lblDescricao1.Text = "texto";
            // 
            // lblSubtitulo1
            // 
            lblSubtitulo1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSubtitulo1.ForeColor = Color.FromArgb(15, 72, 47);
            lblSubtitulo1.Location = new Point(16, 84);
            lblSubtitulo1.Name = "lblSubtitulo1";
            lblSubtitulo1.Size = new Size(168, 40);
            lblSubtitulo1.TabIndex = 0;
            lblSubtitulo1.Text = "O que são?";
            // 
            // pnlDica4
            // 
            pnlDica4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDica4.BackColor = Color.FromArgb(240, 232, 247);
            pnlDica4.Controls.Add(lblDescricao3);
            pnlDica4.Controls.Add(pictureBox4);
            pnlDica4.Controls.Add(lblSubtitulo3);
            pnlDica4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlDica4.ForeColor = Color.FromArgb(107, 143, 11);
            pnlDica4.Location = new Point(671, 5);
            pnlDica4.Margin = new Padding(5);
            pnlDica4.MaximumSize = new Size(345, 420);
            pnlDica4.Name = "pnlDica4";
            pnlDica4.Size = new Size(323, 325);
            pnlDica4.TabIndex = 7;
            // 
            // lblDescricao3
            // 
            lblDescricao3.Font = new Font("Segoe UI", 10F);
            lblDescricao3.ForeColor = Color.FromArgb(102, 128, 120);
            lblDescricao3.Location = new Point(18, 124);
            lblDescricao3.Name = "lblDescricao3";
            lblDescricao3.Size = new Size(287, 188);
            lblDescricao3.TabIndex = 4;
            lblDescricao3.Text = "texto";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(18, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 64);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // lblSubtitulo3
            // 
            lblSubtitulo3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSubtitulo3.ForeColor = Color.FromArgb(15, 72, 47);
            lblSubtitulo3.Location = new Point(17, 84);
            lblSubtitulo3.Name = "lblSubtitulo3";
            lblSubtitulo3.Size = new Size(201, 40);
            lblSubtitulo3.TabIndex = 0;
            lblSubtitulo3.Text = "Onde encontramos?";
            // 
            // UC_InformacaoBaseNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            MinimumSize = new Size(1005, 681);
            Name = "UC_InformacaoBaseNovo";
            Size = new Size(1005, 681);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagem).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            pnlDica2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlDica1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlDica4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDescricaoInicio;
        private Label lblTituloInicio;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlDica2;
        private PictureBox pictureBox2;
        private Label lblSubtitulo2;
        private Panel pnlDica1;
        private PictureBox pictureBox1;
        private Label lblDescricao1;
        private Label lblSubtitulo1;
        private Panel pnlDica4;
        private PictureBox pictureBox4;
        private Label lblSubtitulo3;
        private Label lblDescricao2;
        private Label lblDescricao3;
        private PictureBox picImagem;
    }
}
