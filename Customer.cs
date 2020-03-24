using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        public String Name;
        public int WillingToPay;
        public Customer(string name)
        {
            Name = name;
            SetWillingToPay();
        }
       
       // Sets willing to pay
       // Need help on making more randomized numbers by setting the seed
       
        private void SetWillingToPay()
        {
            Random rand = new Random();
            WillingToPay = rand.Next(1, 5);
        }
        public void SetWeatherPrefernces()
        {
         if 
        }
    }
}
