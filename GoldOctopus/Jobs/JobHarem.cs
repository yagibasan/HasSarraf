using System.Collections.Generic;
using System.IO;
using System.Linq;
using GoldOctopus.Business;
using GoldOctopus.Library.Config;
using Newtonsoft.Json;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Jobs  
{
    public class JobHarem
    {
        private readonly static string TAG = "JobHarem";

        public static List<T> Execute<T>(string kaynakKod)
        {

            KaynakDto kaynak = UtilBL.Kaynaklar.Where(p => p.Kod == kaynakKod).FirstOrDefault();

            if (kaynak == null)
            {
                LogBL.GetInstance().Info(TAG, $"{TAG} jobı {kaynakKod} kaynağını bulunamadı");
                return null;
            }
            else
            {
                List<T> allData = new List<T>();
                foreach (var apiUrl in kaynak.ApiUrls)
                {
                    T data = ApiBL.GetInstance().GetDataFromSource<T>(apiUrl);

                    if (data != null)
                    {
                        allData.Add(data);
                    }
                }

                string content = JsonConvert.SerializeObject(allData, JsonSettings);
                if (!string.IsNullOrEmpty(content))
                {

                   
                    if (!Directory.Exists(App.DataPath))
                        Directory.CreateDirectory(App.DataPath);

                    File.WriteAllText(Path.Combine(App.DataPath, kaynak.Kod + ".json"), content);
                    LogBL.GetInstance().Info(TAG, $"{TAG} jobı  {kaynakKod} kaynağını çalıştırıldı");
                    return allData;
                }
                else
                {
                    LogBL.GetInstance().Info(TAG, $"{TAG} jobı {kaynakKod} kaynağından veri alınamadı");
                    return null;
                }

            }
        }
    }
}
