using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HasSarraf.BackOffice.Adaptors;
using HasSarraf.BackOffice.Business;
using HasSarraf.BackOffice.Library;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Jobs
{
    public class JobSaglamoglu 
    {
        private readonly static string TAG = "JobSaglamoglu";
      
        public static Task Execute()
        {
            List<TabelaFiyatDto> tabelaFiyats = new List<TabelaFiyatDto>();

            KaynakDto kaynak = UtilBL.HasConfig.Kaynaklar.Where(p=> p.Kod == Kaynaklar.Saglamoglu).FirstOrDefault();

            if (kaynak == null)
            {
                LogBL.GetInstance().Error(TAG, "Saglamoglu kaynağı bulunamadı.", null);
                return Task.CompletedTask;
            }
            else
            {

                var data1 = ApiBL.GetInstance().GetSaglamogluData(kaynak.Api1Url);
                var t1 = SaglamogluAdaptor.Parse(data1);
                tabelaFiyats.AddRange(t1);

                var data2 = ApiBL.GetInstance().GetSaglamogluData(kaynak.Api2Url);
                var tabelaFiyat2 = SaglamogluAdaptor.Parse(data2);

                tabelaFiyats.AddRange(tabelaFiyat2);
                DataProviderBL.GetInstance().DataReceived(tabelaFiyats);

                LogBL.GetInstance().Info(TAG, $"JobSaglamoglu çalıştırıldı: {DateTime.Now}");
                return Task.CompletedTask;
            }
        }
    }
}
