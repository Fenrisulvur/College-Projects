using System;

namespace tryCatchAssignment
{
    class InvalidResponseException : Exception
    {
        public InvalidResponseException() : base("Invalid response; please use a number")
        {      
        }

        public InvalidResponseException(string i)
        {
            Console.WriteLine("Please enter a valid number, {0} is not a number.", i);
        }

    }

    class Program
    {
        static Tuple<bool,int> convertToInt(string x)
        {
            int val;
            bool success = Int32.TryParse(x, out val);
            if (!success)
            {
                throw new InvalidResponseException(x);
            }
            else
            {
                return Tuple.Create(true, val);
            }
            
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("_____________________________");
            Console.WriteLine("Please enter a number");

            string response = Console.ReadLine(); 
            var result = new Tuple<bool, int>(false,0); //Default values for the example.

            try
            {
                result = convertToInt(response); //Attempt string conversion to an int.
            }
            catch(InvalidResponseException e)
            {
                Console.WriteLine("Caught a {0}: Continuing with a failed conversion.", e.GetType()); //Display that a custom exception was caught.
            }
            

            Console.WriteLine("Conversion Successful: {0} | Result: {1}", result.Item1, result.Item2); //Display success or failure as well as the int result.
            Console.WriteLine("_____________________________");
        }
    }
}
