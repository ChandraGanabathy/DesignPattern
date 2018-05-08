using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatter
{
    public class CheesePizzaBuilder : PizzaBuilder
    {
        public override void addCheese()
        {
            getPizza().AddCheese(); ;
        }

        public override void addToppings()
        {
            getPizza().addToppings();
        }
        override public void createCrust()
        {
            getPizza().createCrust();
        }

        public override void spreadSauce()
        {
            getPizza().SpreadSauce();
        }
        public override void bake()
        {

        }
        public override string ToString()
        {
            return "This is Cheese Pizza";
        }
    }
}
