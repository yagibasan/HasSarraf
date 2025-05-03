using Newtonsoft.Json; 
namespace GoldOctopus.Library.Config
{
    public class EkranItemDto
    {
        [JsonProperty("sira")]
        public int Sira { get; set; }

        [JsonProperty("sekme")]
        public string Sekme { get; set; }

        [JsonProperty("kaynak")]
        public string Kaynak { get; set; } 

        [JsonProperty("urunKod")]
        public string UrunKodu { get; set; }
         
    } 

}
