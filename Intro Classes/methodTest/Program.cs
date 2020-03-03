using System;

namespace methodTest
{
    class Program
    {
        static int testInt;
        
        static void Main(string[] args)
        {
            const string permaString = "Test";

            string testString = "12345";
            
            string result = splitString(testString);

            Print(permaString + ": "+result) ;

            int myModulus = 15%6;   //Divide 15 by 6 for remainder
            Print(myModulus);

            testInt = 24;
            Print(testInt*2);

            Print("This is a test.");
            Print("Goodbye.");
        }

        static void Print(dynamic x){
            Console.WriteLine(x);
        }

        static string splitString(string str){
            string holder = "";
            for (int i = 0; i < str.Length; i++)
            {
               holder = holder+" "+str[i]; 
            }
            return holder;
        }

    }
}
