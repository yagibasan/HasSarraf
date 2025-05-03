using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Customization.Helpers;
using DevExpress.XtraGrid.Views.Tile.ViewInfo;
using DevExpress.XtraGrid.Views.Tile;
using GoldOctopus.Business;
using GoldOctopus.Library;
using static GoldOctopus.Library.Constants;
using System.Drawing;
using GoldOctopus.Forms;
using System.Diagnostics;
using System.IO;

namespace GoldOctopus.Controls
{
    public partial class ucTabela : DevExpress.XtraEditors.XtraUserControl
    {
        string currentKaynak = string.Empty;
        public ucTabela()
        {
            InitializeComponent();        
        }

        public void Bind()
        {
           
            DataProviderBL.GetInstance().TabelaFiyatlariGuncellendi += UcTabela_TabelaFiyatlariGuncellendi;
            ucAyar.AyarlarDegistirildi += UcAyar_AyarlarDegistirildi;

            SetToggleButton();
            DoldurEkran();

            s1.Visible = s2.Visible = s3.Visible = s4.Visible = !UtilBL.Ayarlar.OtomatikVeriAl;
        }

        private void UcAyar_AyarlarDegistirildi(object sender, EventArgs e)
        {
            SetToggleButton();
            DoldurEkran();

            s1.Visible = s2.Visible = s3.Visible = s4.Visible = !UtilBL.Ayarlar.OtomatikVeriAl;
        }

        void SetToggleButton()
        {
            currentKaynak = UtilBL.Ayarlar.Kaynak;

            if (UtilBL.Ayarlar.Kaynak == Kaynaklar.Harem)
                chkKaynakHarem.Checked = true;
            else
                chkKaynakSaglamoglu.Checked = true;


        }

        private void UcTabela_TabelaFiyatlariGuncellendi(object sender, List<Library.TabelaFiyatDto> e)
        {
            DoldurEkran();
        }

        void DoldurEkran(bool reCalculate =false)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    if (DataProviderBL.GUNCEL_TABELA == null)
                        return;


                    var tabelaUrunleri = UtilBL.Urunler.Where(p => p.TabeladaGoster).OrderBy(p=>p.Sira).ToList();
                    List<TabelaFiyatDto> tabelaFiyats = new List<TabelaFiyatDto>();
                    foreach (var item in tabelaUrunleri)
                    {
                        var tabelaFiyat = DataProviderBL.GUNCEL_TABELA.FirstOrDefault(p => p.Urun.UrunKod == item.UrunKod && p.Kaynak == currentKaynak);
                        if (tabelaFiyat != null)
                            tabelaFiyats.Add(tabelaFiyat);
                        else
                            tabelaFiyats.Add(new TabelaFiyatDto() { Urun = item, Kaynak = currentKaynak,Sira=item.Sira });  
                    }

                    if(reCalculate)
                        tabelaFiyats.ForEach(p => UtilBL.Hesapla(p));

                    gridTabela.DataSource = tabelaFiyats.OrderBy(p => p.Urun.Sira).ToList();  


                }));
            }
            else
            {
                if (DataProviderBL.GUNCEL_TABELA == null)
                    return;

                var tabelaUrunleri = UtilBL.Urunler.Where(p => p.TabeladaGoster).OrderBy(p => p.Sira).ToList();
                List<TabelaFiyatDto> tabelaFiyats = new List<TabelaFiyatDto>();
                foreach (var item in tabelaUrunleri)
                {
                    var tabelaFiyat = DataProviderBL.GUNCEL_TABELA.FirstOrDefault(p => p.Urun.UrunKod == item.UrunKod && p.Kaynak == currentKaynak);
                    if (tabelaFiyat != null)
                        tabelaFiyats.Add(tabelaFiyat);
                    else
                        tabelaFiyats.Add(new TabelaFiyatDto() { Urun = item, Kaynak = currentKaynak, Sira = item.Sira });
                }

                if (reCalculate)
                    tabelaFiyats.ForEach(p => UtilBL.Hesapla(p));

                gridTabela.DataSource = tabelaFiyats.OrderBy(p => p.Urun.Sira).ToList();

            }


        }
         
        private void chkKaynakSaglamoglu_Click(object sender, EventArgs e)
        {
            currentKaynak = Kaynaklar.Saglamoglu;
            DoldurEkran();
        }

        private void chkKaynakHarem_Click(object sender, EventArgs e)
        {
            currentKaynak = Kaynaklar.Harem;
            DoldurEkran();
        }

        private void tileView2_DoubleClick(object sender, EventArgs e)
        {
            TileView view = sender as TileView;

            // HitInfo ile tıklanan yeri belirle
            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            TileViewHitInfo hitInfo = view.CalcHitInfo(pt);

            if (hitInfo.InItem)
            {
                int rowHandle = hitInfo.RowHandle;

                // Row objesini al
                var rowObject = view.GetRow(rowHandle);

                // rowObject artık satıra bağlı olan objedir
                // Örneğin kendi sınıfınsa cast edebilirsin
                if (rowObject is TabelaFiyatDto myObject)
                {
                    frmMarjYontemi frm = new frmMarjYontemi(myObject.Urun);
                    frm.StartPosition = FormStartPosition.CenterScreen;  
                    frm.FormClosed += (s, x) =>
                    {
                        DoldurEkran(true);
                    };  
                    frm.ShowDialog();
                }
            }
        }
 
        private void btnDisTabela_Click(object sender, EventArgs e)
        {
            string path = System.IO.Path.Combine(Constants.App.DataPath, Constants.FileNames.DisTabelaHtml);
            if (File.Exists(path))
            {

                string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
                string url = path;
                string arguments = $"--app=\"{url}\" --disable-features=TranslateUI --user-data-dir=\"C:/Temp/ChromeTestProfile\" --window-size=375,620 --window-position=100,100";

                Process.Start(chromePath, arguments);

            }
        }

        private void btnManuelRefresh_Click(object sender, EventArgs e)
        {
            DataProviderBL.GetInstance().Refresh();
        }
    }
}
