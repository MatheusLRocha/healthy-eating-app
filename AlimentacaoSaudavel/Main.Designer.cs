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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtInicio
            // 
            txtInicio.AutoSize = true;
            txtInicio.Font = new Font("Segoe UI", 12F);
            txtInicio.ForeColor = Color.CornflowerBlue;
            txtInicio.LinkColor = Color.FromArgb(107, 143, 11);
            txtInicio.Location = new Point(37, 28);
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
            txtNutrientes.Location = new Point(88, 28);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 72, 47);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.ForeColor = Color.FromArgb(107, 143, 11);
            panel1.Location = new Point(37, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 120);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(3, 37);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 72, 47);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.FromArgb(107, 143, 11);
            panel2.Location = new Point(306, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 120);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(3, 57);
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 72, 47);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.FromArgb(107, 143, 11);
            panel3.Location = new Point(37, 318);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 120);
            panel3.TabIndex = 6;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(3, 31);
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtDescricaoInicio);
            Controls.Add(txtTituloInicio);
            Controls.Add(txtNutrientes);
            Controls.Add(txtInicio);
            Name = "Main";
            Text = "HealtyhEating";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel txtInicio;
        private LinkLabel txtNutrientes;
        private Label txtTituloInicio;
        private Label txtDescricaoInicio;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private Label label5;
        private Label label6;
    }
}
