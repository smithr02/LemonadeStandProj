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

        public Day()
        {
            AddCustomers();
            
        }

        private void AddCustomers()
        {
            foreach(string name in Names)
            {
                Customer customer = new Customer(name);
                customers.Add(customer);
            }
        }
    }
}
