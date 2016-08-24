using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //   public string answer(string str1);
            Console.WriteLine("\n-----------------------------------------------");
            Console.WriteLine("Welcome! What is your name? (enter your name)");
            string name = Console.ReadLine();
            string Title = name.ToUpper();
            Console.Write("HEY " + Title + "!!! Would you Like to play a game?");
            Console.WriteLine("(enter 'yes' or 'no')");
            string play = Console.ReadLine().ToLower();
            //answer("
            Console.WriteLine();
            if (play == "yes")
            {
                Console.WriteLine("Nice! You are walking across a field and you encounter a fire-breathing dragon! ");
                Console.WriteLine("What are you going to do? ('face the beast' or 'run away')");
                string coward = Console.ReadLine().ToLower();
                if (coward == "face the beast")
                {
                    //------# of heads------
                    Console.WriteLine("\nYou approach the Dragon. You see that he has __ heads.");
                    Console.WriteLine("(enter '1', '2', '3', or '4')");
                    string heads = Console.ReadLine();
                    int eyes = int.Parse(heads) * 2;
                    string weapon = "Nothing";
                    string dragon = "your killer";
                    if (eyes <= 8)
                    {
                        //------choose a weapon------
                        Console.WriteLine("\nNo one has ever faced a " + heads + "-headed dragon before! Choose your weapon.");
                        Console.WriteLine("(enter 'slingshot' or 'sword' or 'bow')");
                        weapon = Console.ReadLine().ToLower();
                        Console.WriteLine();
                        Console.WriteLine("Armed with your " + weapon + ", you approach the dragon.");
                        Console.WriteLine("You can feel its fiery breath as you get closer.");
                        //-----eye color---------
                        Console.WriteLine("It stares at you with its " + eyes + " ____ eyes. (enter 'red' or 'blue')");
                        string color = Console.ReadLine().ToLower();
                        Console.WriteLine();
                        //------Red Eyes---------
                        if (color == "red")
                        {
                            Console.WriteLine("Oh thank goodness! Dragons with " + color + " eyes are friendly");
                            Console.WriteLine();
                            //--------names-----------
                            Console.WriteLine("You pet it and become friends. You name the dragon ____. (enter name)");
                            dragon = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine(Title + " AND " + dragon.ToUpper() + " LIVE HAPPILY EVER AFTER!");
                        }
                        //----------other colors------------
                        else
                        {
                            Console.WriteLine("Welp. Dragons with " + color + " eyes are very deadly but " + weapon + "s are their weakness.");
                            Console.WriteLine("You have defeated the beast but lost an arm and leg in the fight.");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("---------Congratulations champion!------------");
                    }
                    else
                    {
                        Console.WriteLine("Well... " + heads + @" heads is far too many for you to handle.
You definitely just died without a fight. You couldn't handle all " + eyes + " eyes. Rest In Peace " + Title);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("-----------------That sucks!-----------------");
                    }
                    //--------ending/credits-----------
                    Console.WriteLine("Created By: Christian Phillips");
                    Console.WriteLine("Starring " + Title + " as " + Title);
                    Console.WriteLine("Also starring " + dragon + " as '" + dragon + ", The Dragon'");
                    Console.WriteLine(weapon.ToUpper() + " as your primary weapon");
                    Console.WriteLine("Blah Blahson as The Narrator");
                    Console.WriteLine("Quick shoutout to ExperienceIT for sponsoring this");
                    Console.WriteLine("Thanks for playing!");
                    Console.WriteLine("---------------------------------------------\n");

                }
                //-------if they ran away--------
                else if (coward == "run away")
                { Console.WriteLine("Coward!"); }
                else
                { Console.WriteLine("Your answer '" + coward + "' is not an option. Start over!"); }
            }
            //-----if they chose not to play------
            else
            {
                Console.WriteLine("Fine. Then go home.");
                Console.WriteLine();
            }
        }
    }
}