using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse
{
    static class DiningRoom
    {
        static public bool Furniture()
        {
            int answer = 0;
            bool willContinue = true;
            typeWriter.TextMod("The Dining room has a China Cabinet, a table and a beautiful chandelier. What would you like to know about?");
            do
            {
                typeWriter.TextMod("1) Cabinet");
                typeWriter.TextMod("2) Table");
                typeWriter.TextMod("3) Chandelier");
                typeWriter.TextMod("4) Go somewhere else.");
                answer = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (answer)
                {
                    case 1:
                        typeWriter.TextMod("It's a china cabinet...");
                        break;
                    case 2:
                        typeWriter.TextMod("This table is made of mahogany.");
                        break;
                    case 3:
                        typeWriter.TextMod("The chandelier is very nice.");
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
