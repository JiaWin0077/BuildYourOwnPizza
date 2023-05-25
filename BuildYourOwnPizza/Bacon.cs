using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Bacon : ToppingsAbs
    {
        private static Bacon b;
        public Bacon(double price) : base(price)
        {
        }
        public Bacon() : base(00.25)
        {
        }

        public static Bacon createInstance()
        {
            if (b != null)
            {
                return b;
            }
            else
            {
                b = new Bacon();
                return b;
            }
        }

        public static Bacon createInstance(double price)
        {
            if (b != null)
            {
                return b;
            }
            else
            {
                b = new Bacon(price);
                return b;
            }
        }
    }
}
