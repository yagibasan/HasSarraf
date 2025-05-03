using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using GoldOctopus.Business;
using GoldOctopus.Library;
using GoldOctopus.Library.Config;
using GoldOctopus.Library.Sources;
using Newtonsoft.Json;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Adaptors
{
    public class HaremAdaptor
    {
        static IFormatProvider culture = new CultureInfo("en-EN");
        public static List<TabelaFiyatDto> Parse(List<HaremDto> dataList)
        {
            List<TabelaFiyatDto> tabelaFiyatList = new List<TabelaFiyatDto>();
            DateTime dateTime = DateTime.Now;


            string content = JsonConvert.SerializeObject(dataList[0].Data, JsonSettings);
            var data = JsonConvert.DeserializeObject<Dictionary<string, CurrencyData>>(content);

            if(dataList[0].Meta.Tarih!=null)
            dateTime = DateTime.ParseExact(dataList[0].Meta.Tarih,"dd-MM-yyyy HH:mm:ss",null);

            foreach (var item in data)
            {
                KaynakUrunDto kaynakUrunDto = UtilBL.KaynakUrunler.Where(p => p.UrunKoduHarem == item.Value.Code).FirstOrDefault();

                if (kaynakUrunDto == null) continue;
                if (kaynakUrunDto.UrunKoduHarem == "YOK") continue;

                UrunDto urun = UtilBL.Urunler.Where(p => p.UrunKod == kaynakUrunDto.UrunKodu).FirstOrDefault();

                if(urun==null) continue;

             

                if (urun != null)
                {
                    TabelaFiyatDto tabelaFiyat = new TabelaFiyatDto();
                    tabelaFiyat.Kaynak = Kaynaklar.Harem;
                    tabelaFiyat.Urun = urun;
                    tabelaFiyat.Zaman = dateTime;
                    tabelaFiyat.Sira = urun.Sira;

                   
                    decimal.TryParse(item.Value.Alis, NumberStyles.Any, culture, out decimal alis);
                    decimal.TryParse(item.Value.Satis, NumberStyles.Any, culture, out decimal satis); 

                    //if (true)
                    //{
                    //    int marjAlis = (int)(alis * 2 / 100);
                    //    int marjSatis = (int)(satis * 2 / 100);
                    //    alis = alis + (new Random().Next(-marjAlis, marjAlis));
                    //    satis = satis + (new Random().Next(-marjSatis, marjSatis));
                    //}

                  

                    tabelaFiyat.AlisOrijinal = alis;
                    tabelaFiyat.SatisOrijinal = satis;
                    tabelaFiyat.AlisMilyem = 0;
                    tabelaFiyat.SatisMilyem = 0;
                    tabelaFiyat.Durum = TabelaFiyatHesaplamDurum.Hesaplandi;
                    UtilBL.Hesapla(tabelaFiyat);
                    tabelaFiyatList.Add(tabelaFiyat);
                }


            }


            return tabelaFiyatList.OrderBy(p => p.Sira).ToList();
        }

    }
}
