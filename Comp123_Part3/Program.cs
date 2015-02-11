using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_Part3
{
    class Program
    {
        static void Main()
        {
            Card myCard = new Card("Ace", "Hearts");
            myCard.Show();

            waitForAnyKey();
        }

        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Please hit any key to exit....");
            Console.ReadKey();
        }
    }
}
