using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Peppers : ToppingsAbs
    {
        private static Peppers p;
        public Peppers(double price) : base(price)
        {
        }
        public Peppers() : base(00.15)
        {
        }

        public static Peppers createInstance()
        {
            if (p != null)
            {
                return p;
            }
            else
            {
                p = new Peppers();
                return p;
            }
        }

        public static Peppers createInstance(double price)
        {
            if (p != null)
            {
                return p;
            }
            else
            {
                p = new Peppers(price);
                return p;
            }
        }
    }
}
