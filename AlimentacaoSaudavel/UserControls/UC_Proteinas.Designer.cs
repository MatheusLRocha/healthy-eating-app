namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_Proteinas
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
            label2 = new Label();
            label1 = new Label();
            pnlImagem = new Panel();
            label3 = new Label();
            pnlConteudo.SuspendLayout();
            pnlImagem.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConteudo
            // 
            pnlConteudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlConteudo.Controls.Add(label2);
            pnlConteudo.Controls.Add(label1);
            pnlConteudo.Location = new Point(0, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(480, 521);
            pnlConteudo.TabIndex = 0;
            pnlConteudo.Paint += pnlConteudo_Paint;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 143, 11);
            label2.Location = new Point(35, 166);
            label2.Name = "label2";
            label2.Size = new Size(349, 139);
            label2.TabIndex = 1;
            label2.Text = "Funcionam como os tijolos do corpo. Elas quebram-se em aminoácidos para construir e reparar os músculos, a pele, o cabelo e produzir hormônios e anticorpos.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(107, 143, 11);
            label1.Location = new Point(35, 86);
            label1.Name = "label1";
            label1.Size = new Size(139, 37);
            label1.TabIndex = 0;
            label1.Text = "Proteínas";
            // 
            // pnlImagem
            // 
            pnlImagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlImagem.Controls.Add(label3);
            pnlImagem.Location = new Point(480, 0);
            pnlImagem.Name = "pnlImagem";
            pnlImagem.Size = new Size(354, 521);
            pnlImagem.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(107, 143, 11);
            label3.Location = new Point(73, 230);
            label3.Name = "label3";
            label3.Size = new Size(233, 37);
            label3.TabIndex = 2;
            label3.Text = "Suposta Imagem";
            // 
            // UC_Proteinas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(pnlImagem);
            Controls.Add(pnlConteudo);
            Name = "UC_Proteinas";
            Size = new Size(834, 521);
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            pnlImagem.ResumeLayout(false);
            pnlImagem.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConteudo;
        private Panel pnlImagem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
