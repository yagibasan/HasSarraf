using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using GoldOctopus.Library;
using GoldOctopus.Library.Config;
using GoldOctopus.Properties;
using Microsoft.Win32;
using Newtonsoft.Json;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Business
{
    public class UtilBL
    {



        public static List<EkranItemDto> Ekranlar = null;
        public static AyarDto Ayarlar = null;
        public static List<KaynakDto> Kaynaklar = null;
        public static List<UrunDto> Urunler = null;
        public static List<KaynakUrunDto> KaynakUrunler = null;
        public static List<MizanpajDetailDto> SerbestAlanIcerikleri = null;
        public static List<MizanpajDetailDto> KayanYaziIcerikleri = null;
        public static MizanpajDto Mizanpaj = null;


        public static void Init()
        {
            ReadConfig();

            if (!string.IsNullOrEmpty(Settings.Default.TabelaFiyat))
            {
                DataProviderBL.GUNCEL_TABELA = JsonConvert.DeserializeObject<List<TabelaFiyatDto>>(Settings.Default.TabelaFiyat, JsonSettings) as List<TabelaFiyatDto>;
            }

        }

        public static void ReadConfig()
        {
            string configPath = "", configContents = "";

            configPath = Path.Combine(App.ConfigPath, FileNames.Ekran);
            configContents = File.ReadAllText(configPath);
            Ekranlar = JsonConvert.DeserializeObject<List<EkranItemDto>>(configContents, JsonSettings);

            configPath = Path.Combine(App.ConfigPath, FileNames.Ayar);
            configContents = File.ReadAllText(configPath);
            Ayarlar = JsonConvert.DeserializeObject<AyarDto>(configContents, JsonSettings);



            configPath = Path.Combine(App.ConfigPath, FileNames.Kaynak);
            configContents = File.ReadAllText(configPath);
            Kaynaklar = JsonConvert.DeserializeObject<List<KaynakDto>>(configContents, JsonSettings);

            configPath = Path.Combine(App.ConfigPath, FileNames.Urun);
            configContents = File.ReadAllText(configPath);
            Urunler = JsonConvert.DeserializeObject<List<UrunDto>>(configContents, JsonSettings);

            configPath = Path.Combine(App.ConfigPath, FileNames.UrunKaynak);
            configContents = File.ReadAllText(configPath);
            KaynakUrunler = JsonConvert.DeserializeObject<List<KaynakUrunDto>>(configContents, JsonSettings);

            configPath = Path.Combine(App.ConfigPath, FileNames.SerbestAlan);
            configContents = File.ReadAllText(configPath);
            SerbestAlanIcerikleri = JsonConvert.DeserializeObject<List<MizanpajDetailDto>>(configContents, JsonSettings);

            configPath = Path.Combine(App.ConfigPath, FileNames.KayanYazi);
            configContents = File.ReadAllText(configPath);
            KayanYaziIcerikleri = JsonConvert.DeserializeObject<List<MizanpajDetailDto>>(configContents, JsonSettings);

            configPath = Path.Combine(App.ConfigPath, FileNames.Mizanpaj);
            configContents = File.ReadAllText(configPath);
            Mizanpaj = JsonConvert.DeserializeObject<MizanpajDto>(configContents, JsonSettings);



            LogBL.GetInstance().Info("INIT", "Ayar ve katalog değerleri yüklendi");

        }

        public static void KaydetConfig(object data, string pathName)
        {
            string configPath = Path.Combine(App.ConfigPath, pathName);
            string content = JsonConvert.SerializeObject(data, JsonSettings);
            File.WriteAllText(configPath, content);
            LogBL.GetInstance().Info("INIT", pathName + " kayıt edildi");
        }

        private static string ChromeAppFileName
        {
            get
            {
                return (string)(Registry.GetValue("HKEY_LOCAL_MACHINE" + App.ChromeAppKey, "", null) ??
                                    Registry.GetValue("HKEY_CURRENT_USER" + App.ChromeAppKey, "", null));
            }
        }

        public static void OpenLink(string url)
        {
            string chromeAppFileName = ChromeAppFileName;
            if (string.IsNullOrEmpty(chromeAppFileName))
            {
                throw new Exception("Could not find chrome.exe!");
            }
            Process.Start(chromeAppFileName, url);
        }

        public static void EkranUrunKaydet(EkranItemDto newItem)
        {
            EkranItemDto existItem = Ekranlar.Where(p => p.Sekme == newItem.Sekme && p.Sira == newItem.Sira).FirstOrDefault();
            if (existItem != null)
            {
                existItem.UrunKodu = newItem.UrunKodu;
                existItem.Kaynak = newItem.Kaynak;
            }
            else
            {
                Ekranlar.Add(newItem);
            }

            KaydetConfig(Ekranlar, FileNames.Ekran);
        }


        public static void Hesapla(TabelaFiyatDto dto)
        {
            if (dto.Urun != null)
            {
                if (dto.Urun.UrunKod == "eski_ata_lira_try")
                {
                    // Handle specific case if needed
                }

                dto.AlisTabela = FiyatiHesapla(dto.AlisOrijinal, dto.Urun.AlisMarjYontemi, IslemTuru.Alis);
                dto.FarkAlis = dto.AlisTabela - dto.AlisOrijinal;

                dto.SatisTabela = FiyatiHesapla(dto.SatisOrijinal, dto.Urun.SatisMarjYontemi, IslemTuru.Satis);
                dto.FarkSatis = dto.SatisTabela - dto.SatisOrijinal;

                if (dto.Urun.Grup != 2)
                {
                    if (Ayarlar.SarrafiyeOndalikGoster)
                    {
                        dto.AlisTabela = Math.Round(dto.AlisTabela, Ayarlar.SarrafiyeOndalikAdeti);
                        dto.SatisTabela = Math.Round(dto.SatisTabela, Ayarlar.SarrafiyeOndalikAdeti);
                        dto.FarkAlis = Math.Round(dto.FarkAlis, Ayarlar.SarrafiyeOndalikAdeti);
                        dto.FarkSatis = Math.Round(dto.FarkSatis, Ayarlar.SarrafiyeOndalikAdeti);

                        dto.AlisTabelaText = dto.AlisTabela.ToString("N" + Ayarlar.SarrafiyeOndalikAdeti);
                        dto.SatisTabelaText = dto.SatisTabela.ToString("N" + Ayarlar.SarrafiyeOndalikAdeti);
                        dto.AlisOrijinalText = dto.AlisOrijinal.ToString("N" + Ayarlar.SarrafiyeOndalikAdeti);
                        dto.SatisOrijinalText = dto.SatisOrijinal.ToString("N" + Ayarlar.SarrafiyeOndalikAdeti);
                        dto.FarkAlisText = dto.FarkAlis.ToString("N" + Ayarlar.SarrafiyeOndalikAdeti);
                        dto.FarkSatisText = dto.FarkSatis.ToString("N" + Ayarlar.SarrafiyeOndalikAdeti);
                    }
                    else
                    {
                        dto.AlisTabela = Math.Round(dto.AlisTabela, 0);
                        dto.SatisTabela = Math.Round(dto.SatisTabela, 0);

                        dto.FarkAlis = dto.AlisTabela - dto.AlisOrijinal;
                        dto.FarkSatis = dto.SatisTabela - dto.SatisOrijinal;

                        dto.FarkAlis = Math.Round(dto.FarkAlis, 0);
                        dto.FarkSatis = Math.Round(dto.FarkSatis, 0);

                        dto.AlisOrijinalText = dto.AlisOrijinal.ToString("N0");
                        dto.SatisOrijinalText = dto.SatisOrijinal.ToString("N0");
                        dto.AlisTabelaText = dto.AlisTabela.ToString("N0");
                        dto.SatisTabelaText = dto.SatisTabela.ToString("N0");
                        dto.FarkAlisText = dto.FarkAlis.ToString("N0");
                        dto.FarkSatisText = dto.FarkSatis.ToString("N0");
                    }
                }
                else
                {
                    if (Ayarlar.DovizOndalikGoster)
                    {
                        dto.AlisTabela = Math.Round(dto.AlisTabela, Ayarlar.DovizOndalikAdeti);
                        dto.SatisTabela = Math.Round(dto.SatisTabela, Ayarlar.DovizOndalikAdeti);
                        dto.FarkAlis = Math.Round(dto.FarkAlis, Ayarlar.DovizOndalikAdeti);
                        dto.FarkSatis = Math.Round(dto.FarkSatis, Ayarlar.DovizOndalikAdeti);

                        dto.AlisTabelaText = dto.AlisTabela.ToString("N" + Ayarlar.DovizOndalikAdeti);
                        dto.SatisTabelaText = dto.SatisTabela.ToString("N" + Ayarlar.DovizOndalikAdeti);
                        dto.AlisOrijinalText = dto.AlisOrijinal.ToString("N" + Ayarlar.SarrafiyeOndalikAdeti);
                        dto.SatisOrijinalText = dto.SatisOrijinal.ToString("N" + Ayarlar.SarrafiyeOndalikAdeti);
                        dto.FarkAlisText = dto.FarkAlis.ToString("N2");
                        dto.FarkSatisText = dto.FarkSatis.ToString("N2");
                    }
                    else
                    {
                        dto.AlisTabela = Math.Round(dto.AlisOrijinal, 0);
                        dto.SatisTabela = Math.Round(dto.SatisOrijinal, 0);

                        dto.FarkAlis = dto.AlisTabela - dto.AlisOrijinal;
                        dto.FarkSatis = dto.SatisTabela - dto.SatisOrijinal;

                        dto.FarkAlis = Math.Round(dto.FarkAlis, 0);
                        dto.FarkSatis = Math.Round(dto.FarkSatis, 0);

                        dto.AlisOrijinalText = dto.AlisOrijinal.ToString("N0");
                        dto.SatisOrijinalText = dto.SatisOrijinal.ToString("N0");
                        dto.AlisTabelaText = dto.AlisTabela.ToString("N0");
                        dto.SatisTabelaText = dto.SatisTabela.ToString("N0");
                        dto.FarkAlisText = dto.FarkAlis.ToString("N0");
                        dto.FarkSatisText = dto.FarkSatis.ToString("N0");
                    }
                }
            }
        }

        private static decimal FiyatiHesapla(decimal deger, MarjDto marj, string islemTuru)
        {
            if (marj == null)
                return deger;

            decimal karMarji = 0;
            if (marj.Tur == MarjYontemi.Oransal)
                karMarji = deger * marj.OransalDeger / 100;
            else if (marj.Tur == MarjYontemi.Miktar)
                karMarji = marj.MiktarDeger;
            else if (marj.Tur == MarjYontemi.Original)
                karMarji = 0;
            else
                karMarji = 0;

            decimal sonuc = 0;
            if (IslemTuru.Alis == islemTuru)
                sonuc = deger - karMarji;
            else if (IslemTuru.Satis == islemTuru)
                sonuc = deger + karMarji;
            else
                sonuc= deger;

            if (sonuc % 10 < 6)
                sonuc -= sonuc % 10;
            else

                sonuc += 10 - (sonuc % 10);

            return sonuc;
        }


        public static void CreateTabelaHtml(List<TabelaFiyatDto> data, bool isPreview = false)
        {
            string content = File.ReadAllText(Path.Combine(App.TemplatePath, Ayarlar.TabelaSablonu + ".html"));
            string row = string.Empty;

            StringBuilder sbRows = new StringBuilder();
            data=data.OrderBy(p => p.Sira).ToList();
            for (int i = 0; i < data.Count; i++)
            {
                TabelaFiyatDto tabelaFiyatDto = data[i];

                if (Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon1) row = SablonDesenleri.Sablon1;
                else if (Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon2) row = SablonDesenleri.Sablon2;
                else if (Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon3) row = SablonDesenleri.Sablon3;
                else if (Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon4) row = SablonDesenleri.Sablon4;


                string rowType = i % 2 == 0 ? "evenRow" : "oddRow";
                string urunAdi = tabelaFiyatDto.Urun.Adi;
                string alis = tabelaFiyatDto.AlisTabelaText;
                string satis = tabelaFiyatDto.SatisTabelaText;


                row = row.Replace("##ROWTYPE##", rowType);
                row = row.Replace("##ADI##", urunAdi);
                row = row.Replace("##ALIS##", alis);
                row = row.Replace("##SATIS##", satis);

                sbRows.AppendLine(row);

            }

            content = content.Replace("####TABELA####", sbRows.ToString());
            content = content.Replace("####KAYANYAZI####", string.Empty);

            if (!Directory.Exists(Path.Combine(App.DataPath)))
                Directory.CreateDirectory(Path.Combine(App.DataPath));


            string path = Path.Combine(App.DataPath, isPreview ? FileNames.DisTabelaOnIzleme : FileNames.DisTabelaHtml);


            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, content);
        }

    }



    public static class ExtensionMethods
    {
        // Deep clone
        public static T DeepClone<T>(this T a)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, a);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}