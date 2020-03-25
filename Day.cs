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
        Recipe currentRecipe; 
           

        public Day(Recipe todaysRecipe)
        {
            currentWeather = new Weather();
            currentRecipe = todaysRecipe;
            AddCustomers();
            //GoToTheStore();
            //SetRecipe();
            //WillCustomerBuy();

            

            
        }
        public void RunDay(Store store)
        {
            //Go to Store
            GoToStore(store);
            //Setting the recipe
            //(Last) BuyLogic.  Looping over all of our customers and determining whether they buy or not.
        }
        public void GoToStore(Store store)
        {
            //Call all of the store buy methods to get the ingerdiants.
        }
        public void SetRecipe()
        {
            //Call the player object's 'recipe' to make the recipe.
        }
        public void SellLemonade()
        {
            //Loop over customers ands sell lemonade to them based of the true or false they return.
        }



        private void AddCustomers()
        {
            switch (currentWeather.currentWeather)
            {
                case "Sunny":
                    CreateCustomers(50);
                    break;
                case "Cloudy":
                    CreateCustomers(30);
                    break;
                case "Rainy":
                    CreateCustomers(15);
                    break;
                        default:
                    break;
            }
        }
        private void CreateCustomers(int numberOfCustomers)
        {
            Random rng = new Random();
            for(int i = 0; i < numberOfCustomers; i++)
            {
                customers.Add(new Customer(Names[rng.Next(5)], currentWeather, currentRecipe));
            }
        }
        
    }
}
