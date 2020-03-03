using System;
using System.IO;

namespace myLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("dd/MM/yyyy");
            string fName = "myLogger.txt";

            if(!File.Exists(fName)){
                FileStream stream = File.Create(fName);
                stream.Dispose();
            }

            Console.WriteLine("Please enter your log entry for today:");
            string input = Console.ReadLine();
            File.AppendAllText(fName, dateTime+": "+input+"\n");
            
        }
    }
}
