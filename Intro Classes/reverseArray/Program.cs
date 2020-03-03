using System;

namespace reverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine("Please enter value of position {0}",i+1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" , ", revArr(arr)));
        }

        static int[] revArr(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }
    }
}
