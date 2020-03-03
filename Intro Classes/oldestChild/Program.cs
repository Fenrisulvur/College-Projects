using System;
using System.Linq;

namespace oldestChild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of children you have:");
            int numChild = Convert.ToInt32(Console.ReadLine());
            int[] ages = new int[numChild];
            string[] names = new string[numChild];
            for(int i = 0; i < numChild; i++){
                Console.WriteLine("Enter Child "+(i+1)+"'s age and name, Example: age, name");
                String[] splitTemp = Console.ReadLine().Split(',',5, StringSplitOptions.RemoveEmptyEntries); 
                ages[i] = Convert.ToInt32(splitTemp[0]);
                names[i] = splitTemp[1];
            };
            for(int i = 0; i < numChild; i++){ Console.WriteLine("Child {0}: [{1}, {2}]",(i+1),names[i],ages[i]); };
            Console.WriteLine("Average Age: "+ages.Average()+ " Oldest Age: "+ages.Max()+" Youngest Age:"+ages.Min());
            Tuple<int, string> data = largestInArray(ages, names);
            Console.WriteLine("Oldest: {0}, Age: {1}",data.Item2,data.Item1);
        }
        static Tuple<int, string> largestInArray(int[] x, string[] y){
           int largest = 0;
           string prefix = string.Empty; 
           string names = string.Empty;
           for(int i = 0; i < x.Length; i++){ if (x[i] > largest) {largest = x[i]; names = y[i];prefix = "";}else if(x[i] == largest){names += ", "+y[i]; prefix = "Twins:";} }
           return Tuple.Create(largest, (prefix+names));
        }
    }
}
                                                                                      