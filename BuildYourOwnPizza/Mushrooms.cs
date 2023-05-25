using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Mushrooms :ToppingsAbs
    {
        private static Mushrooms m;
        public Mushrooms(double price) : base(price)
        {
        }
        public Mushrooms() : base(00.15)
        {
        }

        public static Mushrooms createInstance()
        {
            if (m != null)
            {
                return m;
            }
            else
            {
                m = new Mushrooms();
                return m;
            }
        }

        public static Mushrooms createInstance(double price)
        {
            if (m != null)
            {
                return m;
            }
            else
            {
                m = new Mushrooms(price);
                return m;
            }
        }
    }
}
