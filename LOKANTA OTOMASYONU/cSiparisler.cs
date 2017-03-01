using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
 
using System.Data;
namespace LOKANTA_OTOMASYONU
{
    class cSiparisler
    {
         
        private int addisyonid;
        private int urunid;
        private int adet;
        private int masaid; 
        

         
        public int Masaid
        {
            get { return masaid; }
            set { masaid = value; }
        }

        public int Adet
        {
            get { return adet; }
            set { adet = value; }
        }

        public int Urunid
        {
            get { return urunid; }
            set { urunid = value; }
        }

        public int Addisyonid
        {
            get { return addisyonid; }
            set { addisyonid = value; }
        }
        public bool siparisekle(cSiparisler siparis) {
           
            bool sonuc = false;
            SqlConnection bgln1 = new SqlConnection("Data Source=GUVEN\\SQLEXPRESS;Initial Catalog=LOKANTA_OTOMASYONU;MultipleActiveResultSets=True;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into HAREKETLER (ADDISYONID,URUNID,MASAID,ADET) VALUES (@adisyonid,@urunid,@masaid,@adet)",bgln1);
            try
            {
                if (bgln1.State == ConnectionState.Closed) { bgln1.Open(); }
                cmd.Parameters.Add("@adisyonid", SqlDbType.Int).Value = siparis.Addisyonid;
                cmd.Parameters.Add("@urunid", SqlDbType.Int).Value = siparis.Urunid;
                cmd.Parameters.Add("@masaid", SqlDbType.Int).Value = siparis.Masaid;
                cmd.Parameters.Add("@adet", SqlDbType.Int).Value = siparis.Adet;
                sonuc = Convert.ToBoolean(cmd.ExecuteNonQuery());

            }
            catch (Exception ex) { string hata = ex.Message; }
            finally { 
                bgln1.Close();
               bgln1.Dispose();
            }
            return sonuc;
        }
       
    }
}
