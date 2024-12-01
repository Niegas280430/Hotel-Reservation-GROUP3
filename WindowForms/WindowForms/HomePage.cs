namespace WindowForms
{
    public partial class HomePageForm : Form
    {
        private Rectangle originalFormSize, pbox1FormSize;
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void add_UControls(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlMAIN.Controls.Clear();
            pnlMAIN.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (var pnl in pnlTOP.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Cornsilk;
            }

            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnROOMS":
                    add_UControls(new UC_ROOMS());
                    pnlROOMS.BackColor = Color.RoyalBlue;
                    break;
                case "btnOFFERS":
                    add_UControls(new UC_OFFERS());
                    pnlOFFERS.BackColor = Color.RoyalBlue;
                    break;
                case "btnFAQ":
                    add_UControls(new UC_FAQ());
                    pnlFAQ.BackColor = Color.RoyalBlue;
                    break;
                case "btnHOME":
                    add_UControls(new UC_HOME());
                    pnlHOME.BackColor = Color.RoyalBlue;
                    break;
            }
        }


    }
}
