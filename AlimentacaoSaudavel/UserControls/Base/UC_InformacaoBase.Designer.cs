namespace AlimentacaoSaudavel.UserControls.Base
{
    partial class UC_InformacaoBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_InformacaoBase));
            pnlConteudo = new Panel();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlImagem = new Panel();
            picImagem = new PictureBox();
            pnlConteudo.SuspendLayout();
            pnlImagem.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(lblDescricao);
            pnlConteudo.Controls.Add(lblTitulo);
            pnlConteudo.Dock = DockStyle.Left;
            pnlConteudo.Location = new Point(0, 0);
            pnlConteudo.Margin = new Padding(4, 5, 4, 5);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(626, 1135);
            pnlConteudo.TabIndex = 11;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.FromArgb(107, 143, 11);
            lblDescricao.Location = new Point(51, 277);
            lblDescricao.Margin = new Padding(4, 0, 4, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(559, 568);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição do conteúdo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(107, 143, 11);
            lblTitulo.Location = new Point(51, 143);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(138, 55);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // pnlImagem
            // 
            pnlImagem.Location = new Point(619, 0);
            pnlImagem.Margin = new Padding(4, 5, 4, 5);
            pnlImagem.Name = "pnlImagem";
            pnlImagem.Size = new Size(1210, 1200);
            pnlImagem.TabIndex = 12;
            // 
            // picImage
            // 
            picImagem = new PictureBox();
            picImagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picImagem.Location = new Point(111, 235);
            picImagem.Margin = new Padding(4, 5, 4, 5);
            picImagem.Name = "picImagem";
            picImagem.Size = new Size(571, 414);
            picImagem.SizeMode = PictureBoxSizeMode.Zoom;
            picImagem.TabIndex = 6;
            picImagem.TabStop = false;

            pnlImagem.Controls.Add(picImagem);
            // 
            // UC_InformacaoBase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlImagem);
            Controls.Add(pnlConteudo);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1436, 1135);
            Name = "UC_InformacaoBase";
            Size = new Size(1436, 1135);
            Resize += UC_InformacaoBase_Resize;
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            pnlImagem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConteudo;
        private Label lblDescricao;
        private Label lblTitulo;
        private Panel pnlImagem;
        private PictureBox picImagem;
    }
}
