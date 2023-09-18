using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_PART2
{
    static class compareproducts
    {
        public static bool Equalproducts(product product1, product product2)
        {
            if (product1.Getnameofproduct()== product2.Getnameofproduct())
            {
                return true;
            }
            return false;
        }
    }
}
