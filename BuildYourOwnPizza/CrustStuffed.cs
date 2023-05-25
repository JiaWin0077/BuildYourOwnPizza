using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class CrustStuffed : Crust 
    {
        private static CrustStuffed c;

        public CrustStuffed() : base(14.00)
        {
        }

        public CrustStuffed(double price) : base(price)
        {
        }

        public static CrustStuffed createInstance()
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new CrustStuffed();
                return c;
            }
        }

        public static CrustStuffed createInstance(double price)
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new CrustStuffed(price);
                return c;
            }
        }
    }
}
