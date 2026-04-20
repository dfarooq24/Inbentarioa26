namespace ERRONKA3.Modeloak
{
    public abstract class Gailua
    {
        public int IdGailu { get; set; }
        public string Marka { get; set; } = "";
        public string Modelo { get; set; } = "";
        public DateTime ErosketaData { get; set; }
        public string Egoera { get; set; } = "";
        public string Mota { get; set; } = "";
        public int IdMintegia { get; set; }
    }
}
