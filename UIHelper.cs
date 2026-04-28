namespace ERRONKA3
{
    /// <summary>
    /// Interfaze grafikoaren laguntzaile estatikoa.
    /// Kolore-sistema, botoi-fabrika eta kontrol-laguntzaileak biltzen ditu.
    /// Formulario guztiek klase hau erabiltzen dute itxura koherentea izateko.
    /// </summary>
    internal static class UIHelper
    {
        /// <summary>Kolore nagusia — urdin iluna.</summary>
        internal static readonly Color Primary  = Color.FromArgb(30, 58, 95);
        /// <summary>Kolore bigarrena — urdin argia.</summary>
        internal static readonly Color Accent   = Color.FromArgb(37, 99, 235);
        /// <summary>Arrakastaren kolorea — berdea.</summary>
        internal static readonly Color Success  = Color.FromArgb(5, 150, 105);
        /// <summary>Arrisku kolorea — gorria.</summary>
        internal static readonly Color Danger   = Color.FromArgb(220, 38, 38);
        /// <summary>Morea — erabiltzaileekin erlazionatutako elementuak.</summary>
        internal static readonly Color Purple   = Color.FromArgb(124, 58, 237);
        /// <summary>Gris itzalia — bigarren mailako testuak.</summary>
        internal static readonly Color Muted    = Color.FromArgb(100, 116, 139);
        /// <summary>Argi grisaxka — panel eta atzeko planoen kolorea.</summary>
        internal static readonly Color BgLight  = Color.FromArgb(241, 245, 249);
        /// <summary>Testu iluna — irakurketa errazeko kolore nagusia.</summary>
        internal static readonly Color TextDark = Color.FromArgb(15, 23, 42);

        /// <summary>
        /// Estilo homogeneoa duen botoi bat sortzen du.
        /// </summary>
        internal static Button MakeBtn(string text, Color bg, Size size, Point loc, EventHandler click)
        {
            var b = new Button
            {
                Text = text, BackColor = bg, ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat, Size = size, Location = loc,
                Font = new Font("Segoe UI", 10, FontStyle.Bold), Cursor = Cursors.Hand
            };
            b.FlatAppearance.BorderSize = 0;
            b.Click += click;
            return b;
        }

        /// <summary>
        /// Estilo homogeneoa duen testu-koadro bat sortzen du.
        /// </summary>
        internal static TextBox MakeTxt(Point loc, int width = 320, bool password = false) =>
            new TextBox
            {
                Location = loc, Size = new Size(width, 30),
                Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White, UseSystemPasswordChar = password
            };

        /// <summary>
        /// Estilo homogeneoa duen goitibeherako zerrenda bat sortzen du.
        /// </summary>
        internal static ComboBox MakeCmb(Point loc, int width, string[] items, bool dropOnly = true)
        {
            var c = new ComboBox
            {
                Location = loc, Size = new Size(width, 30),
                Font = new Font("Segoe UI", 10),
                DropDownStyle = dropOnly ? ComboBoxStyle.DropDownList : ComboBoxStyle.DropDown
            };
            c.Items.AddRange(items);
            return c;
        }

        /// <summary>
        /// Formulario guztietarako goiburu panel bat sortzen du.
        /// Ikono bat eta titulu bat ditu — azpititulurik gabe.
        /// Bi espazio gehitzen dira ezkerrean letra moztu ez dadin.
        /// </summary>
        /// <param name="icon">Goiburuaren ikono Unicode karakterea.</param>
        /// <param name="title">Goiburuaren titulu nagusia.</param>
        /// <param name="sub">Ez da erabiltzen — bateragarritasunerako mantentzen da.</param>
        /// <param name="bg">Goiburuaren atzeko planoko kolorea.</param>
        /// <returns>Estilizatutako <see cref="Panel"/> kontrola.</returns>
        internal static Panel MakeHeader(string icon, string title, string sub, Color bg)
        {
            var p = new Panel { BackColor = bg, Dock = DockStyle.Top, Height = 64 };

            var lIcon = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(20, 16)
            };

            var lTitle = new Label
            {
                Text = "  " + title,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(58, 18)
            };

            p.Controls.AddRange(new Control[] { lIcon, lTitle });
            return p;
        }

        /// <summary>
        /// DataGridView kontrolari itxura profesionala ematen dio.
        /// </summary>
        internal static void StyleDgv(DataGridView d, Color headerColor)
        {
            d.BackgroundColor = Color.White;
            d.BorderStyle = BorderStyle.None;
            d.RowHeadersVisible = false;
            d.AllowUserToAddRows = false;
            d.ReadOnly = true;
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.MultiSelect = false;
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            d.Font = new Font("Segoe UI", 10);
            d.ColumnHeadersDefaultCellStyle.BackColor = headerColor;
            d.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            d.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            d.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
            d.ColumnHeadersHeight = 40;
            d.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            d.EnableHeadersVisualStyles = false;
            d.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            d.DefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 58, 95);
            d.DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
            d.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            d.GridColor = Color.FromArgb(226, 232, 240);
            d.RowTemplate.Height = 36;
            d.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        /// <summary>Panel batean testu-koadro baten errenkada bat gehitzen du.</summary>
        internal static void AddFormRow(Panel p, string lbl, TextBox txt, ref int y)
        {
            p.Controls.Add(new Label { Text = lbl, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Muted, AutoSize = true, Location = new Point(24, y) });
            txt.Location = new Point(24, y + 20); txt.Size = new Size(320, 30);
            txt.Font = new Font("Segoe UI", 10); txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.FromArgb(248, 250, 252);
            p.Controls.Add(txt); y += 66;
        }

        /// <summary>Panel batean data-hautatzaile baten errenkada bat gehitzen du.</summary>
        internal static void AddFormDtp(Panel p, string lbl, DateTimePicker dtp, ref int y)
        {
            p.Controls.Add(new Label { Text = lbl, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Muted, AutoSize = true, Location = new Point(24, y) });
            dtp.Location = new Point(24, y + 20); dtp.Size = new Size(220, 30); dtp.Font = new Font("Segoe UI", 10);
            p.Controls.Add(dtp); y += 66;
        }

        /// <summary>Panel batean goitibeherako zerrenda baten errenkada bat gehitzen du.</summary>
        internal static void AddFormCmb(Panel p, string lbl, ComboBox cmb, ref int y)
        {
            p.Controls.Add(new Label { Text = lbl, Font = new Font("Segoe UI", 9, FontStyle.Bold), ForeColor = Muted, AutoSize = true, Location = new Point(24, y) });
            cmb.Location = new Point(24, y + 20); cmb.Font = new Font("Segoe UI", 10);
            p.Controls.Add(cmb); y += 66;
        }
    }
}
