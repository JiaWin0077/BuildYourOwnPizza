using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class CrustPan : Crust
    {
        private static CrustPan c;

        public CrustPan() : base(10)
        {
        }

        public CrustPan(double price) : base(price)
        {
        }

        public static CrustPan createInstance()
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new CrustPan();
                return c;
            }
        }

        public static CrustPan createInstance(double price)
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new CrustPan(price);
                return c;
            }
        }
    }
}
