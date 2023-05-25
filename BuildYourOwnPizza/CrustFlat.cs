using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class CrustFlat : Crust
    {
        private static CrustFlat c;

        public CrustFlat() : base(12.00)
        {
        }

        public CrustFlat(double price) : base(price)
        {
        }

        public static CrustFlat createInstance()
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new CrustFlat();
                return c;
            }
        }

        public static CrustFlat createInstance(double price)
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new CrustFlat(price);
                return c;
            }
        }
    }
}
