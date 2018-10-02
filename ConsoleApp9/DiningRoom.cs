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
            bool willContinue = true;
            typeWriter.TextMod("The Dining room has a China Cabinet, a table and a beautiful chandelier. What would you like to know about? \n");
            do
            {
                typeWriter.TextMod("1) Cabinet");
                typeWriter.TextMod("2) Table");
                typeWriter.TextMod("3) Chandelier");
                typeWriter.TextMod("4) Go somewhere else.");

                string answer = Console.ReadLine();
                Console.Clear();
                switch (answer)
                {
                    case "1":
                        typeWriter.TextMod("It's a china cabinet...\n");
                        break;
                    case "2":
                        typeWriter.TextMod("This table is made of mahogany.\n");
                        break;
                    case "3":
                        typeWriter.TextMod("The chandelier is very nice.\n");
                        break;
                    case "4":
                        typeWriter.TextMod("\n");
                        willContinue = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, that wasn't a choice, try again. \n");
                        break;
                }
            }
            while (willContinue);
            return true;
        }
    }
}
