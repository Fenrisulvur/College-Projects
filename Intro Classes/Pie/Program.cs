using System;

namespace Pie
{
    class Program
    {
        static void Main(string[] args)
        {
            byte    bytePie;
            short   shortPie;
            int     intPie;
            long    longPie;
            float   floatPie;
            double  doublePie;
            decimal decimalPie;

            bytePie     =   (byte)Math.PI;
            shortPie    =   (short)Math.PI;
            intPie      =   (int)Math.PI;
            longPie     =   (long)Math.PI;
            floatPie    =   (float)Math.PI;
            doublePie   =   (double)Math.PI;
            decimalPie  =   (decimal)Math.PI;

            Console.WriteLine("Pi is {0}",bytePie);
            Console.WriteLine("Pi is {0}",shortPie);
            Console.WriteLine("Pi is {0}",intPie);
            Console.WriteLine("Pi is {0}",longPie);
            Console.WriteLine("Pi is {0}",floatPie);
            Console.WriteLine("Pi is {0}",doublePie);
            Console.WriteLine("Pi is {0}",decimalPie);
        }
    }
}
