using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse
{
    static class Kitchen
    {
        static public bool Appliances()
        {
            bool willContinue = true;
            typeWriter.TextMod("This Kitchen comes with a microwave, fridge and an oven.\n");
            do
            {
                typeWriter.TextMod("1) Microwave");
                typeWriter.TextMod("2) Fridge");
                typeWriter.TextMod("3) Oven");
                typeWriter.TextMod("4) Go somewhere else.");

                string answer = Console.ReadLine();
                Console.Clear();
                switch (answer)
                {

                    case "1":
                        typeWriter.TextMod("This microwave is stainless steel and runs at 1000 watts to ensure proper heating throughout your meal.\n");
                        break;
                    case "2":
                        typeWriter.TextMod("This fridge comes with a water and ice dispenser built into it!\n");
                        break;
                    case "3":
                        typeWriter.TextMod("This oven has an induction stovetop.\n");
                        break;
                    case "4":
                        typeWriter.TextMod("\n");
                        willContinue = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, that wasn't a choice, try again. \n");
                        break;

                }
            } while (willContinue);
            return true;

        }
    }
}
