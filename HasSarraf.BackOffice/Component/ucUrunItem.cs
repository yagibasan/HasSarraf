using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HasSarraf.BackOffice.Business;
using HasSarraf.BackOffice.Library;
using static HasSarraf.BackOffice.Library.Constants;

namespace HasSarraf.BackOffice.Component
{
    public partial class ucUrunItem : DevExpress.XtraEditors.XtraUserControl
    {

        private Color itemBackgroundColor = Color.FloralWhite;     
        private UrunDto CurrentProduct;
        private TabelaFiyatDto Fiyat;

        public ucUrunItem()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        public ucUrunItem(UrunDto product,bool evenRow=false)
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            if (evenRow)
            {
               panelControl1.Appearance.BackColor = itemBackgroundColor;
            }   

            DataProviderBL.GetInstance().TabelaFiyatlariGuncellendi += UcUrunItem_TabelaFiyatlariGuncellendi;
            tableLayoutPanel1.Dock = DockStyle.Fill;
            CurrentProduct = product;
            InitMarjMethod();
            SetData(true);

            listBoxProducts.DataSource = UtilBL.HasConfig.Urunler;

            if (product.Grup == 2)
            {
                if (UtilBL.HasConfig.Ayarlar.DovizOndalikGoster)
                {
                    string formatString = string.Format("{{0:N{0}}}", UtilBL.HasConfig.Ayarlar.DovizOndalikAdeti);
                    string formatString2 = string.Format("N{0}", UtilBL.HasConfig.Ayarlar.DovizOndalikAdeti);

                    spinAlis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinAlis.Properties.DisplayFormat.FormatString = formatString;
                    spinAlis.Properties.IsFloatValue = true;
                    spinAlis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinAlis.Properties.EditFormat.FormatString = formatString;
                    spinAlis.Properties.EditMask = formatString2;

                    spinSatis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinSatis.Properties.DisplayFormat.FormatString = formatString;
                    spinSatis.Properties.IsFloatValue = true;
                    spinSatis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinSatis.Properties.EditFormat.FormatString = formatString;
                    spinSatis.Properties.EditMask = formatString2;
                }
                else
                {
                    string formatString = "{0:N0}";
                    string formatString2 = "N00";

                    spinAlis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinAlis.Properties.DisplayFormat.FormatString = formatString;
                    spinAlis.Properties.IsFloatValue = false;
                    spinAlis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinAlis.Properties.EditFormat.FormatString = formatString;
                    spinAlis.Properties.EditMask = formatString2;

                    spinSatis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinSatis.Properties.DisplayFormat.FormatString = formatString;
                    spinSatis.Properties.IsFloatValue = false;
                    spinSatis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinSatis.Properties.EditFormat.FormatString = formatString;
                    spinSatis.Properties.EditMask = formatString2;
                }
            }
            else
            {
                if (UtilBL.HasConfig.Ayarlar.SarrafiyeOndalikGoster)
                {
                    string formatString = string.Format("{{0:N{0}}}", UtilBL.HasConfig.Ayarlar.SarrafiyeOndalikAdeti);
                    string formatString2 = string.Format("N{0}", UtilBL.HasConfig.Ayarlar.SarrafiyeOndalikAdeti);

                    spinAlis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinAlis.Properties.DisplayFormat.FormatString = formatString;
                    spinAlis.Properties.IsFloatValue = true;
                    spinAlis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinAlis.Properties.EditFormat.FormatString = formatString;
                    spinAlis.Properties.EditMask = formatString2;

                    spinSatis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinSatis.Properties.DisplayFormat.FormatString = formatString;
                    spinSatis.Properties.IsFloatValue = true;
                    spinSatis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinSatis.Properties.EditFormat.FormatString = formatString;
                    spinSatis.Properties.EditMask = formatString2;
                }
                else
                {
                    string formatString = "{0:N0}";
                    string formatString2 = "N00";

                    spinAlis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinAlis.Properties.DisplayFormat.FormatString = formatString;
                    spinAlis.Properties.IsFloatValue = false;
                    spinAlis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinAlis.Properties.EditFormat.FormatString = formatString;
                    spinAlis.Properties.EditMask = formatString2;

                    spinSatis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinSatis.Properties.DisplayFormat.FormatString = formatString;
                    spinSatis.Properties.IsFloatValue = false;
                    spinSatis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                    spinSatis.Properties.EditFormat.FormatString = formatString;
                    spinSatis.Properties.EditMask = formatString2;
                }
            }
        }

