using Newtonsoft.Json;
using static GoldOctopus.Library.Constants;
namespace GoldOctopus.Library.Config
{
    public class AyarDto
    {
        [JsonProperty("magazaAdi")]
        public string MagazaAdi { get; set; } = "Gold Octopus";
        
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

        [JsonProperty("gosterilecekUrunAdeti")]
        public int GosterilecekUrunAdeti { get; set; } = 10;

        [JsonProperty("orijinalDegeriGoster")]
        public bool OrijinalDegeriGoster { get; set; } = true;

        [JsonProperty("farkDegeriniGoster")]
        public bool FarkDegeriniGoster { get; set; } = true;

        [JsonProperty("otomatikVeriAl")]
        public bool OtomatikVeriAl { get; set; } = true;

        [JsonProperty("simulasyon")]
        public bool Simulasyon { get; set; } = false;
    } 

}
