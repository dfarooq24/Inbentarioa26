namespace ERRONKA3
{
    partial class ErabiltzaileakForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            dgv=new DataGridView(); pnlToolbar=new Panel(); pnlDgv=new Panel();
            btnKargatu=new Button(); btnGehitu=new Button(); btnEzabatu=new Button(); btnAtzera=new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();

            var header=UIHelper.MakeHeader("👥","  Erabiltzaileak","Sistemako erabiltzaileak eta baimenak",UIHelper.Purple);
            pnlDgv.Dock=DockStyle.Fill; pnlDgv.Padding=new Padding(14); pnlDgv.BackColor=UIHelper.BgLight;
            pnlDgv.Controls.Add(dgv);
            dgv.Dock=DockStyle.Fill; UIHelper.StyleDgv(dgv,UIHelper.Purple);

            pnlToolbar.BackColor=Color.White; pnlToolbar.Dock=DockStyle.Bottom; pnlToolbar.Height=60;
            btnKargatu=UIHelper.MakeBtn("↻  Kargatu", UIHelper.Accent,   new Size(130,38),new Point(14,11), btnKargatu_Click);
            btnGehitu =UIHelper.MakeBtn("➕  Gehitu",  UIHelper.Success,  new Size(130,38),new Point(154,11),btnGehitu_Click);
            btnEzabatu=UIHelper.MakeBtn("🗑  Ezabatu", UIHelper.Danger,   new Size(130,38),new Point(294,11),btnEzabatu_Click);
            btnAtzera =UIHelper.MakeBtn("← Atzera",    UIHelper.Muted,    new Size(120,38),new Point(800,11),btnAtzera_Click);
            pnlToolbar.Controls.AddRange(new Control[]{btnKargatu,btnGehitu,btnEzabatu,btnAtzera});

            AutoScaleMode=AutoScaleMode.Font; ClientSize=new Size(960,580);
            Controls.AddRange(new Control[]{pnlDgv,pnlToolbar,header});
            MinimumSize=new Size(800,480); StartPosition=FormStartPosition.CenterScreen;
            Text="INBENTARIOA — Erabiltzaileak"; Load+=ErabiltzaileakForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgv;
        private Panel pnlToolbar,pnlDgv;
        private Button btnKargatu,btnGehitu,btnEzabatu,btnAtzera;
    }
}
