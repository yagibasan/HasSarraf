namespace GoldOctopus.Controls
{
    partial class ucManuelTabela
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucManuelTabela));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearPrice = new DevExpress.XtraEditors.SimpleButton();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(50, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 383);
            this.panel1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.AllowFocus = false;
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKaydet.Location = new System.Drawing.Point(604, 409);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnKaydet.Size = new System.Drawing.Size(146, 28);
            this.btnKaydet.TabIndex = 17;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AllowFocus = false;
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.ImageOptions.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(50, 409);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnRefresh.Size = new System.Drawing.Size(104, 28);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Fiyatları Yenile";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClearPrice
            // 
            this.btnClearPrice.AllowFocus = false;
            this.btnClearPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearPrice.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClearPrice.Appearance.Options.UseFont = true;
            this.btnClearPrice.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClearPrice.ImageOptions.Image")));
            this.btnClearPrice.Location = new System.Drawing.Point(160, 409);
            this.btnClearPrice.Name = "btnClearPrice";
            this.btnClearPrice.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnClearPrice.Size = new System.Drawing.Size(104, 28);
            this.btnClearPrice.TabIndex = 19;
            this.btnClearPrice.Text = "Temizle";
            this.btnClearPrice.Click += new System.EventHandler(this.btnClearPrice_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.AllowFocus = false;
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPreview.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnPreview.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPreview.Appearance.Options.UseBackColor = true;
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(494, 409);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnPreview.Size = new System.Drawing.Size(104, 28);
            this.btnPreview.TabIndex = 20;
            this.btnPreview.Text = "ÖNİZLEME";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // ucManuelTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnClearPrice);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.panel1);
            this.Name = "ucManuelTabela";
            this.Size = new System.Drawing.Size(800, 449);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnClearPrice;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
    }
}
