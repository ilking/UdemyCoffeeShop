using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCoffeeShop
{
    class Customer : WaitingCustomer
    {
        public string Name { get; }
        public string DrinkOrdered { get; }

        public Customer(string name, string drinkOrdered)
        {
            this.Name = name;
            this.DrinkOrdered = drinkOrdered;
        }

        public bool orderReady(string preparedDrink)
        {
            if (preparedDrink == DrinkOrdered)
            {
                Console.WriteLine(Name + " has their drink and is leaving the building.");
                return true;
            }

            return false;
        }
    }
}
