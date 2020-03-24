using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        List<Customer> customers = new List<Customer>();
        string [] Names = new string[] { "Steve", "Thomas", "Becky", "Jenny", "Jamal" };
        Weather currentWeather;

        public Day(Weather todaysWeather)
        {
            currentWeather = todaysWeather;
            AddCustomers();
            SetCustomersWeather();
        }
        //Generating all the customers
        //Go to Store
        //Setting the recipe
        //(Last) BuyLogic.  Looping over all of our customers and determining whether they buy or not.

        private void AddCustomers()
        {
            foreach(string name in Names)
            {
                Customer customer = new Customer(name);
                customers.Add(customer);
            }
        }
        private void SetCustomersWeather()
        {
            foreach(Customer C in customers)
            {
                C.SetWeatherPrefernces(currentWeather);
            }
        }
    }
}
