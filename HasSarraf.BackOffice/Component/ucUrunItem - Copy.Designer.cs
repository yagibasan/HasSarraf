namespace HasSarraf.BackOffice.Component
{
    partial class ucUrunItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUrunItem));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMarjAyari = new DevExpress.XtraEditors.SimpleButton();
            this.spinSatis = new DevExpress.XtraEditors.SpinEdit();
            this.spinAlis = new DevExpress.XtraEditors.SpinEdit();
            this.lblOrijinalAlisFiyati = new DevExpress.XtraEditors.LabelControl();
            this.lblFarkAlis = new DevExpress.XtraEditors.LabelControl();
            this.lblOrijinalSatisFiyati = new DevExpress.XtraEditors.LabelControl();
            this.lblFarkSatis = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunAdi = new DevExpress.XtraEditors.LabelControl();
            this.timerAlarmAlis = new System.Windows.Forms.Timer(this.components);
            this.timerAlarmSatis = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSatis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAlis.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.GhostWhite;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.tableLayoutPanel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(842, 54);
            this.panelControl1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.btnMarjAyari, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.spinSatis, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.spinAlis, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOrijinalAlisFiyati, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFarkAlis, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOrijinalSatisFiyati, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFarkSatis, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblUrunAdi, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(838, 50);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnMarjAyari
            // 
            this.btnMarjAyari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMarjAyari.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnMarjAyari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMarjAyari.ImageOptions.Image")));
            this.btnMarjAyari.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btnMarjAyari.Location = new System.Drawing.Point(559, 5);
            this.btnMarjAyari.Name = "btnMarjAyari";
            this.tableLayoutPanel1.SetRowSpan(this.btnMarjAyari, 2);
            this.btnMarjAyari.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnMarjAyari.Size = new System.Drawing.Size(34, 40);
            this.btnMarjAyari.TabIndex = 13;
            this.btnMarjAyari.Click += new System.EventHandler(this.btnMarjAyari_Click);
            // 
            // spinSatis
            // 
            this.spinSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinSatis.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinSatis.Location = new System.Drawing.Point(599, 5);
            this.spinSatis.Name = "spinSatis";
            this.spinSatis.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.spinSatis.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.White;
            this.spinSatis.Properties.AllowMouseWheel = false;
            this.spinSatis.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.spinSatis.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.spinSatis.Properties.Appearance.Options.UseFont = true;
            this.spinSatis.Properties.Appearance.Options.UseForeColor = true;
            this.spinSatis.Properties.AutoHeight = false;
            this.spinSatis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSatis.Properties.DisplayFormat.FormatString = "{0:N0}";
            this.spinSatis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSatis.Properties.EditFormat.FormatString = "{0:N0}";
            this.spinSatis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSatis.Properties.IsFloatValue = false;
            this.spinSatis.Properties.MaskSettings.Set("mask", "N0");
            this.spinSatis.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tableLayoutPanel1.SetRowSpan(this.spinSatis, 2);
            this.spinSatis.Size = new System.Drawing.Size(144, 40);
            this.spinSatis.TabIndex = 11;
            this.spinSatis.EditValueChanged += new System.EventHandler(this.spinSatis_EditValueChanged);
            // 
            // spinAlis
            // 
            this.spinAlis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinAlis.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinAlis.Location = new System.Drawing.Point(409, 5);
            this.spinAlis.Name = "spinAlis";
            this.spinAlis.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.spinAlis.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.White;
            this.spinAlis.Properties.AllowMouseWheel = false;
            this.spinAlis.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.spinAlis.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.spinAlis.Properties.Appearance.Options.UseFont = true;
            this.spinAlis.Properties.Appearance.Options.UseForeColor = true;
            this.spinAlis.Properties.AutoHeight = false;
            this.spinAlis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinAlis.Properties.DisplayFormat.FormatString = "{0:N0}";
            this.spinAlis.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAlis.Properties.EditFormat.FormatString = "{0:N0}";
            this.spinAlis.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinAlis.Properties.IsFloatValue = false;
            this.spinAlis.Properties.MaskSettings.Set("mask", "N0");
            this.spinAlis.Properties.MaxValue = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.tableLayoutPanel1.SetRowSpan(this.spinAlis, 2);
            this.spinAlis.Size = new System.Drawing.Size(144, 40);
            this.spinAlis.TabIndex = 2;
            this.spinAlis.EditValueChanged += new System.EventHandler(this.spinAlis_EditValueChanged);
            // 
            // lblOrijinalAlisFiyati
            // 
            this.lblOrijinalAlisFiyati.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.lblOrijinalAlisFiyati.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrijinalAlisFiyati.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.lblOrijinalAlisFiyati.Appearance.Options.UseBorderColor = true;
            this.lblOrijinalAlisFiyati.Appearance.Options.UseFont = true;
            this.lblOrijinalAlisFiyati.Appearance.Options.UseForeColor = true;
            this.lblOrijinalAlisFiyati.Appearance.Options.UseTextOptions = true;
            this.lblOrijinalAlisFiyati.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblOrijinalAlisFiyati.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOrijinalAlisFiyati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrijinalAlisFiyati.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblOrijinalAlisFiyati.LineVisible = true;
            this.lblOrijinalAlisFiyati.Location = new System.Drawing.Point(322, 4);
            this.lblOrijinalAlisFiyati.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblOrijinalAlisFiyati.Name = "lblOrijinalAlisFiyati";
            this.lblOrijinalAlisFiyati.Size = new System.Drawing.Size(78, 19);
            this.lblOrijinalAlisFiyati.TabIndex = 9;
            this.lblOrijinalAlisFiyati.Text = "0";
            // 
            // lblFarkAlis
            // 
            this.lblFarkAlis.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFarkAlis.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.lblFarkAlis.Appearance.Options.UseFont = true;
            this.lblFarkAlis.Appearance.Options.UseForeColor = true;
            this.lblFarkAlis.Appearance.Options.UseTextOptions = true;
            this.lblFarkAlis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblFarkAlis.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFarkAlis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFarkAlis.LineLocation = DevExpress.XtraEditors.LineLocation.Right;
            this.lblFarkAlis.LineVisible = true;
            this.lblFarkAlis.Location = new System.Drawing.Point(322, 27);
            this.lblFarkAlis.Margin = new System.Windows.Forms.Padding(6, 2, 4, 2);
            this.lblFarkAlis.Name = "lblFarkAlis";
            this.lblFarkAlis.Size = new System.Drawing.Size(80, 19);
            this.lblFarkAlis.TabIndex = 10;
            this.lblFarkAlis.Text = "0";
            // 
            // lblOrijinalSatisFiyati
            // 
            this.lblOrijinalSatisFiyati.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOrijinalSatisFiyati.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this.lblOrijinalSatisFiyati.Appearance.Options.UseFont = true;
            this.lblOrijinalSatisFiyati.Appearance.Options.UseForeColor = true;
            this.lblOrijinalSatisFiyati.Appearance.Options.UseTextOptions = true;
            this.lblOrijinalSatisFiyati.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblOrijinalSatisFiyati.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOrijinalSatisFiyati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrijinalSatisFiyati.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblOrijinalSatisFiyati.LineVisible = true;
            this.lblOrijinalSatisFiyati.Location = new System.Drawing.Point(752, 4);
            this.lblOrijinalSatisFiyati.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblOrijinalSatisFiyati.Name = "lblOrijinalSatisFiyati";
            this.lblOrijinalSatisFiyati.Size = new System.Drawing.Size(78, 19);
            this.lblOrijinalSatisFiyati.TabIndex = 9;
            this.lblOrijinalSatisFiyati.Text = "0";
            // 
            // lblFarkSatis
            // 
            this.lblFarkSatis.Appearance.BorderColor = System.Drawing.Color.Green;
            this.lblFarkSatis.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFarkSatis.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.lblFarkSatis.Appearance.Options.UseBorderColor = true;
            this.lblFarkSatis.Appearance.Options.UseFont = true;
            this.lblFarkSatis.Appearance.Options.UseForeColor = true;
            this.lblFarkSatis.Appearance.Options.UseTextOptions = true;
            this.lblFarkSatis.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblFarkSatis.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFarkSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFarkSatis.LineLocation = DevExpress.XtraEditors.LineLocation.Right;
            this.lblFarkSatis.LineVisible = true;
            this.lblFarkSatis.Location = new System.Drawing.Point(752, 27);
            this.lblFarkSatis.Margin = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.lblFarkSatis.Name = "lblFarkSatis";
            this.lblFarkSatis.Size = new System.Drawing.Size(78, 19);
            this.lblFarkSatis.TabIndex = 10;
            this.lblFarkSatis.Text = "0";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.lblUrunAdi.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblUrunAdi.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.lblUrunAdi.Appearance.Options.UseBorderColor = true;
            this.lblUrunAdi.Appearance.Options.UseFont = true;
            this.lblUrunAdi.Appearance.Options.UseForeColor = true;
            this.lblUrunAdi.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblUrunAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUrunAdi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUrunAdi.Location = new System.Drawing.Point(5, 5);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tableLayoutPanel1.SetRowSpan(this.lblUrunAdi, 2);
            this.lblUrunAdi.Size = new System.Drawing.Size(308, 40);
            this.lblUrunAdi.TabIndex = 14;
            this.lblUrunAdi.Text = "24. A GRAM ALTIN";
            this.lblUrunAdi.DoubleClick += new System.EventHandler(this.lblUrunAdi_DoubleClick);
            // 
            // timerAlarmAlis
            // 
            this.timerAlarmAlis.Interval = 500;
            this.timerAlarmAlis.Tick += new System.EventHandler(this.timerAlarmAlis_Tick);
            // 
            // timerAlarmSatis
            // 
            this.timerAlarmSatis.Interval = 500;
            this.timerAlarmSatis.Tick += new System.EventHandler(this.timerAlarmSatis_Tick);
            // 
            // ucUrunItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "ucUrunItem";
            this.Size = new System.Drawing.Size(842, 54);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinSatis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAlis.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SpinEdit spinAlis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblOrijinalAlisFiyati;
        private DevExpress.XtraEditors.LabelControl lblFarkAlis;
        private DevExpress.XtraEditors.LabelControl lblOrijinalSatisFiyati;
        private DevExpress.XtraEditors.LabelControl lblFarkSatis;
        private DevExpress.XtraEditors.SpinEdit spinSatis;
        private DevExpress.XtraEditors.SimpleButton btnMarjAyari;
        private DevExpress.XtraEditors.LabelControl lblUrunAdi;
        private System.Windows.Forms.Timer timerAlarmAlis;
        private System.Windows.Forms.Timer timerAlarmSatis;
    }
}
