using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_1
{
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public List<Ekstra> EkstraMalzeme { get; set; }
        public Boyut SecilenBoy { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.UrunFiyati;
            switch (SecilenBoy)
            {
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.1M;                
                    break;
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
                case Boyut.Kucuk:
                    ToplamTutar += ToplamTutar * 0M;
                    break;               
            }
            foreach (Ekstra ekstra in EkstraMalzeme)
            {
                ToplamTutar += ekstra.UrunFiyati;
                Form4.EkstralarToplam+= ekstra.UrunFiyati;
            }

            ToplamTutar *= Adet;
        }
        public override string ToString()
        {
            if (EkstraMalzeme.Count < 1)
            {
                return String.Format($"{SeciliMenu.UrunAdi} Menü - x{Adet} - {Convert.ToString(SecilenBoy)} Boy - TOPLAM == {ToplamTutar.ToString("C2")}");                
            }
            else
            {
                string ekstraMalzeme = null;
                foreach (Ekstra ekstra in EkstraMalzeme)
                {
                    ekstraMalzeme += ekstra.UrunAdi + ",";
                }
                ekstraMalzeme = ekstraMalzeme.Trim(',');
                return string.Format($"{SeciliMenu.UrunAdi} Menü - x{Adet} - {Convert.ToString(SecilenBoy)} Boy - {ekstraMalzeme} - TOPLAM == {ToplamTutar.ToString("C2")}");
            }
        }
    }
}
