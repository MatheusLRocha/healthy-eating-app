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
            pnlConteudo = new Panel();
            lblDescricao = new Label();
            lblTitulo = new Label();
            pnlImagem = new Panel();
            panel2 = new Panel();
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
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(438, 520);
            pnlConteudo.TabIndex = 11;
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.FromArgb(107, 143, 11);
            lblDescricao.Location = new Point(36, 166);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(349, 333);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição do conteúdo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(107, 143, 11);
            lblTitulo.Location = new Point(36, 86);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(93, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // pnlImagem
            // 
            pnlImagem.Controls.Add(panel2);
            pnlImagem.Location = new Point(433, 0);
            pnlImagem.Name = "pnlImagem";
            pnlImagem.Size = new Size(402, 520);
            pnlImagem.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 143, 11);
            panel2.Location = new Point(31, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 454);
            panel2.TabIndex = 6;
            // 
            // UC_InformacaoBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(pnlImagem);
            Controls.Add(pnlConteudo);
            Name = "UC_InformacaoBase";
            Size = new Size(835, 520);
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
        private Panel panel2;
    }
}
