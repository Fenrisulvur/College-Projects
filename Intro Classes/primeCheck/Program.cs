using System;
namespace primeCheck
{

    class NumberClass
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public NumberClass(string name, int value)
        {
            this.Name = name;
            this.Value = value;
        }

        public bool IsPrime()
        {
            for (int i = 2;i<Value;i++){ if ( (Value%i)==0 ){ return false; } }
            return true;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            NumberClass newClass = new NumberClass("Test Number 1", 2);
            NumberClass newClass2 = new NumberClass("Test Number 2", 44);

            Console.WriteLine("Is {0} with a value of {1} Prime?: {2}",newClass.Name,newClass.Value,newClass.IsPrime());
            Console.WriteLine("Is {0} with a value of {1} Prime?: {2}",newClass2.Name,newClass2.Value,newClass2.IsPrime());
        }
    }
}