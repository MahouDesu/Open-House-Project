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

            int answer = 0;
            bool willContinue = true;
            typeWriter.TextMod("This is the living room, it comes furnished with a couch, a coffee table, and a recliner. What you like to know about?");
            do
            {
                typeWriter.TextMod("1) Couch");
                typeWriter.TextMod("2) Coffee Table");
                typeWriter.TextMod("3) Recliner");
                typeWriter.TextMod("4) Go somewhere else.");
                answer = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (answer)
                {
                    case 1:
                        typeWriter.TextMod("The couch is a 4 piece sectional couch.");
                        break;
                    case 2:
                        typeWriter.TextMod("The Coffee Table is made of mahogany and is crafted masterfully.");
                        break;
                    case 3:
                        typeWriter.TextMod("The Recliner has electric controls in it and doubles as a massage chair.");
                        break;
                    default:
                        Console.WriteLine();
                        willContinue = false;
                        break;

                }
            }
            while (willContinue);
            return true;
            
        }
    }
}
