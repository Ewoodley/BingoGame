using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Game
    {
        public static int BingoBall;
        public static List<int> BallPin = new List<int>();
        

        public static void GetBingoBall()
        {
            int bingoBall = Caller.NumGenerator();
            BingoBall = bingoBall;
        }
        public static void DupeCheck()
        {
            if (Caller.CallerBall.Contains(BingoBall))
            {
                BallPin.Add(BingoBall);
            }
            else
                return;
        }

        public static void BallCheck()
        {
            int index = -1;
            for (int i = 0; i < BingoBoard.drawBoard.GetLength(0); i++)
            {
                if (BingoBoard.drawBoard[0, i] == BingoBall)
                {
                    index = i;
                    Console.WriteLine("Match Row1");
                }
                if (BingoBoard.drawBoard[1, i] == BingoBall)
                {
                    index = i;
                    Console.WriteLine("Match Row2");
                }
                if (BingoBoard.drawBoard[2, i] == BingoBall)
                {
                    index = i;
                    Console.WriteLine("Match Row3");
                }
                if (BingoBoard.drawBoard[3, i] == BingoBall)
                {
                    index = i;
                    Console.WriteLine("Match Row4");
                }
                if (BingoBoard.drawBoard[4, i] == BingoBall)
                {
                    index = i;
                    Console.WriteLine("Match Row5");
                }
            }
        }
    }
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
