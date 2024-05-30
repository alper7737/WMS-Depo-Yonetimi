namespace WMS_Proje_01
{
    partial class Form_Stok_Kart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Stok_Kart));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtBirim = new DevExpress.XtraEditors.TextEdit();
            this.txtBirimFormul = new DevExpress.XtraEditors.TextEdit();
            this.txtStokGrubu = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimFormul.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokGrubu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnKaydet,
            this.btnSil});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(471, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.Ribbon_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "Kaydet";
            this.btnKaydet.Id = 1;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.LargeImage")));
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaydet_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "Sil";
            this.btnSil.Id = 2;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.LargeImage")));
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Tag = "";
            this.ribbonPageGroup1.Text = "Kaydet";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 463);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(471, 31);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 162);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Stok Kodu";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(10, 188);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Stok Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(10, 214);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Birim 1";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 236);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Birim Formul";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(10, 260);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Stok Grubu";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(87, 162);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(4, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = ":";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(87, 188);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(4, 13);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = ":";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(87, 214);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(4, 13);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = ":";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(87, 236);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(4, 13);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = ":";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(87, 260);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(4, 13);
            this.labelControl10.TabIndex = 11;
            this.labelControl10.Text = ":";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.EditValue = "";
            this.txtStokKodu.Location = new System.Drawing.Point(116, 160);
            this.txtStokKodu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokKodu.MenuManager = this.ribbon;
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtStokKodu.Size = new System.Drawing.Size(229, 20);
            this.txtStokKodu.TabIndex = 12;
            this.txtStokKodu.EditValueChanged += new System.EventHandler(this.txtStokKodu_EditValueChanged);
            // 
            // txtStokAdi
            // 
            this.txtStokAdi.EditValue = "";
            this.txtStokAdi.Location = new System.Drawing.Point(116, 183);
            this.txtStokAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokAdi.MenuManager = this.ribbon;
            this.txtStokAdi.Name = "txtStokAdi";
            this.txtStokAdi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtStokAdi.Size = new System.Drawing.Size(337, 20);
            this.txtStokAdi.TabIndex = 13;
            // 
            // txtBirim
            // 
            this.txtBirim.EditValue = "";
            this.txtBirim.Location = new System.Drawing.Point(116, 209);
            this.txtBirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirim.MenuManager = this.ribbon;
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtBirim.Size = new System.Drawing.Size(229, 20);
            this.txtBirim.TabIndex = 14;
            // 
            // txtBirimFormul
            // 
            this.txtBirimFormul.EditValue = "";
            this.txtBirimFormul.Location = new System.Drawing.Point(116, 233);
            this.txtBirimFormul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirimFormul.MenuManager = this.ribbon;
            this.txtBirimFormul.Name = "txtBirimFormul";
            this.txtBirimFormul.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtBirimFormul.Size = new System.Drawing.Size(229, 20);
            this.txtBirimFormul.TabIndex = 15;
            // 
            // txtStokGrubu
            // 
            this.txtStokGrubu.EditValue = "";
            this.txtStokGrubu.Location = new System.Drawing.Point(116, 256);
            this.txtStokGrubu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStokGrubu.MenuManager = this.ribbon;
            this.txtStokGrubu.Name = "txtStokGrubu";
            this.txtStokGrubu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtStokGrubu.Size = new System.Drawing.Size(229, 20);
            this.txtStokGrubu.TabIndex = 16;
            // 
            // Form_Stok_Kart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 494);
            this.Controls.Add(this.txtStokGrubu);
            this.Controls.Add(this.txtBirimFormul);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.txtStokAdi);
            this.Controls.Add(this.txtStokKodu);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Stok_Kart";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Stok Kart";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Stok_Kart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirimFormul.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokGrubu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        public DevExpress.XtraEditors.TextEdit txtStokKodu;
        public DevExpress.XtraEditors.TextEdit txtStokAdi;
        public DevExpress.XtraEditors.TextEdit txtBirim;
        public DevExpress.XtraEditors.TextEdit txtBirimFormul;
        public DevExpress.XtraEditors.TextEdit txtStokGrubu;
        private DevExpress.XtraBars.BarButtonItem btnSil;
    }
}