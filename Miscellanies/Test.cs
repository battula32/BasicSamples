using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Miscellanies;

namespace RpgTutorial
{
    class MainWorld
    {
        List<Character> Monster;
        DataHandler data = new DataHandler();
        Hero myhero;

        /// <summary>
        /// Mainworlds the specified hero.
        /// </summary>
        /// <param name="hero">The hero.</param>
        /// <param name="monsters">The monsters.</param>
        public void Mainworld(Hero hero, List<Character> monsters)
        {
            Console.Write(@"
You are in a valley, not far from the town of Zalgalax.
Where do you wish to travel?
_____________________________
(NW) (N) (NE)
(w)       (E)
(SW) (S) (SE)
   (Exit)
_____________________________
");
            Console.ReadLine();
            choice = Console.ReadLine();
            switch (answer)
            {
                case "NW":
                case "nw":
                case "Nw":
                    Northwest northwest = new Northwest(myhero);
                    break;
                case "N":
                case "n":
                    North north = new North(myhero);
                    break;
                case "NE":
                case "ne":
                case "Ne":
                    Northeast northeast = new Northeast(myhero);
                    break;
                //NE class will be added later
                default:
                    Console.WriteLine("I'm sorry, I didn't understand that.");
                    return;

            }

            int battlechance;
            int setnumber;
            setnumber = 1;
            Random rand = new Random();
            battlechance = rand.Next(1, 100);

            if (battlechance >= setnumber)
            {
                Random randtwo = new Random();
                int gibblychance = 10;
                int monsterchance;
                Console.WriteLine("Suddenly, a wild monster appears!");
                monsterchance = randtwo.Next(1, 60);

                if (monsterchance ==  1)
                {
                    Monster.Add(new Zombie());
                    Monster.Add(new Zombie());
                    Monster.Add(new Zombie());
                }

                if (monsterchance == 2)
                {
                    Monster.Add(new Borg());
                }

                if (monsterchance == 3)
                {
                    Monster.Add(new Garryxx());
                }

                if (monsterchance == 4)
                {
                    Console.WriteLine("You've been attacked by a tribal raiding party!");
                    Monster.Add(new Barbarian());
                    Monster.Add(new Barbarian());
                    Monster.Add(new Mage());
                }

                if (monsterchance == 5)
                {
                    Monster.Add(new Slime());
                }

                if (monsterchance == 6)
                {
                    Console.WriteLine("A vicious warrior of Gorox appears, a Gorox Paladin!");
                    Monster.Add(new GoroxPaladin());
                }

                Battle battle = new Battle(myhero, Monster);
            }
        }

        public string choice { get; set; }

        public string answer { get; set; }
    }
}
