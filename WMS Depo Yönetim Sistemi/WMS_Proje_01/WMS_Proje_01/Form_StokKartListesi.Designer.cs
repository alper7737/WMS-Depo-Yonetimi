namespace WMS_Proje_01
{
    partial class Form_StokKartListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_StokKartListesi));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnYeniStokKart = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridStokKartListesi = new DevExpress.XtraGrid.GridControl();
            this.grvStokKartListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokKartListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStokKartListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnYeniStokKart});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1151, 179);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnYeniStokKart
            // 
            this.btnYeniStokKart.Caption = "Yeni Kart";
            this.btnYeniStokKart.Glyph = ((System.Drawing.Image)(resources.GetObject("btnYeniStokKart.Glyph")));
            this.btnYeniStokKart.Id = 1;
            this.btnYeniStokKart.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnYeniStokKart.LargeGlyph")));
            this.btnYeniStokKart.Name = "btnYeniStokKart";
            this.btnYeniStokKart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniStokKart_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnYeniStokKart);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "İşlem";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 602);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1151, 40);
            // 
            // gridStokKartListesi
            // 
            this.gridStokKartListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStokKartListesi.Location = new System.Drawing.Point(0, 179);
            this.gridStokKartListesi.MainView = this.grvStokKartListesi;
            this.gridStokKartListesi.MenuManager = this.ribbon;
            this.gridStokKartListesi.Name = "gridStokKartListesi";
            this.gridStokKartListesi.Size = new System.Drawing.Size(1151, 423);
            this.gridStokKartListesi.TabIndex = 2;
            this.gridStokKartListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvStokKartListesi});
            // 
            // grvStokKartListesi
            // 
            this.grvStokKartListesi.GridControl = this.gridStokKartListesi;
            this.grvStokKartListesi.Name = "grvStokKartListesi";
            this.grvStokKartListesi.OptionsView.ShowAutoFilterRow = true;
            this.grvStokKartListesi.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.grvStokKartListesi.DoubleClick += new System.EventHandler(this.grvStokKartListesi_DoubleClick);
            // 
            // Form_StokKartListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 642);
            this.Controls.Add(this.gridStokKartListesi);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Form_StokKartListesi";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Stok Kart Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_StokKartListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStokKartListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvStokKartListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraGrid.GridControl gridStokKartListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView grvStokKartListesi;
        private DevExpress.XtraBars.BarButtonItem btnYeniStokKart;
    }
}