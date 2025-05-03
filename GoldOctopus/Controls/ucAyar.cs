using System;
using System.Windows.Forms;
using GoldOctopus.Business;
using GoldOctopus.Library.Config;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Controls
{
    public partial class ucAyar : DevExpress.XtraEditors.XtraUserControl
    {
        AyarDto Ayarlar = UtilBL.Ayarlar;
        public static event EventHandler AyarlarDegistirildi;
        public ucAyar()
        {
            InitializeComponent();
        }

        public void Bind()
        {
            chkOtomatikVeriAl.DataBindings.Clear();
            chkOtomatikVeriAl.EditValue = Ayarlar.OtomatikVeriAl;
            chkOtomatikVeriAl.DataBindings.Add(new Binding("EditValue", Ayarlar, "OtomatikVeriAl", true, DataSourceUpdateMode.OnPropertyChanged));

            radioKaynak.DataBindings.Clear();
            radioKaynak.EditValue = Ayarlar.Kaynak;
            radioKaynak.DataBindings.Add(new Binding("EditValue", Ayarlar, "Kaynak", true, DataSourceUpdateMode.OnPropertyChanged));

            spinGuncellemePeriyodu.DataBindings.Clear();
            spinGuncellemePeriyodu.EditValue = Ayarlar.GuncellemePeriyodu;
            spinGuncellemePeriyodu.DataBindings.Add(new Binding("EditValue", Ayarlar, "GuncellemePeriyodu", true, DataSourceUpdateMode.OnPropertyChanged));

            spinUrunAdeti.DataBindings.Clear();
            spinUrunAdeti.EditValue = Ayarlar.GosterilecekUrunAdeti;
            spinUrunAdeti.DataBindings.Add(new Binding("EditValue", Ayarlar, "GosterilecekUrunAdeti", true, DataSourceUpdateMode.OnPropertyChanged));


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

            checkOrijinalDeger.DataBindings.Clear();
            checkOrijinalDeger.EditValue = Ayarlar.OrijinalDegeriGoster;
            checkOrijinalDeger.DataBindings.Add(new Binding("EditValue", Ayarlar, "OrijinalDegeriGoster", true, DataSourceUpdateMode.OnPropertyChanged));

            checkFarkDeger.DataBindings.Clear();
            checkFarkDeger.EditValue = Ayarlar.FarkDegeriniGoster;
            checkFarkDeger.DataBindings.Add(new Binding("EditValue", Ayarlar, "FarkDegeriniGoster", true, DataSourceUpdateMode.OnPropertyChanged));

            spinDovizOndalikAdet.DataBindings.Clear();
            spinDovizOndalikAdet.EditValue = Ayarlar.DovizOndalikAdeti;
            spinDovizOndalikAdet.DataBindings.Add(new Binding("EditValue", Ayarlar, "DovizOndalikAdeti", true, DataSourceUpdateMode.OnPropertyChanged));

            spinDovizOndalikAdet.Enabled = Ayarlar.DovizOndalikGoster;
            spinDovizOndalikAdet.DataBindings.Add(new Binding("Enabled", Ayarlar, "DovizOndalikGoster", true, DataSourceUpdateMode.OnPropertyChanged));

            checkButton1.Checked = pictureSablon1.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon1;
            checkButton2.Checked = pictureSablon2.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon2;
            checkButton3.Checked = pictureSablon3.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon3;
            checkButton4.Checked = pictureSablon4.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon4;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UtilBL.KaydetConfig(Ayarlar, FileNames.Ayar);
            AyarlarDegistirildi?.Invoke(this, null);
            Program.mainForm.navigationPanel.SelectedPageIndex = 0;

        }

        private void radioSablon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ayarlar.TabelaSablonu = ((Control)sender).Tag.ToString();

            pictureSablon1.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon1;
            pictureSablon2.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon2;
            pictureSablon3.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon3;
            pictureSablon4.Enabled = Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon4;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            UtilBL.ReadConfig(); 
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }
    }
}
