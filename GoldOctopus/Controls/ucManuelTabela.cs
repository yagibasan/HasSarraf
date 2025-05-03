using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GoldOctopus.Business;
using GoldOctopus.Library;

namespace GoldOctopus.Controls
{
    public partial class ucManuelTabela : DevExpress.XtraEditors.XtraUserControl
    {
      
        public ucManuelTabela()
        {
            InitializeComponent();
        }

        public void Bind(bool isPriceNull=false)
        {
           
            if (DataProviderBL.GUNCEL_TABELA == null)
                return;

            panel1.Controls.Clear();
            List<TabelaFiyatDto> tabelaFiyats = new List<TabelaFiyatDto>();
            var tabelaUrunleri = UtilBL.Urunler.Where(p => p.TabeladaGoster).OrderByDescending(p => p.Sira).ToList();
            tabelaFiyats.Clear();
            foreach (var item in tabelaUrunleri)
            {
                TabelaFiyatDto tabelaFiyat = null;

                if (!isPriceNull)
                {
                    tabelaFiyat = DataProviderBL.GUNCEL_TABELA.FirstOrDefault(p => p.Urun.UrunKod == item.UrunKod && p.Kaynak == UtilBL.Ayarlar.Kaynak);
                    if (tabelaFiyat != null)
                        tabelaFiyats.Add(tabelaFiyat);
                    else
                        tabelaFiyats.Add(new TabelaFiyatDto() { Urun = item, Kaynak = UtilBL.Ayarlar.Kaynak, Sira = item.Sira });
                }
                else
                {
                    tabelaFiyat = new TabelaFiyatDto() { Urun = item, Kaynak = UtilBL.Ayarlar.Kaynak, Sira = item.Sira };
                    tabelaFiyats.Add(tabelaFiyat);
                }
              

                ucUrunItem urunItem = new ucUrunItem(tabelaFiyat); 
                urunItem.Dock = DockStyle.Top;

                panel1.Controls.Add(urunItem);

                SeparatorControl separator = new SeparatorControl();
                separator.Height = 10;
                separator.Dock = DockStyle.Top;
                panel1.Controls.Add(separator);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Bind();
        }

        private void btnClearPrice_Click(object sender, EventArgs e)
        {
            Bind(true);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult=     XtraMessageBox.Show("Manuel veri girişi ile tabela oluşturuyorsunuz. Devam etmeniz durumunda otomatik tabela oluşturma işlemi kapatılacaktır. Ekranda güncel verileri görebilirsiniz. Dış Tabelada girmiş olduğunuz veriler gözükecektir.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            
            if(dialogResult == DialogResult.No)
                return;

            List<TabelaFiyatDto> disTabelaDtos = new List<TabelaFiyatDto>();

            foreach (var item in panel1.Controls)
            {
                if(item is ucUrunItem)
                {
                    ucUrunItem ucUrun = item as ucUrunItem; 
                    disTabelaDtos.Add(ucUrun.GetData());
                }
            }

       
            UtilBL.Ayarlar.OtomatikVeriAl = false;     
            UtilBL.KaydetConfig(UtilBL.Ayarlar, Constants.FileNames.Ayar); 
            UtilBL.CreateTabelaHtml(disTabelaDtos);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            List<TabelaFiyatDto> disTabelaDtos = new List<TabelaFiyatDto>();

            foreach (var item in panel1.Controls)
            {
                if (item is ucUrunItem)
                {
                    ucUrunItem ucUrun = item as ucUrunItem;
                    disTabelaDtos.Add(ucUrun.GetData());
                }
            }

            UtilBL.CreateTabelaHtml(disTabelaDtos,true);
            string path = System.IO.Path.Combine(Constants.App.DataPath, Constants.FileNames.DisTabelaOnIzleme);
            if (File.Exists(path))
            {

                string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
                string url = path;
                string arguments = $"--app=\"{url}\" --disable-features=TranslateUI --user-data-dir=\"C:/Temp/ChromeTestProfile\" --window-size=260,420 --window-position=100,100";

                Process.Start(chromePath, arguments);

            }
        }
    }
}
