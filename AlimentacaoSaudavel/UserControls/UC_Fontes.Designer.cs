namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_Fontes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Fontes));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel7 = new Panel();
            label5 = new Label();
            linkLabel5 = new LinkLabel();
            panel2 = new Panel();
            label2 = new Label();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel6 = new Panel();
            label4 = new Label();
            linkLabel4 = new LinkLabel();
            panel3 = new Panel();
            pnlApresentacao = new Panel();
            txtDescricaoInicio = new Label();
            txtTitulo = new Label();
            panel4 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            pnlApresentacao.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel7, 0, 2);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Location = new Point(29, 23);
            tableLayoutPanel1.MaximumSize = new Size(1120, 550);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(920, 350);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(227, 238, 220);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(linkLabel5);
            panel7.Location = new Point(3, 235);
            panel7.Name = "panel7";
            panel7.Size = new Size(454, 112);
            panel7.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(107, 143, 11);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(436, 47);
            label5.TabIndex = 12;
            label5.Text = "Instituto de Defesa de Consumidores (IDEC)";
            // 
            // linkLabel5
            // 
            linkLabel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel5.LinkColor = Color.FromArgb(107, 143, 11);
            linkLabel5.Location = new Point(6, 81);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(167, 21);
            linkLabel5.TabIndex = 11;
            linkLabel5.TabStop = true;
            linkLabel5.Tag = "https://idec.org.br/de-olho-nos-rotulos/entenda-a-lupa";
            linkLabel5.Text = "[Acessar publicação]";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(227, 238, 220);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(linkLabel2);
            panel2.Location = new Point(3, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(454, 110);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(107, 143, 11);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(436, 47);
            label2.TabIndex = 12;
            label2.Text = "Núcleo de Pesquisas Epidemiológicas em Nutrição e Saúde (NUPENS/USP) - A classificacao nova";
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.FromArgb(107, 143, 11);
            linkLabel2.Location = new Point(6, 81);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(167, 21);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Tag = "https://nupens.fsp.usp.br/a-classificacao-nova/";
            linkLabel2.Text = "[Acessar publicação]";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(227, 238, 220);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 110);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(107, 143, 11);
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(384, 54);
            label1.TabIndex = 11;
            label1.Text = "Ministério da Saúde - Guia alimentar para a população brasileira";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(107, 143, 11);
            linkLabel1.Location = new Point(6, 81);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(167, 21);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Tag = resources.GetString("linkLabel1.Tag");
            linkLabel1.Text = "[Acessar publicação]";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(227, 238, 220);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(linkLabel4);
            panel6.Location = new Point(463, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(454, 110);
            panel6.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(107, 143, 11);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(436, 47);
            label4.TabIndex = 12;
            label4.Text = "GANEP";
            // 
            // linkLabel4
            // 
            linkLabel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            linkLabel4.AutoSize = true;
            linkLabel4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel4.LinkColor = Color.FromArgb(107, 143, 11);
            linkLabel4.Location = new Point(6, 81);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(167, 21);
            linkLabel4.TabIndex = 11;
            linkLabel4.TabStop = true;
            linkLabel4.Tag = "https://ganepeducacao.com.br/novas-diretrizes-da-oms-para-gorduras-e-carboidratos/";
            linkLabel4.Text = "[Acessar publicação]";
            // 
            // panel3
            // 
            panel3.Controls.Add(pnlApresentacao);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1005, 264);
            panel3.TabIndex = 10;
            // 
            // pnlApresentacao
            // 
            pnlApresentacao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlApresentacao.BackColor = Color.FromArgb(227, 238, 220);
            pnlApresentacao.Controls.Add(txtDescricaoInicio);
            pnlApresentacao.Controls.Add(txtTitulo);
            pnlApresentacao.Location = new Point(23, 11);
            pnlApresentacao.Margin = new Padding(8);
            pnlApresentacao.Name = "pnlApresentacao";
            pnlApresentacao.Size = new Size(967, 245);
            pnlApresentacao.TabIndex = 0;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescricaoInicio.Font = new Font("Segoe UI", 12F);
            txtDescricaoInicio.ForeColor = Color.FromArgb(102, 128, 120);
            txtDescricaoInicio.Location = new Point(37, 88);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(554, 122);
            txtDescricaoInicio.TabIndex = 6;
            txtDescricaoInicio.Text = "Dê uma olhada nas nossas fontes, garantimos que tudo apresentado é oficial.";
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtTitulo.ForeColor = Color.FromArgb(15, 72, 47);
            txtTitulo.Location = new Point(28, 26);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(119, 45);
            txtTitulo.TabIndex = 5;
            txtTitulo.Text = "Fontes";
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 264);
            panel4.Name = "panel4";
            panel4.Size = new Size(1005, 417);
            panel4.TabIndex = 11;
            // 
            // UC_Fontes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel4);
            Controls.Add(panel3);
            MinimumSize = new Size(1005, 681);
            Name = "UC_Fontes";
            Size = new Size(1005, 681);
            Resize += UC_Fontes_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            pnlApresentacao.ResumeLayout(false);
            pnlApresentacao.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private LinkLabel linkLabel2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Label label2;
        private Panel panel3;
        private Panel pnlApresentacao;
        private Label txtTitulo;
        private Label txtDescricaoInicio;
        private Panel panel4;
        private Panel panel6;
        private Label label4;
        private LinkLabel linkLabel4;
        private Panel panel7;
        private Label label5;
        private LinkLabel linkLabel5;
    }
}
