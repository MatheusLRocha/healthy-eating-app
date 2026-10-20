namespace AlimentacaoSaudavel.UserControls
{
    partial class UC_Main
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
            txtDescricaoInicio = new Label();
            txtTituloInicio = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlEscolhendoMelhor = new Panel();
            label5 = new Label();
            label6 = new Label();
            pnlClasAlimentos = new Panel();
            label3 = new Label();
            label4 = new Label();
            pnlNutrientes = new Panel();
            label2 = new Label();
            label1 = new Label();
            pnlAlimentacaosDiaADia = new Panel();
            label7 = new Label();
            label8 = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlEscolhendoMelhor.SuspendLayout();
            pnlClasAlimentos.SuspendLayout();
            pnlNutrientes.SuspendLayout();
            pnlAlimentacaosDiaADia.SuspendLayout();
            SuspendLayout();
            // 
            // txtDescricaoInicio
            // 
            txtDescricaoInicio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricaoInicio.ForeColor = Color.FromArgb(107, 143, 11);
            txtDescricaoInicio.Location = new Point(44, 108);
            txtDescricaoInicio.Name = "txtDescricaoInicio";
            txtDescricaoInicio.Size = new Size(558, 47);
            txtDescricaoInicio.TabIndex = 5;
            txtDescricaoInicio.Text = "Entenda de forma simples como os nutrientes, alimentos e grupos alimentares fazem parte da nossa alimentação.";
            // 
            // txtTituloInicio
            // 
            txtTituloInicio.AutoSize = true;
            txtTituloInicio.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTituloInicio.ForeColor = Color.FromArgb(107, 143, 11);
            txtTituloInicio.Location = new Point(44, 78);
            txtTituloInicio.Name = "txtTituloInicio";
            txtTituloInicio.Size = new Size(282, 30);
            txtTituloInicio.TabIndex = 4;
            txtTituloInicio.Text = "Aprenda sobre alimentação";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pnlAlimentacaosDiaADia, 1, 1);
            tableLayoutPanel1.Controls.Add(pnlEscolhendoMelhor, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlClasAlimentos, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlNutrientes, 0, 0);
            tableLayoutPanel1.Location = new Point(44, 158);
            tableLayoutPanel1.MaximumSize = new Size(1000, 580);
            tableLayoutPanel1.MinimumSize = new Size(580, 300);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(580, 300);
            tableLayoutPanel1.TabIndex = 8;
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
            pnlEscolhendoMelhor.MaximumSize = new Size(450, 240);
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
            pnlClasAlimentos.MaximumSize = new Size(450, 240);
            pnlClasAlimentos.MinimumSize = new Size(250, 120);
            pnlClasAlimentos.Name = "pnlClasAlimentos";
            pnlClasAlimentos.Size = new Size(280, 140);
            pnlClasAlimentos.TabIndex = 6;
            pnlClasAlimentos.Click += pnlClasAlimentos_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(5, 57);
            label3.Name = "label3";
            label3.Size = new Size(159, 43);
            label3.TabIndex = 1;
            label3.Text = "Conheca os tipos de alimentos";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(4, 4);
            label4.Name = "label4";
            label4.Size = new Size(193, 64);
            label4.TabIndex = 0;
            label4.Text = "Classificação dos Alimentos";
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
            pnlNutrientes.MaximumSize = new Size(450, 240);
            pnlNutrientes.MinimumSize = new Size(250, 120);
            pnlNutrientes.Name = "pnlNutrientes";
            pnlNutrientes.Size = new Size(280, 140);
            pnlNutrientes.TabIndex = 5;
            pnlNutrientes.Click += pnlNutrientes_Click_1;
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
            // pnlAlimentacaosDiaADia
            // 
            pnlAlimentacaosDiaADia.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAlimentacaosDiaADia.BackColor = Color.FromArgb(15, 72, 47);
            pnlAlimentacaosDiaADia.Controls.Add(label7);
            pnlAlimentacaosDiaADia.Controls.Add(label8);
            pnlAlimentacaosDiaADia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlAlimentacaosDiaADia.ForeColor = Color.FromArgb(107, 143, 11);
            pnlAlimentacaosDiaADia.Location = new Point(295, 155);
            pnlAlimentacaosDiaADia.Margin = new Padding(5);
            pnlAlimentacaosDiaADia.MaximumSize = new Size(450, 240);
            pnlAlimentacaosDiaADia.MinimumSize = new Size(250, 120);
            pnlAlimentacaosDiaADia.Name = "pnlAlimentacaosDiaADia";
            pnlAlimentacaosDiaADia.Size = new Size(280, 140);
            pnlAlimentacaosDiaADia.TabIndex = 7;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(5, 29);
            label7.Name = "label7";
            label7.Size = new Size(233, 69);
            label7.TabIndex = 1;
            label7.Text = "Dicas gerais para uma boa alimentação no dia a dia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(4, 4);
            label8.Name = "label8";
            label8.Size = new Size(234, 25);
            label8.TabIndex = 0;
            label8.Text = "Alimentação no Dia a Dia";
            // 
            // UC_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txtDescricaoInicio);
            Controls.Add(txtTituloInicio);
            Name = "UC_Main";
            Size = new Size(834, 521);
            tableLayoutPanel1.ResumeLayout(false);
            pnlEscolhendoMelhor.ResumeLayout(false);
            pnlEscolhendoMelhor.PerformLayout();
            pnlClasAlimentos.ResumeLayout(false);
            pnlNutrientes.ResumeLayout(false);
            pnlNutrientes.PerformLayout();
            pnlAlimentacaosDiaADia.ResumeLayout(false);
            pnlAlimentacaosDiaADia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtDescricaoInicio;
        private Label txtTituloInicio;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlEscolhendoMelhor;
        private Label label5;
        private Label label6;
        private Panel pnlClasAlimentos;
        private Label label3;
        private Label label4;
        private Panel pnlNutrientes;
        private Label label2;
        private Label label1;
        private Panel pnlAlimentacaosDiaADia;
        private Label label7;
        private Label label8;
    }
}
