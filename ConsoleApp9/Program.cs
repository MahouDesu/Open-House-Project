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
            int answer = 0;
            bool willContinue = true;
            typeWriter.TextMod("Hello! Welcome to our open house!");
            do
            {
                typeWriter.TextMod("What would you like to see?\n");
                typeWriter.TextMod("1) Kitchen");
                typeWriter.TextMod("2) Living room");
                typeWriter.TextMod("3) Dining room");
                typeWriter.TextMod("4) Bedroom");
                typeWriter.TextMod("5) Exit");

                answer = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (answer)
                {
                    case 1:
                        {
                            Kitchen.Appliances();
                            break;
                        }
                    case 2:
                        {
                            LivingRoom.Furniture();
                            break;
                        }
                    case 3:
                        {
                            DiningRoom.Furniture();
                            break;
                        }
                    case 4:
                        {
                            BedRoom.Furniture();
                            break;
                        }
                    case 5:
                        {
                            willContinue = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Please pick a number 1-5");
                        break;
                }
            } while (willContinue);
            typeWriter.TextMod("press enter to continue");
            Console.ReadLine();
        }
    }
}


