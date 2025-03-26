using Newtonsoft.Json;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Library
{
    public class AyarDto
    {


        [JsonProperty("kaynak")]
        public string Kaynak { get; set; } = Kaynaklar.Saglamoglu;

        [JsonProperty("tabelaSablonu")]
        public string TabelaSablonu { get; set; } = TabelaSablonlari.Sablon1;

        [JsonProperty("guncellemePeriyodu")]
        public int GuncellemePeriyodu { get; set; } = 1;

        [JsonProperty("korumaModu")]
        public bool KorumaModu { get; set; } = false;

        [JsonProperty("korumaOrani")]
        public decimal KorumaOrani { get; set; } = 5;

        [JsonProperty("tabeladaGozukecekUrunSayisi")]
        public int TabeladaGozukecekUrunSayisi { get; set; } = 10;

        [JsonProperty("sarrafiyeOndalikAdeti")]
        public int SarrafiyeOndalikAdeti { get; set; } = 2;

        [JsonProperty("sarrafiyeOndalikGoster")]
        public bool SarrafiyeOndalikGoster { get; set; } = false;

        [JsonProperty("dovizOndalikAdeti")]
        public int DovizOndalikAdeti { get; set; } = 2;

        [JsonProperty("dovizOndalikGoster")]
        public bool DovizOndalikGoster { get; set; }=true;

        [JsonProperty("milyemGoster")]
        public bool MilyemGoster { get; set; } = true;
    } 

}
