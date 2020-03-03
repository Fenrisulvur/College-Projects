/*
1. Write a program in C# Sharp to create a user define function with parameters.
Test Data :
Please input a name : John
Expected Output :
Welcome friend John !
Have a nice day!

2. Write a program in C# Sharp to create a function for the sum of two numbers. 
Test Data :
Enter a number: 15
Enter another number: 16
Expected Output :
The sum of two numbers is : 31

3. Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
using System;
*/

using System;

namespace MethodExerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string testName = "John";
            greet(testName);
            begone();
        }
        
        static void greet(string x)
        {
            Console.WriteLine("Welcome friend {0}!",x);
        }

        static void begone()
        {
            Console.WriteLine("Have a nice day!");
        }
    }
}

using System;

namespace MethodExerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int testData1 = 15;
            int testData2 = 16;
            Console.WriteLine(add(testData1,testData2));
        }
        
        static int add(int x, int y)
        {
            return (x+y);
        }

    }
}

using System;

namespace MethodExerciseThree
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString =  "This is a test string.";
            int spaceCount = countSpaces(testString);
            Console.WriteLine(spaceCount);
        }
        
        static int countSpaces(string x)
        {
            return (x.Count(char.IsWhiteSpace));
        }

    }
}
