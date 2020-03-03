using System;

namespace stickerCost
{
    class Program
    {
        static void Main(string[] args)
        {
            const double unicornCost = 0.57;
            const double smileyCost = 0.33;
            double totalCost;
            int smileyCount;
            int unicornCount;

            Console.WriteLine("How many smiley stickers do you want to buy?");
            smileyCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many unicorn stickers do you want to buy?");
            unicornCount = Convert.ToInt32(Console.ReadLine());

            totalCost =  Math.Round(((unicornCost*smileyCount) + (smileyCost*smileyCount))*100)/100 ;

            Console.WriteLine(string.Format("You bought {0} Smiley Stickers and {1} Unicorn Stickers for a total of ${2}",smileyCount,unicornCount,totalCost));
        }
    }
}
