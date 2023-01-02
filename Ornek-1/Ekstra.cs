using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_1
{
    public class Ekstra : IUrun
    {
        public string UrunAdi { get; set; }
        public decimal UrunFiyati { get; set; }

        public override string ToString()
        {
            return UrunAdi + UrunFiyati;
        }
    }
}
