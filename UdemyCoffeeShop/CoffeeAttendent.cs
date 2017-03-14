using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCoffeeShop
{
    class CoffeeAttendent
    {
        List<WaitingCustomer> customerList;
        Queue<string> drinksToPrepare;
        string completedDrink;

        public CoffeeAttendent()
        {
            this.customerList = new List<WaitingCustomer>();
            this.drinksToPrepare = new Queue<string>();
            this.completedDrink = "";
        }

        public void takeOrder(WaitingCustomer customer)
        {
            customerList.Add(customer);
            drinksToPrepare.Enqueue(customer.DrinkOrdered);
            Console.WriteLine("{0,-15} has ordered {1}.", customer.Name, customer.DrinkOrdered);
        }

        public void prepareDrink(string drinkToPrepare)
        {
            completedDrink = drinkToPrepare;
        }

        public void callOutCompletedOrder()
        {
            string drinkReady = drinksToPrepare.Dequeue();
            prepareDrink(drinkReady);
            WaitingCustomer customer = customerList.Find(cust => cust.DrinkOrdered.Equals(drinkReady));
               

            if (customer.orderReady(drinkReady))
            {
                customerList.Remove(customer);
            }
        }

        public Boolean StillHasWorkToDo()
        {
            return drinksToPrepare.Count > 0;
        }
    }
}
