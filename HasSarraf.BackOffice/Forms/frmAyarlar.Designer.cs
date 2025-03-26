namespace HasSarraf.BackOffice.Forms
{
    partial class frmAyarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyarlar));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkSarrafiyeOndalikGoster = new DevExpress.XtraEditors.CheckEdit();
            this.spinSarrafiyeOndalikAdeti = new DevExpress.XtraEditors.SpinEdit();
            this.checkDovizOndalikGoster = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkKorumaModu = new DevExpress.XtraEditors.CheckEdit();
            this.radioKaynak = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spinDovizOndalikAdet = new DevExpress.XtraEditors.SpinEdit();
            this.spinKorumaOrani = new DevExpress.XtraEditors.SpinEdit();
            this.spinGuncellemePeriyodu = new DevExpress.XtraEditors.SpinEdit();
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.btnIptal = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.pictureSablon4 = new DevExpress.XtraEditors.PictureEdit();
            this.radioSablon = new DevExpress.XtraEditors.RadioGroup();
            this.pictureSablon3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureSablon2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureSablon1 = new DevExpress.XtraEditors.PictureEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.checkMilyem = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.checkSarrafiyeOndalikGoster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSarrafiyeOndalikAdeti.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDovizOndalikGoster.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkKorumaModu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioKaynak.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDovizOndalikAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinKorumaOrani.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGuncellemePeriyodu.Properties)).BeginInit();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSablon4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioSablon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSablon3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSablon2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSablon1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMilyem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Veri Okuma Periyodu";
            // 
            // checkSarrafiyeOndalikGoster
            // 
            this.checkSarrafiyeOndalikGoster.Location = new System.Drawing.Point(14, 150);
            this.checkSarrafiyeOndalikGoster.Name = "checkSarrafiyeOndalikGoster";
            this.checkSarrafiyeOndalikGoster.Properties.Caption = "Sarraffiyede ondalık değeri göster";
            this.checkSarrafiyeOndalikGoster.Size = new System.Drawing.Size(216, 22);
            this.checkSarrafiyeOndalikGoster.TabIndex = 3;
            // 
            // spinSarrafiyeOndalikAdeti
            // 
            this.spinSarrafiyeOndalikAdeti.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSarrafiyeOndalikAdeti.Location = new System.Drawing.Point(254, 147);
            this.spinSarrafiyeOndalikAdeti.Name = "spinSarrafiyeOndalikAdeti";
            this.spinSarrafiyeOndalikAdeti.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSarrafiyeOndalikAdeti.Properties.DisplayFormat.FormatString = "{0} basamak";
            this.spinSarrafiyeOndalikAdeti.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSarrafiyeOndalikAdeti.Properties.EditFormat.FormatString = "{0} basamak";
            this.spinSarrafiyeOndalikAdeti.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSarrafiyeOndalikAdeti.Properties.IsFloatValue = false;
            this.spinSarrafiyeOndalikAdeti.Properties.MaskSettings.Set("mask", "N00");
            this.spinSarrafiyeOndalikAdeti.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinSarrafiyeOndalikAdeti.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSarrafiyeOndalikAdeti.Size = new System.Drawing.Size(100, 28);
            this.spinSarrafiyeOndalikAdeti.TabIndex = 4;
            // 
            // checkDovizOndalikGoster
            // 
            this.checkDovizOndalikGoster.Location = new System.Drawing.Point(14, 187);
            this.checkDovizOndalikGoster.Name = "checkDovizOndalikGoster";
            this.checkDovizOndalikGoster.Properties.Caption = "Dövizde ondalık değeri göster";
            this.checkDovizOndalikGoster.Size = new System.Drawing.Size(190, 22);
            this.checkDovizOndalikGoster.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkMilyem);
            this.groupControl1.Controls.Add(this.checkKorumaModu);
            this.groupControl1.Controls.Add(this.radioKaynak);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.spinDovizOndalikAdet);
            this.groupControl1.Controls.Add(this.checkDovizOndalikGoster);
            this.groupControl1.Controls.Add(this.spinKorumaOrani);
            this.groupControl1.Controls.Add(this.checkSarrafiyeOndalikGoster);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.spinGuncellemePeriyodu);
            this.groupControl1.Controls.Add(this.spinSarrafiyeOndalikAdeti);
            this.groupControl1.Location = new System.Drawing.Point(36, 16);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(374, 281);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Genel";
            // 
            // checkKorumaModu
            // 
            this.checkKorumaModu.Location = new System.Drawing.Point(14, 113);
            this.checkKorumaModu.Name = "checkKorumaModu";
            this.checkKorumaModu.Properties.Caption = "Koruma Modu ve Oranı";
            this.checkKorumaModu.Size = new System.Drawing.Size(216, 22);
            this.checkKorumaModu.TabIndex = 12;
            // 
            // radioKaynak
            // 
            this.radioKaynak.Location = new System.Drawing.Point(106, 36);
            this.radioKaynak.Name = "radioKaynak";
            this.radioKaynak.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("saglamoglu", "Sağlamoğlu"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("harem", "Harem", false)});
            this.radioKaynak.Size = new System.Drawing.Size(248, 28);
            this.radioKaynak.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl3.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl3.LineVisible = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Veri Kaynağı";
            // 
            // spinDovizOndalikAdet
            // 
            this.spinDovizOndalikAdet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDovizOndalikAdet.Location = new System.Drawing.Point(254, 184);
            this.spinDovizOndalikAdet.Name = "spinDovizOndalikAdet";
            this.spinDovizOndalikAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinDovizOndalikAdet.Properties.DisplayFormat.FormatString = "{0} basamak";
            this.spinDovizOndalikAdet.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDovizOndalikAdet.Properties.EditFormat.FormatString = "{0} basamak";
            this.spinDovizOndalikAdet.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinDovizOndalikAdet.Properties.IsFloatValue = false;
            this.spinDovizOndalikAdet.Properties.MaskSettings.Set("mask", "N00");
            this.spinDovizOndalikAdet.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinDovizOndalikAdet.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDovizOndalikAdet.Size = new System.Drawing.Size(100, 28);
            this.spinDovizOndalikAdet.TabIndex = 8;
            // 
            // spinKorumaOrani
            // 
            this.spinKorumaOrani.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinKorumaOrani.Location = new System.Drawing.Point(254, 110);
            this.spinKorumaOrani.Name = "spinKorumaOrani";
            this.spinKorumaOrani.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinKorumaOrani.Properties.DisplayFormat.FormatString = "% {0}";
            this.spinKorumaOrani.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinKorumaOrani.Properties.EditFormat.FormatString = "% {0}";
            this.spinKorumaOrani.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinKorumaOrani.Properties.IsFloatValue = false;
            this.spinKorumaOrani.Properties.MaskSettings.Set("mask", "N00");
            this.spinKorumaOrani.Size = new System.Drawing.Size(100, 28);
            this.spinKorumaOrani.TabIndex = 8;
            // 
            // spinGuncellemePeriyodu
            // 
            this.spinGuncellemePeriyodu.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinGuncellemePeriyodu.Location = new System.Drawing.Point(254, 73);
            this.spinGuncellemePeriyodu.Name = "spinGuncellemePeriyodu";
            this.spinGuncellemePeriyodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinGuncellemePeriyodu.Properties.DisplayFormat.FormatString = "{0} dakika";
            this.spinGuncellemePeriyodu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinGuncellemePeriyodu.Properties.EditFormat.FormatString = "{0} dakika";
            this.spinGuncellemePeriyodu.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinGuncellemePeriyodu.Properties.IsFloatValue = false;
            this.spinGuncellemePeriyodu.Properties.MaskSettings.Set("mask", "N00");
            this.spinGuncellemePeriyodu.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.spinGuncellemePeriyodu.Size = new System.Drawing.Size(100, 28);
            this.spinGuncellemePeriyodu.TabIndex = 9;
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.btnIptal);
            this.directXFormContainerControl1.Controls.Add(this.btnKaydet);
            this.directXFormContainerControl1.Controls.Add(this.groupControl2);
            this.directXFormContainerControl1.Controls.Add(this.groupControl1);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(1, 33);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(923, 323);
            this.directXFormContainerControl1.TabIndex = 10;
            // 
            // btnIptal
            // 
            this.btnIptal.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Appearance.Options.UseFont = true;
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Location = new System.Drawing.Point(615, 267);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(135, 30);
            this.btnIptal.TabIndex = 10;
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Location = new System.Drawing.Point(758, 267);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 30);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.pictureSablon4);
            this.groupControl2.Controls.Add(this.radioSablon);
            this.groupControl2.Controls.Add(this.pictureSablon3);
            this.groupControl2.Controls.Add(this.pictureSablon2);
            this.groupControl2.Controls.Add(this.pictureSablon1);
            this.groupControl2.Location = new System.Drawing.Point(420, 16);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(473, 231);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "Tabela Şablonu";
            // 
            // pictureSablon4
            // 
            this.pictureSablon4.EditValue = global::HasSarraf.BackOffice.Properties.Resources.sablon1;
            this.pictureSablon4.Enabled = false;
            this.pictureSablon4.Location = new System.Drawing.Point(362, 73);
            this.pictureSablon4.Name = "pictureSablon4";
            this.pictureSablon4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureSablon4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureSablon4.Size = new System.Drawing.Size(84, 129);
            this.pictureSablon4.TabIndex = 14;
            // 
            // radioSablon
            // 
            this.radioSablon.Location = new System.Drawing.Point(14, 39);
            this.radioSablon.Name = "radioSablon";
            this.radioSablon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioSablon.Properties.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.radioSablon.Properties.Appearance.Options.UseBackColor = true;
            this.radioSablon.Properties.Appearance.Options.UseBorderColor = true;
            this.radioSablon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioSablon.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("sablon1", "ŞABLON-1"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("sablon2", "ŞABLON-2"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("sablon3", "ŞABLON-3"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("sablon4", "ŞABLON-4")});
            this.radioSablon.Size = new System.Drawing.Size(471, 28);
            this.radioSablon.TabIndex = 13;
            this.radioSablon.SelectedIndexChanged += new System.EventHandler(this.radioSablon_SelectedIndexChanged);
            // 
            // pictureSablon3
            // 
            this.pictureSablon3.EditValue = global::HasSarraf.BackOffice.Properties.Resources.sablon1;
            this.pictureSablon3.Enabled = false;
            this.pictureSablon3.Location = new System.Drawing.Point(246, 73);
            this.pictureSablon3.Name = "pictureSablon3";
            this.pictureSablon3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureSablon3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureSablon3.Size = new System.Drawing.Size(84, 129);
            this.pictureSablon3.TabIndex = 4;
            // 
            // pictureSablon2
            // 
            this.pictureSablon2.EditValue = global::HasSarraf.BackOffice.Properties.Resources.sablon1;
            this.pictureSablon2.Enabled = false;
            this.pictureSablon2.Location = new System.Drawing.Point(130, 73);
            this.pictureSablon2.Name = "pictureSablon2";
            this.pictureSablon2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureSablon2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureSablon2.Size = new System.Drawing.Size(84, 129);
            this.pictureSablon2.TabIndex = 2;
            // 
            // pictureSablon1
            // 
            this.pictureSablon1.EditValue = global::HasSarraf.BackOffice.Properties.Resources.sablon1;
            this.pictureSablon1.Enabled = false;
            this.pictureSablon1.Location = new System.Drawing.Point(14, 73);
            this.pictureSablon1.Name = "pictureSablon1";
            this.pictureSablon1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureSablon1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureSablon1.Size = new System.Drawing.Size(84, 129);
            this.pictureSablon1.TabIndex = 0;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "T";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // checkMilyem
            // 
            this.checkMilyem.Location = new System.Drawing.Point(14, 226);
            this.checkMilyem.Name = "checkMilyem";
            this.checkMilyem.Properties.Caption = "Veri kaynağında \"Milyem\" değeri varsa göster";
            this.checkMilyem.Size = new System.Drawing.Size(340, 22);
            this.checkMilyem.TabIndex = 13;
            // 
            // frmAyarlar
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIptal;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(925, 357);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmAyarlar.IconOptions.LargeImage")));
            this.Name = "frmAyarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            ((System.ComponentModel.ISupportInitialize)(this.checkSarrafiyeOndalikGoster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSarrafiyeOndalikAdeti.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDovizOndalikGoster.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkKorumaModu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioKaynak.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinDovizOndalikAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinKorumaOrani.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGuncellemePeriyodu.Properties)).EndInit();
            this.directXFormContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSablon4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioSablon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSablon3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSablon2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSablon1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkMilyem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit checkSarrafiyeOndalikGoster;
        private DevExpress.XtraEditors.SpinEdit spinSarrafiyeOndalikAdeti;
        private DevExpress.XtraEditors.CheckEdit checkDovizOndalikGoster;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit spinKorumaOrani;
        private DevExpress.XtraEditors.SpinEdit spinGuncellemePeriyodu;
        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.SpinEdit spinDovizOndalikAdet;
        private DevExpress.XtraEditors.RadioGroup radioKaynak;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PictureEdit pictureSablon1;
        private DevExpress.XtraEditors.PictureEdit pictureSablon3;
        private DevExpress.XtraEditors.PictureEdit pictureSablon2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.CheckEdit checkKorumaModu;
        private DevExpress.XtraEditors.SimpleButton btnIptal;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.RadioGroup radioSablon;
        private DevExpress.XtraEditors.PictureEdit pictureSablon4;
        private DevExpress.XtraEditors.CheckEdit checkMilyem;
    }
}