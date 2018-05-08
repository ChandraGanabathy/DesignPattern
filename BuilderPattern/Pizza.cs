using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatter
{
    public class Pizza
    {
        private Crust _crust;
        private Sauce _sauce;
        string _cheese = string.Empty;
        public void createCrust()
        {
            _crust = new Crust();
        }
        public void SpreadSauce()
        {
            _sauce = new Sauce();
        }
        public void AddCheese()
        {
            _cheese = "Mozerella";
        }
        public void addToppings()
        {

        }
    }
}
