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
            int answer = 0;
            bool willContinue = true;
            typeWriter.TextMod("This Kitchen comes with a microwave, fridge and an oven.");
            do
            {
                typeWriter.TextMod("1) Microwave");
                typeWriter.TextMod("2) Fridge");
                typeWriter.TextMod("3) Oven");
                typeWriter.TextMod("4) Go somewhere else.");
                answer = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (answer)
                {

                    case 1:
                        typeWriter.TextMod("This microwave is stainless steel and runs at 1000 watts to ensure proper heating throughout your meal.");
                        break;
                    case 2:
                        typeWriter.TextMod("This fridge comes with a water and ice dispenser built into it!");
                        break;
                    case 3:
                        typeWriter.TextMod("This oven has an induction stovetop.");
                        break;
                    default:
                        Console.WriteLine();
                        willContinue = false;
                        break;

                }
            } while (willContinue);
            return true;

        }
    }
}
