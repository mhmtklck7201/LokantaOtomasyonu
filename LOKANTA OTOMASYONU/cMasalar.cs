using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LOKANTA_OTOMASYONU
{
    class cMasalar
    { 
        
        cGENEL gnl = new cGENEL();
        public void masadurumdegistir(string butonname, int state)
        {
           
            SqlConnection bgln1 = new SqlConnection(gnl.bgln);
            SqlCommand cmd = new SqlCommand("update MASALAR set DURUM=@durum where ID=@masano",bgln1);
            if (bgln1.State == ConnectionState.Closed) { bgln1.Open(); }
            string aa = butonname;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            cmd.Parameters.Add("@masano", SqlDbType.Int).Value = aa.Substring(uzunluk-1,1);
            cmd.ExecuteNonQuery();
            bgln1.Close();
            bgln1.Dispose();


        }
        public int MasaNumarasıAl(string deger)
        {
            string aa = deger;
            int uzunluk = aa.Length;
            return Convert.ToInt32(aa.Substring(uzunluk-1,1));
        }
        public bool MasaDurumuAl(int butonname, int state)
        {

            bool result = false;
            SqlConnection bgln1 = new SqlConnection(gnl.bgln);
            SqlCommand cmd = new SqlCommand("select DURUM from MASALAR where ID=@masaid and DURUM=@durum", bgln1);
            cmd.Parameters.Add("@masaid",SqlDbType.Int).Value=butonname;
            cmd.Parameters.Add("@durum", SqlDbType.Int).Value = state;
            try{
                if (bgln1.State == ConnectionState.Closed)
                {
                    bgln1.Open();
                }
                result = Convert.ToBoolean(cmd.ExecuteScalar());
              }
            catch (Exception ex) { string hata = ex.Message; }
            finally
            {
                bgln1.Close();
                bgln1.Dispose();
            }
            return result;
        }
    }
}
