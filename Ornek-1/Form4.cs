using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        int siparisAdedi = 0;
        decimal ciro = 0;

        public static int GunsonuToplam { get; set; }
        public static decimal EkstralarToplam { get; set; }
        private void Form4_Load(object sender, EventArgs e)
        {
            
            Siparis siparis = new Siparis();
            
            foreach (Siparis item in Form1.siparisAdediListesi)
            {
                siparisAdedi += item.Adet;
                ciro += item.ToplamTutar;
            }
            lblEkstraCiro.Text=EkstralarToplam.ToString("C2");
            lblToplamSatis.Text=siparisAdedi.ToString();
            lblCiro.Text=ciro.ToString("C2");
            lblToplamSiparis.Text = GunsonuToplam.ToString();
            foreach (Siparis item in Form1.Siparisler)
            {
                lbxTumSiparisler.Items.Add(item);
            }
        }
    }
}