        void InitMarjMethod()
        {
            spinOransalDegerSatis.EditValueChanged -= new EventHandler(MarjValuesChanged);
            spinMiktarSatis.EditValueChanged -= new EventHandler(MarjValuesChanged);
            spinMiktarAlis.EditValueChanged -= new EventHandler(MarjValuesChanged);
            spinOransalDegerAlis.EditValueChanged -= new EventHandler(MarjValuesChanged);

            chkManuelAlis.CheckedChanged -= new EventHandler(MarjMethodChanged);
            chkMiktarAlis.CheckedChanged -= new EventHandler(MarjMethodChanged);
            chkOransalAlis.CheckedChanged -= new EventHandler(MarjMethodChanged);

            chkManuelSatis.CheckedChanged -= new EventHandler(MarjMethodChanged);
            chkMiktarSatis.CheckedChanged -= new EventHandler(MarjMethodChanged);
            chkOransalSatis.CheckedChanged -= new EventHandler(MarjMethodChanged);

            //ALIŞ
            chkManuelAlis.Checked = CurrentProduct.AlisMarjYontemi.Tur == MarjYontemi.Manuel;
            chkMiktarAlis.Checked = CurrentProduct.AlisMarjYontemi.Tur == MarjYontemi.Miktar;
            chkOransalAlis.Checked = CurrentProduct.AlisMarjYontemi.Tur == MarjYontemi.Oransal;

            spinMiktarAlis.Enabled = chkMiktarAlis.Checked;
            spinOransalDegerAlis.Enabled = chkOransalAlis.Checked;

            spinMiktarAlis.Value = CurrentProduct.AlisMarjYontemi.MiktarDeger;
            spinOransalDegerAlis.Value = CurrentProduct.AlisMarjYontemi.OransalDeger;


            //SATIS

            chkManuelSatis.Checked = CurrentProduct.SatisMarjYontemi.Tur == MarjYontemi.Manuel;
            chkMiktarSatis.Checked = CurrentProduct.SatisMarjYontemi.Tur == MarjYontemi.Miktar;
            chkOransalSatis.Checked = CurrentProduct.SatisMarjYontemi.Tur == MarjYontemi.Oransal;

            spinMiktarSatis.Enabled = chkMiktarSatis.Checked;
            spinOransalDegerSatis.Enabled = chkOransalSatis.Checked;

            spinMiktarSatis.Value = CurrentProduct.SatisMarjYontemi.MiktarDeger;
            spinOransalDegerSatis.Value = CurrentProduct.SatisMarjYontemi.OransalDeger;


            spinOransalDegerSatis.EditValueChanged += new EventHandler(MarjValuesChanged);
            spinMiktarSatis.EditValueChanged += new EventHandler(MarjValuesChanged);
            spinMiktarAlis.EditValueChanged += new EventHandler(MarjValuesChanged);
            spinOransalDegerAlis.EditValueChanged += new EventHandler(MarjValuesChanged);

            chkManuelAlis.CheckedChanged += new EventHandler(MarjMethodChanged);
            chkMiktarAlis.CheckedChanged += new EventHandler(MarjMethodChanged);
            chkOransalAlis.CheckedChanged += new EventHandler(MarjMethodChanged);

            chkManuelSatis.CheckedChanged += new EventHandler(MarjMethodChanged);
            chkMiktarSatis.CheckedChanged += new EventHandler(MarjMethodChanged);
            chkOransalSatis.CheckedChanged += new EventHandler(MarjMethodChanged);

        }


