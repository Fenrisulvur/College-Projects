using System;

namespace TicTacToe
{
    class Program
    {
        static byte[,] table = new byte[3,3];
        static bool turn = false;
        static byte turns = 0;
        static bool win = false;
        static void Main(){
            while(!win){
                if (turns == 9){
                    win = true;
                    drawBoard();
                    Console.WriteLine("Game has ended in a draw!");
                    break;
                }
                drawBoard();
                promptTurn();
            }
        }
        static void promptTurn(){
            Console.WriteLine("Player {0}: Take your turn: ",(!turn) ? " 1 (O) " : " 2 (X) ");
            procTurn(Convert.ToByte(Console.ReadLine()));
        }
        static void procTurn(int choice){
            if (choice > 9 || choice < 1){
                Console.WriteLine("Invalid choice please try again.");
                promptTurn();
            }else{
                byte x = (byte)((choice - 1) / 3);
                byte y = (byte)((choice - 1) % 3);
                if(table[x,y] == 0){
                    table[x,y] = (byte)((!turn) ? 2 : 1); 
                    checkBoard();
                    if(!win){
                        turn = !turn;
                        turns++;
                    }else{
                        drawBoard();
                        Console.WriteLine("Player {0}: has won the game!",(!turn) ? " 1 (O) " : " 2 (X) "); 
                    }
                }else{
                    Console.WriteLine("Space is filled, try again.");
                    promptTurn();
                }
            } 
        }
        static void checkBoard(){
            for(int x = 0; x < 3; x++){
                if (table[x, 0] > 0 && table[x, 0] == table[x, 1] && table[x, 1] == table[x, 2]){
                    win = true;
                    return;
                }
            }
            for(int y = 0; y < 3; y++){
                if (table[0, y] > 0 && table[0, y] == table[1, y] && table[1, y] == table[2, y]){
                    win = true;
                    return;
                }
            }
            if(table[0,0] > 0 && table[0,0] == table[1,1] && table[1,1] == table[2,2]){ 
                win = true;
                return;
            }
            if(table[2,0] > 0 && table[2,0] == table[1,1] && table[1,1] == table[0,2]){
                win = true;
                return;
            }
        }
        static void drawBoard(){
            Console.Clear();
            string pointer;
            byte bSlot = 0;
            for (byte x = 0; x < 3; x++){
                for(byte y = 0; y < 3; y++){
                    bSlot++;  
                    pointer = "   ";
                    if (table[x, y] != 0) pointer = (table[x, y] == 1) ? " X " : " O ";
                    if (table[x, y] == 0) pointer = " "+(bSlot)+" ";
                    Console.Write(pointer);
                    if (y < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (x < 2) Console.WriteLine("-----------"); 
            }
        }

    }
}
