using Newtonsoft.Json;

namespace GoldOctopus.Library.Config    
{
    public class KaynakUrunDto
    {       
        [JsonProperty("urunKodu")]
        public string UrunKodu { get; set; }

        [JsonProperty("urunKoduSaglamoglu")]
        public string UrunKoduSaglamoglu { get; set; }

        [JsonProperty("urunKoduHarem")]
        public string UrunKoduHarem{ get; set; } 
    } 

}
