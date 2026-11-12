namespace AlimentacaoSaudavel.UserControls.Base
{
    partial class UC_Sessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Sessao));
            pctBSessao = new PictureBox();
            lblSessao = new Label();
            ((System.ComponentModel.ISupportInitialize)pctBSessao).BeginInit();
            SuspendLayout();
            // 
            // pctBSessao
            // 
            pctBSessao.Image = (Image)resources.GetObject("pctBSessao.Image");
            pctBSessao.Location = new Point(24, 41);
            pctBSessao.Name = "pctBSessao";
            pctBSessao.Size = new Size(32, 32);
            pctBSessao.TabIndex = 13;
            pctBSessao.TabStop = false;
            pctBSessao.Click += pctBSessao_Click;
            // 
            // lblSessao
            // 
            lblSessao.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSessao.BackColor = Color.FromArgb(227, 238, 220);
            lblSessao.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSessao.ForeColor = Color.FromArgb(15, 72, 47);
            lblSessao.Location = new Point(115, 35);
            lblSessao.Name = "lblSessao";
            lblSessao.Size = new Size(163, 42);
            lblSessao.TabIndex = 14;
            lblSessao.Text = "Sessão";
            lblSessao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UC_Sessao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 238, 220);
            Controls.Add(lblSessao);
            Controls.Add(pctBSessao);
            Name = "UC_Sessao";
            Size = new Size(300, 115);
            ((System.ComponentModel.ISupportInitialize)pctBSessao).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctBSessao;
        private Label lblSessao;
    }
}
