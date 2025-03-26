using Newtonsoft.Json;

namespace HasSarraf.BackOffice.Library
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

        [JsonProperty("api1Url")]
        public string Api1Url { get; set; }

        [JsonProperty("api2Url")]
        public string Api2Url { get; set; }
    } 

}
