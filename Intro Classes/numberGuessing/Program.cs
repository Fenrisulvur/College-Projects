using System;

namespace numberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Dice = new Random();
            int secretNumber = Dice.Next(1,11);
            string guess;
            int guessedNumber;
            bool run = true;
            Console.WriteLine("Pick a number between 1 to 10.");

            while (run)
            {          
                guess = Console.ReadLine();
                guessedNumber = Convert.ToInt32(guess);
    
                if (guessedNumber == secretNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                    run = false;
                }else{
                    Console.WriteLine("You guessed incorrectly! \n Please try again.");
                }
            }

        }
    }
}
