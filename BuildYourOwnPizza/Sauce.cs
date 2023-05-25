using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Sauce : ToppingsAbs
    {
        private static Sauce s;
        public Sauce() : base(.10)
        {

        }

        public Sauce(double price) : base(price)
        {

        }

        public static Sauce createInstance()
        {
            if (s != null)
            {
                return s;
            }
            else
            {
                s = new Sauce();
                return s;
            }
        }

        public static Sauce createInstance(double price)
        {
            if (s != null)
            {
                return s;
            }
            else
            {
                s = new Sauce(price);
                return s;
            }
        }
    }
}
