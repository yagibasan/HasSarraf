namespace HasSarraf.BackOffice.Forms
{
    partial class frmMaster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaster));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTabelaOnIzleme = new DevExpress.XtraBars.BarButtonItem();
            this.btnTabelaGonder = new DevExpress.XtraBars.BarButtonItem();
            this.btnHavuz = new DevExpress.XtraBars.BarButtonItem();
            this.btnKayanYazi = new DevExpress.XtraBars.BarButtonItem();
            this.btnAyarlar = new DevExpress.XtraBars.BarSubItem();
            this.btnYenile = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDataReceiverStatus = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.stackPanelProductItems = new DevExpress.Utils.Layout.StackPanel();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanelProductItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTabelaOnIzleme,
            this.btnTabelaGonder,
            this.btnKayanYazi,
            this.btnAyarlar,
            this.btnHavuz,
            this.btnYenile,
            this.barDataReceiverStatus});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTabelaOnIzleme),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTabelaGonder),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHavuz),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKayanYazi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAyarlar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnYenile)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.RotateWhenVertical = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTabelaOnIzleme
            // 
            this.btnTabelaOnIzleme.Caption = "Tabela Önizleme";
            this.btnTabelaOnIzleme.Id = 0;
            this.btnTabelaOnIzleme.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTabelaOnIzleme.ImageOptions.Image")));
            this.btnTabelaOnIzleme.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTabelaOnIzleme.ImageOptions.LargeImage")));
            this.btnTabelaOnIzleme.Name = "btnTabelaOnIzleme";
            this.btnTabelaOnIzleme.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTabelaOnIzleme.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTabelaOnIzleme_ItemClick);
            // 
            // btnTabelaGonder
            // 
            this.btnTabelaGonder.Caption = "GÖNDER";
            this.btnTabelaGonder.Id = 1;
            this.btnTabelaGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTabelaGonder.ImageOptions.Image")));
            this.btnTabelaGonder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTabelaGonder.ImageOptions.LargeImage")));
            this.btnTabelaGonder.Name = "btnTabelaGonder";
            this.btnTabelaGonder.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTabelaGonder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTabelaGonder_ItemClick);
            // 
            // btnHavuz
            // 
            this.btnHavuz.Caption = "Ürün Havuzu";
            this.btnHavuz.Id = 4;
            this.btnHavuz.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHavuz.ImageOptions.Image")));
            this.btnHavuz.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHavuz.ImageOptions.LargeImage")));
            this.btnHavuz.Name = "btnHavuz";
            this.btnHavuz.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnHavuz.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHavuz_ItemClick);
            // 
            // btnKayanYazi
            // 
            this.btnKayanYazi.Caption = "Kayan Yazı";
            this.btnKayanYazi.Id = 2;
            this.btnKayanYazi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKayanYazi.ImageOptions.Image")));
            this.btnKayanYazi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKayanYazi.ImageOptions.LargeImage")));
            this.btnKayanYazi.Name = "btnKayanYazi";
            this.btnKayanYazi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnKayanYazi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKayanYazi_ItemClick);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Caption = "Ayarlar";
            this.btnAyarlar.Id = 3;
            this.btnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.Image")));
            this.btnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAyarlar.ImageOptions.LargeImage")));
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAyarlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAyarlar_ItemClick);
            // 
            // btnYenile
            // 
            this.btnYenile.Caption = "Yenile";
            this.btnYenile.Id = 5;
            this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
            this.btnYenile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.LargeImage")));
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnYenile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYenile_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barDataReceiverStatus)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDataReceiverStatus
            // 
            this.barDataReceiverStatus.Caption = "###";
            this.barDataReceiverStatus.Id = 6;
            this.barDataReceiverStatus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDataReceiverStatus.ImageOptions.Image")));
            this.barDataReceiverStatus.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barDataReceiverStatus.ImageOptions.LargeImage")));
            this.barDataReceiverStatus.Name = "barDataReceiverStatus";
            this.barDataReceiverStatus.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(828, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 677);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(828, 39);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 638);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(828, 39);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 638);
            // 
            // stackPanelProductItems
            // 
            this.stackPanelProductItems.AutoScroll = true;
            this.stackPanelProductItems.AutoSize = true;
            this.stackPanelProductItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanelProductItems.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanelProductItems.Location = new System.Drawing.Point(0, 39);
            this.stackPanelProductItems.Name = "stackPanelProductItems";
            this.stackPanelProductItems.Size = new System.Drawing.Size(828, 638);
            this.stackPanelProductItems.TabIndex = 6;
            this.stackPanelProductItems.UseSkinIndents = true;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "apply_16x16.png");
            this.imageCollection1.Images.SetKeyName(1, "cancel_16x16.png");
            this.imageCollection1.Images.SetKeyName(2, "warning_16x16.png");
            // 
            // frmMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 716);
            this.Controls.Add(this.stackPanelProductItems);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmMaster.IconOptions.LargeImage")));
            this.MinimumSize = new System.Drawing.Size(830, 750);
            this.Name = "frmMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HAS SARRAF";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanelProductItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnTabelaOnIzleme;
        private DevExpress.XtraBars.BarButtonItem btnTabelaGonder;
        private DevExpress.XtraBars.BarButtonItem btnKayanYazi;
        private DevExpress.XtraBars.BarSubItem btnAyarlar;
        private DevExpress.XtraBars.BarButtonItem btnHavuz;
        private DevExpress.XtraBars.BarButtonItem btnYenile;
        private DevExpress.XtraBars.BarButtonItem barDataReceiverStatus;
        private DevExpress.Utils.Layout.StackPanel stackPanelProductItems;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}