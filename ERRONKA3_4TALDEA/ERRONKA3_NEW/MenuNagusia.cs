namespace ERRONKA3
{
    public partial class MenuNagusia : Form
    {
        private readonly string _rola;

        public MenuNagusia(string rola)
        {
            InitializeComponent();
            _rola = rola.Trim().ToLower();
        }

        private void MenuNagusia_Load(object sender, EventArgs e)
        {
            lblRola.Text = "● " + char.ToUpper(_rola[0]) + _rola[1..];

            switch (_rola)
            {
                case "irakaslea":
                    cardGehitu.Visible = false;
                    cardErab.Visible = false;
                    break;
                case "mintegi_burua":
                    cardErab.Visible = false;
                    break;
            }
        }

        private void btnGailuak_Click(object sender, EventArgs e) => new GailuakForm().Show();
        private void btnGehitu_Click(object sender, EventArgs e) => new GailuaGehituForm().Show();
        private void btnErab_Click(object sender, EventArgs e) => new ErabiltzaileakForm().Show();
        private void btnIrten_Click(object sender, EventArgs e) => Application.Exit();
    }
}
