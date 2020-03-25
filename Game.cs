using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        Store store = new Store();
        Player player = new Player();

        public void RunGame()
        {
            
            
            
            Day day = new Day();
            Console.WriteLine(day.weather.currentWeather); // cloudy
            Console.WriteLine(day.weather.temp); //22
            day.RunDay(store, player);
            
            
            Console.WriteLine(day.weather.currentWeather); // sunny
            Console.WriteLine(day.weather.temp); // 45
        }
    }
}
