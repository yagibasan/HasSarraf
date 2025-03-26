using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace HasSarraf.BackOffice.Library
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
            public static readonly string ApplicationRoot = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            public static readonly string DataPath = Path.Combine(ApplicationRoot, "Data"); 
            public static readonly string AssetsPath = Path.Combine(ApplicationRoot, "Assets"); 
            public static readonly string TemplatePath = Path.Combine(ApplicationRoot, "Assets","template"); 
            public static readonly string ApplicationVersion = Assembly.GetEntryAssembly().GetName().Version.ToString().Replace(".", string.Empty);
             public static readonly string ChromeAppKey = @"\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe";

        }

        public struct FileNames
        {
            public static readonly string Config = "config.json"; 
            public static readonly string TabelaFiyat = "TabelaFiyat.json";  
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
            public const string Manuel = "manuel";
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

        public struct SablonDesenleri
        {
            public const string Sablon1 = @"<div class=""row ##ROWTYPE##"">
       <div class=""col-6 urunAdi""> ##ADI##</div>
       <div class=""col-3 alis-deger""> ##ALIS## </div>
       <div class=""col-3 satis-deger"">##SATIS## </div>
   </div>";
            public const string Sablon2 = @"<div class=""row ##ROWTYPE##"">
       <div class=""col-6 urunAdi""> ##ADI##</div>
       <div class=""col-3 alis-deger""> ##ALIS## </div>
       <div class=""col-3 satis-deger"">##SATIS## </div>
   </div>";
            public const string Sablon3 = @"<div class=""row ##ROWTYPE##"">
       <div class=""col-6 urunAdi""> ##ADI##</div>
       <div class=""col-3 alis-deger""> ##ALIS## </div>
       <div class=""col-3 satis-deger"">##SATIS## </div>
   </div>"; 
            
           public const string Sablon4 = @"<div class=""row row-flex ##ROWTYPE##"">
       <div class=""col-6 urunAdi""> ##ADI##</div>
       <div class=""col-3 alis-deger""> ##ALIS## </div>
       <div class=""col-3 satis-deger"">##SATIS## </div>
   </div>";
        }


       
    }

    
    }
