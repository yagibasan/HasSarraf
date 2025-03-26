using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Timers;
using HasSarraf.BackOffice.Forms;
using HasSarraf.BackOffice.Jobs;
using HasSarraf.BackOffice.Library;
using HasSarraf.BackOffice.Properties;
using Newtonsoft.Json;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Business
{
    public class DataProviderBL
    {

        private static DataProviderBL instance;

        private readonly LogBL Log = LogBL.GetInstance();
        public event EventHandler<List<TabelaFiyatDto>> TabelaFiyatlariGuncellendi;
        public static List<TabelaFiyatDto> TabelaFiyat = new List<TabelaFiyatDto>();
        Timer timer = null;

        public static DataProviderBL GetInstance()
        {
            if (instance == null)
            {
                instance = new DataProviderBL();
                frmAyarlar.AyarlarDegistirildi += FrmAyarlar_AyarlarDegistirildi;
                return instance;
            }

            return instance;
        }

        private static void FrmAyarlar_AyarlarDegistirildi(object sender, EventArgs e)
        {
            GetInstance().Init();
        }

        public  void Refresh()
        {
            JobHarem.Execute();
            if (UtilBL.HasConfig.Ayarlar.Kaynak == Kaynaklar.Saglamoglu)
            {
                JobSaglamoglu.Execute();
            }
        }
        public async void Init()
        {
            string periodPattern = string.Format("*/{0} * * * *", UtilBL.HasConfig.Ayarlar.GuncellemePeriyodu);

            if (UtilBL.HasConfig.Ayarlar.Kaynak == Kaynaklar.Saglamoglu)
            {
                if(timer != null)
                {
                    timer.Stop();
                    timer.Dispose();
                }   

                timer = new Timer();
                timer.Enabled = true;   
                timer.Interval = 1000 * UtilBL.HasConfig.Ayarlar.GuncellemePeriyodu;
                timer.Elapsed += TimerElapsedHandler;   
                timer.Start(); 

            }
        }

        private void TimerElapsedHandler(object sender, ElapsedEventArgs e)
        {
            if (UtilBL.HasConfig.Ayarlar.Kaynak == Kaynaklar.Saglamoglu)
            {
                JobSaglamoglu.Execute();     
            }

            JobHarem.Execute();

        }

        public void DataReceived(List<TabelaFiyatDto> tabelaFiyatDtos)
        {
            try
            {
                TabelaFiyat = tabelaFiyatDtos.OrderBy(p=>p.Sira).ToList();
                TabelaFiyatlariGuncellendi?.Invoke(this, TabelaFiyat);
                SaveTabela(TabelaFiyat);
                Settings.Default.TabelaFiyat = JsonConvert.SerializeObject(tabelaFiyatDtos, JsonSettings);
                Settings.Default.TabelaFiyatZamani = DateTime.Now;
                Settings.Default.Save();

                TabelaFiyat = JsonConvert.DeserializeObject<List<TabelaFiyatDto>>(Settings.Default.TabelaFiyat, JsonSettings);
                TabelaFiyat = tabelaFiyatDtos.OrderBy(p => p.Sira).ToList();
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
                File.WriteAllText(path, content);
            }
            catch (Exception ex)
            {
                LogBL.GetInstance().Error("ADAPTOR", "SaveTabela", ex);
            }
        }

    }
}