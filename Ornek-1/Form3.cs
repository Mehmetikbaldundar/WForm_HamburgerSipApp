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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraKaydet_Click(object sender, EventArgs e)
        {
            Ekstra ekstra = new Ekstra();            
            ekstra.UrunAdi = txtEkstraAdi.Text;
            ekstra.UrunFiyati = numericUpDown1.Value;

            Form1.ekstraMalzemeler.Add(ekstra);

            txtEkstraAdi.Clear();
            numericUpDown1.ResetText();
        }
    }
}
