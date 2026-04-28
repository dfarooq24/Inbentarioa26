namespace ERRONKA3
{
    /// <summary>
    /// Menu nagusiaren formularioa.
    /// Erabiltzailearen rola arabera ekintza ezberdinak erakusten ditu:
    /// irakaslea: ikusi bakarrik; mintegi_burua: editatu ere bai; admin: dena.
    /// </summary>
    public partial class MenuNagusia : Form
    {
        /// <summary>Saioa hasi duen erabiltzailearen rola (lowercase).</summary>
        private readonly string _rola;

        /// <summary>
        /// MenuNagusia berri bat hasieratzen du erabiltzaile rolarekin.
        /// </summary>
        /// <param name="rola">Autentifikazioan lortutako rola string-a.</param>
        public MenuNagusia(string rola)
        {
            InitializeComponent();
            _rola = rola.Trim().ToLower();
        }

        /// <summary>Formularioa kargatzean rola arabera botoiak erakutsi edo ezkutatu.</summary>
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

        /// <summary>Gailuen zerrenda formularioa irekitzen du.</summary>
        private void btnGailuak_Click(object sender, EventArgs e) => new GailuakForm().Show();

        /// <summary>Gailu berria gehitzeko formularioa irekitzen du.</summary>
        private void btnGehitu_Click(object sender, EventArgs e) => new GailuaGehituForm().Show();

        /// <summary>Erabiltzaileak kudeatzeko formularioa irekitzen du.</summary>
        private void btnErab_Click(object sender, EventArgs e) => new ErabiltzaileakForm().Show();

        /// <summary>Aplikazioa ixten du.</summary>
        private void btnIrten_Click(object sender, EventArgs e) => Application.Exit();
    }
}
