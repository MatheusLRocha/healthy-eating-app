using AlimentacaoSaudavel.UserControls;
using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia;

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

        private void linkLblInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Main ucMain = new UC_Main(this);
            addUserControl(ucMain);
        }

        private void linkLblNutrientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Nutrientes ucNutrientes = new UC_Nutrientes();
            addUserControl(ucNutrientes);
        }

        private void linkLblClasAlimentos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_ClasAlimentos ucClasAlimentos = new UC_ClasAlimentos();
            addUserControl(ucClasAlimentos);
        }

        private void linkLblFontes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_Fontes ucFontes = new UC_Fontes();
            addUserControl(ucFontes);
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLblAlimentosDia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UC_AlimentacaoDiaDia ucAlimentacaoDiaDia = new UC_AlimentacaoDiaDia();
            addUserControl(ucAlimentacaoDiaDia);
        }
    }
}
