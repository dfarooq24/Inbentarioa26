namespace ERRONKA3
{
    partial class GailuakForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            dgv = new DataGridView(); pnlToolbar = new Panel();
            btnKargatu = new Button(); btnEditatu = new Button();
            btnEzabatu = new Button(); btnAtzera = new Button();
            pnlDgv = new Panel();

            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();

            var header = UIHelper.MakeHeader("🖥", "Gailuen Inbentarioa", "Ikastetxeko gailu digitalen zerrenda", UIHelper.Accent);

            // DGV wrapper
            pnlDgv.Dock = DockStyle.Fill; pnlDgv.Padding = new Padding(14);
            pnlDgv.BackColor = UIHelper.BgLight; pnlDgv.Controls.Add(dgv);

            // DataGridView
            dgv.Dock = DockStyle.Fill;
            UIHelper.StyleDgv(dgv, UIHelper.Accent);

            // Toolbar
            pnlToolbar.BackColor = Color.White; pnlToolbar.Dock = DockStyle.Bottom; pnlToolbar.Height = 60;
            btnKargatu = UIHelper.MakeBtn("↻  Kargatu",  UIHelper.Accent,   new Size(130, 38), new Point(14, 11), btnKargatu_Click);
            btnEditatu = UIHelper.MakeBtn("✏  Editatu",  UIHelper.Success,  new Size(130, 38), new Point(154, 11), btnEditatu_Click);
            btnEzabatu = UIHelper.MakeBtn("🗑  Ezabatu", UIHelper.Danger,   new Size(130, 38), new Point(294, 11), btnEzabatu_Click);
            btnAtzera  = UIHelper.MakeBtn("← Atzera",    UIHelper.Muted,    new Size(120, 38), new Point(780, 11), btnAtzera_Click);
            pnlToolbar.Controls.AddRange(new Control[] { btnKargatu, btnEditatu, btnEzabatu, btnAtzera });

            AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(1020, 620);
            Controls.AddRange(new Control[] { pnlDgv, pnlToolbar, header });
            MinimumSize = new Size(900, 500); StartPosition = FormStartPosition.CenterScreen;
            Text = "INBENTARIOA — Gailuak"; Load += GailuakForm_Load;

            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgv;
        private Panel pnlToolbar, pnlDgv;
        private Button btnKargatu, btnEditatu, btnEzabatu, btnAtzera;
    }
}
