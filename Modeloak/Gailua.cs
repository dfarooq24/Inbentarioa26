namespace ERRONKA3.Modeloak
{
    /// <summary>
    /// Gailu digitalen oinarrizko klase abstraktua.
    /// Ezin da zuzenean instantziatu — <see cref="Ordenagailua"/> edo
    /// <see cref="Inprimagailua"/> erabili behar da.
    /// Propietate komunak behin bakarrik definitzen ditu herentziaren bidez.
    /// </summary>
    public abstract class Gailua
    {
        /// <summary>Datu-baseko gako nagusia. Auto-inkrementala.</summary>
        public int IdGailu { get; set; }

        /// <summary>Gailu fabrikatzailearen izena (adib: Dell, HP, Canon).</summary>
        public string Marka { get; set; } = "";

        /// <summary>Gailu motaren modelo zehatza (adib: Latitude 5520).</summary>
        public string Modelo { get; set; } = "";

        /// <summary>Gailua ikastetxeak erosi zueneko data.</summary>
        public DateTime ErosketaData { get; set; }

        /// <summary>Gailu egoera: aktibo, apurtuta, konpontzen edo ezabatuta.</summary>
        public string Egoera { get; set; } = "";

        /// <summary>Gailu mota: "ordenagailua" edo "inprimagailua". Azpiklaseak automatikoki ezartzen du.</summary>
        public string Mota { get; set; } = "";

        /// <summary>Gailua dagoen mintegiaren ID zenbakia.</summary>
        public int IdMintegia { get; set; }
    }
}
