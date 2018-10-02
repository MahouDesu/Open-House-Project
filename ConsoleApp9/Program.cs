using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool willContinue = true;
            typeWriter.TextMod("Hello! Welcome to our open house!");
            do //may want to use a diferent loop type that doesn't even have to execute once. or
               //find another workaround to not display "please pick a number" again before it exits"
            {
                typeWriter.TextMod("What would you like to see?\n");
                typeWriter.TextMod("1) Kitchen");
                typeWriter.TextMod("2) Living room");
                typeWriter.TextMod("3) Dining room");
                typeWriter.TextMod("4) Bedroom");
                typeWriter.TextMod("5) Exit");

                string answer = (Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Please pick a number 1-5");
                switch (answer)
                {
                    case "1":
                        {
                            Kitchen.Appliances();
                            break;
                        }
                    case "2":
                        {
                            LivingRoom.Furniture();
                            break;
                        }
                    case "3":
                        {
                            DiningRoom.Furniture();
                            break;
                        }
                    case "4":
                        {
                            BedRoom.Furniture();
                            break;
                        }
                    case "5":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sorry, that wasn't a choice, try again. \n");
                            break;
                        }
                }
            } while (willContinue);
            typeWriter.TextMod("press enter to continue");
            Console.ReadLine();
        }
    }
}


