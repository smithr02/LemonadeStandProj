using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        public int temp;
        public string currentWeather;
        List<string> weatherConditions = new List<string>() { "Cloudy", "Clear", "Rainy" };

        public Weather()
        {
            setWeather();
           
        }

        public void setWeather()
        {
            Random rand = new Random();
            temp = rand.Next(30, 90);
            currentWeather = weatherConditions[rand.Next(0,2)];
           
        }

    }
}
