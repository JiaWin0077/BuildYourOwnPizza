using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Spinach : ToppingsAbs
    {
        private static Spinach s;
        public Spinach(double price) : base(price)
        {
        }
        public Spinach() : base(00.15)
        {
        }

        public static Spinach createInstance()
        {
            if (s != null)
            {
                return s;
            }
            else
            {
                s = new Spinach();
                return s;
            }
        }

        public static Spinach createInstance(double price)
        {
            if (s != null)
            {
                return s;
            }
            else
            {
                s = new Spinach(price);
                return s;
            }
        }
    }
}
