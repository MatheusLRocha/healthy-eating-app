using AlimentacaoSaudavel.UserControls;

namespace AlimentacaoSaudavel
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
    }
}
