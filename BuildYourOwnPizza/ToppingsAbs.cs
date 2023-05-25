using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    abstract internal class ToppingsAbs : ToppingsIF
    {
        double price;

        public ToppingsAbs(double price)
        {
            this.price = price;
        }

        public double getPrice()
        {
            return price;
        }
    }
}
