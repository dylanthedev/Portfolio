using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;

namespace DungeonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int killCount = 0;
            Console.Title = "Dungeon Slayer";
            
            Console.Write("Enter your name, hero: ");
            string heroName = Console.ReadLine();
            Console.Clear();
            
            Console.WriteLine("Welcome, {0}! Your journey begins...\n", heroName);
            
            
            Weapon flail = new Weapon("Flail", 5, 15, 10, true);

            Player player = new Player(heroName, 60, 10, 40, 40, Race.Daedra, flail);

            
            bool exit = false;

            do
            {
                Console.Title = "Monsters killed: " + killCount;
                Console.WriteLine(GetRoom());

                Ogre weakOgre = new Ogre("Young Ogre", 12, 12, 20, 10, 1, 3,
                    "A young, inexperienced ogre. It still looks tough!", false);
                Ogre armoredOgre = new Ogre("Shrek", 25, 25, 45, 20, 2, 5,
                    "Mean, green, and smells like onions.", true);
                Falmer falmerWarrior = new Falmer("Falmer Warrior", 15, 15, 50, 15, 1, 3,
                    "Blind but deadly.", false);
                Falmer falmerShadowMaster = new Falmer("Falmer Shadowmaster", 22, 22, 75, 15, 2, 6,
                    "The strongest of all Falmers.", true);
                Dragon babyDragon = new Dragon("Newborn Dragon", 10, 10, 30, 60, 1, 4,
                    "Hasn't even learned to fly yet.", false);
                Dragon kingDragon = new Dragon("King Black Dragon", 40, 40, 65, 25, 3, 6,
                    "The king of all dragons.", true);

                Monster[] monsters = { weakOgre, weakOgre, weakOgre, weakOgre, armoredOgre, falmerWarrior, falmerWarrior, falmerShadowMaster,
                    babyDragon, babyDragon, babyDragon, babyDragon, babyDragon, babyDragon, kingDragon };

                Monster monster = monsters[new Random().Next(monsters.Length)];

                Console.WriteLine("\nIn this room: " + monster.Name);

                bool reload = false;

                do
                {
                    
                    Console.WriteLine("\nChoose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away!\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit Game\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            Console.WriteLine("Attack method goes here...");
                            //TODO Handle if Player dies
                            //TODO Handle if Player kills Monster
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"You have slain the {monster.Name}!");
                                Console.ResetColor();
                                reload = true;
                                killCount++;

                            }//end if
                            
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("RUN!!!");
                            Console.WriteLine("{0} attacks you as you flee!", monster.Name);
                            Combat.DoAttack(monster, player);
                            

                            //TODO Get a new room if Player survives
                            //TODO Exit the game if Player dies
                            reload = true;
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine(player);
                            //Console.WriteLine("Monsters killed: {0}", killCount);
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine(monster);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("GAME OVER!");
                            break;
                        default:
                            Console.WriteLine("Thou hath chosen an improper action." +
                                "Triest thou again.");
                            break;
                    }
                    if (player.Life < 1)
                    {
                        Console.WriteLine("You have died...");
                        Console.WriteLine("You killed {0} monsters.", killCount);
                        exit = true;
                    }

                } while (!reload && !exit);  //end while

            } while (!exit);    //end while
        }//end Main()

        private static string GetRoom()
        {
            string[] rooms =
            {
                "A cluster of low crates surrounds a barrel in the center of this chamber.\nAtop the barrel lies a stack of copper coins and two stacks of cards, one face up.\nMeanwhile, atop each crate rests a fan of five face-down playing cards.\nA thin layer of dust covers everything.\nClearly someone meant to return to their game of cards.",
                "Rounded green stones set in the floor form a snake's head that points in the direction of the doorway you stand in.\nThe body of the snake flows back and toward the wall to go round about the room in ever smaller circles, creating a spiral pattern on the floor.\nSimilar green-stone snakes wend along the walls, seemingly at random heights, and their long bodies make wave shapes.",
                "There's a hiss as you open this door, and you smell a sour odor, like something rotten or fermented.\nInside you see a small room lined with dusty shelves, crates, and barrels.\nIt looks like someone once used this place as a larder, but it has been a long time since anyone came to retrieve food from it.",
                "This small room is lined with benchlike seats on all the walls.\nThe seats all have holes in their top, like a privy.\nFacing stones on the front of the benches prevent you from seeing how deep the holes go.\nIt looks like a communal bathroom. ",
                "This chamber of well-laid stones holds a wide bas-relief of a pastoral scene.\nIn it you see a mountain like Mount Waterdeep, except that Castle Waterdeep and the city are missing.\nInstead, a small fishing village is a short way from a walled complex with several tall towers.",
                "Fire crackles and pops in a small cooking fire set in the center of the room.\nThe smoke from a burning rat on a spit curls up through a hole in the ceiling.\nAround the fire lie several fur blankets and a bag.\nIt looks like someone camped here until not long ago, but then left in a hurry.",
                "You open the door to what must be a combat training room.\nRough fighting circles are scratched into the surface of the floor.\nWooden fighting dummies stand waiting for someone to attack them.\nA few punching bags hang from the ceiling.\nThere's something peculiar about it all though.\nEvery dummy is stocky and each has a bedraggled piece of leather hanging from its head that could be a long mask or a beard.",
                "This narrow room at first appears to be a dead-end corridor, but then you note several metal plates on the walls set at about eye height.\nLooking more closely, you see that one of these plates is slid aside to reveal a peephole.",
                "This small chamber seems divided into three parts.\nThe first has several hooks on the walls from which hang dusty robes.\nAn open curtain separates that space from the next, which has a dry basin set in the floor.\nBeyond that lies another parted curtain behind which you can see several straw mats in a semicircle pointing toward a statue of a dog-headed man.",
                "A pit yawns open before you just on the other side of the door's threshold.\nThe entire floor of the room has fallen into a second room beneath it.\nAcross the way you can spy a door in the wall now 15 feet off the rubble-strewn floor, and near the center of the room stands a thick column of mortared stone that appears to hold the spiral staircase that leads down to what was the lower level.",
                "A chill crawls up your spine and out over your skin as you look upon this room.\nThe carvings on the wall are magnificent, a symphony in stonework -- but given the themes represented, it might be better described as a requiem.\nScenes of death, both violent and peaceful, appear on every wall framed by grinning skeletons and ghoulish forms in ragged cloaks.",
                "This room is hung with hundreds of dusty tapestries.\nAll show signs of wear: moth holes, scorch marks, dark stains, and the damage of years of neglect.\nThey hang on all the walls and hang from the ceiling to brush against the floor, blocking your view of the rest of the room."

            };

            //A simpler way of getting a random room from the array:
            //Random rand = new Random();
            return rooms[new Random().Next(rooms.Length)];
            //int indexNbr = rand.Next(rooms.Length);
            //string room = rooms[indexNbr];

            //return rooms[indexNbr];

        }//end GetRoom()


    }//end class
}//end namespace
