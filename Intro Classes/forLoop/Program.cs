using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNumb;
            int increment;

            Console.WriteLine("How high do you want me to count?");
            targetNumb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What do you want me to count by?");
            increment = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= targetNumb; i+=increment)
            {
                Console.WriteLine(i);
            }


        }
    }
}
