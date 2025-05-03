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

namespace GoldOctopus.Controls
{
    public partial class ucUrunHavuzu : DevExpress.XtraEditors.XtraUserControl
    {
        CheckButton enSonSecilenIslem = new CheckButton();
        public ucUrunHavuzu()
        {
            InitializeComponent();
        }

        public void Bind()
        {
 
            if (UtilBL.Urunler != null)
            {
                buttonAdlariniDuzenle();
                chkSeciliUrunler.Checked = true;
                chkUrunSecildi(chkSeciliUrunler, null);
            }

        }

        void buttonAdlariniDuzenle()
        {
            var groupInfo = UtilBL.Urunler.Select(p => new
            {
                p.Grup,
                p.GrupAdi,
                ItemCount = UtilBL.Urunler.Count(x => x.Grup == p.Grup)
            }).Distinct().ToList();


            string seciliUrunler = string.Format("{0}{1}{2} adet", "Göstrilen Ürünler", Environment.NewLine, UtilBL.Urunler.Where(p => p.TabeladaGoster).ToList().Count);
            string tumUrunler = string.Format("{0}{1}{2} adet", "Tüm Ürünler", Environment.NewLine, UtilBL.Urunler.Count);

            chkSeciliUrunler.Text = seciliUrunler;
            chkTumUrunler.Text = tumUrunler;

            foreach (var item in groupInfo)
            {
                string grupAdi = string.Format("{0}{1}{2} adet", item.GrupAdi, Environment.NewLine, item.ItemCount);

                if (item.Grup == 1) chkSerbestPiyasaAltin.Text = grupAdi;
                else if (item.Grup == 2) chkSerbestPiyasaDoviz.Text = grupAdi;
                else if (item.Grup == 3) chkSarrafiye.Text = grupAdi;
                else if (item.Grup == 4) chkGramAltin.Text = grupAdi;
                else if (item.Grup == 5) chkSeciliUrunler.Text = grupAdi;
                else if (item.Grup == 6) chkTumUrunler.Text = grupAdi;


            }
        }

        private void chkUrunSecildi(object sender, EventArgs e)
        {
            enSonSecilenIslem = sender as CheckButton;
            int grupId = Convert.ToInt32(enSonSecilenIslem.Tag);
            if (grupId == 6)
                gridControl.DataSource = UtilBL.Urunler.OrderBy(p => p.Sira).ToList();
            else if (grupId == 5)
                gridControl.DataSource = UtilBL.Urunler.Where(p => p.TabeladaGoster).OrderBy(p => p.Sira).ToList();
            else
                gridControl.DataSource = UtilBL.Urunler.Where(p => p.Grup == grupId).OrderBy(p => p.Sira).ToList();
        }

        private void repositoryItemCheckEditGoster_EditValueChanged(object sender, EventArgs e)
        {
            gridView1.PostEditor();
            buttonAdlariniDuzenle();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Sira")
            {
                chkUrunSecildi(enSonSecilenIslem, null);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            UtilBL.Init();
            chkUrunSecildi(enSonSecilenIslem, null);
            buttonAdlariniDuzenle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            UtilBL.KaydetConfig(UtilBL.Urunler, Constants.FileNames.Urun);
        }

        private void repositoryItemCheckEditGoster_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int secilmisUrunAdet = UtilBL.Urunler.Where(p => p.TabeladaGoster).ToList().Count;
            bool secimDurumu = (bool)e.NewValue;
            int toplamSecilecekUrunAdeti = secilmisUrunAdet + (secimDurumu ? 1 : -1);
            if (toplamSecilecekUrunAdeti > UtilBL.Ayarlar.TabeladaGozukecekUrunSayisi)
            {
                e.Cancel = true;
                XtraMessageBox.Show("En fazla " + UtilBL.Ayarlar.TabeladaGozukecekUrunSayisi + " ürün seçebilirsiniz", "Uyarı", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
    }
}
