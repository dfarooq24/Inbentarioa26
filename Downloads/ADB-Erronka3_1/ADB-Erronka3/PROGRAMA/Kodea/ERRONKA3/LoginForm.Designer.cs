namespace ERRONKA3
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            // Controls
            pnlLeft = new Panel(); pnlRight = new Panel(); pnlCard = new Panel();
            lblLogo = new Label(); lblAppName = new Label(); lblTagline = new Label(); git push -f origin mainecho "bin/" >> .gitignore
echo "obj/" >> .gitignore
git rm -r--cached bin/ obj / 2 >$null
git add .
git commit -m "DocFX dokumentazioa gehitu - exe gabe"
git push -f origin mainecho "bin/" >> .gitignore
echo "obj/" >> .gitignore
git rm -r--cached bin/ obj / 2 >$null
git add .
git commit -m "DocFX dokumentazioa gehitu - exe gabe"
git push -f origin main
            lblWelcome = new Label(); lblUserLbl = new Label(); txtUser = new TextBox();
            lblPassLbl = new Label(); txtPass = new TextBox(); btnSartu = new Button();
            lblFooter = new Label();

            SuspendLayout();

            // ── LEFT panel (brand) ─────────────────────────────
            pnlLeft.Dock = DockStyle.Left; pnlLeft.Width = 380;
            pnlLeft.BackColor = UIHelper.Primary;

            lblLogo.Text = "◈"; lblLogo.Font = new Font("Segoe UI", 52, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(96, 165, 250); lblLogo.AutoSize = false;
            lblLogo.Size = new Size(380, 80); lblLogo.Location = new Point(0, 140);
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;

            lblAppName.Text = "INBENTARIOA"; lblAppName.Font = new Font("Segoe UI", 26, FontStyle.Bold);
            lblAppName.ForeColor = Color.White; lblAppName.AutoSize = false;
            lblAppName.Size = new Size(380, 46); lblAppName.Location = new Point(0, 226);
            lblAppName.TextAlign = ContentAlignment.MiddleCenter;

            lblTagline.Text = "Izarraitz LHII · Gailu kudeaketa sistema";
            lblTagline.Font = new Font("Segoe UI", 10); lblTagline.ForeColor = Color.FromArgb(148, 163, 184);
            lblTagline.AutoSize = false; lblTagline.Size = new Size(380, 26); lblTagline.Location = new Point(0, 278);
            lblTagline.TextAlign = ContentAlignment.MiddleCenter;

            pnlLeft.Controls.AddRange(new Control[] { lblLogo, lblAppName, lblTagline });

            // ── RIGHT panel ────────────────────────────────────
            pnlRight.Dock = DockStyle.Fill; pnlRight.BackColor = Color.FromArgb(248, 250, 252);
            pnlRight.Controls.Add(pnlCard);

            // ── Card ──────────────────────────────────────────
            pnlCard.BackColor = Color.White; pnlCard.Size = new Size(360, 400);
            pnlCard.Location = new Point(60, 80);

            lblWelcome.Text = "Ongi etorri";
            lblWelcome.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            lblWelcome.ForeColor = UIHelper.Primary; lblWelcome.AutoSize = false;
            lblWelcome.Size = new Size(360, 40); lblWelcome.Location = new Point(0, 28);
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;

            lblUserLbl.Text = "Erabiltzailea"; lblUserLbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblUserLbl.ForeColor = UIHelper.Muted; lblUserLbl.AutoSize = true; lblUserLbl.Location = new Point(30, 96);

            txtUser = UIHelper.MakeTxt(new Point(30, 118));
            txtUser.PlaceholderText = "Izena sartu...";

            lblPassLbl.Text = "Pasahitza"; lblPassLbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblPassLbl.ForeColor = UIHelper.Muted; lblPassLbl.AutoSize = true; lblPassLbl.Location = new Point(30, 166);

            txtPass = UIHelper.MakeTxt(new Point(30, 188), password: true);
            txtPass.PlaceholderText = "Pasahitza sartu...";
            txtPass.KeyDown += txtPass_KeyDown;

            btnSartu = UIHelper.MakeBtn("  SARTU  →", UIHelper.Primary, new Size(300, 48), new Point(30, 252), btnSartu_Click);
            btnSartu.Font = new Font("Segoe UI", 13, FontStyle.Bold);

            lblFooter.Text = "ERRONKA 3 · v2.0 · 2025-2026";
            lblFooter.Font = new Font("Segoe UI", 8); lblFooter.ForeColor = Color.FromArgb(148, 163, 184);
            lblFooter.AutoSize = false; lblFooter.Size = new Size(360, 22); lblFooter.Location = new Point(0, 368);
            lblFooter.TextAlign = ContentAlignment.MiddleCenter;

            pnlCard.Controls.AddRange(new Control[] { lblWelcome, lblUserLbl, txtUser, lblPassLbl, txtPass, btnSartu, lblFooter });

            // ── Form ──────────────────────────────────────────
            AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(860, 560);
            Controls.AddRange(new Control[] { pnlRight, pnlLeft });
            FormBorderStyle = FormBorderStyle.FixedSingle; MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen; Text = "INBENTARIOA — Saioa hasi";
            ResumeLayout(false);
        }

        private Panel pnlLeft, pnlRight, pnlCard;
        private Label lblLogo, lblAppName, lblTagline, lblWelcome;
        private Label lblUserLbl, lblPassLbl, lblFooter;
        private TextBox txtUser, txtPass;
        private Button btnSartu;
    }
}
