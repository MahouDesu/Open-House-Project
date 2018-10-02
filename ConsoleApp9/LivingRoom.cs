using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse
{
    static class LivingRoom
    {
        static public bool Furniture()
        {

            bool willContinue = true;
            typeWriter.TextMod("This is the living room, it comes furnished with a couch, a coffee table, and a recliner. What would you like to know about?");
            do
            {
                typeWriter.TextMod("1) Couch");
                typeWriter.TextMod("2) Coffee Table");
                typeWriter.TextMod("3) Recliner");
                typeWriter.TextMod("4) Go somewhere else.");

                string answer = (Console.ReadLine());
                Console.Clear();
                switch (answer)
                {
                    case "1":
                        typeWriter.TextMod("The couch is a 4 piece sectional couch.\n");
                        break;
                    case "2":
                        typeWriter.TextMod("The Coffee Table is made of mahogany and is crafted masterfully.\n");
                        break;
                    case "3":
                        typeWriter.TextMod("The Recliner has electric controls in it and doubles as a massage chair.\n");
                        break;
                    case "4":
                        Console.WriteLine("\n");
                        willContinue = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, that wasn't an option. Try Again. \n");
                        break;
                }
            }
            while (willContinue);
            return true;
            
        }
    }
}
