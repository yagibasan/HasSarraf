using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Timers;
using GoldOctopus.Adaptors;
using GoldOctopus.Controls;
using GoldOctopus.Jobs;
using GoldOctopus.Library;
using GoldOctopus.Library.Sources;
using GoldOctopus.Properties;
using Newtonsoft.Json;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Business
{
    public class DataProviderBL
    {

        private static DataProviderBL instance;

        private readonly LogBL Log = LogBL.GetInstance();
        public event EventHandler<List<TabelaFiyatDto>> TabelaFiyatlariGuncellendi;
        public static List<TabelaFiyatDto> GUNCEL_TABELA = new List<TabelaFiyatDto>();
      
        System.Timers.Timer timer = null;

        public static DataProviderBL GetInstance()
        {
            if (instance == null)
            {
                instance = new DataProviderBL();
                ucAyar.AyarlarDegistirildi += UcAyar_AyarlarDegistirildi;
                return instance;
            }

            return instance;
        }

        private static void UcAyar_AyarlarDegistirildi(object sender, EventArgs e)
        {
            GetInstance().Init();
        }


        public void Refresh()
        {
            ExecuteJobs();
        }
        public void Init()
        {

            new Thread(() => ExecuteJobs()).Start();

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }

            timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = 1000 * UtilBL.Ayarlar.GuncellemePeriyodu;
            //timer.Interval = 1000 * 5;
            timer.Elapsed += TimerElapsedHandler;
            timer.Start();


        }

        private void TimerElapsedHandler(object sender, ElapsedEventArgs e)
        {
            ExecuteJobs();
        }


        public void ExecuteJobs()
        {
           // new Thread(() => ExecuteSaglamoglu()).Start();
            new Thread(() => ExecuteHarem()).Start();
        }

        #region jobs executes

        public void ExecuteSaglamoglu()
        {
            List<SaglamogluDto> data = JobGeneric.Execute<SaglamogluDto>(Kaynaklar.Saglamoglu);
            if (data != null)
            {
                var tabela = SaglamogluAdaptor.Parse(data);
                DataReceived(Kaynaklar.Saglamoglu, tabela);
            }
        }

        public void ExecuteHarem()
        {
            List<HaremDto> data = JobGeneric.Execute<HaremDto>(Kaynaklar.Harem);

            if (data != null)
            {
                var tabela = HaremAdaptor.Parse(data);
                DataReceived(Kaynaklar.Harem, tabela);
            }
        }

        #endregion

        public void DataReceived(string kaynakAdi, List<TabelaFiyatDto> tabelaFiyatDtos)
        {
            try
            {
                if (GUNCEL_TABELA == null)
                    GUNCEL_TABELA = tabelaFiyatDtos;
                else
                {
                    foreach (var yeniFiyat in tabelaFiyatDtos)
                    {
                        var tabelaItem = GUNCEL_TABELA.Where(p => p.Kaynak == kaynakAdi && p.Urun.UrunKod == yeniFiyat.Urun.UrunKod).FirstOrDefault();

                        if (tabelaItem != null)
                        {

                            yeniFiyat.AlisTabelaEski = tabelaItem.AlisTabela;
                            yeniFiyat.SatisTabelaEski = tabelaItem.SatisTabela;

                            yeniFiyat.AlisDegisimYonu = degisimYonu(tabelaItem.AlisTabela, yeniFiyat.AlisTabela);
                            yeniFiyat.SatisDegisimYonu = degisimYonu(tabelaItem.SatisTabela, yeniFiyat.SatisTabela);

                            tabelaItem = yeniFiyat;
                        }
                    }

                    GUNCEL_TABELA.RemoveAll(p => p.Kaynak == kaynakAdi);
                    GUNCEL_TABELA.AddRange(tabelaFiyatDtos);
                    GUNCEL_TABELA = GUNCEL_TABELA.OrderBy(p => p.Sira).ToList();

                }

                TabelaFiyatlariGuncellendi?.Invoke(this, GUNCEL_TABELA);

                SaveTabela(GUNCEL_TABELA);
                if(UtilBL.Ayarlar.OtomatikVeriAl)
                    SaveDisTabela(GUNCEL_TABELA);

                Settings.Default.TabelaFiyat = JsonConvert.SerializeObject(GUNCEL_TABELA, JsonSettings);
                Settings.Default.TabelaFiyatZamani = DateTime.Now;
                Settings.Default.Save();

            }
            catch (Exception ex)
            {
                TabelaFiyatlariGuncellendi?.Invoke(this, null);
                Log.Error("Veri alınamadı", ex);
            }

        }

        public void SaveTabela(List<TabelaFiyatDto> data)
        {
            try
            {
                data = data.OrderBy(p => p.Sira).ToList();
                string content = JsonConvert.SerializeObject(data, JsonSettings);
                string path = Path.Combine(App.AssetsPath, FileNames.TabelaFiyat);
                //string path = Path.Combine(App.DataPath, FileNames.TabelaFiyat);
                File.WriteAllText(path, content);
            }
            catch (Exception ex)
            {
                LogBL.GetInstance().Error("ADAPTOR", "SaveTabela", ex);
            }
        }

        public void SaveDisTabela(List<TabelaFiyatDto> data)
        {
            try
            {
                var items = data.Where(p => p.Urun.TabeladaGoster && p.Kaynak== UtilBL.Ayarlar.Kaynak).OrderBy(p => p.Urun.Sira).ToList();
                UtilBL.CreateTabelaHtml(items);
            }
            catch (Exception ex)
            {
                LogBL.GetInstance().Error("FILE", "DisTabela", ex);
            }
        }

        public List<TabelaFiyatDto> ReadTabela()
        {
            try
            {
                string path = Path.Combine(App.DataPath, FileNames.TabelaFiyat);
                string content = File.ReadAllText(path);
                GUNCEL_TABELA = JsonConvert.DeserializeObject<List<TabelaFiyatDto>>(content, JsonSettings) as List<TabelaFiyatDto>;
                return GUNCEL_TABELA;

            }
            catch (Exception ex)
            {
                LogBL.GetInstance().Error("ADAPTOR", "SaveTabela", ex);
                return null;
            }
        }

        public int degisimYonu(decimal eski, decimal yeni)
        {
            if (eski > yeni)
            {
                return -1;
            }
            else if (eski < yeni)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}