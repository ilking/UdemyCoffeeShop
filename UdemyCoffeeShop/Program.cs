using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeAttendent attendent = new CoffeeAttendent();
            Random rnd = new Random();

            for(int i = 0; i < 10; i++)
            {
                attendent.takeOrder(CustomerFactory.MakeCustomer());
                if(rnd.Next(100) < 30)
                {
                    attendent.callOutCompletedOrder();
                }
            }

            while (attendent.StillHasWorkToDo())
            {
                attendent.callOutCompletedOrder();
            }
        }
    }
}
