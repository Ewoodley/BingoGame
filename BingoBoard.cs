using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bingo
{
    public class BingoBoard
    {
        public static int[,] drawBoard = new int[5,5];

        public  BingoBoard()
        {
            Random draw = new Random();
            Console.WriteLine("B\tI\tN\tG\tO");
                     
            for (var row = 0; row < drawBoard.GetLength(0); row++)
            {
                for (var col = 0; col < drawBoard.GetLength(1); col++)
                { 
                   drawBoard[row, col] = draw.Next(1, 25);
                   Console.Write(drawBoard[row, col] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
