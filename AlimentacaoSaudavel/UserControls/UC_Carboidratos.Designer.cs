namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_Carboidratos
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
            label1 = new Label();
            label2 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(107, 143, 11);
            label1.Location = new Point(36, 86);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 1;
            label1.Text = "Carboidratos";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(107, 143, 11);
            label2.Location = new Point(36, 166);
            label2.Name = "label2";
            label2.Size = new Size(349, 139);
            label2.TabIndex = 2;
            label2.Text = "Funcionam como os tijolos do corpo. Elas quebram-se em aminoácidos para construir e reparar os músculos, a pele, o cabelo e produzir hormônios e anticorpos.";
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
            pnlConteudo.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(107, 143, 11);
            label5.Location = new Point(36, 305);
            label5.Name = "label5";
            label5.Size = new Size(349, 139);
            label5.TabIndex = 2;
            label5.Text = "Fornecem energia para as atividades do organismo. Estão presentes em alimentos como arroz, batata, mandioca, aveia, milho, pães, massas e frutas";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(107, 143, 11);
            label3.Location = new Point(36, 166);
            label3.Name = "label3";
            label3.Size = new Size(349, 139);
            label3.TabIndex = 1;
            label3.Text = "São a moeda de energia preferida do organismo. Quando consumidos, transformam-se em glicose, que abastece o cérebro e os músculos rapidamente.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(107, 143, 11);
            label4.Location = new Point(36, 86);
            label4.Name = "label4";
            label4.Size = new Size(185, 37);
            label4.TabIndex = 0;
            label4.Text = "Carboidratos";
            // 
            // pnlImagem
            // 
            pnlImagem.Controls.Add(panel2);
            pnlImagem.Location = new Point(444, 0);
            pnlImagem.Name = "pnlImagem";
            pnlImagem.Size = new Size(390, 521);
            pnlImagem.TabIndex = 4;
            pnlImagem.Resize += pnlImagem_Resize;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(107, 143, 11);
            panel2.Location = new Point(36, 37);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 454);
            panel2.TabIndex = 1;
            // 
            // UC_Carboidratos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(pnlImagem);
            Controls.Add(pnlConteudo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Carboidratos";
            Size = new Size(834, 521);
            Load += UC_Carboidratos_Load;
            Resize += UC_Carboidratos_Resize;
            pnlConteudo.ResumeLayout(false);
            pnlConteudo.PerformLayout();
            pnlImagem.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel pnlConteudo;
        private Label label3;
        private Label label4;
        private Panel pnlImagem;
        private Panel panel2;
        private Label label5;
    }
}
