namespace ERRONKA3.Modeloak
{
    public class Erabiltzailea
    {
        public int IdErab { get; set; }
        public string Izena { get; set; } = "";
        public string Pasahitza { get; set; } = "";
        public string Rola { get; set; } = "";
        public int IdMintegia { get; set; }
    }
}
