using System;
using GoldOctopus.Business;
using GoldOctopus.Library.Config;
using Newtonsoft.Json;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Library
{
    public class DisTabelaDto
    {       
        
        [JsonProperty("sira")]
        public int Sira { get; set; } 
     
        [JsonProperty("urunAdi")]
        public string UrunAdi { get; set; }

        [JsonProperty("alis")]
        public decimal Alis { get; set; } = 0;

        [JsonProperty("satis")]
        public decimal Satis { get; set; } = 0;

        [JsonProperty("zaman")]
        public string Zaman
        {
            get { return string.Format("{0:dd.MM.yyyy HH:mm:ss}", DateTime.Now); }
        }

        [JsonProperty("satisText")] 
        public string SatisText
        {
            get { return string.Format("{0:N0}",Satis); } 
        }

        [JsonProperty("alisText")]
        public string AlisText
        {
            get { return string.Format("{0:N0}", Alis); }
        }


    }

}
