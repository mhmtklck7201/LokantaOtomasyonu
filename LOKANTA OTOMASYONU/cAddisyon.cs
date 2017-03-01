using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace LOKANTA_OTOMASYONU
{
    class cAddisyon
    {
        private int masaid;
        private DateTime tarih;
        private int durum;
        private int personelid;

        public int Masaid
        {
            get { return masaid; }
            set { masaid = value; }
        }
       

        public int Personelid
        {
            get { return personelid; }
            set { personelid = value; }
        }
        

        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        

        public int Durum
        {
            get { return durum; }
            set { durum = value; }
        }
        cGENEL gnl = new cGENEL();
        public int AdisyonAl(int masaid)
        {
            SqlConnection bgln = new SqlConnection(gnl.bgln);
            SqlCommand cmd = new SqlCommand("select top 1 ID from ADDISYON where MASAID=@masaid order by ID desc",bgln);
            cmd.Parameters.Add("@masaid", SqlDbType.Int).Value = masaid;
            try
            {
                if (bgln.State == ConnectionState.Closed)
                {
                    bgln.Open();
                }
                masaid = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                string hata = Ex.Message;
            }
            finally { bgln.Close(); }
            return masaid;
        }
        public bool adisyonayar(cAddisyon bilgi)
        {
                bool sonuc = false;
                SqlConnection bgln1 = new SqlConnection(gnl.bgln);
                SqlCommand cmd = new SqlCommand("insert into ADDISYON(MASAID,PERSONELID,TARIH,DURUM) VALUES (@masaid,@personelid,@tarih,@durum)", bgln1);
                try
                {
                    if (bgln1.State == ConnectionState.Closed) { bgln1.Open(); }
                  cmd.Parameters.Add("@masaid", SqlDbType.Int).Value = bilgi.Masaid;
                cmd.Parameters.Add("@personelid", SqlDbType.Int).Value = bilgi.Personelid;
                cmd.Parameters.Add("@tarih", SqlDbType.DateTime).Value = bilgi.Tarih;
                cmd.Parameters.Add("@durum", SqlDbType.Bit).Value = 0;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (Exception ex) { string hata = ex.Message; }
            finally
            {
                bgln1.Close();
                bgln1.Dispose();
            }
            return sonuc;

        }
    }
}
