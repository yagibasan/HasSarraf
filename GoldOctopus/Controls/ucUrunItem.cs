using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GoldOctopus.Business;
using GoldOctopus.Library;
using GoldOctopus.Library.Config;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Controls
{
    public partial class ucUrunItem : DevExpress.XtraEditors.XtraUserControl
    {


        public TabelaFiyatDto TabelaFiyat;

        public ucUrunItem(TabelaFiyatDto dto)
        {
            InitializeComponent();

            TabelaFiyat = dto;
            if (TabelaFiyat == null) return;

            txtUrunAdi.DataBindings.Add(new Binding("EditValue", TabelaFiyat.Urun, "Adi", true, DataSourceUpdateMode.OnPropertyChanged));
            
            lblOrijinalAlisFiyati.DataBindings.Add(new Binding("Text", TabelaFiyat, "AlisOrijinalText", true, DataSourceUpdateMode.OnPropertyChanged));
            lblFarkAlis.DataBindings.Add(new Binding("Text", TabelaFiyat, "FarkAlisText", true, DataSourceUpdateMode.OnPropertyChanged));

            spinEditAlis.DataBindings.Clear();
            spinEditAlis.EditValue = TabelaFiyat.AlisTabela;
            spinEditAlis.DataBindings.Add(new Binding("EditValue", TabelaFiyat, "AlisTabela", true, DataSourceUpdateMode.OnPropertyChanged));


            lblOrijinalSatisFiyati.DataBindings.Add(new Binding("Text", TabelaFiyat, "SatisOrijinalText", true, DataSourceUpdateMode.OnPropertyChanged));
            lblFarkSatis.DataBindings.Add(new Binding("Text", TabelaFiyat, "FarkSatisText", true, DataSourceUpdateMode.OnPropertyChanged));

            spinEditSatis.DataBindings.Clear();
            spinEditSatis.EditValue = TabelaFiyat.SatisTabela;
            spinEditSatis.DataBindings.Add(new Binding("EditValue", TabelaFiyat, "SatisTabela", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        public TabelaFiyatDto GetData()
        {
            TabelaFiyat.AlisOrijinal = spinEditAlis.Value;
            TabelaFiyat.SatisOrijinal = spinEditSatis.Value;
            TabelaFiyat.Urun.AlisMarjYontemi = new MarjDto() { Tur = MarjYontemi.Original };
            TabelaFiyat.Urun.SatisMarjYontemi = new MarjDto() { Tur = MarjYontemi.Original };

            TabelaFiyat.AlisTabela = spinEditAlis.Value;
            TabelaFiyat.SatisTabela = spinEditSatis.Value;
            TabelaFiyat.Urun.Adi = txtUrunAdi.Text.Trim();
            TabelaFiyat.Urun.Sira = TabelaFiyat.Sira;
            TabelaFiyat.Sira = TabelaFiyat.Sira;

            UtilBL.Hesapla(TabelaFiyat);

            return TabelaFiyat;
        }

       
    }
}
