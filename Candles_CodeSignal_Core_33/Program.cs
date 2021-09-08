using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candles_CodeSignal_Core_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int candles = 6;
            int make = 4;
            int res = Candles(candles, make);
            Console.WriteLine(res);
        }

        static int Candles(int candles, int makeNew)
        {
            int r = 0;
            while (candles > 0)
            {
                candles--;
                r++;
                if (r % makeNew == 0)
                    candles++;
            }
            return r;
        }

    }
}
