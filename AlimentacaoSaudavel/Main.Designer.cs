namespace AlimentacaoSaudavel
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInicio = new LinkLabel();
            txtNutrientes = new LinkLabel();
            txtTituloInicio = new Label();
            txtDescricaoInicio = new Label();
            pnlNutrientes = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlClasAlimentos = new Panel();
            label3 = new Label();
            label4 = new Label();
            pnlEscolhendoMelhor = new Panel();
            label5 = new Label();
            label6 = new Label();
            pnlHeader = new Panel();
            pnlIntroduction = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlNutrientes.SuspendLayout();
            pnlClasAlimentos.SuspendLayout();
            pnlEscolhendoMelhor.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlIntroduction.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtInicio
            // 
            txtInicio.AutoSize = true;
            txtInicio.Font = new Font("Segoe UI", 12F);
            txtInicio.ForeColor = Color.CornflowerBlue;
            txtInicio.LinkColor = Color.FromArgb(107, 143, 11);
            txtInicio.Location = new Point(38, 22);
            txtInicio.Name = "txtInicio";
            txtInicio.Size = new Size(47, 21);
            txtInicio.TabIndex = 0;
            txtInicio.TabStop = true;
            txtInicio.Text = "Inicio";
            txtInicio.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtNutrientes
            // 
            txtNutrientes.AutoSize = true;
            txtNutrientes.Font = new Font("Segoe UI", 12F);
            txtNutrientes.LinkColor = Color.FromArgb(107, 143, 11);
            txtNutrientes.Location = new Point(89, 22);
            txtNutrientes.Name = "txtNutrientes";
            txtNutrientes.Size = new Size(83, 21);
            txtNutrientes.TabIndex = 1;
            txtNutrientes.TabStop = true;
            txtNutrientes.Text = "Nutrientes";
            txtNutrientes.LinkClicked += linkLabel2_LinkClicked;
            // 
            // txtTituloInicio
            // 
            txtTituloInicio.AutoSize = true;
            txtTituloInicio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTituloInicio.ForeColor = Color.FromArgb(107, 143, 11);
            txtTituloInicio.Location = new Point(37, 74);
            txtTituloInicio.Name = "txtTituloInicio";
            txtTituloInicio.Size = new Size(282, 30);
            txtTituloInicio.TabIndex = 2;
            txtTituloInicio.Text = "Aprenda sobre alimentação";
            txtTituloInicio.Click += label1_Click;
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricaoInicio.ForeColor = Color.FromArgb(107, 143, 11);
            txtDescricaoInicio.Location = new Point(37, 104);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(558, 47);
            txtDescricaoInicio.TabIndex = 3;
            txtDescricaoInicio.Text = "Entenda de forma simples como os nutrientes, alimentos e grupos alimentares fazem parte da nossa alimentação.";
            txtDescricaoInicio.Click += label2_Click;
            // 
            // pnlNutrientes
            // 
            pnlNutrientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlNutrientes.BackColor = Color.FromArgb(15, 72, 47);
            pnlNutrientes.Controls.Add(label2);
            pnlNutrientes.Controls.Add(label1);
            pnlNutrientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlNutrientes.ForeColor = Color.FromArgb(107, 143, 11);
            pnlNutrientes.Location = new Point(5, 5);
            pnlNutrientes.Margin = new Padding(5);
            pnlNutrientes.MaximumSize = new Size(340, 150);
            pnlNutrientes.MinimumSize = new Size(250, 120);
            pnlNutrientes.Name = "pnlNutrientes";
            pnlNutrientes.Size = new Size(280, 140);
            pnlNutrientes.TabIndex = 5;
            pnlNutrientes.Click += pNutrientes_Click;
            pnlNutrientes.Paint += pNutrientes_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(5, 37);
            label2.Name = "label2";
            label2.Size = new Size(141, 19);
            label2.TabIndex = 1;
            label2.Text = "Entenda suas funcoes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "Nutrientes";
            // 
            // pnlClasAlimentos
            // 
            pnlClasAlimentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlClasAlimentos.BackColor = Color.FromArgb(15, 72, 47);
            pnlClasAlimentos.Controls.Add(label3);
            pnlClasAlimentos.Controls.Add(label4);
            pnlClasAlimentos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlClasAlimentos.ForeColor = Color.FromArgb(107, 143, 11);
            pnlClasAlimentos.Location = new Point(295, 5);
            pnlClasAlimentos.Margin = new Padding(5);
            pnlClasAlimentos.MaximumSize = new Size(340, 150);
            pnlClasAlimentos.MinimumSize = new Size(250, 120);
            pnlClasAlimentos.Name = "pnlClasAlimentos";
            pnlClasAlimentos.Size = new Size(280, 140);
            pnlClasAlimentos.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(5, 57);
            label3.Name = "label3";
            label3.Size = new Size(159, 43);
            label3.TabIndex = 1;
            label3.Text = "Conheca os tipos de alimentos";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(4, 4);
            label4.Name = "label4";
            label4.Size = new Size(193, 64);
            label4.TabIndex = 0;
            label4.Text = "Classificação dos Alimentos";
            label4.Click += label4_Click;
            // 
            // pnlEscolhendoMelhor
            // 
            pnlEscolhendoMelhor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlEscolhendoMelhor.BackColor = Color.FromArgb(15, 72, 47);
            pnlEscolhendoMelhor.Controls.Add(label5);
            pnlEscolhendoMelhor.Controls.Add(label6);
            pnlEscolhendoMelhor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlEscolhendoMelhor.ForeColor = Color.FromArgb(107, 143, 11);
            pnlEscolhendoMelhor.Location = new Point(5, 155);
            pnlEscolhendoMelhor.Margin = new Padding(5);
            pnlEscolhendoMelhor.MaximumSize = new Size(340, 150);
            pnlEscolhendoMelhor.MinimumSize = new Size(250, 120);
            pnlEscolhendoMelhor.Name = "pnlEscolhendoMelhor";
            pnlEscolhendoMelhor.Size = new Size(280, 140);
            pnlEscolhendoMelhor.TabIndex = 6;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(5, 29);
            label5.Name = "label5";
            label5.Size = new Size(233, 69);
            label5.TabIndex = 1;
            label5.Text = "Aprenda a comparar alimentos, interpretar informações nutricionais e fazer escolhas mais conscientes.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(4, 4);
            label6.Name = "label6";
            label6.Size = new Size(182, 25);
            label6.TabIndex = 0;
            label6.Text = "Escolhendo Melhor";
            label6.Click += label6_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(txtNutrientes);
            pnlHeader.Controls.Add(txtInicio);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(834, 59);
            pnlHeader.TabIndex = 7;
            // 
            // pnlIntroduction
            // 
            pnlIntroduction.Controls.Add(tableLayoutPanel1);
            pnlIntroduction.Dock = DockStyle.Fill;
            pnlIntroduction.Location = new Point(0, 0);
            pnlIntroduction.Name = "pnlIntroduction";
            pnlIntroduction.Size = new Size(834, 521);
            pnlIntroduction.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlEscolhendoMelhor, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlClasAlimentos, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlNutrientes, 0, 0);
            tableLayoutPanel1.Location = new Point(37, 178);
            tableLayoutPanel1.MaximumSize = new Size(700, 350);
            tableLayoutPanel1.MinimumSize = new Size(580, 300);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(580, 300);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            ClientSize = new Size(834, 521);
            Controls.Add(txtDescricaoInicio);
            Controls.Add(txtTituloInicio);
            Controls.Add(pnlHeader);
            Controls.Add(pnlIntroduction);
            MinimumSize = new Size(850, 560);
            Name = "Main";
            Text = "HealtyhEating";
            pnlNutrientes.ResumeLayout(false);
            pnlNutrientes.PerformLayout();
            pnlClasAlimentos.ResumeLayout(false);
            pnlEscolhendoMelhor.ResumeLayout(false);
            pnlEscolhendoMelhor.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlIntroduction.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel txtInicio;
        private LinkLabel txtNutrientes;
        private Label txtTituloInicio;
        private Label txtDescricaoInicio;
        private Panel pnlNutrientes;
        private Label label1;
        private Label label2;
        private Panel pnlClasAlimentos;
        private Label label3;
        private Label label4;
        private Panel pnlEscolhendoMelhor;
        private Label label5;
        private Label label6;
        private Panel pnlHeader;
        private Panel pnlIntroduction;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
