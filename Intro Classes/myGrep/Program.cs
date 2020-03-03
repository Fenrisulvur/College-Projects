using System;
using System.IO;

namespace myGrep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a term to search for:");
            string sTerm = Console.ReadLine(); 
            int count = 0;

            foreach (string line in File.ReadAllLines("microsoft.txt"))
            {
                if(line.Contains(sTerm)){
                    Console.WriteLine(line);
                    count++;
                }
            }
              
            Console.Write("Lines the term was found in: "); 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(count); 
            Console.ResetColor();
        }
    }
}
