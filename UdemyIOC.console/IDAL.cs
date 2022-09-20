using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIOC.console
{
    interface IDAL
    {
        List<Product> GetProducts();

        int Hesapla();
    }
}
