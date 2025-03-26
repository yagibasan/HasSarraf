using System;
using System.Windows.Forms;
using HasSarraf.BackOffice.Business;
using HasSarraf.BackOffice.Library;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Forms
{
    public partial class frmAyarlar : DevExpress.XtraEditors.DirectXForm
    {
        AyarDto Ayarlar = UtilBL.HasConfig.Ayarlar;
        public static event EventHandler AyarlarDegistirildi;

        public frmAyarlar()
        {
            InitializeComponent();

            radioKaynak.DataBindings.Clear();
            radioKaynak.EditValue = Ayarlar.Kaynak;
            radioKaynak.DataBindings.Add(new Binding("EditValue", Ayarlar, "Kaynak", true, DataSourceUpdateMode.OnPropertyChanged));

            spinGuncellemePeriyodu.DataBindings.Clear();
            spinGuncellemePeriyodu.EditValue = Ayarlar.GuncellemePeriyodu;
            spinGuncellemePeriyodu.DataBindings.Add(new Binding("EditValue", Ayarlar, "GuncellemePeriyodu", true, DataSourceUpdateMode.OnPropertyChanged));


            checkKorumaModu.DataBindings.Clear();
            checkKorumaModu.EditValue = Ayarlar.KorumaModu;
            checkKorumaModu.DataBindings.Add(new Binding("EditValue", Ayarlar, "KorumaModu", true, DataSourceUpdateMode.OnPropertyChanged));

            spinKorumaOrani.DataBindings.Clear();
            spinKorumaOrani.EditValue = Ayarlar.KorumaOrani;
            spinKorumaOrani.DataBindings.Add(new Binding("EditValue", Ayarlar, "KorumaOrani", true, DataSourceUpdateMode.OnPropertyChanged));

            spinKorumaOrani.Enabled = Ayarlar.KorumaModu;
            spinKorumaOrani.DataBindings.Add(new Binding("Enabled", Ayarlar, "KorumaModu", true, DataSourceUpdateMode.OnPropertyChanged));


            checkSarrafiyeOndalikGoster.DataBindings.Clear();
            checkSarrafiyeOndalikGoster.EditValue = Ayarlar.SarrafiyeOndalikGoster;
            checkSarrafiyeOndalikGoster.DataBindings.Add(new Binding("EditValue", Ayarlar, "SarrafiyeOndalikGoster", true, DataSourceUpdateMode.OnPropertyChanged));

            checkMilyem.DataBindings.Clear();
            checkMilyem.EditValue = Ayarlar.MilyemGoster;
            checkMilyem.DataBindings.Add(new Binding("EditValue", Ayarlar, "MilyemGoster", true, DataSourceUpdateMode.OnPropertyChanged));

            spinSarrafiyeOndalikAdeti.DataBindings.Clear();
            spinSarrafiyeOndalikAdeti.EditValue = Ayarlar.SarrafiyeOndalikAdeti;
            spinSarrafiyeOndalikAdeti.DataBindings.Add(new Binding("EditValue", Ayarlar, "SarrafiyeOndalikAdeti", true, DataSourceUpdateMode.OnPropertyChanged));

            spinSarrafiyeOndalikAdeti.Enabled = Ayarlar.SarrafiyeOndalikGoster;
            spinSarrafiyeOndalikAdeti.DataBindings.Add(new Binding("Enabled", Ayarlar, "SarrafiyeOndalikGoster", true, DataSourceUpdateMode.OnPropertyChanged));


            checkDovizOndalikGoster.DataBindings.Clear();
            checkDovizOndalikGoster.EditValue = Ayarlar.DovizOndalikGoster;
            checkDovizOndalikGoster.DataBindings.Add(new Binding("EditValue", Ayarlar, "DovizOndalikGoster", true, DataSourceUpdateMode.OnPropertyChanged));

            spinDovizOndalikAdet.DataBindings.Clear();
            spinDovizOndalikAdet.EditValue = Ayarlar.DovizOndalikAdeti;
            spinDovizOndalikAdet.DataBindings.Add(new Binding("EditValue", Ayarlar, "DovizOndalikAdeti", true, DataSourceUpdateMode.OnPropertyChanged));

            spinDovizOndalikAdet.Enabled = Ayarlar.DovizOndalikGoster;
            spinDovizOndalikAdet.DataBindings.Add(new Binding("Enabled", Ayarlar, "DovizOndalikGoster", true, DataSourceUpdateMode.OnPropertyChanged));


            radioSablon.DataBindings.Clear();
            radioSablon.EditValue = Ayarlar.TabelaSablonu;
            radioSablon.DataBindings.Add(new Binding("EditValue", Ayarlar, "TabelaSablonu", true, DataSourceUpdateMode.OnPropertyChanged));


            pictureSablon1.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon1;
            pictureSablon2.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon2;
            pictureSablon3.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon3;
            pictureSablon4.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon4;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UtilBL.SaveAyarlar();
            AyarlarDegistirildi?.Invoke(this, null);
            Close();
        }

        private void radioSablon_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureSablon1.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon1;
            pictureSablon2.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon2;
            pictureSablon3.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon3;
            pictureSablon4.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon4;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            UtilBL.ReadConfig();
            Close();
        }
    }
}