using System;

namespace inputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string test;
            string combinedTest = "Output:";
            
            Console.WriteLine(Convert.ToInt32(44));

            for (int i = 0; i < 3; i++)
            {
                SetColor(ConsoleColor.DarkCyan);
                Console.WriteLine("Input a line: "+(3-i)+" Left");
                SetColor(ConsoleColor.Green);
                test = Console.ReadLine();
                combinedTest = combinedTest+" "+test;
                SetColor(ConsoleColor.Yellow);
                Console.WriteLine("Input: "+test);
            };

            Console.WriteLine(combinedTest);
            SetColor(ConsoleColor.DarkCyan);

            Console.WriteLine("Input your ID.");
            string myNumber;
            myNumber = Console.ReadLine();
            
            Console.WriteLine("Enter a Pin:");
            string myNumber2;
            myNumber2 = Console.ReadLine();

            Console.WriteLine("Access Denied: User"+myNumber+" Pin: "+myNumber2);
            SetColor(ConsoleColor.Red);
            //end of test
            /*
            yee
            test
             */
            Console.WriteLine("TERMINATION");
            SetColor(ConsoleColor.Gray);

            
        }

        static void SetColor(ConsoleColor col) => Console.ForegroundColor = col;
    }
}
