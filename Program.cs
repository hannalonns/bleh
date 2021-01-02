using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Drawing;

namespace Laboration_2
{
    class Program
    {
        static void Main(string[] args)
        { /*Här börjar programmet
        Boolean visar att displaymenu skall vara true detta innebär 
        att Menyn kommer att visas efter input så länge som jag anger true*/
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.WriteLine("\n----------Meny-----------");
            Console.WriteLine("\n  Welcome to Lockdown University!!!");
            Console.WriteLine("\n Press 'Enter' in order to start the game");
            Console.WriteLine("I you to not want to play. just write 'no'.");
            string result = Console.ReadLine();

            if (result == "")

            {
                Start();

                return true;

            }

            else if (result == "no")
            {
                Console.WriteLine("Bye");
                return false;
            }
            else
            {
                return true;
            }

        }
        private static void Start()
        {
            Console.WriteLine("In order to move. \n use the commands 'goup''godown''goright''goleft'");
            Console.WriteLine("Let us begin\n Please enter your name");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You wake up on your back. Your head is aching. Where are you?");
            Console.WriteLine("You know that your name in {0} bot other than that, its a blur",name);
            Console.WriteLine("After looking around you realise you are at the Univesity. It's a Lockown in effect");
            Console.WriteLine("The Whole country is in Lockdown. You remeber that you where chased here, but by who?");
            Console.WriteLine("You stand up and brush yourself off, you need to get out of here.");
        }
    }
    }