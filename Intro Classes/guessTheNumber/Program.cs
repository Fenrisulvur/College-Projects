using System;
using System.IO;

namespace guessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Dice = new Random();
            int secretNumber = Dice.Next(1,11);
            string guess;
            int guessedNumber;
            int attemps = 0;
            int avgAttemps = avgScores();
            bool guessed = false;

            Console.WriteLine("Guess my number that is between 1-10.");

            while (!guessed)
            {          
                guess = Console.ReadLine();
                guessedNumber = Convert.ToInt32(guess);
    
                if (guessedNumber == secretNumber)
                {
                    Console.WriteLine("You guessed correctly!");
                    guessed = true;
                }
                else
                {
                    Console.WriteLine("You guessed incorrectly! \n Please try again.");
                    attemps++;
                }
            }

            if (avgAttemps >= attemps || avgAttemps == 0)
            {
                Console.WriteLine("Congrats! You guessed correctly and beat the average! You {0} Average {1}",attemps,avgAttemps);
            }
            else
            {
                Console.WriteLine("Sorry, You guessed correctly but made more guesses than the average! You {0} Average {1}",attemps,avgAttemps);
            }

            writeScore(attemps.ToString());
            
        }

        static int avgScores()
        {
            int sum = 0;
            int i = 0;

            if(File.Exists("Scores.txt")){     
                foreach (string line in File.ReadAllLines("Scores.txt"))
                 {
                    sum += Convert.ToInt32(line);
                    i++;
                 } 
            }else{
                File.Create("Scores.txt");
            }
            Console.WriteLine("Games Played {1} Avg Guesses needed {2}",sum,i,Math.Max(1,sum)/Math.Max(1,i));
            return Math.Max(1,sum)/Math.Max(1,i);  
        }

        static void writeScore(string x)
        {
           File.AppendAllText("Scores.txt", x+"\n");
        }

    }
}
