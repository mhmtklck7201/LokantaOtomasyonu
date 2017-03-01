using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace LOKANTA_OTOMASYONU
{
    class cURUNCESITLERI
    {
        cGENEL gnl = new cGENEL();
        public bool masadurumu(int butonadı, int durum)
        {
            bool sonuc = false;
            SqlConnection bgln = new SqlConnection(gnl.bgln);
            SqlCommand cmd = new SqlCommand("select from MASALAR where ID=@masaid and DURUM=@durum",bgln); 
            cmd.Parameters.Add("@masaid",System.Data.SqlDbType.Int).Value=butonadı;
            cmd.Parameters.Add("@durum", System.Data.SqlDbType.Int).Value = durum;
            try
            {
                if (bgln.State == ConnectionState.Closed)
                {
                    bgln.Open();
                }
                sonuc = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally {
                bgln.Dispose();
                bgln.Close();
            }
            return sonuc;
        }
        public void urunal(ListView cesitler, Button btn)
        {
            cesitler.Items.Clear();
            SqlConnection bgln = new SqlConnection(gnl.bgln);
            SqlCommand cmd = new SqlCommand("select URUNAD,FIYAT,URUNLER.ID from KATEGORI INNER JOIN URUNLER ON KATEGORI.ID=URUNLER.KATEGORIID where URUNLER.KATEGORIID=@kategoriid",bgln);
            string aa = btn.Name;
            int uzunluk = aa.Length;
            cmd.Parameters.Add("@kategoriid", System.Data.SqlDbType.Int).Value = aa.Substring(uzunluk-1,1);
            if (bgln.State == ConnectionState.Closed)
            {
                bgln.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                cesitler.Items.Add(dr["URUNAD"].ToString());
                cesitler.Items[i].SubItems.Add(dr["FIYAT"].ToString());
                cesitler.Items[i].SubItems.Add(dr["ID"].ToString());
                i++; 
            }
            dr.Close();
            bgln.Dispose();
            bgln.Close();
        }
    }
}
