using AlimentacaoSaudavel.UserControls;
using AlimentacaoSaudavel.UserControls.AlimentacaoDiaDia;
using AlimentacaoSaudavel.UserControls.EscolhendoMelhor;

namespace AlimentacaoSaudavel
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            PanelRound panelRound = new PanelRound();

            panelRound.ArredondarCantos(cBtnInicio, 8);
            panelRound.ArredondarCantos(cBtnAlimentacaoDiaDia, 8);
            panelRound.ArredondarCantos(cBtnEscolhendoMelhor, 8);
            panelRound.ArredondarCantos(cBtnNutrientes, 8);
            panelRound.ArredondarCantos(cBtnClasAlimentos, 8);
            panelRound.ArredondarCantos(cBtnFontes, 8);
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

        private void cBtnInicio_Click(object sender, EventArgs e)
        {
            UC_Main ucMain = new UC_Main(this);
            addUserControl(ucMain);
        }

        private void cBtnNutrientes_Click(object sender, EventArgs e)
        {
            UC_Nutrientes ucNutrientes = new UC_Nutrientes();
            addUserControl(ucNutrientes);
        }

        private void cBtnClasAlimentos_Click(object sender, EventArgs e)
        {
            UC_ClasAlimentos ucClasAlimentos = new UC_ClasAlimentos();
            addUserControl(ucClasAlimentos);
        }

        private void cBtnEscolhendoMelhor_Click(object sender, EventArgs e)
        {
            UC_EscolhendoMelhor ucEscolhendoMelhor = new UC_EscolhendoMelhor();
            addUserControl(ucEscolhendoMelhor);
        }

        private void cBtnAlimentacaoDiaDia_Click(object sender, EventArgs e)
        {
            UC_AlimentacaoDiaDia ucAlimentacaoDiaDia = new UC_AlimentacaoDiaDia();
            addUserControl(ucAlimentacaoDiaDia);
        }

        private void cBtnFontes_Click(object sender, EventArgs e)
        {
            UC_Fontes ucFontes = new UC_Fontes();
            addUserControl(ucFontes);
        }
    }
}
