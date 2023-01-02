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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuyuKaydet_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.UrunAdi = txtMenuAdi.Text;
            menu.UrunFiyati = nudFiyat.Value;

            Form1.menuler.Add(menu);

            txtMenuAdi.Clear();
            nudFiyat.ResetText();
        }
    }
}
