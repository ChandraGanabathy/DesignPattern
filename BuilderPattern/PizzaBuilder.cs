using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatter
{
	public abstract class PizzaBuilder
	{
		private Pizza _pizza = new Pizza();
		protected Pizza getPizza()
		{
			return _pizza;
		}
		public abstract void createCrust();
		public abstract void spreadSauce();	
		public abstract void addCheese();
		public abstract void addToppings();
		public abstract void bake();
        public virtual void Precooking()
        {
            //code some logics
        }
        public Pizza create()
		{
			return _pizza;
		}
	}

	
	

}
