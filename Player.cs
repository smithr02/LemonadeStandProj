using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        // constructor (SPAWNER)
        public Player()   //Solid design principle example- this is thing single resoonsibility example, it runs the player class well and efficiently. Generates our variables and sets our recipe.
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

       public Recipe SetRecipe()
        {
            recipe.SetRecipe();
            recipe.CreatePitcher(inventory);
            return recipe;
        }
    }
}
