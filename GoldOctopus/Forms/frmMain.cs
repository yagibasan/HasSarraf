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
using DevExpress.XtraSplashScreen;
using GoldOctopus.Business;
using GoldOctopus.Library;
using GoldOctopus.Properties;
using static GoldOctopus.Library.Constants;

namespace GoldOctopus.Forms
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();

            DataProviderBL.GetInstance().TabelaFiyatlariGuncellendi += FrmMain_TabelaFiyatlariGuncellendi;
            SetDataReceiveStatus(DataReceiveStatus.FirstLoading);  
            DataProviderBL.GetInstance().Init();

            ucTabela1.Bind(); 
            ucAyar1.Bind();
            ucUrunHavuzu1.Bind();
            ucManuelTabela1.Bind();
            ucTabelaMizanpaj1.Bind();

            BindSaglamoglu();
            BindHaremAltin();

            SplashScreenManager.CloseForm(true);
        }



        private void FrmMain_TabelaFiyatlariGuncellendi(object sender, List<TabelaFiyatDto> e)
        {
            if (e != null)
            {
                SetDataReceiveStatus(DataReceiveStatus.Received);
                BindSaglamoglu();
                BindHaremAltin();
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
                barDataReceiverStatus.Caption = "Veriler Güncelleniyor... | " + Settings.Default.TabelaFiyatZamani.ToString("HH:mm:ss");
                this.barDataReceiverStatus.ImageOptions.Image = imageCollection1.Images[3];
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

        void BindSaglamoglu()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    if (DataProviderBL.GUNCEL_TABELA == null)
                        return;


                    List<TabelaFiyatDto> tabelaFiyats = new List<TabelaFiyatDto>();
                    var tabelaUrunleri = UtilBL.Urunler.Where(p => p.TabeladaGoster).OrderBy(p => p.Sira).ToList();

                    foreach (var item in tabelaUrunleri)
                    {
                        var tabelaFiyat = DataProviderBL.GUNCEL_TABELA.FirstOrDefault(p => p.Urun.UrunKod == item.UrunKod && p.Kaynak == Kaynaklar.Saglamoglu);
                        if (tabelaFiyat != null)
                            tabelaFiyats.Add(tabelaFiyat);
                        else
                            tabelaFiyats.Add(new TabelaFiyatDto() { Urun = item, Kaynak = Kaynaklar.Saglamoglu, Sira = item.Sira });
                    }

                    var digerUrunler = UtilBL.Urunler.Where(p => !p.TabeladaGoster).OrderBy(p => p.Sira).ToList();

                    foreach (var item in digerUrunler)
                    {
                        var tabelaFiyat = DataProviderBL.GUNCEL_TABELA.FirstOrDefault(p => p.Urun.UrunKod == item.UrunKod && p.Kaynak == Kaynaklar.Saglamoglu);
                        if (tabelaFiyat != null)
                            tabelaFiyats.Add(tabelaFiyat);
                        else
                            tabelaFiyats.Add(new TabelaFiyatDto() { Urun = item, Kaynak = Kaynaklar.Saglamoglu, Sira = item.Sira });
                    }

                    gridSaglamoglu.DataSource = tabelaFiyats;


                }));
            }
 
        }

        void BindHaremAltin()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    if (DataProviderBL.GUNCEL_TABELA == null)   
                        return;


                    List<TabelaFiyatDto> tabelaFiyats = new List<TabelaFiyatDto>();
                    var tabelaUrunleri = UtilBL.Urunler.Where(p => p.TabeladaGoster).OrderBy(p => p.Sira).ToList();

                    foreach (var item in tabelaUrunleri)
                    {
                        var tabelaFiyat = DataProviderBL.GUNCEL_TABELA.FirstOrDefault(p => p.Urun.UrunKod == item.UrunKod && p.Kaynak == Kaynaklar.Harem);
                        if (tabelaFiyat != null)
                            tabelaFiyats.Add(tabelaFiyat);
                        else
                            tabelaFiyats.Add(new TabelaFiyatDto() { Urun = item, Kaynak = Kaynaklar.Harem, Sira = item.Sira });
                    }

                    var digerUrunler = UtilBL.Urunler.Where(p => !p.TabeladaGoster).OrderBy(p => p.Sira).ToList();

                    foreach (var item in digerUrunler)
                    {
                        var tabelaFiyat = DataProviderBL.GUNCEL_TABELA.FirstOrDefault(p => p.Urun.UrunKod == item.UrunKod && p.Kaynak == Kaynaklar.Harem);
                        if (tabelaFiyat != null)
                            tabelaFiyats.Add(tabelaFiyat);
                        else
                            tabelaFiyats.Add(new TabelaFiyatDto() { Urun = item, Kaynak = Kaynaklar.Harem, Sira = item.Sira });
                    }

                    gridHaremAltin.DataSource = tabelaFiyats;


                }));
            }

        }


    }
}