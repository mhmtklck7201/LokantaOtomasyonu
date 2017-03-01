using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LOKANTA_OTOMASYONU
{
    public partial class MASALAR : Form
    {
        public Giris giris;
       
       
        public MASALAR()
        {

            InitializeComponent();
           
        }
         cGENEL gnl = new cGENEL();
         public string masano;
         private void btnmasa1_Click(object sender, EventArgs e)
         {
            
             int uzunluk = btnmasa1.Text.Length;
             cGENEL.butondegeri = btnmasa1.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa1.Text;
             this.Hide();
             giris.frmsiparis.Show();


         }
         private void btnmasa2_Click(object sender, EventArgs e)
         {
             masano = btnmasa2.Text;
             int uzunluk = btnmasa2.Text.Length;
             cGENEL.butondegeri = btnmasa2.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa2.Text;
             giris.frmsiparis.Show();
             this.Hide();
           


         }
         private void btnmasa3_Click(object sender, EventArgs e)
         {
             
             int uzunluk = btnmasa3.Text.Length;
             cGENEL.butondegeri = btnmasa3.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa3.Text;
             this.Hide();
             giris.frmsiparis.Show();
         }

         private void btnmasa4_Click(object sender, EventArgs e)
         {
              
             int uzunluk = btnmasa4.Text.Length;
             cGENEL.butondegeri = btnmasa4.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa4.Text;
             this.Hide();
             giris.frmsiparis.ShowDialog();
         }
         private void MASALAR_Load(object sender, EventArgs e)
         {
             SqlConnection bgln = new SqlConnection(gnl.bgln);
             bgln.Open();
             SqlCommand cmd = new SqlCommand("select DURUM,ID from MASALAR", bgln);
             SqlDataReader dr = cmd.ExecuteReader();
             while (dr.Read())
             {
                 foreach (Control item in this.Controls)
                 {
                     if (item is Button)
                     {
                         if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "1")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "2")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "3")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "4")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "5")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "6")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "7")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "8")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "9")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "10")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "11")
                         {
                             item.BackColor = Color.Red;
                         }
                         else if (item.Name == "btnmasa" + dr["ID"].ToString() && dr["DURUM"].ToString() == "12")
                         {
                             item.BackColor = Color.Red;
                         }
                     }////12 videoda kaldım 16:10 a da bak clası iyice tanı
                 }

             }
         }

         private void btnmasa5_Click(object sender, EventArgs e)
         {
             
             int uzunluk = btnmasa4.Text.Length;
             cGENEL.butondegeri = btnmasa5.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa5.Text;
             this.Hide();
             giris.frmsiparis.ShowDialog();
         }

         private void btnmasa6_Click(object sender, EventArgs e)
         {
             
             int uzunluk = btnmasa6.Text.Length;
             cGENEL.butondegeri = btnmasa6.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa6.Text;
             this.Hide();
             giris.frmsiparis.ShowDialog();
         }

         private void btnmasa7_Click(object sender, EventArgs e)
         {
              
             int uzunluk = btnmasa7.Text.Length;
             cGENEL.butondegeri = btnmasa7.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa7.Text;
             this.Hide();
             giris.frmsiparis.ShowDialog();
         }

         private void btnmasa8_Click(object sender, EventArgs e)
         {
              
             int uzunluk = btnmasa8.Text.Length;
             cGENEL.butondegeri = btnmasa8.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa8.Text;
             this.Hide();
             giris.frmsiparis.ShowDialog();
         }

         private void btnmasa9_Click(object sender, EventArgs e)
         {
              
             int uzunluk = btnmasa9.Text.Length;
             cGENEL.butondegeri = btnmasa9.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa9.Text;
             this.Hide();
             giris.frmsiparis.ShowDialog();
         }

         private void btnmasa10_Click(object sender, EventArgs e)
         {
             
             int uzunluk = btnmasa10.Text.Length;
             cGENEL.butondegeri = btnmasa10.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa10.Text;
             this.Hide();
             giris.frmsiparis.ShowDialog();
         }

         private void btnmasa11_Click(object sender, EventArgs e)
         {
              
             int uzunluk = btnmasa11.Text.Length;
             cGENEL.butondegeri = btnmasa11.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa11.Text;
             this.Hide();
             giris.frmsiparis.ShowDialog();
         }

         private void btnmasa12_Click(object sender, EventArgs e)
         {
              
             int uzunluk = btnmasa12.Text.Length;
             cGENEL.butondegeri = btnmasa12.Text.Substring(uzunluk - 6, 6);
             cGENEL.butonadi = btnmasa12.Text;
             this.Hide();
             giris.frmsiparis.ShowDialog();
         }
   
    }
}
