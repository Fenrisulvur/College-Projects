using System;
using System.Collections;

namespace avgGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList grades = new ArrayList();
            double max = 0;
            double avg = 0; 
            double min = 100;
            while (true) //While loop to continue asking for grades
            {
                Console.WriteLine("Enter your next grade; type end to exit.");
                string response = Console.ReadLine().Replace('%',' '); //Remove the % sign incase user inputs it to prevent errors
                if (response.ToLower() == "end"){ //Exit condition for the loop.
                    break; 
                }else if ( Double.TryParse(response, out double x)){ //Make Sure it's a valid number before adding grade
                    grades.Add(Math.Clamp(x, 0, 100)); //Constrain it to a max of 100% & min of 0%
                }else{
                    Console.WriteLine("Last grade discarded: Invalid Format");
                }
            }
            foreach (double x in grades) //Loop to compare each item to min, max, and get sum; Could use sort for min/max but i was experimenting.
            {
                avg += x;
                if(x > max){max = x;}
                if(x < min){min = x;}
                Console.WriteLine("[{0}, Current Sum {1}]",x,avg);
            }
            avg = (avg/grades.Count); //Calculate Average
            Console.WriteLine("Average Grade: {0}%, Highest: {1}%, Lowest: {2}%",roundGrade(avg), roundGrade(max), roundGrade(min));
        }
        static double roundGrade(double x){ //Round to nearest hundreths place
            return (Math.Round((x)*100)/100);
        }
    }
}
