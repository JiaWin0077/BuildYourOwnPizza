using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Crust : CrustIF
    {
        double price;
        public Crust(double price)
        {
            this.price = price;
        }

        public Crust()
        {

        }

        public double getPrice()
        {
            return price;
        }
    }
}
