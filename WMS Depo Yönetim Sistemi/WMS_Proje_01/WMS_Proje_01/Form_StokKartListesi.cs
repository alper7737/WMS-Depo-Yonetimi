using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WMS_Proje_01
{
    public partial class Form_StokKartListesi : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form_Stok_Kart frm_Form_Stok_Kart = (Form_Stok_Kart)Application.OpenForms["Form_Stok_Kart"];
        Class_Baglanti _Baglanti = new Class_Baglanti();
        Form_Stok_Kart frm_StokKart;
        public Form_StokKartListesi()
        {
            InitializeComponent();
        }

        public void _grid_StokKartListesi()
        {
            gridStokKartListesi.DataSource=null;
            grvStokKartListesi.Columns.Clear();
            gridStokKartListesi.DataSource = _Baglanti.grid_StokKartListesi(_Baglanti._conn());
            grvStokKartListesi.OptionsBehavior.Editable = false;
        }
        private void Form_StokKartListesi_Load(object sender, EventArgs e)
        {
            _grid_StokKartListesi();
        }

        private void btnYeniStokKart_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (frm_StokKart == null || frm_StokKart.IsDisposed)
            {
                frm_StokKart = new Form_Stok_Kart();
                frm_StokKart.Show();
            }
            else
            {
                MessageBox.Show("Form Açık");
            }
           
        }

        private void grvStokKartListesi_DoubleClick(object sender, EventArgs e)
        {
            frm_StokKart = new Form_Stok_Kart();
            frm_StokKart.txtStokKodu.EditValue = grvStokKartListesi.GetRowCellValue(grvStokKartListesi.FocusedRowHandle, grvStokKartListesi.Columns["St_Kod"]).ToString();
            frm_StokKart.txtStokAdi.EditValue = grvStokKartListesi.GetRowCellValue(grvStokKartListesi.FocusedRowHandle, grvStokKartListesi.Columns["St_Ad"]).ToString();
            frm_StokKart.txtBirim.EditValue = grvStokKartListesi.GetRowCellValue(grvStokKartListesi.FocusedRowHandle, grvStokKartListesi.Columns["St_BirimKod1"]).ToString();
            frm_StokKart.txtBirimFormul.EditValue = grvStokKartListesi.GetRowCellValue(grvStokKartListesi.FocusedRowHandle, grvStokKartListesi.Columns["St_BirimKod1"]).ToString();
            frm_StokKart.txtStokGrubu.EditValue = grvStokKartListesi.GetRowCellValue(grvStokKartListesi.FocusedRowHandle, grvStokKartListesi.Columns["St_StokGrubu1"]).ToString();
            frm_StokKart.Show();
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}