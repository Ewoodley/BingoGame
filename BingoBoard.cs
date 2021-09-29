using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bingo
{
    public class BingoBoard
    {
        public BingoBoard()
        {
            int[,] drawboard = new int[5, 5];
            Random draw = new Random();
            Console.WriteLine("B\tI\tN\tG\tO");
                     
            for (int i = 0; i < drawboard.GetLength(0); i++)
            {
                for (int j = 0; j < drawboard.GetLength(1); j++)
                { 
                   drawboard[i, j] = draw.Next(1, 76);

                    Console.Write(drawboard[i, j] + "\t");

                }
                Console.WriteLine("\n");
                
            }
        }
    }
}
