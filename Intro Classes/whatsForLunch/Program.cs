using System;

namespace whatsForLunch
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;

            Console.WriteLine("Have you had lunch yet? [y,n]");
            response =  Console.ReadLine().Substring(0,1).ToLower();

            if (response == "y") 
            {
                Console.WriteLine("Congratulations!");
            }
            else
            {
                Console.WriteLine("Do you want pizza?");
                string response2 =  Console.ReadLine().Substring(0,1).ToLower();
                
                if (response2 == "y") 
                {
                    Console.WriteLine("Wait for me, i am coming with you.");
                }
                else
                {
                    Console.WriteLine("You are missing out.");
                }
                
            }

        }
    }
}
