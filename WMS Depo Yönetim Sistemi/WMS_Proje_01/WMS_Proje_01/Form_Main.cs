using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace WMS_Proje_01
{
    public partial class Form_Main : RibbonForm
    {
        Form_StokKartListesi frmStokKartListesi;
        public Form_Main()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
           
        }

        private void btnStokKart_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            if (frmStokKartListesi == null || frmStokKartListesi.IsDisposed)
            {
                frmStokKartListesi = new Form_StokKartListesi();
                frmStokKartListesi.Show();
            }
            else
            {
                MessageBox.Show("Form Açık");
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {

        }

        private void RibbonControl_Click(object sender, EventArgs e)
        {

        }

        private void BtnCikis_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}