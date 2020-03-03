
using System;
using System.IO;

namespace myLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            string ticket;
            string userTicket;
            byte ticketType;
            int money = loadMons();
            int reward;
            
            while (running)
            {
                displaySplash();
                Console.WriteLine("Funds: ${0}",money);
                ticketType = askTicketType();                   //Ask ticket type, 3 or 4 digit

                if (money < 1 && ticketType == 1 || money < 2 && ticketType == 2) 
                {
                    Console.WriteLine("Sorry, you are broke loser.");
                    return;
                }
                else if (ticketType == 3)
                {
                    money = 100;
                    writeMons(money);
                    Console.WriteLine("Easter egg found, you have been reset to $100");
                    return;
                }

                money-=(1*ticketType);
                ticket = generateTicketnum(ticketType);         //Gen random ticket num based on type
                userTicket = askTicketNum(ticketType, ticket);  //Ask for their ticket num or gen a response
                reward = compareTickets(ticket, userTicket);   //Ask for their ticket num or gen a response               
                money += reward;
                writeMons(money);
                Console.WriteLine("Play again? [y,N]");
                string input = Console.ReadLine();
                if (!(input.ToLower() == "y")) { running = false;}
            }
            
        }
 
        static int compareTickets(string baseTicket, string userTicket) //Compare and reward matches
        {
            byte matched = 0;
            int reward;

            if (baseTicket.Length < userTicket.Length) { }
            for(byte i = 0;i<(byte)baseTicket.Length;i++)
            {
                if(baseTicket.Substring(i,1) == userTicket.Substring(i,1))
                {
                    matched++;
                }
            }
            switch (matched)
            {
                case 1:
                    reward = 10;
                    Console.WriteLine("You matched {0} and won {1}!",matched,reward);
                    break;
                case 2:
                    reward = 1000;
                    Console.WriteLine("You matched {0} and won {1}!",matched,reward);
                    break;
                case 3:
                    reward = 10000;
                    Console.WriteLine("You matched {0} and won {1}!",matched,reward);
                    break;
                case 4:
                    reward = 1000000;
                    Console.WriteLine("You matched {0} and won {1}!",matched,reward);
                    break;
                default:
                    reward = 0;
                    Console.WriteLine("Sorry you had no matches!");
                    break;
            }
            
            return reward;
        }

        static byte askTicketType() //Ask for 3 or 4 digits
        {
            byte tType = 1;
            bool run = true;

            while(run)
            {
                Console.WriteLine("Please pick a ticket type: [1] Three Digit, [2] Four Digit");
                string input = Console.ReadLine();
                if(input == "1")
                {
                    tType = 1;
                    run = false;
                }
                else if (input == "2")
                {
                    tType = 2;
                    run = false;
                }
                else if (input == "myLottery")
                {
                    tType = 3;
                    run = false;
                }
                else
                {
                   Console.WriteLine("Invalid input, please try again."); 
                }
            }

            return tType;
        }

        static string askTicketNum(byte tType, string ticket) //Ask or gen their ticket
        {
            string tNum = "";
            bool run = true;
            string input;
            Console.WriteLine("Please enter your ticket or press enter to generate one.");

            while (run) 
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    tNum = generateTicketnum(tType);
                    run = false;
                }
                else if (input.Length < ticket.Length || input.Length > ticket.Length )
                {
                   Console.WriteLine("Too short or too long, please try again."); 
                }
                else
                {
                    tNum = input;
                    run = false;
                }
            }

            return tNum;
        }

        static string generateTicketnum(byte x) //Generate a ticket
        {
            byte slots = (byte)( 2 + x); //Since its only 3 or 4 slot i can have the default of 2 + the type of ticket 1 or 2 to get the valid slot count easier.
            Random numGen = new Random();
            string ticketNum = "";
            for (byte i = 0; i<slots;i++)
            {
                ticketNum+=numGen.Next(1,10);
            }
            return ticketNum;
        }

        static void displaySplash() //Boot message
        {
            Console.WriteLine("\n#    # #   # #        ####  ##### ##### ###### #####  #   #\n##  ##  # #  #       #    #   #     #   #      #    #  # #\n# ## #   #   #       #    #   #     #   #####  #    #   #\n#    #   #   #       #    #   #     #   #      #####    #\n#    #   #   #       #    #   #     #   #      #   #    #\n#    #   #   #######  ####    #     #   ###### #    #   #");
        }
       
        static int loadMons() //Load data
        {
            int money = 10;

            if(File.Exists("Money.txt")){     
                money = Convert.ToInt32(File.ReadAllText("Money.txt"));
            }else{
                File.Create("Money.txt");
            }
            return money;  
        }
        static void writeMons(int x) //Write data
        { 
            File.WriteAllText("Money.txt",x.ToString());
        }


    }
}
