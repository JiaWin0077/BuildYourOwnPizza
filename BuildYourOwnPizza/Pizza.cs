using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class Pizza : ObserverableIF
    {
        double price;
        List<ToppingsIF> toppings;

        public Pizza()
        {
            toppings = new List<ToppingsIF>();
            price = 0;
        }

        public Pizza(double price)
        {
            this.price = price;
        }

        public void observer(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.update();
        }

        public virtual double getPrice()
        {
            return price;
        }

        public void addToppings(ToppingsIF t)
        {
            toppings.Add(t);
            price += t.getPrice();
        }

    }
}
