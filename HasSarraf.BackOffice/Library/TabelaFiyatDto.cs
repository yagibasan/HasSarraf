using Newtonsoft.Json;
using System;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Library
{
    public class TabelaFiyatDto
    {
        [JsonProperty("sira")]
        public int Sira { get; set; }

        [JsonProperty("urun")]
        public UrunDto Urun { get; set; }

        [JsonProperty("alisOrijinal")]
        public decimal AlisOrijinal { get; set; } = 0;

        [JsonProperty("satisOrijinal")]
        public decimal SatisOrijinal { get; set; } = 0;

        [JsonProperty("alis")]
        public decimal AlisTabela { get; set; } = 0;

        [JsonProperty("satis")]
        public decimal SatisTabela { get; set; } = 0;

        [JsonProperty("farkSatis")]
        public decimal FarkSatis { get; set; } = 0;

        [JsonProperty("farkAlis")]
        public decimal FarkAlis { get; set; } = 0;

        [JsonProperty("zaman")]
        public DateTime Zaman { get; set; }

        [JsonProperty("durum")]
        public string Durum { get; set; } = TabelaFiyatHesaplamDurum.Hesaplanmadi;

        [JsonProperty("alisMilyem")]
        public decimal? AlisMilyem { get; set; } 

        [JsonProperty("satisMilyem")]
        public decimal? SatisMilyem { get; set; }

        public void Hesapla()
        {
            if (Urun != null)
            {
                Hesapla(Urun);
            }
        }

        public void Hesapla(UrunDto customUrun)
        {
            if (customUrun != null)
            {
                if(customUrun.AlisMarjYontemi.Tur != MarjYontemi.Manuel)
                {
                    AlisTabela = FiyatiHesapla(AlisOrijinal, customUrun.AlisMarjYontemi, IslemTuru.Alis);
                    FarkAlis = AlisTabela - AlisOrijinal;
                }

                if (customUrun.SatisMarjYontemi.Tur != MarjYontemi.Manuel)
                {
                    SatisTabela = FiyatiHesapla(SatisOrijinal, customUrun.SatisMarjYontemi, IslemTuru.Satis);
                    FarkSatis = SatisTabela - SatisOrijinal;
                }
            }
        }

        private decimal FiyatiHesapla(decimal deger, MarjDto marj, string islemTuru)
        {
            if (marj == null)
                return deger;

            decimal karMarji = 0;
            if (marj.Tur == MarjYontemi.Oransal)
                karMarji = deger * marj.OransalDeger / 100;
            else if (marj.Tur == MarjYontemi.Miktar)
                karMarji = marj.MiktarDeger;
            else if (marj.Tur == MarjYontemi.Manuel)
                karMarji = 0;
            else
                karMarji = 0;

            if (IslemTuru.Alis == islemTuru)
                return deger - karMarji;
            else if (IslemTuru.Satis == islemTuru)
                return deger + karMarji;
            else
                return deger;


        }

    }

}
