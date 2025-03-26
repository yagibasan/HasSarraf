using HasSarraf.BackOffice.Forms;
using HasSarraf.BackOffice.Jobs;
using HasSarraf.BackOffice.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Component
{
    public partial class ucUrunItem : DevExpress.XtraEditors.XtraUserControl
    {

        private Color itemBackgroundColor = Color.FloralWhite;
        private int alisAlarmiIndex = 0;
        private int satisAlarmiIndex = 0;
        private TabelaFiyatDto tabelaFiyat;

        public TabelaFiyatDto TabelaFiyat
        {
            get
            {
                return tabelaFiyat;
            }
            set
            {
                tabelaFiyat = value; 
            }
        }


        public ucUrunItem()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            TabelaFiyatDto.TabelaFiyatHesaplamasiDegisti += TabelaFiyat_TabelaFiyatHesaplamasiDegisti;
        }

         
        public void VerileriGoster(bool ilkKezDoldur = false)
        {
            Task.Run(() =>
            {
                


                        if (TabelaFiyat != null)
                        {
                            try
                            {
                                if (TabelaFiyat.Sira % 2 == 1)
                                    itemBackgroundColor = Color.FloralWhite;
                                else
                                    itemBackgroundColor = Color.GhostWhite;

                                panelControl1.BackColor = itemBackgroundColor;

                                lblUrunAdi.Text = TabelaFiyat.Urun.Adi;

                                if (TabelaFiyat.Urun.AlisMarjYontemi.Tur != MarjYontemi.Manuel)
                                    spinAlis.EditValue = TabelaFiyat.AlisTabela;

                                if (TabelaFiyat.Urun.SatisMarjYontemi.Tur != MarjYontemi.Manuel)
                                    spinSatis.EditValue = TabelaFiyat.SatisTabela;

                                if (ilkKezDoldur)
                                {
                                    if (TabelaFiyat.Urun.AlisMarjYontemi.Tur == MarjYontemi.Manuel)
                                        spinAlis.EditValue = TabelaFiyat.AlisOrijinal;

                                    if (TabelaFiyat.Urun.SatisMarjYontemi.Tur == MarjYontemi.Manuel)
                                        spinSatis.EditValue = TabelaFiyat.SatisOrijinal;
                                }

                                decimal alisKari = tabelaFiyat.AlisOrijinal - Convert.ToDecimal(spinAlis.EditValue);
                                decimal satisKari = Convert.ToDecimal(spinSatis.EditValue) - tabelaFiyat.SatisOrijinal;


                                if (alisKari<0)
                                    baslatAlisAlarmi();
                                else
                                    iptalAlisAlarmi();

                                if (satisKari < 0)
                                    baslatSatisAlarmi();
                                else
                                    iptalSatisAlarmi();


                                lblFarkAlis.Text = string.Format("{0:N0}", alisKari);
                                lblFarkSatis.Text = string.Format("{0:N0}", satisKari);

                                lblOrijinalAlisFiyati.Text = string.Format("{0:N0}", tabelaFiyat.AlisOrijinal);
                                lblOrijinalSatisFiyati.Text = string.Format("{0:N0}", tabelaFiyat.SatisOrijinal);
                            }
                            catch (Exception ex)
                            {

                                throw;
                            }

                        }



                  
            });
        }

        private void TabelaFiyat_TabelaFiyatHesaplamasiDegisti(object sender, TabelaFiyatDto e)
        {
            if(TabelaFiyat != null && e.Urun.Slug == TabelaFiyat.Urun.Slug)
            {
                TabelaFiyat = e;
            }   
                   
        }     
           
        private void spinAlis_EditValueChanged(object sender, EventArgs e)
        {
            TabelaFiyat.AlisTabela = Convert.ToDecimal(spinAlis.EditValue); 
            TabelaFiyat.Hesapla();
        }

        private void spinSatis_EditValueChanged(object sender, EventArgs e)
        {
            TabelaFiyat.SatisTabela = Convert.ToDecimal(spinSatis.EditValue);
            TabelaFiyat.Hesapla();
        }

        private void btnMarjAyari_Click(object sender, EventArgs e)
        {
            try
            {
                frmMarjYontemi frmMarj = new frmMarjYontemi(TabelaFiyat);
                frmMarj.StartPosition = FormStartPosition.Manual;
                frmMarj.Location = new Point(this.Location.X + (this.Width / 2), this.Location.Y + 190);
                frmMarj.ShowDialog();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        void baslatAlisAlarmi() {
           
            timerAlarmAlis.Enabled = true;  
        }

        void iptalAlisAlarmi()
        {

            timerAlarmAlis.Enabled = false;
            alisAlarmiIndex = 0; 
            spinAlis.BackColor = Color.White;
            spinAlis.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;

        }

        private void timerAlarmAlis_Tick(object sender, EventArgs e)
        {
            if(alisAlarmiIndex%2 == 0)
            {                
                spinAlis.Properties.Appearance.ForeColor = Color.White;
                spinAlis.Properties.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            }
            else
            {
                spinAlis.Properties.Appearance.BackColor = Color.White;
                spinAlis.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            }

            alisAlarmiIndex++;
        }

        void baslatSatisAlarmi()
        {

            timerAlarmSatis.Enabled = true;
        }

        void iptalSatisAlarmi()
        {

            timerAlarmSatis.Enabled = false;
            satisAlarmiIndex = 0;
            spinSatis.BackColor = Color.White;
            spinSatis.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;

        }

        private void timerAlarmSatis_Tick(object sender, EventArgs e)
        {

            if (satisAlarmiIndex % 2 == 0)
            {
                spinSatis.Properties.Appearance.ForeColor = Color.White;
                spinSatis.Properties.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            }
            else
            {

                spinSatis.Properties.Appearance.BackColor= Color.White;
                spinSatis.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;

              
            }

            satisAlarmiIndex++;
        }

        private void lblUrunAdi_DoubleClick(object sender, EventArgs e)
        {
             

            try
            {
                frmUrunSec urunSec = new frmUrunSec();
                urunSec.StartPosition = FormStartPosition.Manual;
                urunSec.Location = new Point(this.Location.X + (this.Width / 2), this.Location.Y + 190);

                urunSec.FormClosed += (x, y) =>
                {
                    if(urunSec.SecilenUrun!=null)
                        UrunDegistirildi(urunSec.SecilenUrun);
                };
                urunSec.ShowDialog();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void UrunDegistirildi(UrunDto urunDto)
        {
            lbluru
        }
    }
}
