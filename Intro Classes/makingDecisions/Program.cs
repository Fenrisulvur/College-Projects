using System;

namespace makingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAge;
            string userBirthMonth;
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine("Please enter your age.");
            userAge = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter your birth month.");
            userBirthMonth = Console.ReadLine();

            if (Convert.ToInt32(userAge) > 21 && (!userBirthMonth.Contains("sep") && !userBirthMonth.Contains("may")) ) {
                Console.WriteLine("You get a free pizza.");                   
            }
            
        }
    }
}
