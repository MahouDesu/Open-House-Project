using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OpenHouse
{
    static class typeWriter
    {
        public static void TextMod(string text)
        {
            int typewriterDelay = 30;
            foreach (char letter in text)
            {
                Thread.Sleep(typewriterDelay);
                Console.Write(letter);

            }
            Console.WriteLine();
            
        } 
    }
}
