using System;

namespace howMany
{
    class Program
    {
        static void Main(string[] args)
        {
            string phraseCheck;
            int repititions = 0;
            int strLength;

            Console.WriteLine("Enter the phrase you want to check.");
            phraseCheck = string.Join(" ", Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)); //remove excess spaces

            strLength = phraseCheck.Length;        

            for (int i = 0; i < strLength; i++)
            {
                if (phraseCheck[i] == ' ') {repititions++;}
            }
            Console.WriteLine( String.Format("I found Spaces a total of {0} times, total string length: {1} word count: {2}", repititions, strLength, repititions+1) );

        }
    }
}
