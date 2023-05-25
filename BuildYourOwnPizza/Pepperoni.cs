using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Pepperoni : ToppingsAbs
    {
        private static Pepperoni p;
        public Pepperoni(double price) : base(price)
        {
        }
        public Pepperoni() : base(00.20)
        {
        }

        public static Pepperoni createInstance()
        {
            if (p != null)
            {
                return p;
            }
            else
            {
                p = new Pepperoni();
                return p;
            }
        }

        public static Pepperoni createInstance(double price)
        {
            if (p != null)
            {
                return p;
            }
            else
            {
                p = new Pepperoni(price);
                return p;
            }
        }
    }
}
