using Newtonsoft.Json;

namespace GoldOctopus.Library.Sources   
{



    public class HaremDto
    {
        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Meta
    {
        [JsonProperty("time")]
        public long Time { get; set; }

        [JsonProperty("tarih")]
        public string Tarih { get; set; }
    }

    public class Dir
    {
        [JsonProperty("alis_dir")]
        public string AlisDir { get; set; }

        [JsonProperty("satis_dir")]
        public string SatisDir { get; set; }
    }

    public class CurrencyData
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("alis")]
        public string Alis { get; set; }

        [JsonProperty("satis")]
        public string Satis { get; set; }

        [JsonProperty("tarih")]
        public string Tarih { get; set; }

        [JsonProperty("dir")]
        public Dir Dir { get; set; }

        [JsonProperty("dusuk")]
        public double Dusuk { get; set; }

        [JsonProperty("yuksek")]
        public double Yuksek { get; set; }

        [JsonProperty("kapanis")]
        public double Kapanis { get; set; }
    }

    public class Data
    {
        [JsonProperty("DKKTRY")]
        public CurrencyData DKKTRY { get; set; }

        [JsonProperty("USDJPY")]
        public CurrencyData USDJPY { get; set; }

        [JsonProperty("XPDUSD")]
        public CurrencyData XPDUSD { get; set; }

        [JsonProperty("PALADYUM")]
        public CurrencyData PALADYUM { get; set; }

        [JsonProperty("USDTRY")]
        public CurrencyData USDTRY { get; set; }

        [JsonProperty("ALTIN")]
        public CurrencyData ALTIN { get; set; }

        [JsonProperty("USDPURE")]
        public CurrencyData USDPURE { get; set; }

        [JsonProperty("EURTRY")]
        public CurrencyData EURTRY { get; set; }

        [JsonProperty("ONS")]
        public CurrencyData ONS { get; set; }

        [JsonProperty("USDKG")]
        public CurrencyData USDKG { get; set; }

        [JsonProperty("EURKG")]
        public CurrencyData EURKG { get; set; }

        [JsonProperty("GBPTRY")]
        public CurrencyData GBPTRY { get; set; }

        [JsonProperty("AYAR22")]
        public CurrencyData AYAR22 { get; set; }

        [JsonProperty("CHFTRY")]
        public CurrencyData CHFTRY { get; set; }

        [JsonProperty("AUDTRY")]
        public CurrencyData AUDTRY { get; set; }

        [JsonProperty("KULCEALTIN")]
        public CurrencyData KULCEALTIN { get; set; }

        [JsonProperty("CADTRY")]
        public CurrencyData CADTRY { get; set; }

        [JsonProperty("XAUXAG")]
        public CurrencyData XAUXAG { get; set; }

        [JsonProperty("CEYREK_YENI")]
        public CurrencyData CEYREK_YENI { get; set; }

        [JsonProperty("SARTRY")]
        public CurrencyData SARTRY { get; set; }

        [JsonProperty("CEYREK_ESKI")]
        public CurrencyData CEYREK_ESKI { get; set; }

        [JsonProperty("YARIM_YENI")]
        public CurrencyData YARIM_YENI { get; set; }

        [JsonProperty("JPYTRY")]
        public CurrencyData JPYTRY { get; set; }

        [JsonProperty("YARIM_ESKI")]
        public CurrencyData YARIM_ESKI { get; set; }

        [JsonProperty("TEK_YENI")]
        public CurrencyData TEK_YENI { get; set; }

        [JsonProperty("SEKTRY")]
        public CurrencyData SEKTRY { get; set; }

        [JsonProperty("TEK_ESKI")]
        public CurrencyData TEK_ESKI { get; set; }

        [JsonProperty("ATA_YENI")]
        public CurrencyData ATA_YENI { get; set; }

        [JsonProperty("NOKTRY")]
        public CurrencyData NOKTRY { get; set; }

        [JsonProperty("ATA_ESKI")]
        public CurrencyData ATA_ESKI { get; set; }

        [JsonProperty("ATA5_YENI")]
        public CurrencyData ATA5_YENI { get; set; }

        [JsonProperty("ATA5_ESKI")]
        public CurrencyData ATA5_ESKI { get; set; }

        [JsonProperty("GREMESE_YENI")]
        public CurrencyData GREMESE_YENI { get; set; }

        [JsonProperty("GREMESE_ESKI")]
        public CurrencyData GREMESE_ESKI { get; set; }

        [JsonProperty("AYAR14")]
        public CurrencyData AYAR14 { get; set; }

        [JsonProperty("GUMUSTRY")]
        public CurrencyData GUMUSTRY { get; set; }

        [JsonProperty("XAGUSD")]
        public CurrencyData XAGUSD { get; set; }

        [JsonProperty("XPTUSD")]
        public CurrencyData XPTUSD { get; set; }

        [JsonProperty("PLATIN")]
        public CurrencyData PLATIN { get; set; }

        [JsonProperty("GUMUSUSD")]
        public CurrencyData GUMUSUSD { get; set; }

        [JsonProperty("USDCHF")]
        public CurrencyData USDCHF { get; set; }

        [JsonProperty("EURUSD")]
        public CurrencyData EURUSD { get; set; }

        [JsonProperty("GBPUSD")]
        public CurrencyData GBPUSD { get; set; }

        [JsonProperty("USDCAD")]
        public CurrencyData USDCAD { get; set; }

        [JsonProperty("AUDUSD")]
        public CurrencyData AUDUSD { get; set; }

        [JsonProperty("USDSAR")]
        public CurrencyData USDSAR { get; set; }

        [JsonProperty("AEDUSD")]
        public CurrencyData AEDUSD { get; set; }

        [JsonProperty("USDILS")]
        public CurrencyData USDILS { get; set; }

        [JsonProperty("AEDTRY")]
        public CurrencyData AEDTRY { get; set; }

        [JsonProperty("ILSTRY")]
        public CurrencyData ILSTRY { get; set; }

        [JsonProperty("OMRUSD")]
        public CurrencyData OMRUSD { get; set; }

        [JsonProperty("OMRTRY")]
        public CurrencyData OMRTRY { get; set; }

        [JsonProperty("KWDUSD")]
        public CurrencyData KWDUSD { get; set; }

        [JsonProperty("KWDTRY")]
        public CurrencyData KWDTRY { get; set; }

        [JsonProperty("USDQAR")]
        public CurrencyData USDQAR { get; set; }

        [JsonProperty("QARTRY")]
        public CurrencyData QARTRY { get; set; }

        [JsonProperty("USDMAD")]
        public CurrencyData USDMAD { get; set; }

        [JsonProperty("MADTRY")]
        public CurrencyData MADTRY { get; set; }
    }





}
