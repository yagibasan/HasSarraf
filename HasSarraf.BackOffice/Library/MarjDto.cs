using System;
using Newtonsoft.Json;

namespace HasSarraf.BackOffice.Library
{
    [Serializable]
    public class MarjDto
    {         

        [JsonProperty("tur")]
        public string Tur { get; set; } = Constants.MarjYontemi.Manuel;

        [JsonProperty("oransalDeger")]
        public decimal OransalDeger { get; set; } = 0;

        [JsonProperty("miktarDeger")]
        public decimal MiktarDeger { get; set; } = 0;
    }

}
