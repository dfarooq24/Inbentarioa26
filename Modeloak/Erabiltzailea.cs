namespace ERRONKA3.Modeloak
{
    /// <summary>
    /// Sistemako erabiltzaile bat irudikatzen duen modelo klasea.
    /// Datu-baseko "erabiltzailea" taularen isla da.
    /// Hiru rola daude: admin, mintegi_burua eta irakaslea.
    /// </summary>
    public class Erabiltzailea
    {
        /// <summary>Datu-baseko gako nagusia. Auto-inkrementala.</summary>
        public int IdErab { get; set; }

        /// <summary>Erabiltzailearen saioa hasteko izena.</summary>
        public string Izena { get; set; } = "";

        /// <summary>Erabiltzailearen pasahitza.</summary>
        public string Pasahitza { get; set; } = "";

        /// <summary>Erabiltzailearen rola: admin, ikt_arduraduna, mintegi_burua edo irakaslea.</summary>
        public string Rola { get; set; } = "";

        /// <summary>Erabiltzailea dagoen mintegiaren ID zenbakia.</summary>
        public int IdMintegia { get; set; }
    }
}
