using System.Configuration;
using System.Globalization;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace GoldOctopus.Library
{
    public enum DataReceiveStatus
    {
        FirstLoading=1,
        Received=2,
        NotReceived=3,
        HasError=4   

   }

   
    public  class Constants
    {
        public struct App
        {

            public const string AppName = "HasSarraf";
            public const string ExeName = "HasSarraf.exe";
            public static readonly string ApplicationRoot = ConfigurationManager.AppSettings["ApplicationRoot"];
            public static readonly string DataPath = Path.Combine(ApplicationRoot, "Data");
            public static readonly string AssetsPath = Path.Combine(ApplicationRoot, "Assets"); 
            public static readonly string ConfigPath = Path.Combine(AssetsPath, "Config"); 
            public static readonly string TemplatePath = Path.Combine(ApplicationRoot, "Assets","Template"); 
            public static readonly string ApplicationVersion = Assembly.GetEntryAssembly().GetName().Version.ToString().Replace(".", string.Empty);
            public static readonly string ChromeAppKey = @"\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe";

        }

        public struct FileNames
        {
            public static readonly string Ekran = "ekran.json"; 
            public static readonly string Ayar = "ayar.json"; 
            public static readonly string Kaynak = "kaynak.json"; 
            public static readonly string Urun = "urun.json"; 
            public static readonly string UrunKaynak = "urunKaynak.json"; 
            public static readonly string TabelaFiyat = "tabelaFiyat.json";  
            public static readonly string DisTabela = "disTabela.json";  
            public static readonly string Mizanpaj = "mizanpaj.json";  
            public static readonly string SerbestAlan = "serbestAlan.json";   
            public static readonly string KayanYazi = "kayanYazi.json"; 
            public static readonly string DisTabelaHtml = "index.html"; 
            public static readonly string DisTabelaOnIzleme = "onizleme.html"; 
        }

        public struct Sekmeler
        {
            public static readonly string AnaEkran = "anaekran";
            public static readonly string Tabela = "tabela";
            public static readonly string Saglamoglu = "saglamoglu";
            public static readonly string Harem = "harem"; 
        }

        public static readonly JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore,
            Culture = new CultureInfo("en-US"),
            DateFormatString = "dd.MM.yyyy HH:mm:ss",
            FloatParseHandling = FloatParseHandling.Decimal,
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.Auto,

        };

        public struct TabelaFiyatHesaplamDurum
        {
            public const string Hesaplandi = "hesaplandi";
            public const string Hesaplanmadi = "hesaplanmadi";
        }

        public struct MarjYontemi
        {
            public const string Oransal = "oransal";
            public const string Miktar = "miktar"; 
            public const string Original = "orijinal";
        }
        
        public struct IslemTuru
        {
            public const string Alis = "alis";
            public const string Satis = "satis"; 
        }

        public struct Kaynaklar
        {
            public const string Saglamoglu = "saglamoglu"; 
            public const string Harem = "harem"; 
        }

        public struct TabelaSablonlari
        {
            public const string Sablon1 = "sablon1";
            public const string Sablon2 = "sablon2";
            public const string Sablon3 = "sablon3";
            public const string Sablon4 = "sablon4";
        }
        public struct MizanpajIcerikTuru
        {
            public static readonly string Gorsel = "gorsel";
            public static readonly string Metin = "metin"; 
        }
        public struct SablonDesenleri
        {
            public const string Sablon1 = @"<div class=""row ##ROWTYPE##"">
       <div class=""colx-6 urunAdi""> ##ADI##</div>
       <div class=""colx-3 alis-deger""> ##ALIS## </div>
       <div class=""colx-3 satis-deger"">##SATIS## </div>
   </div>";
            public const string Sablon2 = @"<div class=""row ##ROWTYPE##"">
       <div class=""colx-6 urunAdi""> ##ADI##</div>
       <div class=""colx-3 alis-deger""> ##ALIS## </div>
       <div class=""colx-3 satis-deger"">##SATIS## </div>
   </div>";
            public const string Sablon3 = @"<div class=""row ##ROWTYPE##"">
       <div class=""colx-6 urunAdi""> ##ADI##</div>
       <div class=""colx-3 alis-deger""> ##ALIS## </div>
       <div class=""colx-3 satis-deger"">##SATIS## </div>
   </div>"; 
            
           public const string Sablon4 = @"<div class=""row row-flex ##ROWTYPE##"">
       <div class=""colx-6 urunAdi""> ##ADI##</div>
       <div class=""colx-3 alis-deger""> ##ALIS## </div>
       <div class=""colx-3 satis-deger"">##SATIS## </div>
   </div>";
        }


       
    }

    
    }
