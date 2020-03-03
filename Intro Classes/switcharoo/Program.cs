using System;

namespace switcharoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite color");
            string favColor = Console.ReadLine().ToLower();
            int i = 2;

            switch (favColor)
                {
                case "red" when i == 2:
                    Console.WriteLine("Red ones go faster x 2");
                    break;
                case "red":
                    Console.WriteLine("Red ones go faster");
                    break;
                case "green":
                    Console.WriteLine("Green boiz da best");
                    break;
                case "blue":
                    Console.WriteLine("Da ba de da ba die");
                    break;
                case "cyan":
                    Console.WriteLine("Cool choice");
                    break;
                case "magenta":
                    Console.WriteLine("You offend my eyes");
                    break;
                case "brown":
                    Console.WriteLine("Uh oh, stiiinkyy");
                    break;
                case "blurple":
                    Console.WriteLine("Know your place, trash.");
                    break;   
                default:
                    Console.WriteLine("That is a lame color.");
                    break;
            }


            
        }
    }
}
