using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public int maxCupsPerPitcher;
        public int CupsRemaining;

        public Recipe()
        {
            maxCupsPerPitcher = 10;
        }

        public void CreatePitcher(Inventory ourInventory) //keeping track of our inventory
        {
            if (CanCreatePitcher(ourInventory))
            {
                for (int i = 0; i < numberOfLemons; i++)
                {
                    ourInventory.lemons.RemoveAt(0);
                }

                for (int i = 0; i < numberOfIceCubes; i++)
                {
                    ourInventory.iceCubes.RemoveAt(0);
                }

                for (int i = 0; i < numberOfSugarCubes; i++)
                {
                    ourInventory.sugarCubes.RemoveAt(0);
                }
            }
            else
            {
                Console.Write("Not enough stuuuuuuuuf");
            }
            
           
            

        }

        public void SetRecipe()
        {
            Console.WriteLine("How many lemons do you want?");
            numberOfLemons = int.Parse(Console.ReadLine());

            Console.WriteLine("How many sugar cubes do you want?");
            numberOfSugarCubes = int.Parse(Console.ReadLine());

            Console.WriteLine("How many ice cubes do you want?");
            numberOfIceCubes = int.Parse(Console.ReadLine());

        }

        public bool CanCreatePitcher(Inventory EnoughSupplies)
        {
            if (numberOfLemons > EnoughSupplies.lemons.Count && numberOfSugarCubes > EnoughSupplies.sugarCubes.Count && numberOfIceCubes > EnoughSupplies.iceCubes.Count)
            {
                return true;
            }
            return false;
            
           

        }



    }
}
