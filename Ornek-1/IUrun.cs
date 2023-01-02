using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_1
{
    public interface IUrun
    {
        string UrunAdi { get; set; }
        decimal UrunFiyati { get; set; }        
    }
}
