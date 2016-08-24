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
            Console.WriteLine("Welcome! What is your name? (enter your name)");
            string name = Console.ReadLine();
            string Title = name.ToUpper();
            Console.Write("HEY " + Title + "!!! Would you Like to play a game?");
            Console.WriteLine("(enter 'yes' or 'no')");
            string play = Console.ReadLine().ToLower();
            Console.WriteLine();
            if (play == "yes")
            {
                Console.WriteLine("Nice! You are walking across a field and you encounter a fire-breathing dragon! ");
                Console.WriteLine("What are you going to do? ('face the beast' or 'run away')");
                string coward = Console.ReadLine().ToLower();
                if (coward == "face the beast")
                {
                    //-----# of heads-----
                    Console.WriteLine("You approach the Dragon. You see that he has __ heads.");
                    Console.WriteLine("(enter '1' or '2' or '3')");
                    string heads = Console.ReadLine();
                    int eyes = int.Parse(heads) * 2;
                    Console.WriteLine();
                    //------choose a weapon------
                    Console.WriteLine("No one has ever faced a " + heads + "-headed dragon before! Choose your weapon.");
                    Console.WriteLine("(enter 'slingshot' or 'sword' or 'bow and arrow')");
                    string weapon = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    Console.WriteLine("Armed with your " + weapon + " , you approach the dragon.");
                    Console.WriteLine("You can feel its fiery breath as you get closer.");
                    //-----eye color---------
                    Console.WriteLine("It stares at you with its " + eyes + " ____ eyes. (enter 'red' or 'blue')");
                    string color = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    Console.WriteLine("Oh thank goodness! Dragons with " + color + " eyes are friendly");
                    Console.WriteLine();
                    //------names---------
                    Console.WriteLine("You pet it and become friends. You name the dragon ____. (enter name)");
                    string dragon = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine(name + " and " + dragon + " live happily ever after.");

                }
                //-------if they run away--------
                else
                { Console.WriteLine("Coward!"); }
            }
            //-----if they dont wanna play-----
            else
            { Console.WriteLine("Fine. Then go home."); }
        }
    }
}
