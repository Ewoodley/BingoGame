using System;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var board = new BingoBoard();
                     
            Game.GetBingoBall();
            Caller.Calls();
            
               
                Console.WriteLine("Push any key to draw a new ball");
                Console.ReadLine();
                               
            
            //var test = new Game();
            // Part of DupeCheck Test
            //test.DupeCheck();
        }
    }

}
/* TO DO
 * Check Bingo Card against Caller Ball
 * Check Win or Lose Conditions
 * Check for Duplicate Draws
 */


