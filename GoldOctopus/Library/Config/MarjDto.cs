using System;
using Newtonsoft.Json;

namespace GoldOctopus.Library.Config    
{
    [Serializable]
    public class MarjDto
    {         

        [JsonProperty("tur")]
        public string Tur { get; set; } = Constants.MarjYontemi.Original; 

        [JsonProperty("oransalDeger")]
        public decimal OransalDeger { get; set; } = 0;

        [JsonProperty("miktarDeger")]
        public decimal MiktarDeger { get; set; } = 0;

    }


    public class MarjWrapperDto
    {
        public MarjWrapperDto(MarjDto marjDto)
        {
            if (marjDto != null)
            {
                OrijinalAktif = marjDto.Tur == Constants.MarjYontemi.Original;
                OransalAktif = marjDto.Tur == Constants.MarjYontemi.Oransal;
                MiktarAktif = marjDto.Tur == Constants.MarjYontemi.Miktar;
            }
            OransalDeger = marjDto.OransalDeger; ;
            MiktarDeger = marjDto.MiktarDeger;
        }

        public MarjDto GetMarDto()
        {
            MarjDto marjDto = new MarjDto();
            if (OrijinalAktif)
                marjDto.Tur = Constants.MarjYontemi.Original;
            else if (OransalAktif)
                marjDto.Tur = Constants.MarjYontemi.Oransal;
            else if (MiktarAktif)
                marjDto.Tur = Constants.MarjYontemi.Miktar;

            marjDto.OransalDeger =OransalDeger;
            marjDto.MiktarDeger = MiktarDeger;

            return marjDto;
        }



        public decimal OransalDeger { get; set; } = 0;      
        public decimal MiktarDeger { get; set; } = 0;    
        public bool OransalAktif { get; set; } = false; 
        public bool MiktarAktif { get; set; } = false;
        public bool OrijinalAktif { get; set; } = true;

    }

}
