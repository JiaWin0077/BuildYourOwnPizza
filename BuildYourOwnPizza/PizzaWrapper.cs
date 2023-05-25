using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class PizzaWrapper : Pizza
    {
        Pizza p;
        CrustIF c;
        public PizzaWrapper(Pizza p, CrustIF c) : base(p.getPrice() + c.getPrice())
        {
            this.p = p;
            this.c = c;
        }

        public override double getPrice()
        {
            return p.getPrice() + c.getPrice();
        }
    }
}
