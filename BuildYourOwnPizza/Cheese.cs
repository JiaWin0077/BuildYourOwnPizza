using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Cheese : ToppingsAbs
    {
        private static Cheese c;
        public Cheese(double price) : base(price)
        {
        }
        public Cheese() : base(00.10)
        {
        }

        public static Cheese createInstance()
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new Cheese();
                return c;
            }
        }

        public static Cheese createInstance(double price)
        {
            if (c != null)
            {
                return c;
            }
            else
            {
                c = new Cheese(price);
                return c;
            }
        }
    }
}
