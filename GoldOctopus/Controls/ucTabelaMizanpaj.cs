using DevExpress.XtraEditors;
using GoldOctopus.Business;
using GoldOctopus.Library;
using System;
using System.Linq;
using System.Windows.Forms;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Controls
{
    public partial class ucTabelaMizanpaj : DevExpress.XtraEditors.XtraUserControl
    {
        private int xpos = 10, ypos = 20;
        public string mode = "Left-to-Right";
        public ucTabelaMizanpaj()
        {
            InitializeComponent();

            xtraTabControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            xtraTabControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            xtraTabControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }

        public void Bind()
        {
            chkSA.DataBindings.Clear();
            checkSASol.DataBindings.Clear();
            spinSAYukseklik.DataBindings.Clear();
            radioSATur.DataBindings.Clear();
            txtSAIcerik.DataBindings.Clear();
            colorSAArkaPlan.DataBindings.Clear();
            txtSAFont.DataBindings.Clear();
            colorSAYaziRengi.DataBindings.Clear();
            lblSAOnizleme.DataBindings.Clear();
            gcSerbestAlan.DataBindings.Clear();
            lblSerbestAlan.DataBindings.Clear();


            chkSA.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.SerbestAlan, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            checkSASol.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.SerbestAlan, "SolaYasli", true, DataSourceUpdateMode.OnPropertyChanged));
            spinSAYukseklik.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.SerbestAlan, "Yukseklik", true, DataSourceUpdateMode.OnPropertyChanged));
            radioSATur.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.SerbestAlan, "IcerikTuru", true, DataSourceUpdateMode.OnPropertyChanged));
            txtSAIcerik.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.SerbestAlan, "Icerik", true, DataSourceUpdateMode.OnPropertyChanged));
            colorSAArkaPlan.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.SerbestAlan, "ArkaPlanRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            colorSAYaziRengi.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.SerbestAlan, "YaziRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            txtSAFont.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.SerbestAlan, "Font", true, DataSourceUpdateMode.OnPropertyChanged));

            spinSAYukseklik.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.SerbestAlan, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            radioSATur.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.SerbestAlan, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            txtSAIcerik.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.SerbestAlan, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            colorSAArkaPlan.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.SerbestAlan, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            colorSAYaziRengi.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.SerbestAlan, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            txtSAFont.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.SerbestAlan, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            checkSASol.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.SerbestAlan, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));

            lblSAOnizleme.DataBindings.Add(new Binding("Height", UtilBL.Mizanpaj.SerbestAlan, "Yukseklik", true, DataSourceUpdateMode.OnPropertyChanged));
            lblSAOnizleme.DataBindings.Add(new Binding("BackColor", UtilBL.Mizanpaj.SerbestAlan, "ArkaPlanRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            lblSAOnizleme.DataBindings.Add(new Binding("ForeColor", UtilBL.Mizanpaj.SerbestAlan, "YaziRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            lblSAOnizleme.DataBindings.Add(new Binding("Font", UtilBL.Mizanpaj.SerbestAlan, "Font", true, DataSourceUpdateMode.OnPropertyChanged));
            lblSAOnizleme.DataBindings.Add(new Binding("Text", UtilBL.Mizanpaj.SerbestAlan, "Icerik", true, DataSourceUpdateMode.OnPropertyChanged));
            var bindingSolaYasli = new Binding("TextAlign", UtilBL.Mizanpaj.SerbestAlan, "SolaYasli", true, DataSourceUpdateMode.OnPropertyChanged);

            bindingSolaYasli.Format += (s, e) =>
            {
                if (e.Value is bool leftSide)
                {
                    e.Value = leftSide ? System.Drawing.ContentAlignment.MiddleLeft : System.Drawing.ContentAlignment.MiddleCenter;
                }
            };

            lblSAOnizleme.DataBindings.Add(bindingSolaYasli);

            gcSerbestAlan.DataBindings.Add(new Binding("Visible", UtilBL.Mizanpaj.SerbestAlan, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            gcSerbestAlan.DataBindings.Add(new Binding("Height", UtilBL.Mizanpaj.SerbestAlan, "Yukseklik", true, DataSourceUpdateMode.OnPropertyChanged));
            lblSerbestAlan.DataBindings.Add(new Binding("Text", UtilBL.Mizanpaj.SerbestAlan, "Icerik", true, DataSourceUpdateMode.OnPropertyChanged));


            /*KAYAN YAZİ*/

            chkKY.DataBindings.Clear();
            spinKYYukseklik.DataBindings.Clear();
            txtKYIcerik.DataBindings.Clear();
            colorKYArkaPlan.DataBindings.Clear();
            txtKYFont.DataBindings.Clear();
            colorKYYaziRengi.DataBindings.Clear();
            lblKYOnIzleme.DataBindings.Clear();
            gcKayanYazi.DataBindings.Clear();
            lblKayanYazi.DataBindings.Clear();
            trackBarKYHizi.DataBindings.Clear();



            chkKY.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.KayanYazi, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            spinKYYukseklik.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.KayanYazi, "Yukseklik", true, DataSourceUpdateMode.OnPropertyChanged));
            txtKYIcerik.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.KayanYazi, "Icerik", true, DataSourceUpdateMode.OnPropertyChanged));
            colorKYArkaPlan.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.KayanYazi, "ArkaPlanRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            colorKYYaziRengi.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.KayanYazi, "YaziRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            txtKYFont.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.KayanYazi, "Font", true, DataSourceUpdateMode.OnPropertyChanged));
            trackBarKYHizi.DataBindings.Add(new Binding("EditValue", UtilBL.Mizanpaj.KayanYazi, "KayanYaziHizi", true, DataSourceUpdateMode.OnPropertyChanged));

            spinKYYukseklik.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.KayanYazi, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            txtKYIcerik.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.KayanYazi, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            colorKYArkaPlan.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.KayanYazi, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            colorKYYaziRengi.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.KayanYazi, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            txtKYFont.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.KayanYazi, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            trackBarKYHizi.DataBindings.Add(new Binding("Enabled", UtilBL.Mizanpaj.KayanYazi, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));

            lblKYOnIzleme.DataBindings.Add(new Binding("Height", UtilBL.Mizanpaj.KayanYazi, "Yukseklik", true, DataSourceUpdateMode.OnPropertyChanged));
            lblKYOnIzleme.DataBindings.Add(new Binding("BackColor", UtilBL.Mizanpaj.KayanYazi, "ArkaPlanRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            lblKYOnIzleme.DataBindings.Add(new Binding("ForeColor", UtilBL.Mizanpaj.KayanYazi, "YaziRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            lblKYOnIzleme.DataBindings.Add(new Binding("Font", UtilBL.Mizanpaj.KayanYazi, "Font", true, DataSourceUpdateMode.OnPropertyChanged));
            lblKYOnIzleme.DataBindings.Add(new Binding("Text", UtilBL.Mizanpaj.KayanYazi, "Icerik", true, DataSourceUpdateMode.OnPropertyChanged));


            gcKayanYazi.DataBindings.Add(new Binding("Visible", UtilBL.Mizanpaj.KayanYazi, "Aktif", true, DataSourceUpdateMode.OnPropertyChanged));
            gcKayanYazi.DataBindings.Add(new Binding("Height", UtilBL.Mizanpaj.KayanYazi, "Yukseklik", true, DataSourceUpdateMode.OnPropertyChanged));
            lblKayanYazi.DataBindings.Add(new Binding("Text", UtilBL.Mizanpaj.KayanYazi, "Icerik", true, DataSourceUpdateMode.OnPropertyChanged));


            listBoxSA.DataSource = UtilBL.SerbestAlanIcerikleri;
            listBoxSA.DisplayMember = "KayitAdi";
            listBoxSA.ValueMember = "KayitAdi";

            listBoxKY.DataSource = UtilBL.KayanYaziIcerikleri;
            listBoxKY.DisplayMember = "KayitAdi";
            listBoxKY.ValueMember = "KayitAdi";

            if(chkKY.Checked)
            {
                timer1.Interval = 5 * UtilBL.Mizanpaj.KayanYazi.KayanYaziHizi;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                lblKYOnIzleme.Location = new System.Drawing.Point(20, ypos);
                xpos = 20;
            }   
           
        }





        private void listBoxControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, System.EventArgs e)
        {
            UtilBL.KaydetConfig(UtilBL.Mizanpaj, FileNames.Mizanpaj);
        }

        private void txtSAFont_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSAFont.EditValue = fontDialog1.Font;
            }
        }

        private void txtKYFont_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtKYFont.EditValue = fontDialog1.Font;
            }
        }

        private void gcSAList_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            string islem = e.Button.Properties.Tag.ToString();

            switch (islem)
            {
                case "kaydet":
                    listeKaydet(FileNames.SerbestAlan);
                    break;
                case "sil":
                    listeSil(FileNames.SerbestAlan);
                    break;
                case "yenile":
                    listeYenile();
                    break;
                default:
                    break;
            }
        }

        private void gcKYList_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            string islem = e.Button.Properties.Tag.ToString();

            switch (islem)
            {
                case "kaydet":
                    listeKaydet(FileNames.KayanYazi);
                    break;
                case "sil":
                    listeSil(FileNames.KayanYazi);
                    break;
                case "yenile":
                    listeYenile();
                    break;
                default:
                    break;
            }
        }

        void listeKaydet(string file)
        {
            if (file == FileNames.SerbestAlan)
            {

                string kayitAdi = XtraInputBox.Show("Serbest alanı kaydetmek için kayıt adı giriniz", "Kayıt İşlemi", UtilBL.Mizanpaj.SerbestAlan.KayitAdi);
                if (kayitAdi != null)
                {

                    MizanpajDetailDto item = new MizanpajDetailDto();

                    item.KayitAdi = kayitAdi;
                    item.IcerikTuru = MizanpajIcerikTuru.Metin;
                    item.Aktif = chkSA.Checked;
                    item.ArkaPlanRengi = colorSAArkaPlan.Color;
                    item.Font = txtSAFont.Font;
                    item.Icerik = txtSAIcerik.Text.Trim();
                    item.SolaYasli = checkSASol.Checked;
                    item.Yukseklik = (int)spinKYYukseklik.Value;
                    item.YaziRengi = colorSAYaziRengi.Color;

                    var isExistItem = UtilBL.SerbestAlanIcerikleri.Where(p => p.KayitAdi == kayitAdi).FirstOrDefault();

                    if (isExistItem == null)
                        UtilBL.SerbestAlanIcerikleri.Add(item);
                    else
                        isExistItem = item;

                    UtilBL.KaydetConfig(UtilBL.SerbestAlanIcerikleri, file);
                    listBoxSA.DataSource = UtilBL.SerbestAlanIcerikleri;
                }

            }
            else if (file == FileNames.KayanYazi)
            {

                string kayitAdi = XtraInputBox.Show("Kayan yazıyı kaydetmek için kayıt adı giriniz", "Kayıt İşlemi", UtilBL.Mizanpaj.KayanYazi.KayitAdi);
                if (kayitAdi != null)
                {

                    MizanpajDetailDto item = new MizanpajDetailDto();

                    item.KayitAdi = kayitAdi;
                    item.IcerikTuru = MizanpajIcerikTuru.Metin;
                    item.Aktif = chkKY.Checked;
                    item.ArkaPlanRengi = colorKYArkaPlan.Color;
                    item.Font = txtKYFont.Font;
                    item.Icerik = txtKYIcerik.Text.Trim();
                    item.KayanYaziHizi = trackBarKYHizi.Value;
                    item.Yukseklik = (int)spinKYYukseklik.Value;
                    item.YaziRengi = colorKYYaziRengi.Color;

                    var isExistItem = UtilBL.KayanYaziIcerikleri.Where(p => p.KayitAdi == kayitAdi).FirstOrDefault();

                    if (isExistItem == null)
                        UtilBL.KayanYaziIcerikleri.Add(item);
                    else
                        isExistItem = item;

                    UtilBL.KaydetConfig(UtilBL.KayanYaziIcerikleri, file);
                    listBoxKY.DataSource = UtilBL.KayanYaziIcerikleri;
                }

            }
        }

        void listeSil(string file)
        {
            if (file == FileNames.SerbestAlan)
            {
                if (listBoxSA.SelectedItem != null)
                {
                    string kayitAdi = listBoxSA.SelectedValue?.ToString();
                    var isExistItem = UtilBL.SerbestAlanIcerikleri.Where(p => p.KayitAdi == kayitAdi).FirstOrDefault();
                    if (isExistItem != null)
                    {
                        UtilBL.SerbestAlanIcerikleri.Remove(isExistItem);
                        UtilBL.KaydetConfig(UtilBL.SerbestAlanIcerikleri, file);
                        listBoxSA.DataSource = UtilBL.SerbestAlanIcerikleri;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Silmek için bir kayıt seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (file == FileNames.KayanYazi)
            {
                if (listBoxKY.SelectedItem != null)
                {
                    string kayitAdi = listBoxKY.SelectedValue?.ToString();
                    var isExistItem = UtilBL.KayanYaziIcerikleri.Where(p => p.KayitAdi == kayitAdi).FirstOrDefault();
                    if (isExistItem != null)
                    {
                        UtilBL.KayanYaziIcerikleri.Remove(isExistItem);
                        UtilBL.KaydetConfig(UtilBL.KayanYaziIcerikleri, file);
                        listBoxKY.DataSource = UtilBL.KayanYaziIcerikleri;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Silmek için bir kayıt seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void listeYenile()
        {

            UtilBL.ReadConfig();
            listBoxSA.DataSource = UtilBL.SerbestAlanIcerikleri;
            listBoxSA.DisplayMember = "KayitAdi";
            listBoxSA.ValueMember = "KayitAdi";

            listBoxKY.DataSource = UtilBL.KayanYaziIcerikleri;
            listBoxKY.DisplayMember = "KayitAdi";
            listBoxKY.ValueMember = "KayitAdi";

        }

        private void listBoxSA_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBoxSA.SelectedItem != null)
            {
                UtilBL.Mizanpaj.SerbestAlan = listBoxSA.SelectedItem as MizanpajDetailDto;
                Bind();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.groupControl2.Width == xpos)
            {
                lblKYOnIzleme.Location = new System.Drawing.Point(10, ypos);
                xpos = 0;
            }
            else
            {
                lblKYOnIzleme.Location = new System.Drawing.Point(xpos, ypos);
                xpos -= 2;
            }

            if (xpos < -(lblKYOnIzleme.Width))
            {
                lblKYOnIzleme.Location = new System.Drawing.Point(5 + lblKYOnIzleme.Width, ypos);
                xpos = lblKYOnIzleme.Location.X;
                ypos = lblKYOnIzleme.Location.Y;
            }
        }

        private void trackBarKYHizi_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBarKYHizi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
          
            timer1.Interval = 5 * (int)e.NewValue;
            UtilBL.Mizanpaj.KayanYazi.KayanYaziHizi = (int)e.NewValue;
            
        }

        private void chkKY_EditValueChanged(object sender, EventArgs e)
        {
            if (chkKY.Checked)
            {
                lblKYOnIzleme.Location = new System.Drawing.Point(10,  20);
                timer1.Start();
            }
            else
            {
                timer1.Stop();
                lblKYOnIzleme.Location = new System.Drawing.Point(10, 20);
                xpos = 10;
                xpos = 20;
            }
        }

        private void listBoxKY_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (listBoxKY.SelectedItem != null)
            {
                UtilBL.Mizanpaj.KayanYazi = listBoxKY.SelectedItem as MizanpajDetailDto;
                Bind();
            }
        }
    }
}
