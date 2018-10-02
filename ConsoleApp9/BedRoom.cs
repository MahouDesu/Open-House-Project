using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenHouse
{
    static class BedRoom
    {
        static public bool Furniture()
        {
            bool willContinue = true;
            typeWriter.TextMod("This is the master bedroom. It comes pre-furnished with a bed, curtains, and a television.\n");
            do
            {
                typeWriter.TextMod("1) Bed");
                typeWriter.TextMod("2) Curtains");
                typeWriter.TextMod("3) Television");
                typeWriter.TextMod("4) Go somewhere else.");

                string answer = Console.ReadLine();
                Console.Clear();
                switch (answer)
                {
                    case "1":
                        typeWriter.TextMod("This is a memory foam matress, it looks very comfortable.\n");
                        break;
                    case "2":
                        typeWriter.TextMod("The curtains are a dark red and can block out the light of the outside for those mornings you just want to sleep in.\n");
                        break;
                    case "3":
                        typeWriter.TextMod("The smart tv can connect to your wifi and is able to stream video from mutiple different services without the need for cable.\n");
                        break;
                    default:
                        typeWriter.TextMod("get out\n");
                        willContinue = false;
                        break;
                }
            } while (willContinue);
            return true;
            
        }
    }
}
