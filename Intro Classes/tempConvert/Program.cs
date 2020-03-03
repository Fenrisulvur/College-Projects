using System;

namespace tempConvert
{
    class Program
    {
        static void Main(string[] args)
        {    
            string userScale;
            string flippedScale;
            double userTemp;
            double calcTemp;

            Console.WriteLine("Please choose your temperature scale: [F,c]");
            try{
                userScale = Console.ReadLine().Substring(0,1).ToUpper();  
            }catch{
                userScale = "F";
            }
            
            Console.WriteLine("Please input the temperature.");
            userTemp = Convert.ToDouble(Console.ReadLine());

            if (userScale == "C"){
                calcTemp = (userTemp * 9) / 5 + 32;
                flippedScale = "F";
            }else{
                calcTemp = (userTemp - 32) * 5 / 9;
                flippedScale = "C"; 
            }

            calcTemp = Math.Round(calcTemp*100)/100;
            Console.WriteLine( string.Format("Converted temperature: {0}{1}; Original: {2}{3}",calcTemp ,flippedScale,userTemp,userScale) );
        }
    }
}

