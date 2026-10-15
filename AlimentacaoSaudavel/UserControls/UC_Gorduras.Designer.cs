namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_Gorduras
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
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            pnlImagem = new Panel();
            panel2 = new Panel();
            pnlConteudo.SuspendLayout();
            pnlImagem.SuspendLayout();
            SuspendLayout();
            // 
            // pnlConteudo
            // 
            pnlConteudo.Controls.Add(label5);
            pnlConteudo.Controls.Add(label3);
            pnlConteudo.Controls.Add(label4);
            pnlConteudo.Dock = DockStyle.Left;
            pnlConteudo.Location = new Point(0, 0);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(438, 521);
            pnlConteudo.TabIndex = 4;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(107, 143, 11);
            label5.Location = new Point(36, 305);
            label5.Name = "label5";
            label5.Size = new Size(349, 139);
            label5.TabIndex = 2;
            label5.Text = "Estão presentes em azeite, abacate, castanhas, sementes, peixes, manteiga e outros alimentos. ";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(107, 143, 11);
            label3.Location = new Point(36, 166);
            label3.Name = "label3";
            label3.Size = new Size(349, 139);
            label3.TabIndex = 1;
            label3.Text = "São o estoque de energia de longo prazo. Além disso, protegem os órgãos contra impactos, mantêm a temperatura corporal e são indispensáveis para a absorção das vitaminas lipossolúveis (A, D, E e K).";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(107, 143, 11);
            label4.Location = new Point(36, 86);
            label4.Name = "label4";
            label4.Size = new Size(135, 37);
            label4.TabIndex = 0;
            label4.Text = "Gorduras";
            // 
            // pnlImagem
            // 
            pnlImagem.Controls.Add(panel2);
            pnlImagem.Location = new Point(438, 0);
            pnlImagem.Name = "pnlImagem";
            pnlImagem.Size = new Size(396, 521);
            pnlImagem.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 143, 11);
            panel2.Location = new Point(36, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 454);
            panel2.TabIndex = 1;
            // 
            // UC_Gorduras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(pnlImagem);
            Controls.Add(pnlConteudo);
            Name = "UC_Gorduras";
            Size = new Size(834, 521);
            Resize += UC_Gorduras_Resize;
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            pnlImagem.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlConteudo;
        private Label label5;
        private Label label3;
        private Label label4;
        private Panel pnlImagem;
        private Panel panel2;
    }
}
