using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GoldOctopus.Business;
using GoldOctopus.Library;
using GoldOctopus.Library.Config;

namespace GoldOctopus.Forms
{
    public partial class frmMarjYontemi : DevExpress.XtraEditors.XtraForm
    {
        public MarjWrapperDto MarjItemAlis { get; set; }
        public MarjWrapperDto MarjItemSatis { get; set; }

        public UrunDto UrunDto { get; set; }    
        public frmMarjYontemi(UrunDto urun)
        {
            InitializeComponent();
            UrunDto = urun;
            MarjItemAlis = new MarjWrapperDto(urun.AlisMarjYontemi);
            MarjItemSatis = new MarjWrapperDto(urun.SatisMarjYontemi);


            labelUrunAdi.DataBindings.Add(new Binding("Text", urun, "Adi", true, DataSourceUpdateMode.OnPropertyChanged));

            chkOrijinalAlis.DataBindings.Clear();
            chkOrijinalAlis.EditValue = MarjItemAlis.OrijinalAktif;
            chkOrijinalAlis.DataBindings.Add(new Binding("EditValue", MarjItemAlis, "OrijinalAktif", true, DataSourceUpdateMode.OnPropertyChanged));

            chkMiktarAlis.DataBindings.Clear();
            chkMiktarAlis.EditValue = MarjItemAlis.MiktarAktif;
            chkMiktarAlis.DataBindings.Add(new Binding("EditValue", MarjItemAlis, "MiktarAktif", true, DataSourceUpdateMode.OnPropertyChanged));

            chkOransalAlis.DataBindings.Clear();
            chkOransalAlis.EditValue = MarjItemAlis.OransalAktif;
            chkOransalAlis.DataBindings.Add(new Binding("EditValue", MarjItemAlis, "OransalAktif", true, DataSourceUpdateMode.OnPropertyChanged));

            chkOrijinalSatis.DataBindings.Clear();
            chkOrijinalSatis.EditValue = MarjItemSatis.OrijinalAktif;
            chkOrijinalSatis.DataBindings.Add(new Binding("EditValue", MarjItemSatis, "OrijinalAktif", true, DataSourceUpdateMode.OnPropertyChanged));

            chkMiktarSatis.DataBindings.Clear();
            chkMiktarSatis.EditValue = MarjItemSatis.MiktarAktif;
            chkMiktarSatis.DataBindings.Add(new Binding("EditValue", MarjItemSatis, "MiktarAktif", true, DataSourceUpdateMode.OnPropertyChanged));

            chkOransalSatis.DataBindings.Clear();
            chkOransalSatis.EditValue = MarjItemSatis.OransalAktif;
            chkOransalSatis.DataBindings.Add(new Binding("EditValue", MarjItemSatis, "OransalAktif", true, DataSourceUpdateMode.OnPropertyChanged));
            
            spinMiktarAlis.Enabled = MarjItemAlis.MiktarAktif;
            spinMiktarAlis.DataBindings.Add(new Binding("Enabled", MarjItemAlis, "MiktarAktif", true, DataSourceUpdateMode.OnPropertyChanged));

            spinOransalDegerAlis.Enabled = MarjItemAlis.OransalAktif;
            spinOransalDegerAlis.DataBindings.Add(new Binding("Enabled", MarjItemAlis, "OransalAktif", true, DataSourceUpdateMode.OnPropertyChanged));

            spinMiktarSatis.Enabled = MarjItemSatis.MiktarAktif;
            spinMiktarSatis.DataBindings.Add(new Binding("Enabled", MarjItemSatis, "MiktarAktif", true, DataSourceUpdateMode.OnPropertyChanged));

            spinOransalDegerSatis.Enabled = MarjItemSatis.OransalAktif;
            spinOransalDegerSatis.DataBindings.Add(new Binding("Enabled", MarjItemSatis, "OransalAktif", true, DataSourceUpdateMode.OnPropertyChanged));


            spinMiktarAlis.EditValue = MarjItemAlis.MiktarDeger;
            spinMiktarAlis.DataBindings.Add(new Binding("EditValue", MarjItemAlis, "MiktarDeger", true, DataSourceUpdateMode.OnPropertyChanged));

            spinOransalDegerAlis.EditValue = MarjItemAlis.OransalDeger;
            spinOransalDegerAlis.DataBindings.Add(new Binding("EditValue", MarjItemAlis, "OransalDeger", true, DataSourceUpdateMode.OnPropertyChanged));

            spinMiktarSatis.EditValue = MarjItemSatis.MiktarDeger;
            spinMiktarSatis.DataBindings.Add(new Binding("EditValue", MarjItemSatis, "MiktarDeger", true, DataSourceUpdateMode.OnPropertyChanged));

            spinOransalDegerSatis.EditValue = MarjItemSatis.OransalDeger;
            spinOransalDegerSatis.DataBindings.Add(new Binding("EditValue", MarjItemSatis, "OransalDeger", true, DataSourceUpdateMode.OnPropertyChanged));


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var originalUrun = UtilBL.Urunler.FirstOrDefault(p => p.UrunKod == UrunDto.UrunKod);
            originalUrun.AlisMarjYontemi = MarjItemAlis.GetMarDto();
            originalUrun.SatisMarjYontemi = MarjItemSatis.GetMarDto();
            UtilBL.KaydetConfig(UtilBL.Urunler, Constants.FileNames.Urun);
            Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            UtilBL.ReadConfig();
            Close();
        }
    }
}