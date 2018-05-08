using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatter
{
	class Program
	{
		static void Main(string[] args)
		{
            PizzaDirector director = new PizzaDirector();
            CheesePizzaBuilder cheezepizza = new CheesePizzaBuilder();
            director.MakePizza(cheezepizza);
            System.Console.WriteLine(cheezepizza.ToString());

            NYCPizza nycpizza = new NYCPizza();
            director.MakePizza(nycpizza);
            System.Console.WriteLine(nycpizza.ToString());

            HawaainPizza hi = new HawaainPizza();
            director.MakePizza(nycpizza);
            System.Console.WriteLine(hi.ToString());


            System.Console.ReadLine();

        }
		
	}
}
