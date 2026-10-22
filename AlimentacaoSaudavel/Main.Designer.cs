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
            linlLblInicio = new LinkLabel();
            linkLblNutrientes = new LinkLabel();
            pnlHeader = new Panel();
            pictureBox7 = new PictureBox();
            label1 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            linkLblAlimentosDia = new LinkLabel();
            linkLblEscolhas = new LinkLabel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            linkLblFontes = new LinkLabel();
            linkLblClasAlimentos = new LinkLabel();
            pnlMain = new Panel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linlLblInicio
            // 
            linlLblInicio.AutoSize = true;
            linlLblInicio.Font = new Font("Segoe UI", 12F);
            linlLblInicio.ForeColor = Color.CornflowerBlue;
            linlLblInicio.LinkColor = Color.White;
            linlLblInicio.Location = new Point(58, 140);
            linlLblInicio.Name = "linlLblInicio";
            linlLblInicio.Size = new Size(47, 21);
            linlLblInicio.TabIndex = 0;
            linlLblInicio.TabStop = true;
            linlLblInicio.Text = "Inicio";
            linlLblInicio.LinkClicked += linkLblInicio_LinkClicked;
            // 
            // linkLblNutrientes
            // 
            linkLblNutrientes.AutoSize = true;
            linkLblNutrientes.Font = new Font("Segoe UI", 12F);
            linkLblNutrientes.LinkColor = Color.White;
            linkLblNutrientes.Location = new Point(58, 200);
            linkLblNutrientes.Name = "linkLblNutrientes";
            linkLblNutrientes.Size = new Size(83, 21);
            linkLblNutrientes.TabIndex = 1;
            linkLblNutrientes.TabStop = true;
            linkLblNutrientes.Text = "Nutrientes";
            linkLblNutrientes.LinkClicked += linkLblNutrientes_LinkClicked;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(15, 72, 47);
            pnlHeader.Controls.Add(pictureBox7);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(pictureBox6);
            pnlHeader.Controls.Add(pictureBox5);
            pnlHeader.Controls.Add(linkLblAlimentosDia);
            pnlHeader.Controls.Add(linkLblEscolhas);
            pnlHeader.Controls.Add(pictureBox4);
            pnlHeader.Controls.Add(pictureBox3);
            pnlHeader.Controls.Add(pictureBox2);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(linkLblFontes);
            pnlHeader.Controls.Add(linkLblClasAlimentos);
            pnlHeader.Controls.Add(linkLblNutrientes);
            pnlHeader.Controls.Add(linlLblInicio);
            pnlHeader.Dock = DockStyle.Left;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(265, 681);
            pnlHeader.TabIndex = 7;
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
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 371);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(20, 311);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // linkLblAlimentosDia
            // 
            linkLblAlimentosDia.AutoSize = true;
            linkLblAlimentosDia.Font = new Font("Segoe UI", 12F);
            linkLblAlimentosDia.LinkColor = Color.White;
            linkLblAlimentosDia.Location = new Point(58, 382);
            linkLblAlimentosDia.Name = "linkLblAlimentosDia";
            linkLblAlimentosDia.Size = new Size(184, 21);
            linkLblAlimentosDia.TabIndex = 8;
            linkLblAlimentosDia.TabStop = true;
            linkLblAlimentosDia.Text = "Alimentação no Dia a Dia";
            linkLblAlimentosDia.LinkClicked += linkLblAlimentosDia_LinkClicked;
            // 
            // linkLblEscolhas
            // 
            linkLblEscolhas.AutoSize = true;
            linkLblEscolhas.Font = new Font("Segoe UI", 12F);
            linkLblEscolhas.LinkColor = Color.White;
            linkLblEscolhas.Location = new Point(57, 322);
            linkLblEscolhas.Name = "linkLblEscolhas";
            linkLblEscolhas.Size = new Size(143, 21);
            linkLblEscolhas.TabIndex = 7;
            linkLblEscolhas.TabStop = true;
            linkLblEscolhas.Text = "Escolhendo Melhor";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 431);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 249);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // linkLblFontes
            // 
            linkLblFontes.AutoSize = true;
            linkLblFontes.Font = new Font("Segoe UI", 12F);
            linkLblFontes.LinkColor = Color.White;
            linkLblFontes.Location = new Point(58, 442);
            linkLblFontes.Name = "linkLblFontes";
            linkLblFontes.Size = new Size(142, 21);
            linkLblFontes.TabIndex = 3;
            linkLblFontes.TabStop = true;
            linkLblFontes.Text = "Fontes/Referências";
            linkLblFontes.LinkClicked += linkLblFontes_LinkClicked;
            // 
            // linkLblClasAlimentos
            // 
            linkLblClasAlimentos.AutoSize = true;
            linkLblClasAlimentos.Font = new Font("Segoe UI", 12F);
            linkLblClasAlimentos.LinkColor = Color.White;
            linkLblClasAlimentos.Location = new Point(58, 260);
            linkLblClasAlimentos.Name = "linkLblClasAlimentos";
            linkLblClasAlimentos.Size = new Size(201, 21);
            linkLblClasAlimentos.TabIndex = 2;
            linkLblClasAlimentos.TabStop = true;
            linkLblClasAlimentos.Text = "Classificação dos Alimentos";
            linkLblClasAlimentos.LinkClicked += linkLblClasAlimentos_LinkClicked;
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.Location = new Point(265, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(999, 681);
            pnlMain.TabIndex = 8;
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
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linlLblInicio;
        private LinkLabel linkLblNutrientes;
        private Panel pnlHeader;
        private LinkLabel linkLblClasAlimentos;
        private LinkLabel linkLblFontes;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private LinkLabel linkLblEscolhas;
        private LinkLabel linkLblAlimentosDia;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label1;
        private PictureBox pictureBox7;
        private Panel pnlMain;
    }
}
