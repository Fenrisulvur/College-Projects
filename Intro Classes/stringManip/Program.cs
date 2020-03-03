using System;

namespace stringManip
{
    class Program
    {
        static void Main(string[] args)
        {
            string origStr = "Epson Projector";
            string subVar = "Ep";
            int stringIndex = origStr.IndexOf(subVar);
            print(stringIndex);
            print(origStr.Substring(2,4));
            print(subVar.Length+" - "+stringIndex);
            print(origStr.Substring(stringIndex, subVar.Length));
        }
        static void print(dynamic x)
        {
            Console.WriteLine(x);
        }

    }
}
