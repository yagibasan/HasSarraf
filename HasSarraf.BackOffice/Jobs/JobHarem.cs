using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HasSarraf.BackOffice.Adaptors;
using HasSarraf.BackOffice.Business;
using HasSarraf.BackOffice.Library;
using HasSarraf.BackOffice.Library.Saglamoglu;
using Newtonsoft.Json;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Jobs
{
    public class JobHarem
    {
        private readonly static string TAG = "JobHarem";

        public static Task Execute()
        {
            List<TabelaFiyatDto> tabelaFiyats = new List<TabelaFiyatDto>();

            KaynakDto kaynak = UtilBL.HasConfig.Kaynaklar.Where(p => p.Kod == Kaynaklar.Harem).FirstOrDefault();

            if (kaynak == null)
            {
                LogBL.GetInstance().Error(TAG, "Harem kaynağı bulunamadı.", null);
                return Task.CompletedTask;
            }
            else
            {

                var data = ApiBL.GetInstance().GetDataFromSource<HaremDto>(kaynak.Api1Url);

                if (data != null)
                {
                    if (!Directory.Exists(App.DataPath))
                        Directory.CreateDirectory(App.DataPath);

                    string content = JsonConvert.SerializeObject(data, JsonSettings);
                    File.WriteAllText(Path.Combine(App.DataPath, kaynak.Kod + ".json"), content);
                }


                LogBL.GetInstance().Info(TAG, $"JobHarem çalıştırıldı: {DateTime.Now}");
                return Task.CompletedTask;
            }
        }
    }
}
