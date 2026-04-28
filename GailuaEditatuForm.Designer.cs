namespace ERRONKA3
{
    partial class GailuaEditatuForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            txtMarka=new TextBox(); txtModelo=new TextBox(); dtpData=new DateTimePicker();
            cmbMota=new ComboBox(); cmbMintegia=new ComboBox(); cmbEgoera=new ComboBox();
            txtRAM=new TextBox(); txtROM=new TextBox(); txtCPU=new TextBox();
            chkKolorea=new CheckBox(); pnlOrd=new Panel(); pnlPrint=new Panel();
            btnGorde=new Button(); btnAtzera=new Button(); pnlBody=new Panel();
            SuspendLayout();

            var header=UIHelper.MakeHeader("✏","  Gailua Editatu","Gailu honen datuak eguneratu",UIHelper.Accent);
            pnlBody.BackColor=Color.White; pnlBody.Dock=DockStyle.Fill; pnlBody.AutoScroll=true;

            var pnlLeft  = new Panel { BackColor=Color.White,       Size=new Size(400,500), Location=new Point(0,0) };
            var pnlRight = new Panel { BackColor=UIHelper.BgLight,  Size=new Size(360,500), Location=new Point(410,0) };

            var lblL=new Label{Text="Datu Orokorrak",Font=new Font("Segoe UI",13,FontStyle.Bold),
                ForeColor=UIHelper.Primary,AutoSize=true,Location=new Point(24,18)};
            int y=56;
            UIHelper.AddFormRow(pnlLeft,"Marka",txtMarka,ref y);
            UIHelper.AddFormRow(pnlLeft,"Modelo",txtModelo,ref y);
            UIHelper.AddFormDtp(pnlLeft,"Erosketa Data",dtpData,ref y);
            cmbMota=UIHelper.MakeCmb(Point.Empty,220,new[]{"ordenagailua","inprimagailua"});
            UIHelper.AddFormCmb(pnlLeft,"Mota",cmbMota,ref y);
            cmbMintegia=UIHelper.MakeCmb(Point.Empty,120,new[]{"1","2","3"});
            UIHelper.AddFormCmb(pnlLeft,"Mintegia",cmbMintegia,ref y);
            cmbEgoera=UIHelper.MakeCmb(Point.Empty,160,new[]{"aktibo","apurtuta","konpontzen","ezabatuta"});
            UIHelper.AddFormCmb(pnlLeft,"Egoera",cmbEgoera,ref y);
            cmbMota.SelectedIndexChanged+=cmbMota_SelectedIndexChanged;
            pnlLeft.Controls.Add(lblL);

            var lblR=new Label{Text="Ezaugarri Espezifikoak",Font=new Font("Segoe UI",13,FontStyle.Bold),
                ForeColor=UIHelper.Primary,AutoSize=true,Location=new Point(24,18)};
            pnlOrd.BackColor=Color.White; pnlOrd.Location=new Point(0,56); pnlOrd.Size=new Size(360,240); pnlOrd.Visible=false;
            int yo=0;
            UIHelper.AddFormRow(pnlOrd,"RAM (GB)",txtRAM,ref yo);
            UIHelper.AddFormRow(pnlOrd,"ROM / Disko (GB)",txtROM,ref yo);
            UIHelper.AddFormRow(pnlOrd,"CPU",txtCPU,ref yo);

            pnlPrint.BackColor=Color.White; pnlPrint.Location=new Point(0,56); pnlPrint.Size=new Size(360,80); pnlPrint.Visible=false;
            chkKolorea.Text="Koloretako inprimagailua"; chkKolorea.Font=new Font("Segoe UI",11);
            chkKolorea.AutoSize=true; chkKolorea.Location=new Point(24,16);
            pnlPrint.Controls.Add(chkKolorea);

            pnlRight.Controls.AddRange(new Control[]{lblR,pnlOrd,pnlPrint});
            pnlBody.Controls.AddRange(new Control[]{pnlLeft,pnlRight});

            var pnlFoot=new Panel{BackColor=Color.FromArgb(248,250,252),Dock=DockStyle.Bottom,Height=58};
            btnGorde=UIHelper.MakeBtn("✔  Gorde",UIHelper.Accent,new Size(140,38),new Point(460,10),btnGorde_Click);
            btnAtzera=UIHelper.MakeBtn("← Atzera",UIHelper.Muted,new Size(120,38),new Point(610,10),btnAtzera_Click);
            pnlFoot.Controls.AddRange(new Control[]{btnGorde,btnAtzera});

            AutoScaleMode=AutoScaleMode.Font; ClientSize=new Size(780,560);
            Controls.AddRange(new Control[]{pnlBody,pnlFoot,header});
            FormBorderStyle=FormBorderStyle.FixedDialog; MaximizeBox=false;
            StartPosition=FormStartPosition.CenterParent; Text="Gailua editatu";
            Load+=GailuaEditatuForm_Load;
            ResumeLayout(false);
        }

        private Panel pnlBody,pnlOrd,pnlPrint;
        private TextBox txtMarka,txtModelo,txtRAM,txtROM,txtCPU;
        private DateTimePicker dtpData;
        private ComboBox cmbMota,cmbMintegia,cmbEgoera;
        private CheckBox chkKolorea;
        private Button btnGorde,btnAtzera;
    }
}
