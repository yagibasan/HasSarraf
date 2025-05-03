using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoldOctopus.Business;
using GoldOctopus.Library;
using GoldOctopus.Library.Config;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Jobs
{
    public class JobSaglamoglu 
    {
        private readonly static string TAG = "JobSaglamoglu";
      
        public static void Execute()
        {
            List<TabelaFiyatDto> tabelaFiyats = new List<TabelaFiyatDto>();

            KaynakDto kaynak = UtilBL.Kaynaklar.Where(p=> p.Kod == Kaynaklar.Saglamoglu).FirstOrDefault();

            if (kaynak == null)
            {
                LogBL.GetInstance().Error(TAG, "Saglamoglu kaynağı bulunamadı.", null);
                
            }
            else
            {

                //var data1 = ApiBL.GetInstance().GetSaglamogluData(kaynak.Api1Url);
                //var t1 = SaglamogluAdaptor.Parse(data1);
                //tabelaFiyats.AddRange(t1);

                //var data2 = ApiBL.GetInstance().GetSaglamogluData(kaynak.Api2Url);
                //var tabelaFiyat2 = SaglamogluAdaptor.Parse(data2);

                //tabelaFiyats.AddRange(tabelaFiyat2);
                //DataProviderBL.GetInstance().DataReceived(tabelaFiyats);

                LogBL.GetInstance().Info(TAG, $"JobSaglamoglu çalıştırıldı: {DateTime.Now}");
               
            }
        }
    }
}
