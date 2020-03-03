using System;

namespace checkAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageString;
            
            Console.WriteLine("Please enter your age.");
            ageString = Console.ReadLine();
            age = Convert.ToInt32(ageString);

            if( age < 18 ){
                Console.WriteLine("You do not meet the age requirements");
            }else{
                Console.WriteLine("You meet the age requirements, Welcome.");
            }


        }
    }
}
