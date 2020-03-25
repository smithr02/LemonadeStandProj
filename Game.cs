using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {

        public void RunGame()
        {
            Weather today = new Weather();
            Recipe recipe = new Recipe();
            recipe.SetRecipe();
            Day day = new Day(recipe);
            Console.WriteLine(today.currentWeather); // cloudy
            Console.WriteLine(today.temp); //22

            today.setWeather();
            Console.WriteLine(today.currentWeather); // sunny
            Console.WriteLine(today.temp); // 45
        }
    }
}
