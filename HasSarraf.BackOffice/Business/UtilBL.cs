using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using HasSarraf.BackOffice.Library;
using HasSarraf.BackOffice.Properties;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace HasSarraf.BackOffice.Business
{
    public class UtilBL
    {

        public static HasConfigDto HasConfig = new HasConfigDto();


        public static void Init()
        {
            ReadConfig();

            if (!string.IsNullOrEmpty(Settings.Default.TabelaFiyat))
            {
                DataProviderBL.TabelaFiyat = JsonConvert.DeserializeObject<List<TabelaFiyatDto>>(Settings.Default.TabelaFiyat, Constants.JsonSettings) as List<TabelaFiyatDto>;
            }

        }

        public static void ReadConfig()
        {
            string configPath = Path.Combine(Constants.App.AssetsPath, Constants.FileNames.Config);
            string configContents = File.ReadAllText(configPath);
            HasConfig = JsonConvert.DeserializeObject<HasConfigDto>(configContents, Constants.JsonSettings);
            LogBL.GetInstance().Info("INIT", "ConfigLoaded");

           

        }

        public static void SaveUrunler(List<UrunDto> urunler)
        {
            string configPath = Path.Combine(Constants.App.AssetsPath, Constants.FileNames.Config);
            HasConfig.Urunler = urunler;
            string content = JsonConvert.SerializeObject(HasConfig, Constants.JsonSettings);
            File.WriteAllText(configPath, content);
            LogBL.GetInstance().Info("INIT", "Config saved");
        }

        public static void SaveUrun(UrunDto urun)
        {
            string configPath = Path.Combine(Constants.App.AssetsPath, Constants.FileNames.Config);
            var eskiUrun = HasConfig.Urunler.Where(p => p.Slug == urun.Slug).FirstOrDefault();
            if (eskiUrun != null)
            {
                eskiUrun = urun;
            }

            string content = JsonConvert.SerializeObject(HasConfig, Constants.JsonSettings);
            File.WriteAllText(configPath, content);
            LogBL.GetInstance().Info("INIT", "Config saved");
        }

        public static void SaveAyarlar()
        {
            string configPath = Path.Combine(Constants.App.AssetsPath, Constants.FileNames.Config); 
            string content = JsonConvert.SerializeObject(HasConfig, Constants.JsonSettings);
            File.WriteAllText(configPath, content);
            LogBL.GetInstance().Info("INIT", "Settings saved");
        }



        private static string ChromeAppFileName
        {
            get
            {
                return (string)(Registry.GetValue("HKEY_LOCAL_MACHINE" + Constants.App.ChromeAppKey, "", null) ??
                                    Registry.GetValue("HKEY_CURRENT_USER" + Constants.App.ChromeAppKey, "", null));
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


        // Deep clone


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