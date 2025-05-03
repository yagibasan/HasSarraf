using System.Drawing;
using Newtonsoft.Json;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Library
{
    public class MizanpajDto
    {
        [JsonProperty("serbestAlanSira")]
        public int SerbestAlanSira { get; set; } = 0;

        [JsonProperty("kayanYaziSira")]
        public int KayanYaziSira { get; set; } = 1;

        [JsonProperty("fiyatListesiSira")]
        public int FiyatListesiSira { get; set; } = 2;

        [JsonProperty("serbestAlan")]
        public MizanpajDetailDto SerbestAlan { get; set; } = new MizanpajDetailDto() { Yukseklik = 80,Icerik="SERBEST ALAN METNİ" };

        [JsonProperty("kayanYazi")]
        public MizanpajDetailDto KayanYazi { get; set; } = new MizanpajDetailDto() { Yukseklik=30,Icerik="KAYAN YAZI METNİ"};

        [JsonProperty("fiyatListesi")]
        public MizanpajDetailDto FiyatListesi { get; set; } = new MizanpajDetailDto() { Aktif=true,Yukseklik=-1};
    }

    public class MizanpajDetailDto
    {

        [JsonProperty("kayitAdi")]
        public string KayitAdi { get; set; }

        [JsonProperty("aktif")]
        public bool Aktif { get; set; } = false;

        [JsonProperty("font")]
        public Font Font { get; set; } = new Font("Consolas", 24, FontStyle.Bold);

        [JsonProperty("yukseklik")]
        public int Yukseklik { get; set; } = 30;

        [JsonProperty("yaziRengi")]
        public Color YaziRengi { get; set; } = Color.White;

        [JsonProperty("arkaPlanRengi")]
        public Color ArkaPlanRengi { get; set; }=Color.Black;   

        [JsonProperty("icerikTuru")]
        public string IcerikTuru { get; set; } = MizanpajIcerikTuru.Metin;

        [JsonProperty("icerik")]
        public string Icerik { get; set; }= "METİN YAZISI"; 

        [JsonProperty("kayanYaziHizi")]
        public int KayanYaziHizi { get; set; } = 10;

        [JsonProperty("solaYasli")]
        public bool SolaYasli { get; set; } = false;
    }


}
