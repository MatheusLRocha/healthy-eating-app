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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pnlHeader = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            cBtnFontes = new CustomButton();
            cBtnInicio = new CustomButton();
            cBtnAlimentacaoDiaDia = new CustomButton();
            cBtnEscolhendoMelhor = new CustomButton();
            cBtnNutrientes = new CustomButton();
            cBtnClasAlimentos = new CustomButton();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            pnlLogo = new Panel();
            pnlMain = new Panel();
            cBtnCreditos = new CustomButton();
            pnlHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(15, 72, 47);
            pnlHeader.Controls.Add(tableLayoutPanel1);
            pnlHeader.Controls.Add(pictureBox7);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(pnlLogo);
            pnlHeader.Dock = DockStyle.Left;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(260, 681);
            pnlHeader.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cBtnCreditos, 0, 6);
            tableLayoutPanel1.Controls.Add(cBtnFontes, 0, 5);
            tableLayoutPanel1.Controls.Add(cBtnInicio, 0, 0);
            tableLayoutPanel1.Controls.Add(cBtnAlimentacaoDiaDia, 0, 4);
            tableLayoutPanel1.Controls.Add(cBtnEscolhendoMelhor, 0, 3);
            tableLayoutPanel1.Controls.Add(cBtnNutrientes, 0, 1);
            tableLayoutPanel1.Controls.Add(cBtnClasAlimentos, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 130);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2853069F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.285305F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2881613F));
            tableLayoutPanel1.Size = new Size(260, 369);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // cBtnFontes
            // 
            cBtnFontes.BackColor = Color.FromArgb(15, 72, 47);
            cBtnFontes.FlatAppearance.BorderSize = 0;
            cBtnFontes.FlatStyle = FlatStyle.Flat;
            cBtnFontes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cBtnFontes.ForeColor = Color.White;
            cBtnFontes.HoverColor = Color.FromArgb(46, 125, 79);
            cBtnFontes.Image = (Image)resources.GetObject("cBtnFontes.Image");
            cBtnFontes.ImageAlign = ContentAlignment.MiddleLeft;
            cBtnFontes.Location = new Point(3, 263);
            cBtnFontes.Name = "cBtnFontes";
            cBtnFontes.NormalColor = Color.FromArgb(15, 72, 47);
            cBtnFontes.Size = new Size(250, 45);
            cBtnFontes.TabIndex = 16;
            cBtnFontes.Text = "          Fontes/Referências";
            cBtnFontes.TextAlign = ContentAlignment.MiddleLeft;
            cBtnFontes.UseVisualStyleBackColor = false;
            cBtnFontes.Click += cBtnFontes_Click;
            // 
            // cBtnInicio
            // 
            cBtnInicio.BackColor = Color.FromArgb(15, 72, 47);
            cBtnInicio.FlatAppearance.BorderSize = 0;
            cBtnInicio.FlatStyle = FlatStyle.Flat;
            cBtnInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cBtnInicio.ForeColor = Color.White;
            cBtnInicio.HoverColor = Color.FromArgb(46, 125, 79);
            cBtnInicio.Image = (Image)resources.GetObject("cBtnInicio.Image");
            cBtnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            cBtnInicio.Location = new Point(3, 3);
            cBtnInicio.Name = "cBtnInicio";
            cBtnInicio.NormalColor = Color.FromArgb(15, 72, 47);
            cBtnInicio.Size = new Size(250, 45);
            cBtnInicio.TabIndex = 0;
            cBtnInicio.Text = "          Início";
            cBtnInicio.TextAlign = ContentAlignment.MiddleLeft;
            cBtnInicio.UseVisualStyleBackColor = false;
            cBtnInicio.Click += cBtnInicio_Click;
            // 
            // cBtnAlimentacaoDiaDia
            // 
            cBtnAlimentacaoDiaDia.BackColor = Color.FromArgb(15, 72, 47);
            cBtnAlimentacaoDiaDia.FlatAppearance.BorderSize = 0;
            cBtnAlimentacaoDiaDia.FlatStyle = FlatStyle.Flat;
            cBtnAlimentacaoDiaDia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cBtnAlimentacaoDiaDia.ForeColor = Color.White;
            cBtnAlimentacaoDiaDia.HoverColor = Color.FromArgb(46, 125, 79);
            cBtnAlimentacaoDiaDia.Image = (Image)resources.GetObject("cBtnAlimentacaoDiaDia.Image");
            cBtnAlimentacaoDiaDia.ImageAlign = ContentAlignment.MiddleLeft;
            cBtnAlimentacaoDiaDia.Location = new Point(3, 211);
            cBtnAlimentacaoDiaDia.Name = "cBtnAlimentacaoDiaDia";
            cBtnAlimentacaoDiaDia.NormalColor = Color.FromArgb(15, 72, 47);
            cBtnAlimentacaoDiaDia.Size = new Size(250, 45);
            cBtnAlimentacaoDiaDia.TabIndex = 15;
            cBtnAlimentacaoDiaDia.Text = "          Alimentação no dia a dia";
            cBtnAlimentacaoDiaDia.TextAlign = ContentAlignment.MiddleLeft;
            cBtnAlimentacaoDiaDia.UseVisualStyleBackColor = false;
            cBtnAlimentacaoDiaDia.Click += cBtnAlimentacaoDiaDia_Click;
            // 
            // cBtnEscolhendoMelhor
            // 
            cBtnEscolhendoMelhor.BackColor = Color.FromArgb(15, 72, 47);
            cBtnEscolhendoMelhor.FlatAppearance.BorderSize = 0;
            cBtnEscolhendoMelhor.FlatStyle = FlatStyle.Flat;
            cBtnEscolhendoMelhor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cBtnEscolhendoMelhor.ForeColor = Color.White;
            cBtnEscolhendoMelhor.HoverColor = Color.FromArgb(46, 125, 79);
            cBtnEscolhendoMelhor.Image = (Image)resources.GetObject("cBtnEscolhendoMelhor.Image");
            cBtnEscolhendoMelhor.ImageAlign = ContentAlignment.MiddleLeft;
            cBtnEscolhendoMelhor.Location = new Point(3, 159);
            cBtnEscolhendoMelhor.Name = "cBtnEscolhendoMelhor";
            cBtnEscolhendoMelhor.NormalColor = Color.FromArgb(15, 72, 47);
            cBtnEscolhendoMelhor.Size = new Size(250, 45);
            cBtnEscolhendoMelhor.TabIndex = 14;
            cBtnEscolhendoMelhor.Text = "          Escolhendo melhor";
            cBtnEscolhendoMelhor.TextAlign = ContentAlignment.MiddleLeft;
            cBtnEscolhendoMelhor.UseVisualStyleBackColor = false;
            cBtnEscolhendoMelhor.Click += cBtnEscolhendoMelhor_Click;
            // 
            // cBtnNutrientes
            // 
            cBtnNutrientes.BackColor = Color.FromArgb(15, 72, 47);
            cBtnNutrientes.FlatAppearance.BorderSize = 0;
            cBtnNutrientes.FlatStyle = FlatStyle.Flat;
            cBtnNutrientes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cBtnNutrientes.ForeColor = Color.White;
            cBtnNutrientes.HoverColor = Color.FromArgb(46, 125, 79);
            cBtnNutrientes.Image = (Image)resources.GetObject("cBtnNutrientes.Image");
            cBtnNutrientes.ImageAlign = ContentAlignment.MiddleLeft;
            cBtnNutrientes.Location = new Point(3, 55);
            cBtnNutrientes.Name = "cBtnNutrientes";
            cBtnNutrientes.NormalColor = Color.FromArgb(15, 72, 47);
            cBtnNutrientes.Size = new Size(250, 45);
            cBtnNutrientes.TabIndex = 1;
            cBtnNutrientes.Text = "          Nutrientes";
            cBtnNutrientes.TextAlign = ContentAlignment.MiddleLeft;
            cBtnNutrientes.UseVisualStyleBackColor = false;
            cBtnNutrientes.Click += cBtnNutrientes_Click;
            // 
            // cBtnClasAlimentos
            // 
            cBtnClasAlimentos.BackColor = Color.FromArgb(15, 72, 47);
            cBtnClasAlimentos.FlatAppearance.BorderSize = 0;
            cBtnClasAlimentos.FlatStyle = FlatStyle.Flat;
            cBtnClasAlimentos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cBtnClasAlimentos.ForeColor = Color.White;
            cBtnClasAlimentos.HoverColor = Color.FromArgb(46, 125, 79);
            cBtnClasAlimentos.Image = (Image)resources.GetObject("cBtnClasAlimentos.Image");
            cBtnClasAlimentos.ImageAlign = ContentAlignment.MiddleLeft;
            cBtnClasAlimentos.Location = new Point(3, 107);
            cBtnClasAlimentos.Name = "cBtnClasAlimentos";
            cBtnClasAlimentos.NormalColor = Color.FromArgb(15, 72, 47);
            cBtnClasAlimentos.Size = new Size(250, 45);
            cBtnClasAlimentos.TabIndex = 2;
            cBtnClasAlimentos.Text = "          Classificação dos alimentos";
            cBtnClasAlimentos.TextAlign = ContentAlignment.MiddleLeft;
            cBtnClasAlimentos.UseVisualStyleBackColor = false;
            cBtnClasAlimentos.Click += cBtnClasAlimentos_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(18, 28);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(64, 64);
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(88, 28);
            label1.Name = "label1";
            label1.Size = new Size(142, 65);
            label1.TabIndex = 11;
            label1.Text = "Alimentação Saudável";
            // 
            // pnlLogo
            // 
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(260, 130);
            pnlLogo.TabIndex = 13;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.Location = new Point(259, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1005, 681);
            pnlMain.TabIndex = 8;
            // 
            // cBtnCreditos
            // 
            cBtnCreditos.BackColor = Color.FromArgb(15, 72, 47);
            cBtnCreditos.FlatAppearance.BorderSize = 0;
            cBtnCreditos.FlatStyle = FlatStyle.Flat;
            cBtnCreditos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cBtnCreditos.ForeColor = Color.White;
            cBtnCreditos.HoverColor = Color.FromArgb(46, 125, 79);
            cBtnCreditos.Image = (Image)resources.GetObject("cBtnCreditos.Image");
            cBtnCreditos.ImageAlign = ContentAlignment.MiddleLeft;
            cBtnCreditos.Location = new Point(3, 315);
            cBtnCreditos.Name = "cBtnCreditos";
            cBtnCreditos.NormalColor = Color.FromArgb(15, 72, 47);
            cBtnCreditos.Size = new Size(250, 45);
            cBtnCreditos.TabIndex = 17;
            cBtnCreditos.Text = "          Créditos";
            cBtnCreditos.TextAlign = ContentAlignment.MiddleLeft;
            cBtnCreditos.UseVisualStyleBackColor = false;
            cBtnCreditos.Click += cBtnCreditos_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlMain);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1280, 720);
            Name = "Main";
            Text = "HealtyhEating";
            Load += Main_Load;
            pnlHeader.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlHeader;
        private Label label1;
        private PictureBox pictureBox7;
        private Panel pnlMain;
        private Panel pnlLogo;
        private CustomButton cBtnInicio;
        private CustomButton cBtnClasAlimentos;
        private CustomButton cBtnNutrientes;
        private CustomButton cBtnEscolhendoMelhor;
        private CustomButton cBtnFontes;
        private CustomButton cBtnAlimentacaoDiaDia;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomButton cBtnCreditos;
    }
}
