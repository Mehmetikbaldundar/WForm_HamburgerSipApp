using Ornek_1.Properties;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu {UrunAdi="Big Mac",            UrunFiyati=79},
            new Menu {UrunAdi="TBT Burger",         UrunFiyati=64},
            new Menu {UrunAdi="Köfteburger",        UrunFiyati=70},
            new Menu {UrunAdi="McRoyal",            UrunFiyati=95},
            new Menu {UrunAdi="McChicken",          UrunFiyati=73},
            new Menu {UrunAdi="Double Cheeseburger",UrunFiyati=83},
            new Menu {UrunAdi="Daba Daba Burger",   UrunFiyati=78},
            new Menu {UrunAdi="Hamburger",          UrunFiyati=65}
        };
        public static List<Ekstra> ekstraMalzemeler = new List<Ekstra>()
        {
            new Ekstra{UrunAdi="Hardal",     UrunFiyati=3},
            new Ekstra{UrunAdi="Ranch",      UrunFiyati=3},
            new Ekstra{UrunAdi="Barbekü",    UrunFiyati=3},
            new Ekstra{UrunAdi="Acı Sos",    UrunFiyati=2},
            new Ekstra{UrunAdi="Çıtır Soğan",UrunFiyati=21},
            new Ekstra{UrunAdi="Buffalo",    UrunFiyati=3},
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu menu in menuler)
            {
                cmbMenu.Items.Add(menu);
            }
            foreach (Ekstra ekstra in ekstraMalzemeler)
            {
                flpEkstraMalzeme.Controls.Add(new CheckBox() { Text = ekstra.UrunAdi, ForeColor = Color.Black, Tag = ekstra });
            }
        }

        private void cmbMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenu.SelectedIndex == 0)
            {
                pcbMenu.Image = Properties.Resources.Bigmac;
            }
            else if (cmbMenu.SelectedIndex == 1)
            {
                pcbMenu.Image = Properties.Resources.Cheeseburger;
            }
            else if (cmbMenu.SelectedIndex == 2)
            {
                pcbMenu.Image = Properties.Resources.Mangalburger;
            }
            else if (cmbMenu.SelectedIndex == 3)
            {
                pcbMenu.Image = Properties.Resources.Mcroyal;
            }
            else if (cmbMenu.SelectedIndex == 4)
            {
                pcbMenu.Image = Properties.Resources.Mcchicken;
            }
            else if (cmbMenu.SelectedIndex == 5)
            {
                pcbMenu.Image = Properties.Resources.Doublecheeseburger;
            }
            else if (cmbMenu.SelectedIndex == 6)
            {
                pcbMenu.Image = Properties.Resources.Maxburger;
            }
            else if (cmbMenu.SelectedIndex == 7)
            {
                pcbMenu.Image = Properties.Resources.Hamburger;
            }
            else if (cmbMenu.SelectedIndex == -1)
            {
                pcbMenu.Image = Properties.Resources.HamburgerMain;
            }
            else
            {
                pcbMenu.Image = Properties.Resources.NewMenu;
            }

        }

        private void btnSipEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SeciliMenu = (Menu)cmbMenu.SelectedItem;

            if (rdbBuyuk.Checked)
                siparis.SecilenBoy = Boyut.Buyuk;
            else if (rdbOrta.Checked)
                siparis.SecilenBoy = Boyut.Orta;
            else if (rdbKucuk.Checked)
                siparis.SecilenBoy = Boyut.Kucuk;

            siparis.EkstraMalzeme = new List<Ekstra>();

            foreach (CheckBox ekstraMalzeme in flpEkstraMalzeme.Controls)
            {
                if (ekstraMalzeme.Checked)
                    siparis.EkstraMalzeme.Add((Ekstra)(ekstraMalzeme.Tag));
            }
            siparis.Adet = Convert.ToInt32(nudAdet.Value);
            siparis.Hesapla();

            lbxSiparisler.Items.Add(siparis);

            decimal toplam = ToplamTutar();

            siparis.Adet = (int)(nudAdet.Value);
            siparis.ToplamTutar = toplam;
            Form4.GunsonuToplam++;
            siparisAdediListesi.Add(siparis);


            Fonksiyonlar.Temizle(this.Controls);
        }

        private decimal ToplamTutar()
        {
            decimal toplam = 0;

            foreach (Siparis siparis in lbxSiparisler.Items)
                toplam += siparis.ToplamTutar;
            lblToplamTutar.Text = toplam.ToString("C2");
            return toplam;
        }
        private void btnSipTamamla_Click(object sender, EventArgs e)
        {
            DialogResult onayKutusu = MessageBox.Show("Toplam Sipariş Ücreti:" + ToplamTutar().ToString("C2") + "\n Siparişi tamamlamak istermisiniz ? ", "SiparişBilgileri", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onayKutusu == DialogResult.Yes)
            {
                foreach (Siparis sip in lbxSiparisler.Items)
                {
                    Siparisler.Add(sip);
                }
                lbxSiparisler.Items.Clear();

                ToplamTutar();
                MessageBox.Show("Sipariş Tamamlandı");
            }
            else if (onayKutusu == DialogResult.No)
            {
                MessageBox.Show(" Siparişler İptal Edilmiştir.");
            }

        }
        public static List<Siparis> siparisAdediListesi = new List<Siparis>();
        public static List<Siparis> Siparisler = new List<Siparis>();

    }
}
