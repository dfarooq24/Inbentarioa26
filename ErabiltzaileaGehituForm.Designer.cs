namespace ERRONKA3
{
    partial class ErabiltzaileaGehituForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            txtIzena=new TextBox(); txtPasahitza=new TextBox();
            cmbRola=new ComboBox(); cmbMintegia=new ComboBox();
            btnGorde=new Button(); btnAtzera=new Button(); pnlBody=new Panel();
            SuspendLayout();

            var header=UIHelper.MakeHeader("👤","  Erabiltzaile Berria","Sistemako erabiltzaile berri bat sortu",UIHelper.Purple);
            pnlBody.BackColor=Color.White; pnlBody.Dock=DockStyle.Fill; pnlBody.Padding=new Padding(40,20,40,20);

            int y=20;
            UIHelper.AddFormRow(pnlBody,"Izena *",txtIzena,ref y);
            UIHelper.AddFormRow(pnlBody,"Pasahitza *",txtPasahitza,ref y);
            txtPasahitza.UseSystemPasswordChar=true;
            cmbRola=UIHelper.MakeCmb(Point.Empty,220,new[]{"admin","ikt_arduraduna","mintegi_burua","irakaslea"});
            UIHelper.AddFormCmb(pnlBody,"Rola *",cmbRola,ref y);
            cmbMintegia=UIHelper.MakeCmb(Point.Empty,120,new[]{"1","2","3"});
            UIHelper.AddFormCmb(pnlBody,"Mintegia",cmbMintegia,ref y);

            var pnlFoot=new Panel{BackColor=Color.FromArgb(248,250,252),Dock=DockStyle.Bottom,Height=58};
            btnGorde=UIHelper.MakeBtn("✔  Gorde",UIHelper.Purple,new Size(140,38),new Point(170,10),btnGorde_Click);
            btnAtzera=UIHelper.MakeBtn("← Atzera",UIHelper.Muted,new Size(120,38),new Point(320,10),btnAtzera_Click);
            pnlFoot.Controls.AddRange(new Control[]{btnGorde,btnAtzera});

            AutoScaleMode=AutoScaleMode.Font; ClientSize=new Size(500,460);
            Controls.AddRange(new Control[]{pnlBody,pnlFoot,header});
            FormBorderStyle=FormBorderStyle.FixedDialog; MaximizeBox=false;
            StartPosition=FormStartPosition.CenterParent; Text="Erabiltzaile berria";
            ResumeLayout(false);
        }

        private Panel pnlBody;
        private TextBox txtIzena,txtPasahitza;
        private ComboBox cmbRola,cmbMintegia;
        private Button btnGorde,btnAtzera;
    }
}
