using AlimentacaoSaudavel.UserControls;

namespace AlimentacaoSaudavel
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UC_Main ucMain = new UC_Main(this);
            addUserControl(ucMain);
        }

        private void txtInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Main ucMain = new UC_Main(this);
            addUserControl(ucMain);
        }

        private void txtNutrientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Nutrientes ucNutrientes = new UC_Nutrientes();
            addUserControl(ucNutrientes);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_ClasAlimentos ucClasAlimentos = new UC_ClasAlimentos();
            addUserControl(ucClasAlimentos);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Fontes ucFontes = new UC_Fontes();
            addUserControl(ucFontes);
        }
    }
}
