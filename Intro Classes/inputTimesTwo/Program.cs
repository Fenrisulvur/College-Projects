using System;

namespace inputTimesTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int strConver;
            int output;

            Console.WriteLine("Please input a number to be doubled:");
            input = Console.ReadLine();
            strConver = Convert.ToInt32(input);
            output = strConver*2;
            Console.WriteLine("Result: "+output);
            
        }

    }
}