        public void SetData(bool reCalculate = false)
        {
            if (CurrentProduct == null) return;

            lblUrunAdi.Text = CurrentProduct.Adi.ToString();

            Fiyat = DataProviderBL.TabelaFiyat?.Where(p => p.Urun.Slug == CurrentProduct.Slug).FirstOrDefault();

            if (Fiyat != null)
            {
                if (CurrentProduct.AlisMarjYontemi.Tur == MarjYontemi.Manuel)                
                    Fiyat.AlisTabela = spinAlis.Value;
                
                if (CurrentProduct.SatisMarjYontemi.Tur == MarjYontemi.Manuel)
                    Fiyat.SatisTabela = spinSatis.Value;


               
                Fiyat.Hesapla(CurrentProduct);

                spinAlis.Value = Fiyat.AlisTabela;
                spinSatis.Value = Fiyat.SatisTabela;

                if (CurrentProduct.Grup == 2)
                {
                    string formatString = string.Format("{{0:N{0}}}", UtilBL.HasConfig.Ayarlar.DovizOndalikAdeti);

                    if (UtilBL.HasConfig.Ayarlar.DovizOndalikGoster)
                        formatString = string.Format("{{0:N{0}}}", UtilBL.HasConfig.Ayarlar.DovizOndalikAdeti);
                    else 
                        formatString = "{0:N0}";   


                    lblFarkAlis.Text = string.Format(formatString, Fiyat.AlisOrijinal- Fiyat.AlisTabela );
                    lblFarkSatis.Text = string.Format(formatString, Fiyat.SatisTabela - Fiyat.SatisOrijinal);

                    lblOrijinalAlisFiyati.Text = string.Format(formatString,  Fiyat.AlisOrijinal);
                    lblOrijinalSatisFiyati.Text = string.Format(formatString,  Fiyat.SatisOrijinal);
                }
                else
                {
                    string formatString = string.Format("{{0:N{0}}}", UtilBL.HasConfig.Ayarlar.SarrafiyeOndalikAdeti);

                    if (UtilBL.HasConfig.Ayarlar.SarrafiyeOndalikGoster)
                        formatString = string.Format("{{0:N{0}}}", UtilBL.HasConfig.Ayarlar.SarrafiyeOndalikAdeti);
                    else
                        formatString = "{0:N0}";

                    lblFarkAlis.Text = string.Format("{0:N0}", Fiyat.AlisOrijinal- Fiyat.AlisTabela);
                    lblFarkSatis.Text = string.Format("{0:N0}", Fiyat.SatisTabela-Fiyat.SatisOrijinal);




                    if (CurrentProduct.Grup == 3 && UtilBL.HasConfig.Ayarlar.MilyemGoster && Fiyat.AlisMilyem.HasValue)                   
                        lblOrijinalAlisFiyati.Text = string.Format("{0:N0} - {1:N4}", Fiyat.AlisOrijinal, Fiyat.AlisMilyem);                        
                    else                    
                        lblOrijinalAlisFiyati.Text = string.Format("{0:N0}", Fiyat.AlisOrijinal);


                    if (CurrentProduct.Grup == 3 && UtilBL.HasConfig.Ayarlar.MilyemGoster && Fiyat.SatisMilyem.HasValue)
                        lblOrijinalSatisFiyati.Text = string.Format("{0:N0} - {1:N1}", Fiyat.SatisOrijinal, Fiyat.SatisMilyem);
                    else
                        lblOrijinalSatisFiyati.Text = string.Format("{0:N0}", Fiyat.SatisOrijinal); 


                }
            }
        }

