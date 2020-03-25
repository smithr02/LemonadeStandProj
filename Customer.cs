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
        public int PriceWillingToPay;
        public bool WillingToPay;
        public Customer(string name, Weather weather, Recipe recipe)
        {
            Name = name;
            SetCustomerPref(weather, recipe);
        }
       
       // Sets willing to pay
       // Need help on making more randomized numbers by setting the seed
       
        private void SetWillingToPay()
        {
            Random rand = new Random();
            PriceWillingToPay = rand.Next(1, 5);
        }
        
        // Can either be "Cloudy", "Clear", "Rainy"
            
        public void SetCustomerPref(Weather weather, Recipe recipe)
        {
            SetWillingToPay();
            switch (weather.currentWeather)
            {
                case "Cloudy":
                    {
                        if (weather.temp >= 50 && PriceWillingToPay > recipe.PricePerCup)
                        {
                            WillingToPay = true;
                        }
                        else
                            WillingToPay = false;

                        break;
                    }
                case "Rainy":
                    {
                        if (weather.temp >= 70 && PriceWillingToPay > recipe.PricePerCup)
                        {
                            WillingToPay = true;
                        }
                        else
                            WillingToPay = false;

                        break;
                    }
                case "Clear":
                    {
                        if (weather.temp >= 40 && PriceWillingToPay > recipe.PricePerCup)
                        {
                            WillingToPay = true;
                        }
                        else
                            WillingToPay = false;
                        
                        break;
                    }

                default:
                    {
                        break;
                    }
            }
        }
    }
}
