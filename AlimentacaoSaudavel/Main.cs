using AlimentacaoSaudavel.UserControls;

namespace AlimentacaoSaudavel
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pNutrientes_Paint(object sender, PaintEventArgs e)
        {

        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pNutrientes_Click(object sender, EventArgs e)
        {
            UC_Nutrientes ucNutrientes = new UC_Nutrientes();
            addUserControl(ucNutrientes);
        }

        private void pnlClasAlimentos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlClasAlimentos_Click(object sender, EventArgs e)
        {
            UC_ClasAlimentos ucClasAlimentos = new UC_ClasAlimentos();
            addUserControl(ucClasAlimentos);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UC_Main ucMain = new UC_Main(this);
            addUserControl(ucMain);
        }
    }
}
