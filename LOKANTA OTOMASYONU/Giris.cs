using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOKANTA_OTOMASYONU
{
    public partial class Giris : Form
    {
        public MASALAR frmmasa;
        public frmSiparis frmsiparis;
         
        public Giris()
        {
            frmmasa = new MASALAR();
            frmsiparis = new frmSiparis();
            InitializeComponent();
            frmmasa.giris = this;
            frmsiparis.frmgiris = this;
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            frmmasa.ShowDialog();
            this.Hide();
        }
    }
}
