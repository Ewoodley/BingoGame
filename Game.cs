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
        public static int row1 = 0;
        public static int row2 = 0;
        public static int row3 = 0;
        public static int row4 = 0;
        public static int row5 = 0;
        
        public static void GetBingoBall()
        {
            int bingoBall = Caller.NumGenerator();
            BingoBall = bingoBall;
        }
        public static void DupeCheck()
        {
            if (!Caller.CallerBall.Contains(BingoBall))
            {
                BallPin.Add(BingoBall);
            }
            else
                GetBingoBall();
        }

        public static void BallCheck()
        {
            for (int i = 0; i < BingoBoard.drawBoard.GetLength(0); i++)
            {
                if (BingoBoard.drawBoard[0, i] == BingoBall)
                {
                    row1++;
                    Console.WriteLine($"Match Row1, you have {row1} matches in this row");
                    
                }
                if (BingoBoard.drawBoard[1, i] == BingoBall)
                {row2++;
                    Console.WriteLine($"Match Row2, you have {row2} matches in this row");
                    
                }
                if (BingoBoard.drawBoard[2, i] == BingoBall)
                {row3++;
                    Console.WriteLine($"Match Row3, you have {row3} matches in this row");
                    
                }
                if (BingoBoard.drawBoard[3, i] == BingoBall)
                {row4++;
                    Console.WriteLine($"Match Row4, you have {row4} matches in this row");
                    
                }
               if (BingoBoard.drawBoard[4, i] == BingoBall)
                {row5++;
                    Console.WriteLine($"Match Row5, you have {row5} matches in this row");
                    
                }
                if (row1 == 5 || row2 == 5 || row3 == 5 || row4 == 5 || row5 == 5)
                {
                    Console.WriteLine("Congratulations, you won!");
                    bool win = true;
                    break;
                }

                    


            }
        }
           


    }
            
             


        
    
}
