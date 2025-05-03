using System.Drawing;
using Newtonsoft.Json; 
namespace GoldOctopus.Library.Config
{
    public class KayanYaziDto
    {
        [JsonProperty("goster")]
        public bool Goster { get; set; }

        [JsonProperty("icerik")]
        public string Icerik { get; set; }

        [JsonProperty("arkaPlanRengi")]
        public Color ArkaPlanRengi { get; set; }

        [JsonProperty("yaziRengi")]
        public Color YaziRengi { get; set; } 

        [JsonProperty("yaziBoyutu")]
        public int YaziBoyutu { get; set; }

        [JsonProperty("yaziHizi")]
        public int YaziHizi { get; set; }

        [JsonProperty("yaziFontu")]
        public Font YaziFontu { get; set; }
    } 

}
