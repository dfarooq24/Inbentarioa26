namespace ERRONKA3.Modeloak
{
    /// <summary>
    /// Inprimagailua gailu mota irudikatzen duen klasea.
    /// <see cref="Gailua"/> klase abstraktutik heredatzen du eta
    /// inprimagailuen propietate espezifikoa gehitzen du: Kolorea.
    /// </summary>
    public class Inprimagailua : Gailua
    {
        /// <summary>
        /// Inprimagailuak koloretan inprima dezakeen adierazten du.
        /// Egia bada koloretakoa da; gezurra bada zuri-beltzekoa.
        /// </summary>
        public bool Kolorea { get; set; }

        /// <summary>
        /// Inprimagailua berri bat sortzen du eta Mota automatikoki "inprimagailua" ezartzen du.
        /// </summary>
        public Inprimagailua() { Mota = "inprimagailua"; }
    }
}
