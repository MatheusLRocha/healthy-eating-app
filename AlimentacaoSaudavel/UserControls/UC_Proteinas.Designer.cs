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
            panel2 = new Panel();
            pnlConteudo.SuspendLayout();
            pnlImagem.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(label2);
            pnlConteudo.Controls.Add(label1);
            pnlConteudo.Dock = DockStyle.Left;
            pnlConteudo.Location = new Point(0, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(438, 521);
            pnlConteudo.TabIndex = 0;
            pnlConteudo.Paint += pnlConteudo_Paint;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 143, 11);
            label2.Location = new Point(36, 166);
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
            label1.Location = new Point(36, 86);
            label1.Name = "label1";
            label1.Size = new Size(139, 37);
            label1.TabIndex = 0;
            label1.Text = "Proteínas";
            // 
            // pnlImagem
            // 
            pnlImagem.Controls.Add(panel2);
            pnlImagem.Dock = DockStyle.Right;
            pnlImagem.Location = new Point(436, 0);
            pnlImagem.Name = "pnlImagem";
            pnlImagem.Size = new Size(398, 521);
            pnlImagem.TabIndex = 1;
            pnlImagem.Resize += pnlImagem_Resize;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 143, 11);
            panel2.Location = new Point(36, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 454);
            panel2.TabIndex = 1;
            panel2.Resize += panel2_Resize;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConteudo;
        private Panel pnlImagem;
        private Label label1;
        private Label label2;
        private Panel panel2;
    }
}
