using System;
using System.IO;
using System.Text;
using System.Diagnostics;

namespace myFiles
{
    class Program
    {
        static void Main(string[] args)
        {
       
           /*Console.WriteLine("Enter file name:");
            string fName = Console.ReadLine()+".txt";

            if(!File.Exists(fName)){
                FileStream stream = File.Create(fName);
                stream.Dispose();
            }else{
                Console.WriteLine("File already exists. Do you want to overwrite it? [y/N]");
                string response = Console.ReadLine();
                if (response == "y"){
                    FileStream stream = File.Create(fName);
                    stream.Dispose();
                }
            }

            Console.WriteLine("Enter text to add:");
            string input = Console.ReadLine();
            File.AppendAllText(fName,input+"\n");

            Console.WriteLine("Do you want to view the contents of the current file? [y/N]");
            string response2 = Console.ReadLine();
            if (response2 == "y"){
                foreach (string line in File.ReadAllLines(fName))
                {
                    Console.WriteLine(line);
                }
            }*/

            
            Console.WriteLine("Enter a url:");
            string url = Console.ReadLine();
            Console.WriteLine("Choose a browser Firefox, Edge, Chrome:");
            string input = Console.ReadLine().ToLower();

            switch (input){
                case "firefox":
                    Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe",url);
                    break;
                case "edge":
                    Process.Start("microsoft-edge" );
                    break;
                case "chrome":
                    break;
                default:
                    Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe",url);
                    break;
            }
            

        }
    }
}
