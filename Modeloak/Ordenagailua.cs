namespace ERRONKA3.Modeloak
{
    /// <summary>
    /// Ordenagailua gailu mota irudikatzen duen klasea.
    /// <see cref="Gailua"/> klase abstraktutik heredatzen du eta
    /// ordenagailuen propietate espezifikoak gehitzen ditu: RAM, ROM eta CPU.
    /// </summary>
    public class Ordenagailua : Gailua
    {
        /// <summary>RAM memoria kopurua (adib: "16 GB").</summary>
        public string RAM { get; set; } = "";

        /// <summary>Biltegi kapazitatea (adib: "512 GB SSD").</summary>
        public string ROM { get; set; } = "";

        /// <summary>Prozesadore mota eta abiadura (adib: "Intel i5-1135G7").</summary>
        public string CPU { get; set; } = "";

        /// <summary>
        /// Ordenagailua berri bat sortzen du eta Mota automatikoki "ordenagailua" ezartzen du.
        /// </summary>
        public Ordenagailua() { Mota = "ordenagailua"; }
    }
}
