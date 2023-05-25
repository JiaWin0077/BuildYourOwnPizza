using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Olives :ToppingsAbs
    {
        private static Olives o;
        public Olives(double price) : base(price)
        {
        }
        public Olives() : base(00.15)
        {
        }

        public static Olives createInstance()
        {
            if (o != null)
            {
                return o;
            }
            else
            {
                o = new Olives();
                return o;
            }
        }

        public static Olives createInstance(double price)
        {
            if (o != null)
            {
                return o;
            }
            else
            {
                o = new Olives(price);
                return o;
            }
        }
    }
}
