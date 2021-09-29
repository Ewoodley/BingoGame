using System;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new BingoBoard();
            var ball = new Caller();
        }
    }
}

/* TO DO
 * Check Bingo Card against Caller Ball
 * Check Win or Lose Conditions
 * Check for Duplicate Draws
 */
