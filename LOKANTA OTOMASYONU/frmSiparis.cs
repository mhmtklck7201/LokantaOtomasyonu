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
    public partial class frmSiparis : Form
    {
        public Giris frmgiris;
        public frmSiparis()
        {
            InitializeComponent();
        }
        //OLUŞTURDUĞUM HESAP işlemleri(ADET)
        void islem(object sender ,EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Name)

            {
                case "btn1" :
                    txtadet.Text += (1).ToString();
                    break;
                case "btn2":
                    txtadet.Text += (2).ToString();
                    break;
                case "btn3":
                    txtadet.Text += (3).ToString();
                    break;
                case "btn4":
                    txtadet.Text += (4).ToString();
                    break;
                case "btn5":
                    txtadet.Text += (5).ToString();
                    break;
                case "btn6":
                    txtadet.Text += (6).ToString();
                    break;
                case "btn7":
                    txtadet.Text += (7).ToString();
                    break;
                case "btn8":
                    txtadet.Text += (8).ToString();
                    break;
                case "btn9":
                    txtadet.Text += (9).ToString();
                    break;
                case "btn0":
                    txtadet.Text += (0).ToString();
                    break;

                    
                default:
                    break;
            }


        }
        public int masaid;
        private void frmSiparis_Load(object sender, EventArgs e)
        {
            cMasalar masa = new cMasalar();
            lblmasano.Text = cGENEL.butonadi;
             masaid = masa.MasaNumarasıAl(cGENEL.butonadi);
            if (masa.MasaDurumuAl(masaid, 1)==true)
            {
                cAddisyon ad = new cAddisyon();
                int adisyonid = ad.AdisyonAl(masaid);

            
            }

            btn1.Click += new EventHandler(islem);
            btn2.Click += new EventHandler(islem);
            btn3.Click += new EventHandler(islem);
            btn4.Click += new EventHandler(islem);
            btn5.Click += new EventHandler(islem);
            btn6.Click += new EventHandler(islem);
            btn7.Click += new EventHandler(islem);
            btn8.Click += new EventHandler(islem);
            btn9.Click += new EventHandler(islem);
            btn0.Click += new EventHandler(islem);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }
        cURUNCESITLERI cu = new cURUNCESITLERI();
        cGENEL gnl = new cGENEL();
        private void btnanayemek3_Click(object sender, EventArgs e)
        {
            
            cu.urunal(listView1,btnanayemek3);
        }

        private void btnarasicak2_Click(object sender, EventArgs e)
        {
            cu.urunal(listView1, btnarasicak2);
        }

        private void btncorba1_Click(object sender, EventArgs e)
        {
            cu.urunal(listView1, btncorba1);
        }

        private void btnfastfood4_Click(object sender, EventArgs e)
        {
            cu.urunal(listView1, btnfastfood4);
        }

        private void btnsalata5_Click(object sender, EventArgs e)
        {
            cu.urunal(listView1, btnsalata5);
        }

        private void btntatlilar6_Click(object sender, EventArgs e)
        {
            cu.urunal(listView1, btntatlilar6);
        }

        private void btnicecek7_Click(object sender, EventArgs e)
        {
            cu.urunal(listView1, btnicecek7);
        }
        int sayac = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (txtadet.Text == "") { txtadet.Text = "1"; }
            if (listView1.Items.Count > 0)
            {
                sayac = listView2.Items.Count;
                listView2.Items.Add(listView1.SelectedItems[0].Text);
                listView2.Items[sayac].SubItems.Add((Convert.ToDecimal(listView1.SelectedItems[0].SubItems[1].Text)*Convert.ToDecimal(txtadet.Text)).ToString());
                listView2.Items[sayac].SubItems.Add(txtadet.Text);   
                listView2.Items[sayac].SubItems.Add("0");
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsiparis_Click(object sender, EventArgs e)
        {
            
            cSiparisler siparis = new cSiparisler();
           cMasalar masa=new cMasalar();
            MASALAR masalar = new MASALAR();
            cAddisyon adisyon=new cAddisyon();
             
            
            if (listView2.Items.Count > 0)
            {
             
                for (int i = 0; i < listView2.Items.Count; i++)
                {
                   
                }
                masalar.Show();
            }
           

        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
             
        }

         
    }
}
