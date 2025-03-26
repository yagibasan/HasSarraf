using System;
using Newtonsoft.Json;

namespace HasSarraf.BackOffice.Library
{
    [Serializable]
    public class UrunDto
    {
        [JsonProperty("adi")]
        public string Adi { get; set; }

        [JsonProperty("goster")]
        public bool Goster { get; set; }

        [JsonProperty("grup")]
        public int Grup { get; set; }

        [JsonProperty("grupAdi")]
        public string GrupAdi { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sira")]
        public int Sira { get; set; }

        [JsonProperty("favori")]
        public bool Favori { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("alisMarjYontemi")]
        public MarjDto AlisMarjYontemi { get; set; } = new MarjDto();

        [JsonProperty("satisMarjYontemi")]
        public MarjDto SatisMarjYontemi { get; set; } = new MarjDto();


    }

}
