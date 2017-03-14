using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCoffeeShop
{
    interface WaitingCustomer
    {
        bool orderReady(string preparedDrink);
        string DrinkOrdered { get; }
        string Name { get; }
    }
}
