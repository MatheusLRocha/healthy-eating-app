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
            // pnlMain
            // 
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(834, 521);
            pnlMain.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 226, 217);
            ClientSize = new Size(834, 521);
            Controls.Add(pnlHeader);
            Controls.Add(pnlMain);
            MinimumSize = new Size(850, 560);
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
    }
}
