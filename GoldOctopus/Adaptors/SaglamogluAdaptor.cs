using System;
using System.Collections.Generic;
using System.Linq;
using GoldOctopus.Business;
using GoldOctopus.Library;
using GoldOctopus.Library.Config;
using GoldOctopus.Library.Sources;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Adaptors
{
    public class SaglamogluAdaptor
    {
        public static List<TabelaFiyatDto> Parse(List<SaglamogluDto> dataList)
        {
            List<TabelaFiyatDto> tabelaFiyatList = new List<TabelaFiyatDto>();

            DateTime dateTime = DateTime.Now;

            foreach (var data in dataList)
            {
                foreach (var tabs in data.TabGroup.Tabs.ToList())
                {
                    int grupId = tabs.TabGroupId;
                    foreach (var product in tabs.Products)
                    {
                     

                        KaynakUrunDto kaynakUrunDto = UtilBL.KaynakUrunler.Where(p => p.UrunKoduSaglamoglu == product.Slug).FirstOrDefault();


                      
                        if (kaynakUrunDto == null) continue;
                        if (kaynakUrunDto.UrunKoduSaglamoglu == "YOK") continue;


                        UrunDto urun = UtilBL.Urunler.Where(p => p.UrunKod == kaynakUrunDto.UrunKodu).FirstOrDefault(); 

                       
                        if (urun != null)
                        { 
                            TabelaFiyatDto tabelaFiyat = new TabelaFiyatDto();
                            tabelaFiyat.Kaynak = Kaynaklar.Saglamoglu;  
                            tabelaFiyat.Urun = urun;
                            tabelaFiyat.Zaman = dateTime;
                            tabelaFiyat.Sira = urun.Sira;

                            if (product.Forex != null)
                            {
                                if (product.Forex.Groups != null)
                                {
                                    int groupCount = product.Forex.Groups.Count;
                                    if (groupCount > 0)
                                    {
                                        decimal alis = product.Forex.Groups[0].Ask;
                                        decimal satis = product.Forex.Groups[0].Bid;

                                        if(UtilBL.Ayarlar.Simulasyon)
                                        {
                                            alis -= dateTime.Second;
                                            satis += dateTime.Second;
                                        }

                                        tabelaFiyat.AlisOrijinal = alis;
                                        tabelaFiyat.SatisOrijinal = satis;
                                        tabelaFiyat.AlisMilyem = product.Forex.Groups[0].LaborAsk;
                                        tabelaFiyat.SatisMilyem = product.Forex.Groups[0].LaborBid;
                                        tabelaFiyat.Durum = TabelaFiyatHesaplamDurum.Hesaplandi;
                                        UtilBL.Hesapla(tabelaFiyat);
                                        tabelaFiyatList.Add(tabelaFiyat);
                                    }
                                }
                            }
                        }
                        else
                        {
                            LogBL.GetInstance().Info("ADAPTOR", $"Urun bulunamadı: {product.Slug}");
                        }
                    }

                }
            }

           

            return tabelaFiyatList.OrderBy(p => p.Sira).ToList();
        } 
      
    }
}
