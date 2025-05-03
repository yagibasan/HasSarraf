using System;
using GoldOctopus.Business;
using GoldOctopus.Library.Config;
using Newtonsoft.Json;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Library
{
    public class TabelaFiyatDto
    {
        
        
        [JsonProperty("sira")]
        public int Sira { get; set; }

        [JsonProperty("kaynak")]
        public string Kaynak { get; set; }

        [JsonProperty("urun")]
        public UrunDto Urun { get; set; }

        [JsonProperty("alisOrijinal")]
        public decimal AlisOrijinal { get; set; } = 0;

        [JsonProperty("satisOrijinal")]
        public decimal SatisOrijinal { get; set; } = 0;

        [JsonProperty("alisOrijinalText")]
        public string AlisOrijinalText { get; set; } = "###";   

        [JsonProperty("satisOrijinalText")]
        public string SatisOrijinalText { get; set; } = "###";

        [JsonProperty("alisTabela")]
        public decimal AlisTabela { get; set; } = 0;

        [JsonProperty("satisTabela")]
        public decimal SatisTabela { get; set; } = 0;

        [JsonProperty("alisTabelaText")]
        public string AlisTabelaText { get; set; } = "###";

        [JsonProperty("satisTabelaText")]
        public string SatisTabelaText { get; set; } = "###";

        [JsonProperty("farkSatis")]
        public decimal FarkSatis { get; set; } = 0;

        [JsonProperty("farkAlis")]
        public decimal FarkAlis { get; set; } = 0;
        
        [JsonProperty("farkSatisText")]
        public string FarkSatisText { get; set; } = "###";

        [JsonProperty("farkAlisText")]
        public string FarkAlisText { get; set; } = "###";

        [JsonProperty("zaman")]
        public DateTime Zaman { get; set; }

        [JsonProperty("durum")]
        public string Durum { get; set; } = TabelaFiyatHesaplamDurum.Hesaplanmadi;

        [JsonProperty("alisMilyem")]
        public decimal? AlisMilyem { get; set; } 

        [JsonProperty("satisMilyem")]
        public decimal? SatisMilyem { get; set; }

        [JsonProperty("alisTabelaEski")]
        public decimal AlisTabelaEski { get; set; } = 0;

        [JsonProperty("satisTabelaEski")]
        public decimal SatisTabelaEski { get; set; } = 0;

        [JsonProperty("alisDegisimYonu")]
        public int AlisDegisimYonu{ get; set; } = 0;

        [JsonProperty("satisDegisimYonu")]
        public int SatisDegisimYonu { get; set; } = 0;
         

    }

}
