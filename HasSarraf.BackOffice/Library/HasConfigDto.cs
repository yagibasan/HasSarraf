using Newtonsoft.Json;
using System.Collections.Generic;

namespace HasSarraf.BackOffice.Library
{
    public class HasConfigDto
    {
        [JsonProperty("ayar")]
        public AyarDto Ayarlar { get; set; }
        
        [JsonProperty("kayanYazi")]
        public KayanYaziDto KayanYazi { get; set; }

        [JsonProperty("kaynak")]
        public List<KaynakDto> Kaynaklar { get; set; }

        [JsonProperty("urun")]
        public List<UrunDto> Urunler { get; set; } 
    }
}
