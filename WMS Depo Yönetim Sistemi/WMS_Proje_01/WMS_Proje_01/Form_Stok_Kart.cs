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
    
    public partial class Form_Stok_Kart : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Class_Baglanti _Baglanti = new Class_Baglanti();
        Form_StokKartListesi frm_StokKartListesi = (Form_StokKartListesi)Application.OpenForms["Form_StokKartListesi"];
        public Form_Stok_Kart()
        {
            InitializeComponent();
        }

        private void btnKaydet_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_Baglanti.value_StokKartiVarmi(_Baglanti._conn(),txtStokKodu.EditValue.ToString()) > 0)
            {
                _Baglanti.Update_StokKart(_Baglanti._conn()
                , txtStokKodu.EditValue.ToString()
                , txtStokAdi.EditValue.ToString()
                , txtBirim.EditValue.ToString()
                , txtBirimFormul.EditValue.ToString()
                , txtStokGrubu.EditValue.ToString());

                frm_StokKartListesi._grid_StokKartListesi();

                MessageBox.Show("Kayıtlar güncellendi");
               
            }
            else{

            _Baglanti.Insert_StokKart(_Baglanti._conn()
                , txtStokKodu.EditValue.ToString()
                , txtStokAdi.EditValue.ToString()
                , txtBirim.EditValue.ToString()
                , txtBirimFormul.EditValue.ToString()
                , txtStokGrubu.EditValue.ToString()
                , "", DateTime.Now
                , "", DateTime.Now);

                frm_StokKartListesi._grid_StokKartListesi();

                MessageBox.Show("Yeni Kart Eklendi");
                }

        }

        private void txtStokKodu_EditValueChanged(object sender, EventArgs e)
        {
            if (_Baglanti.value_StokKartiVarmi(_Baglanti._conn(), txtStokKodu.EditValue.ToString()) > 0)
            {

                txtStokAdi.EditValue = _Baglanti.value_StokKartBilgi(_Baglanti._conn(), txtStokKodu.EditValue.ToString(), "St_Ad");
                txtBirim.EditValue = _Baglanti.value_StokKartBilgi(_Baglanti._conn(), txtStokKodu.EditValue.ToString(), "St_BirimKod1");
                txtBirimFormul.EditValue = _Baglanti.value_StokKartBilgi(_Baglanti._conn(), txtStokKodu.EditValue.ToString(), "St_BirimFrm1");
                txtStokGrubu.EditValue = _Baglanti.value_StokKartBilgi(_Baglanti._conn(), txtStokKodu.EditValue.ToString(), "St_StokGrubu1");
            }
            else
            {
                txtStokAdi.EditValue = "";
                txtBirim.EditValue = "";
                txtBirimFormul.EditValue = "";
                txtStokGrubu.EditValue =  "";
            }

            

        }

        private void btnSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_Baglanti.value_StokKartiVarmi(_Baglanti._conn(), txtStokKodu.EditValue.ToString()) > 0)
            {
                _Baglanti.Delete_StokKart(_Baglanti._conn(), txtStokKodu.EditValue.ToString());

                frm_StokKartListesi._grid_StokKartListesi();
                MessageBox.Show("Stok Kartı Silindi");
            }
            else
            {
                MessageBox.Show("Stok Kartı Bulunamadı");
            }
        }

        private void Form_Stok_Kart_Load(object sender, EventArgs e)
        {

        }

        private void Ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}