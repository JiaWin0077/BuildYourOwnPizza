using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class CrustThin : Crust
    {
        private static CrustThin c;

        public CrustThin() : base(10.00)
        {
        }

        public CrustThin(double price) : base(price)
        {
        }

        public static CrustThin createInstance()
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new CrustThin();
                return c;
            }
        }

        public static CrustThin createInstance(double price)
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new CrustThin(price);
                return c;
            }
        }
    }
}