        private void MarjMethodChanged(object sender, EventArgs e)
        {
            if (sender is CheckEdit)
            {
                CheckEdit chk = sender as CheckEdit;
                if (chk.Checked)
                {
                    string[] commands = chk.Tag.ToString().Split('-');
                    string islemTuru = commands[0];
                    string marjYontemi = commands[1];

                    if (islemTuru == IslemTuru.Alis)
                    {
                        spinMiktarAlis.Enabled = false;
                        spinOransalDegerAlis.Enabled = false;
                    }

                    else if (islemTuru == IslemTuru.Satis)
                    {
                        spinMiktarSatis.Enabled = false;
                        spinOransalDegerSatis.Enabled = false;
                    }

                    if (islemTuru == IslemTuru.Alis && marjYontemi == MarjYontemi.Manuel)
                    {
                        CurrentProduct.AlisMarjYontemi.Tur = MarjYontemi.Manuel;
                    }
                    else if (islemTuru == IslemTuru.Alis && marjYontemi == MarjYontemi.Oransal)
                    {
                        CurrentProduct.AlisMarjYontemi.Tur = MarjYontemi.Oransal;
                        CurrentProduct.AlisMarjYontemi.OransalDeger = spinOransalDegerAlis.Value;

                        spinOransalDegerAlis.Enabled = true;
                    }
                    else if (islemTuru == IslemTuru.Alis && marjYontemi == MarjYontemi.Miktar)
                    {
                        CurrentProduct.AlisMarjYontemi.Tur = MarjYontemi.Miktar;
                        CurrentProduct.AlisMarjYontemi.MiktarDeger = spinMiktarAlis.Value;

                        spinMiktarAlis.Enabled = true;
                    }

                    else if (islemTuru == IslemTuru.Satis && marjYontemi == MarjYontemi.Manuel)
                    {
                        CurrentProduct.SatisMarjYontemi.Tur = MarjYontemi.Manuel;
                    }
                    else if (islemTuru == IslemTuru.Satis && marjYontemi == MarjYontemi.Oransal)
                    {
                        CurrentProduct.SatisMarjYontemi.Tur = MarjYontemi.Oransal;
                        CurrentProduct.SatisMarjYontemi.OransalDeger = spinOransalDegerSatis.Value;

                        spinOransalDegerSatis.Enabled = true;
                    }
                    else if (islemTuru == IslemTuru.Satis && marjYontemi == MarjYontemi.Miktar)
                    {
                        CurrentProduct.SatisMarjYontemi.Tur = MarjYontemi.Miktar;
                        CurrentProduct.SatisMarjYontemi.MiktarDeger = spinMiktarSatis.Value;

                        spinMiktarSatis.Enabled = true;
                    }

                    SetData(true);
                }

            }
        }

        private void MarjValuesChanged(object sender, EventArgs e)
        {
            if (sender is SpinEdit)
            {
                SpinEdit spin = sender as SpinEdit;
                string[] commands = spin.Tag.ToString().Split('-');
                string islemTuru = commands[0];
                string marjYontemi = commands[1];

                if (islemTuru == IslemTuru.Alis && marjYontemi == MarjYontemi.Oransal)
                {
                    CurrentProduct.AlisMarjYontemi.OransalDeger = spinOransalDegerAlis.Value;
                }
                else if (islemTuru == IslemTuru.Alis && marjYontemi == MarjYontemi.Miktar)
                {
                    CurrentProduct.AlisMarjYontemi.MiktarDeger = spinMiktarAlis.Value;
                }
                else if (islemTuru == IslemTuru.Satis && marjYontemi == MarjYontemi.Oransal)
                {
                    CurrentProduct.SatisMarjYontemi.OransalDeger = spinOransalDegerSatis.Value;
                }
                else if (islemTuru == IslemTuru.Satis && marjYontemi == MarjYontemi.Miktar)
                {
                    CurrentProduct.SatisMarjYontemi.MiktarDeger = spinMiktarSatis.Value;
                }

                SetData(true);

            }
        }

        private void UcUrunItem_TabelaFiyatlariGuncellendi(object sender, List<TabelaFiyatDto> e)
        {
            SetData();
        }

        private void btnCloseMarjMethodPopup(object sender, EventArgs e)
        {
            UtilBL.ReadConfig();
            CurrentProduct = UtilBL.HasConfig.Urunler.Where(p => p.Slug == CurrentProduct.Slug).FirstOrDefault();
            InitMarjMethod();
            SetData(true);
            popupMarjYonetimi.ClosePopup();
        }

        private void btnSaveMarjMethod(object sender, EventArgs e)
        {
            UtilBL.SaveUrun(CurrentProduct);
            InitMarjMethod();
            SetData(true);
            popupMarjYonetimi.ClosePopup();
        }

        private void ChangeProduct(object sender, EventArgs e)
        {
            flyoutPanel1.ShowBeakForm();
        }

        private void lblUrunAdi_Click(object sender, EventArgs e)
        {

        }

        private void btnProdutChange_Click(object sender, EventArgs e)
        {
            flyoutPanel1.HideBeakForm();
            if (listBoxProducts.SelectedItem != null)
            {
                CurrentProduct = listBoxProducts.SelectedItem as UrunDto;
                InitMarjMethod();
                SetData(true);
            }
        }

        private void lblFarkAlis_Click(object sender, EventArgs e)
        {

        }
    }
}
