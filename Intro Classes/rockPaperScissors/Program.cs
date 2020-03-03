using System;
using System.IO;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndGen = new Random();
            int[] score = new int[]{0,0};
            int[] wins = loadScores();;
            Console.WriteLine("Input Number of rounds");
            int rnds = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < rnds; i++){
                Console.WriteLine("------------------------------------------------------------------ \nRound: {0} \n----------\nInput your move: [1] = Rock, [2] = Scissors, [3] = Paper",i+1);
                int move =  Math.Clamp(Convert.ToInt32(Console.ReadLine()),1,3);
                int npcMove = rndGen.Next(1,4);
                Console.WriteLine("You used {0} the opponent used {1} {2}",getName(move),getName(npcMove), npcMove);

                if( move == 1 && npcMove == 2 || move == 2 && npcMove == 3 || move == 3 && npcMove == 1 ){
                    score[0]++;
                    Console.WriteLine("You win this round.");
                }else if( npcMove == 1 && move == 2|| npcMove == 2 && move == 3 || npcMove == 3 && move == 1){
                    score[1]++;
                    Console.WriteLine("You lost this round.");
                }else{ 
                    Console.WriteLine("Draw."); 
                }

            }

            if(score[0] > score[1]){
                Console.WriteLine("You win the game!");
                wins[0]++;
            }else if (score[1] > score[0]){
                Console.WriteLine("You lost the game!");
                wins[1]++;
            }else{ 
                Console.WriteLine("Draw!"); 
            }

            Console.WriteLine("--------------\nFinal game score [ You {0} : {1} Com ]\n--------------\nWin history [ You {2} : {3} Com ] ", score[0], score[1], wins[0], wins[1]);
            writeScores(wins);      
        }

        static int[] loadScores(){ //load existing data
            int[] scores = new int[]{0,0};
            int i = 0;

            if(File.Exists("Scores.txt")){     
                foreach (string line in File.ReadAllLines("Scores.txt"))
                 {
                    scores[i] = Convert.ToInt32(line);
                    i++;
                 } 
            }else{
                File.Create("Scores.txt");
            }
            return scores;  
        }

        static void writeScores(int[] x){ //overwrite existing data
           /* using (StreamWriter sw = new StreamWriter("Scores.txt")) {
                foreach (int s in x) {
                sw.WriteLine(s);
                } 
            }*/
            string[] test = new string[]{x[0].ToString(),x[1].ToString()};
            File.WriteAllLines("Scores.txt", test);
        }
        static string getName(int x){ //get move name
            if (x==1){
                return "Rock";
            }else if (x==2){
                return "Scissors";
            }else{
                return "Paper"; 
            }
        }
    }
}






