using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatter
{
	public class PizzaDirector
	{
		public void MakePizza(PizzaBuilder pizzabuilder)
		{
			pizzabuilder.createCrust();
			pizzabuilder.spreadSauce();
			pizzabuilder.addCheese();
			pizzabuilder.addToppings();
			pizzabuilder.bake();
		}
	}
}
