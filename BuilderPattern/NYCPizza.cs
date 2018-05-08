using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatter
{
    public class NYCPizza : PizzaBuilder
    {
        public override void addCheese()
        {
            getPizza().AddCheese(); ;
        }

        public override void addToppings()
        {
            getPizza().addToppings();
        }

        public override void bake()
        {

        }

        override public void createCrust()
        {
            getPizza().createCrust();
        }

        public override void spreadSauce()
        {
            getPizza().SpreadSauce();
        }
        public override string ToString()
        {
            return "This is NyzPizza";
        }
    }
}
