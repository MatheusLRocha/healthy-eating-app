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
            pnlHeader = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            pnlMain = new Panel();
            pnlHeader.SuspendLayout();
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
            txtInicio.LinkClicked += txtInicio_LinkClicked;
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
            txtNutrientes.LinkClicked += txtNutrientes_LinkClicked;
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(linkLabel2);
            pnlHeader.Controls.Add(linkLabel1);
            pnlHeader.Controls.Add(txtNutrientes);
            pnlHeader.Controls.Add(txtInicio);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1264, 59);
            pnlHeader.TabIndex = 7;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F);
            linkLabel2.LinkColor = Color.FromArgb(107, 143, 11);
            linkLabel2.Location = new Point(385, 22);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(142, 21);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Fontes/Referências";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.LinkColor = Color.FromArgb(107, 143, 11);
            linkLabel1.Location = new Point(178, 22);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(201, 21);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Classificação dos Alimentos";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1264, 681);
            pnlMain.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            ClientSize = new Size(1264, 681);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMain);
            MinimumSize = new Size(1280, 720);
            Name = "Main";
            Text = "HealtyhEating";
            Load += Main_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel txtInicio;
        private LinkLabel txtNutrientes;
        private Panel pnlHeader;
        private Panel pnlMain;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
