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
        List<Day> Days = new List<Day>();
        public int dayNumber;

        public void RunGame()
        {
            DisplayWelcome();
            CreateDays();
            RunDays();
            GameOver();    
            
            
           
        }
        public void CreateDays()
        {
            for(int i=0 ; i < 7; i++)
            {
                Days.Add(new Day { });
            }
            
            
            //create 7 day objects and store them in the DAys List
        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to my lemondade stand of DOOM!!!");
            Console.ReadLine();
            //Display instructions and welcome message
        }
        public void RunDays()
        {
            foreach(Day day in Days)
            {
                Console.WriteLine("Current temp is: " + day.weather.temp + " F " + day.weather.currentWeather);
                day.RunDay(store , player);
            }
            //Loop over all day objects in the list and call day.RunDay()
        }
        public void GameOver()
        {
            Console.WriteLine("This game is now finished! Just like you if you're a demon!");
            Console.ReadLine();
            //once all days have been completed display game over
        }
    }
}
