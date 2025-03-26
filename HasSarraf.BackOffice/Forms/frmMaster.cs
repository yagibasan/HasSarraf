using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using HasSarraf.BackOffice.Business;
using HasSarraf.BackOffice.Component;
using HasSarraf.BackOffice.Library;
using HasSarraf.BackOffice.Properties;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Forms
{
    public partial class frmMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmMaster()
        {
            InitializeComponent();
            Load += FrmMaster_Load;
        }

        private void FrmMaster_Load(object sender, System.EventArgs e)
        {
            DataProviderBL.GetInstance().TabelaFiyatlariGuncellendi += FrmMain_TabelaFiyatlariGuncellendi;

            SetDataReceiveStatus(DataReceiveStatus.FirstLoading);
           
            UtilBL.Init();
            DataProviderBL.GetInstance().Refresh();
            DataProviderBL.GetInstance().Init();          
            CreateRows();

            SplashScreenManager.CloseForm(true);
        }

        private void FrmMain_TabelaFiyatlariGuncellendi(object sender, List<TabelaFiyatDto> e)
        {
            if (e != null)
            {
                SetDataReceiveStatus(DataReceiveStatus.Received);
            }
            else
            {
                SetDataReceiveStatus(DataReceiveStatus.NotReceived);
            }
        }

        void SetDataReceiveStatus(DataReceiveStatus status)
        {
            
            if (status == DataReceiveStatus.FirstLoading)
            {
                barDataReceiverStatus.Caption = "Veriler Güncel Değil | " + Settings.Default.TabelaFiyatZamani.ToString("HH:mm:ss");               
                this.barDataReceiverStatus.ImageOptions.Image = imageCollection1.Images[2];
            }
            else if (status == DataReceiveStatus.Received)
            {
                barDataReceiverStatus.Caption = "Veriler Güncel | " + Settings.Default.TabelaFiyatZamani.ToString("HH:mm:ss");            
                this.barDataReceiverStatus.ImageOptions.Image = imageCollection1.Images[0];
            }
            else if (status == DataReceiveStatus.NotReceived)
            {
                barDataReceiverStatus.Caption = "Veriler Alınamadı";
                this.barDataReceiverStatus.ImageOptions.Image = imageCollection1.Images[1];
            }

        }

        void CreateRows()
        {
            stackPanelProductItems.Controls.Clear();

            int i = 1;
            foreach (var item in UtilBL.HasConfig.Urunler.Where(p => p.Goster).OrderBy(p => p.Sira))
            {
                if (i <= UtilBL.HasConfig.Ayarlar.TabeladaGozukecekUrunSayisi)
                {
                    ucUrunItem urunItem = new ucUrunItem(item,i%2==0);
                    urunItem.Name = "ucUrunItem" + item.Id;
                    urunItem.Width = 800;
                    urunItem.Height = 50;
                    stackPanelProductItems.Controls.Add(urunItem);

                    i++;
                }
                else
                {
                    XtraMessageBox.Show("Tabela'da gösterilecek ürün sayısı aşıldı. Lütfen ayarlardan kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
        }

        void CreateTabela(bool isPreview = false)
        {
            string content = File.ReadAllText(Path.Combine(App.TemplatePath, UtilBL.HasConfig.Ayarlar.TabelaSablonu + ".html"));
            string row = string.Empty;

            StringBuilder sbRows = new StringBuilder();       
            for (int i = 0; i < DataProviderBL.TabelaFiyat.Count; i++)
            {
                TabelaFiyatDto tabelaFiyatDto = DataProviderBL.TabelaFiyat[i];

                if (UtilBL.HasConfig.Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon1) row = SablonDesenleri.Sablon1;
                else if (UtilBL.HasConfig.Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon2) row = SablonDesenleri.Sablon2;
                else if (UtilBL.HasConfig.Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon3) row = SablonDesenleri.Sablon3;
                else if (UtilBL.HasConfig.Ayarlar.TabelaSablonu == TabelaSablonlari.Sablon4) row = SablonDesenleri.Sablon4;


                string rowType = i % 2 == 0 ? "evenRow" : "oddRow";
                string urunAdi = tabelaFiyatDto.Urun.Adi;
                string alis = "";
                string satis = "";
                if (tabelaFiyatDto.Urun.Grup == 2)
                {
                    string formatString = string.Format("N{0}", UtilBL.HasConfig.Ayarlar.DovizOndalikGoster ? UtilBL.HasConfig.Ayarlar.DovizOndalikAdeti : 0);

                    alis = tabelaFiyatDto.AlisTabela.ToString(formatString);
                    satis = tabelaFiyatDto.SatisTabela.ToString(formatString);
                }
                else
                {
                    string formatString = string.Format("N{0}", UtilBL.HasConfig.Ayarlar.SarrafiyeOndalikGoster ? UtilBL.HasConfig.Ayarlar.SarrafiyeOndalikAdeti : 0);

                    alis = tabelaFiyatDto.AlisTabela.ToString(formatString);
                    satis = tabelaFiyatDto.SatisTabela.ToString(formatString);
                }

                row = row.Replace("##ROWTYPE##", rowType);
                row = row.Replace("##ADI##", urunAdi);
                row = row.Replace("##ALIS##", alis);
                row = row.Replace("##SATIS##", satis);

                sbRows.AppendLine(row);

            }

            content = content.Replace("####TABELA####", sbRows.ToString());
            content = content.Replace("####KAYANYAZI####", string.Empty);

            if (!Directory.Exists(Path.Combine(App.ApplicationRoot, "Tabela")))
                Directory.CreateDirectory(Path.Combine(App.ApplicationRoot, "Tabela"));

            string path = Path.Combine(App.ApplicationRoot, "Tabela", isPreview ? "preview.html" : "index.html");


            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, content);
        }
            


        private void btnTabelaOnIzleme_ItemClick(object sender, ItemClickEventArgs e)
        { 
            CreateTabela(true);
            string path = Path.Combine(App.ApplicationRoot, "Tabela", "preview.html");
            if (File.Exists(path))
            {
                string param = "--new-window \"" + path + "\" --window-size=\"320,500\"";
                UtilBL.OpenLink(param);
            }
        }

        private void btnTabelaGonder_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateTabela(false);
        }

        private void btnHavuz_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUrunHavuzu frm = new frmUrunHavuzu();
            frm.ShowDialog();
        }

        private void btnYenile_ItemClick(object sender, ItemClickEventArgs e)
        {
            UtilBL.Init();
            DataProviderBL.GetInstance().Refresh();
            CreateRows();
        }

        private void btnAyarlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmAyarlar().ShowDialog();
        }

        private void btnKayanYazi_ItemClick(object sender, ItemClickEventArgs e)
        {
            new frmKayanYazi().ShowDialog();
        }
    }
}