using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace WMS_Proje_01
{
    public class Class_Baglanti
    {
        DataSet _ds = new DataSet();
        public SqlConnection _conn()
        {
            SqlConnection _conn = new SqlConnection("Server=" + Properties.Settings.Default.Server.ToString()
                                                              + ";Database=" + Properties.Settings.Default.Database.ToString()
                                                              + ";user id=" + Properties.Settings.Default.User.ToString()
                                                              + ";password=" + Properties.Settings.Default.Password.ToString()
                                                              + ";LANGUAGE=Turkish"
                                                              + ";Connection Timeout=10"
                                                              + ";Application Name= " + this.GetType().Assembly.GetName().Name.ToString());

            return _conn;
        }

        public DataTable grid_StokKartListesi(SqlConnection _conn)
        {
            _ds.Tables.Clear();

            string _Query = " SET LANGUAGE Turkish; "
                          +  " SELECT [St_Kod] "
                          +  "          ,[St_Ad] "
                          +  "          ,[St_BirimKod1] "
                          +  "          ,[St_BirimKod1] "
                          +  "          ,[St_StokGrubu1] "  
                          +  "          ,[Kayit_Olusturan] "
                          +  "          ,[Kayit_OlusTarih] "
                          +  "          ,[Kayit_Degistiren] "
                          + "          ,[Kayit_DegisTarih] "
                          +  "      FROM [WMS_Proje].[dbo].[M3_Stok_Kart] ";
                        
                          

            if (_conn.State == ConnectionState.Closed) { _conn.Open(); }
            SqlCommand _sqlCommand = new SqlCommand(_Query, _conn);
            _sqlCommand.CommandTimeout = 0;

            SqlDataAdapter _da = new SqlDataAdapter(_sqlCommand);

            DataTable dt_StokKart = new DataTable();

            _da.Fill(dt_StokKart);
            if (_conn.State == ConnectionState.Open) { _conn.Close(); }

            return dt_StokKart;


        }

        public void Insert_StokKart(SqlConnection _Mir, string St_Kod, string St_Ad, string St_BirimKod1
                                                                    , string St_BirimFrm1, string St_StokGrubu1
                                                                    , string Kayit_Olusturan, DateTime Kayit_OlusTarih, string Kayit_Degistiren, DateTime Kayit_DegisTarih)
        {


            try
            {

                string _Query = string.Format("  SET LANGUAGE Turkish;  INSERT INTO [dbo].[M3_Stok_Kart]   "
                    + "  ([St_Kod],[St_Ad] ,[St_BirimKod1],[St_BirimFrm1],[St_StokGrubu1],[Kayit_Olusturan],[Kayit_OlusTarih],[Kayit_Degistiren],[Kayit_DegisTarih])"
                    + " VALUES "
                    + " ('{0}' ,'{1}','{2}' ,'{3}','{4}','{5}',Convert(Datetime,'{6}'),'{7}',Convert(Datetime,'{8}'))"
                    , St_Kod, St_Ad, St_BirimKod1, St_BirimFrm1, St_StokGrubu1, Kayit_Olusturan, Kayit_OlusTarih
                    , Kayit_Degistiren, Kayit_DegisTarih);



                if (_Mir.State == ConnectionState.Closed) { _Mir.Open(); }
                SqlCommand _SqlCommand = new SqlCommand(_Query, _Mir);
                _SqlCommand.ExecuteNonQuery();
                if (_Mir.State == ConnectionState.Open) { _Mir.Close(); }

            }
            catch (Exception ex)
            {
            }
        }

        public void Update_StokKart(SqlConnection _Mir, string St_Kod, string St_Ad, string St_BirimKod1
                                                                    , string St_BirimFrm1, string St_StokGrubu1)
        {


            try
            {

                string _Query = string.Format("  SET LANGUAGE Turkish;  UPDATE [dbo].[M3_Stok_Kart]   "
                                               +" SET    [St_Ad] = '{0}' ,   [St_BirimKod1] = '{1}' ,   [St_BirimFrm1] = '{2}' ,   [St_StokGrubu1] = '{3}' ,   [Kayit_Olusturan] = ''  "
                                               +" ,   [Kayit_Degistiren] = '' ,   [Kayit_DegisTarih] = GETDATE()   Where St_Kod='{4}'"
                                                , St_Ad, St_BirimKod1, St_BirimFrm1, St_StokGrubu1, St_Kod);
                    
                    



                if (_Mir.State == ConnectionState.Closed) { _Mir.Open(); }
                SqlCommand _SqlCommand = new SqlCommand(_Query, _Mir);
                _SqlCommand.ExecuteNonQuery();
                if (_Mir.State == ConnectionState.Open) { _Mir.Close(); }

            }
            catch (Exception ex)
            {
            }
        }

        public void Delete_StokKart(SqlConnection _Mir, string St_Kod)
        {


            try
            {

                string _Query = string.Format("  SET LANGUAGE Turkish;  DELETE FROM [dbo].[M3_Stok_Kart]   Where St_Kod='{0}'"
                                                , St_Kod);





                if (_Mir.State == ConnectionState.Closed) { _Mir.Open(); }
                SqlCommand _SqlCommand = new SqlCommand(_Query, _Mir);
                _SqlCommand.ExecuteNonQuery();
                if (_Mir.State == ConnectionState.Open) { _Mir.Close(); }

            }
            catch (Exception ex)
            {
            }
        }

        public int value_StokKartiVarmi(SqlConnection _conn, string St_Kod)
        {




            string _Query = string.Format(" SET LANGUAGE Turkish;   SELECT  Count(*) From M3_Stok_Kart Where St_Kod='{0}'", St_Kod);



            if (_conn.State == ConnectionState.Closed) { _conn.Open(); }

            SqlCommand _sqlCommand = new SqlCommand(_Query, _conn);
            _sqlCommand.CommandTimeout = 0;
            int _Value = Convert.ToInt32(_sqlCommand.ExecuteScalar());
            if (_conn.State == ConnectionState.Open) { _conn.Close(); }


            return _Value;


        }

        public string value_StokKartBilgi(SqlConnection _conn, string St_Kod,string _Alan)
        {




            string _Query = string.Format(string.Format(" SET LANGUAGE Turkish;   SELECT TOP 1 {0} From M3_Stok_Kart Where St_Kod='{{0}}'", _Alan), St_Kod);



            if (_conn.State == ConnectionState.Closed) { _conn.Open(); }

            SqlCommand _sqlCommand = new SqlCommand(_Query, _conn);
            _sqlCommand.CommandTimeout = 0;
            string _Value = _sqlCommand.ExecuteScalar().ToString();
            if (_conn.State == ConnectionState.Open) { _conn.Close(); }


            return _Value;


        }
    }
}
