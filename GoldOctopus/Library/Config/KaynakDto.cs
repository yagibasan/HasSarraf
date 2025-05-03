using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoldOctopus.Library.Config    
{
    public class KaynakDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("kod")]
        public string Kod { get; set; }

        [JsonProperty("adi")]
        public string Adi { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; } 

        [JsonProperty("apiUrls")]
        public List<string> ApiUrls { get; set; } 
    } 

}
