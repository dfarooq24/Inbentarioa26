namespace ERRONKA3
{
    partial class MenuNagusia
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            pnlHeader = new Panel(); lblLogo = new Label(); lblTitle = new Label(); lblRola = new Label();
            pnlBody = new Panel(); lblGreeting = new Label(); lblSub = new Label();
            pnlCards = new Panel();
            cardGailuak = new Panel(); cardGehitu = new Panel(); cardErab = new Panel();
            pnlFooter = new Panel(); btnIrten = new Button(); lblCopy = new Label();

            SuspendLayout();

            // ── HEADER ────────────────────────────────────────
            pnlHeader.BackColor = UIHelper.Primary; pnlHeader.Dock = DockStyle.Top; pnlHeader.Height = 64;

            lblLogo.Text = "◈"; lblLogo.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(96, 165, 250); lblLogo.AutoSize = true; lblLogo.Location = new Point(18, 17);

            lblTitle.Text = "  INBENTARIOA"; lblTitle.Font = new Font("Segoe UI", 17, FontStyle.Bold);
            lblTitle.ForeColor = Color.White; lblTitle.AutoSize = true; lblTitle.Location = new Point(54, 18);

            lblRola.Text = ""; lblRola.Font = new Font("Segoe UI", 10);
            lblRola.ForeColor = Color.FromArgb(148, 163, 184); lblRola.AutoSize = true;
            lblRola.Location = new Point(680, 22);

            pnlHeader.Controls.AddRange(new Control[] { lblLogo, lblTitle, lblRola });

            // ── BODY ──────────────────────────────────────────
            pnlBody.BackColor = UIHelper.BgLight; pnlBody.Dock = DockStyle.Fill;

            lblGreeting.Text = "Menu Nagusia";
            lblGreeting.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblGreeting.ForeColor = UIHelper.Primary; lblGreeting.AutoSize = true; lblGreeting.Location = new Point(40, 36);

            lblSub.Text = "Hautatu burutu nahi duzun ekintza";
            lblSub.Font = new Font("Segoe UI", 11); lblSub.ForeColor = UIHelper.Muted;
            lblSub.AutoSize = true; lblSub.Location = new Point(40, 72);

            // ── CARDS ─────────────────────────────────────────
            pnlCards.BackColor = Color.Transparent; pnlCards.Location = new Point(30, 120);
            pnlCards.Size = new Size(800, 220);

            BuildCard(cardGailuak, new Point(0,0),   "🖥",  "Gailuak Ikusi",
                "Inbentarioa kontsultatu,\neditatu eta kudeatu", UIHelper.Accent,   btnGailuak_Click);
            BuildCard(cardGehitu,  new Point(260,0),  "➕", "Gailu Berria",
                "Gailu berri bat sisteman\nerregistratu",        UIHelper.Success,  btnGehitu_Click);
            BuildCard(cardErab,    new Point(520,0),  "👥", "Erabiltzaileak",
                "Erabiltzaileak kudeatu\neta baimenak ezarri",   UIHelper.Purple,   btnErab_Click);

            pnlCards.Controls.AddRange(new Control[] { cardGailuak, cardGehitu, cardErab });
            pnlBody.Controls.AddRange(new Control[] { lblGreeting, lblSub, pnlCards });

            // ── FOOTER ────────────────────────────────────────
            pnlFooter.BackColor = Color.White; pnlFooter.Dock = DockStyle.Bottom; pnlFooter.Height = 58;

            btnIrten = UIHelper.MakeBtn("⏻  Irten", UIHelper.Danger, new Size(110, 36), new Point(18, 11), btnIrten_Click);
            lblCopy.Text = "Izarraitz LHII · ERRONKA 3 · 2025-2026";
            lblCopy.Font = new Font("Segoe UI", 9); lblCopy.ForeColor = UIHelper.Muted;
            lblCopy.AutoSize = true; lblCopy.Location = new Point(600, 20);

            pnlFooter.Controls.AddRange(new Control[] { btnIrten, lblCopy });

            // ── FORM ──────────────────────────────────────────
            AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(880, 520);
            Controls.AddRange(new Control[] { pnlBody, pnlFooter, pnlHeader });
            MinimumSize = new Size(880, 520); StartPosition = FormStartPosition.CenterScreen;
            Text = "INBENTARIOA — Menu Nagusia"; Load += MenuNagusia_Load;
            ResumeLayout(false);
        }

        private static void BuildCard(Panel card, Point loc, string icon, string title, string desc, Color accent, EventHandler click)
        {
            card.BackColor = Color.White; card.Size = new Size(240, 200); card.Location = loc;

            var lblI = new Label { Text = icon, Font = new Font("Segoe UI Emoji", 30), AutoSize = false,
                Size = new Size(240, 54), Location = new Point(0, 14), TextAlign = ContentAlignment.MiddleCenter };

            var btn = new Button { Text = title, Font = new Font("Segoe UI", 12, FontStyle.Bold),
                BackColor = accent, ForeColor = Color.White, FlatStyle = FlatStyle.Flat,
                Size = new Size(200, 40), Location = new Point(20, 74), Cursor = Cursors.Hand };
            btn.FlatAppearance.BorderSize = 0; btn.Click += click;

            var lblD = new Label { Text = desc, Font = new Font("Segoe UI", 9), ForeColor = UIHelper.Muted,
                AutoSize = false, Size = new Size(200, 44), Location = new Point(20, 122),
                TextAlign = ContentAlignment.TopCenter };

            var sep = new Panel { BackColor = accent, Size = new Size(240, 3), Location = new Point(0, 0) };

            card.Controls.AddRange(new Control[] { sep, lblI, btn, lblD });
        }

        private Panel pnlHeader, pnlBody, pnlCards, pnlFooter;
        private Panel cardGailuak, cardGehitu, cardErab;
        private Label lblLogo, lblTitle, lblRola, lblGreeting, lblSub, lblCopy;
        private Button btnIrten;
    }
}
