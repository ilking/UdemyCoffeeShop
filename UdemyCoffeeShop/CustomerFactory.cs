using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCoffeeShop
{
    class CustomerFactory
    {
        static string[] firstNames = new string[] { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian",
                                            "abby", "abigail", "adele", "adrian", "john", "phillip", "josh"};
        static string[] lastNames = new string[] { "abbott", "acosta", "adams", "adkins", "aguilar", "aranovski", "king", "groskin", "prince", "jester" };

        static string[] possibleDrinks = new string[] { "coolata", "jasmine tea", "espresso", "hot chocolate", "egg mcmuffin", "tall dark coffee",
                                           "hot milk", "cheese sandwich", "donuts", "cream filled donut", "egg sandwich", "toasted bagel" };

        static Random rnd = new Random();

        static System.Globalization.TextInfo textInfo = new System.Globalization.CultureInfo("en-US", false).TextInfo;

        private CustomerFactory() { }

        public static WaitingCustomer MakeCustomer()
        {
            string name = firstNames[rnd.Next(firstNames.Length)] + " " + lastNames[rnd.Next(lastNames.Length)];
            string drink = possibleDrinks[rnd.Next(possibleDrinks.Length)];

            return new Customer(textInfo.ToTitleCase(name), drink);
        }
    }
}
