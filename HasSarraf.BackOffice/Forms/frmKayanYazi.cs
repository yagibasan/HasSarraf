using System;
using System.Windows.Forms;
using HasSarraf.BackOffice.Business;
using HasSarraf.BackOffice.Library;

namespace HasSarraf.BackOffice.Forms
{
    public partial class frmKayanYazi : DevExpress.XtraEditors.DirectXForm
    {
        KayanYaziDto KayanYazi = UtilBL.HasConfig.KayanYazi;
        public static event EventHandler KayanYaziDegistirildi;
        private int xpos = 0, ypos = 0;
        public string mode = "Left-to-Right";
        public frmKayanYazi()
        {
            InitializeComponent();

            xpos = lblOnIzleme.Location.X;
            ypos = lblOnIzleme.Location.Y;

            checkGoster.DataBindings.Clear();
            checkGoster.EditValue = KayanYazi.Goster;
            checkGoster.DataBindings.Add(new Binding("EditValue", KayanYazi, "Goster", true, DataSourceUpdateMode.OnPropertyChanged));

            txtIcerik.DataBindings.Clear();
            txtIcerik.EditValue = KayanYazi.Icerik;
            txtIcerik.DataBindings.Add(new Binding("EditValue", KayanYazi, "Icerik", true, DataSourceUpdateMode.OnPropertyChanged));
            txtIcerik.DataBindings.Add(new Binding("Enabled", KayanYazi, "Goster", true, DataSourceUpdateMode.OnPropertyChanged));

            colorArkaPlan.DataBindings.Clear();
            colorArkaPlan.EditValue = KayanYazi.ArkaPlanRengi;
            colorArkaPlan.DataBindings.Add(new Binding("EditValue", KayanYazi, "ArkaPlanRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            colorArkaPlan.DataBindings.Add(new Binding("Enabled", KayanYazi, "Goster", true, DataSourceUpdateMode.OnPropertyChanged));

            colorYazi.DataBindings.Clear();
            colorYazi.EditValue = KayanYazi.YaziRengi;
            colorYazi.DataBindings.Add(new Binding("EditValue", KayanYazi, "YaziRengi", true, DataSourceUpdateMode.OnPropertyChanged));
            colorYazi.DataBindings.Add(new Binding("Enabled", KayanYazi, "Goster", true, DataSourceUpdateMode.OnPropertyChanged));

            trackBarYaziHizi.DataBindings.Clear();
            trackBarYaziHizi.EditValue = KayanYazi.YaziHizi;
            trackBarYaziHizi.DataBindings.Add(new Binding("EditValue", KayanYazi, "YaziHizi", true, DataSourceUpdateMode.OnPropertyChanged));
            trackBarYaziHizi.DataBindings.Add(new Binding("Enabled", KayanYazi, "Goster", true, DataSourceUpdateMode.OnPropertyChanged));

            txtFont.DataBindings.Clear();
            txtFont.EditValue = KayanYazi.YaziFontu;
            txtFont.DataBindings.Add(new Binding("EditValue", KayanYazi, "YaziFontu", true, DataSourceUpdateMode.OnPropertyChanged));
            txtFont.DataBindings.Add(new Binding("Enabled", KayanYazi, "Goster", true, DataSourceUpdateMode.OnPropertyChanged));


            lblOnIzleme.Appearance.Font = KayanYazi.YaziFontu;
            lblOnIzleme.Appearance.BackColor = KayanYazi.ArkaPlanRengi;
            lblOnIzleme.Appearance.ForeColor = KayanYazi.YaziRengi;
            timer1.Interval = 5* KayanYazi.YaziHizi;  
            lblOnIzleme.Text = KayanYazi.Icerik;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
          
            UtilBL.SaveAyarlar();
            KayanYaziDegistirildi?.Invoke(this, null);
            Close();
        }
 
        private void btnIptal_Click(object sender, EventArgs e)
        {
            UtilBL.ReadConfig();
            Close();
        }

      
        private void txtFont_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFont.EditValue = fontDialog1.Font;
                lblOnIzleme.Font= fontDialog1.Font;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            if (this.groupControl2.Width == xpos)
            {
                lblOnIzleme.Location = new System.Drawing.Point(0, ypos);
                xpos = 0;
            }
            else
            {
                lblOnIzleme.Location = new System.Drawing.Point(xpos, ypos);
                xpos -= 2;
            }

            if (xpos < -(lblOnIzleme.Width))
            {
                lblOnIzleme.Location = new System.Drawing.Point(5+lblOnIzleme.Width, ypos);
                xpos = lblOnIzleme.Location.X;
                ypos = lblOnIzleme.Location.Y;
            }
        }

     
        private void txtIcerik_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {          
           lblOnIzleme.Text = e.NewValue.ToString();   
        }

        private void colorArkaPlan_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            lblOnIzleme.Appearance.BackColor = (System.Drawing.Color)e.NewValue;    
        }

        private void trackBarYaziHizi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            timer1.Interval = 5 * (int)e.NewValue;
            KayanYazi.YaziHizi = (int)e.NewValue;
        }

        private void colorYazi_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            lblOnIzleme.Appearance.ForeColor = (System.Drawing.Color)e.NewValue; 
        }
    }
}