using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Game
    {
        public static string BingoBall;
        public static List<string> BallPin = new List<string>();
        
        public static void GetBingoBall()
        {
            string bingoBall = Convert.ToString($"{Caller.CharGenerator()}{Caller.NumGenerator()}");
            BingoBall = bingoBall;
        }
        public static void DupeCheck()
        {
            if (!Caller.CallerBall.Contains(BingoBall))
            {
                BallPin.Add(BingoBall);
                Caller.Calls();
            }
            else
                GetBingoBall();
        }

        public static int BallCheck(string BallPin, int numbersCalled)
        {
            for (var row = 0; row < BingoBoard.row; row++)
            {
                for (var col = 0; col < BingoBoard.col; col++)
                {
                    if (BingoBoard.drawBoard[row, col].Equals(BallPin))
                    {
                        Console.WriteLine("Got that!");
                        numbersCalled++;
                        Console.WriteLine($"You have had {numbersCalled} numbers so far");
                    }
                }
            }
            return numbersCalled;
            /* public static int Win()
             {
                 bool win = false;
                 int winner = 0;
                 while (!win)
                 {
                     for (int k = 0; k < 5; k++)
                         for (int j = 0; j < 5; j++)
                             if (k == w0 && k == w1 && k == w2 && k = w3 && k == w4) winner++;
                     if (j == w5 && j == w6 && j == w7 && j = w8 && j == w9) winner++;
                     if (winner == 1) win = true;

                 }
                 return Win();


             }

                 public static int Lose()
                 {
                     bool lose = false;
                     int lost = 0;
                     if (GetBing() == 75)
                         lost++;
                     if (lost == 1)
                     {
                         lose = true;
                         return Lose();

                     }
                     else return 0;

                 }*/


        }
    }
}
