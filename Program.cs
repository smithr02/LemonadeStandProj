using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather today = new Weather();
            Day day = new Day(today);
            Console.WriteLine(today.currentWeather); // cloudy
            Console.WriteLine(today.temp); //22

            today.setWeather();
            Console.WriteLine(today.currentWeather); // sunny
            Console.WriteLine(today.temp); // 45


        }
    }
}
