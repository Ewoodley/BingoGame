using System;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new BingoBoard();

            while (true)
            {  
            Console.WriteLine("Push any key to draw a new ball");
            Console.ReadLine();
            Game.GetBingoBall();
            Caller.Calls();
            Game.DupeCheck();
            Game.BallCheck();
            }
        }
    }
}
/* TO DO
 * Check Bingo Card against Caller Ball
 * Check Win or Lose Conditions
 */


