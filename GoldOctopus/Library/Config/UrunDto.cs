using System;
using Newtonsoft.Json;

namespace GoldOctopus.Library.Config    
{
    [Serializable]
    public class UrunDto
    {
        [JsonProperty("adi")]
        public string Adi { get; set; }

        [JsonProperty("birim")]
        public string Birim { get; set; }

        [JsonProperty("ortakUrun")]
        public bool OrtakUrun { get; set; }

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

        [JsonProperty("tabeladaGoster")]
        public bool TabeladaGoster { get; set; } = false;

        [JsonProperty("anaEkrandaGoster")]
        public bool AnaEkrandaGoster { get; set; } = false;

        [JsonProperty("urunKod")]
        public string UrunKod { get; set; }

        [JsonProperty("alisMarjYontemi")]
        public MarjDto AlisMarjYontemi { get; set; } = new MarjDto();

        [JsonProperty("satisMarjYontemi")]
        public MarjDto SatisMarjYontemi { get; set; } = new MarjDto();


    }

}
