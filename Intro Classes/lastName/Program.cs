using System;

namespace lastName
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            int nameIndex;

            print("Please enter your full name.");
            fullName = Console.ReadLine();
            nameIndex = fullName.IndexOf(" ")+1;                                                      
            int lastNameLength = ( fullName.Length - nameIndex);                                       


            if (lastNameLength >= 5)
            {                                                                                        
                print("First 5 of last name is: "+fullName.Substring(nameIndex,5)); 
            }
            else
            {               
                print("First 5 of last name is: "+fullName.Substring(nameIndex,lastNameLength));     
            }
        }

        static void print(dynamic x)
        {
            Console.WriteLine(x);
        }
    } 
}