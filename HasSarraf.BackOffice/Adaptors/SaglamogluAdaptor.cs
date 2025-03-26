using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HasSarraf.BackOffice.Business;
using HasSarraf.BackOffice.Library;
using HasSarraf.BackOffice.Library.Saglamoglu;
using Newtonsoft.Json;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Adaptors
{
    public class SaglamogluAdaptor
    {
        public static List<TabelaFiyatDto> Parse(SaglamogluDto data)
        {
            List<TabelaFiyatDto> tabelaFiyatList = new List<TabelaFiyatDto>();

            DateTime dateTime = DateTime.Now;

            foreach (var tabs in data.TabGroup.Tabs.ToList())
            {
                int grupId = tabs.TabGroupId;
                foreach (var product in tabs.Products)
                {
                    UrunDto urun = UtilBL.HasConfig.Urunler.Where(p => p.Slug == product.Slug).FirstOrDefault();
                    if (urun != null)
                    {
                        if (urun.Goster == false) continue;

                        TabelaFiyatDto tabelaFiyat = new TabelaFiyatDto();
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
                                    decimal alis = product.Forex.Groups[groupCount - 1].Ask;
                                    decimal satis = product.Forex.Groups[groupCount - 1].Bid;

                                    if (true)
                                    {
                                        int marjAlis = (int)(alis * 2 / 100);
                                        int marjSatis = (int)(satis * 2 / 100);
                                        alis = alis + (new Random().Next(-marjAlis, marjAlis));
                                        satis = satis + (new Random().Next(-marjSatis, marjSatis));
                                    }

                                    tabelaFiyat.AlisOrijinal = alis;
                                    tabelaFiyat.SatisOrijinal = satis;
                                    tabelaFiyat.AlisMilyem = product.Forex.Groups[groupCount - 1].LaborAsk;
                                    tabelaFiyat.SatisMilyem = product.Forex.Groups[groupCount - 1].LaborBid;
                                    tabelaFiyat.Durum = TabelaFiyatHesaplamDurum.Hesaplandi;
                                    tabelaFiyat.Hesapla();
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

            return tabelaFiyatList.OrderBy(p => p.Sira).ToList();
        } 
      
    }
}
