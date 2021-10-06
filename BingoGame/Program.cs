using System;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new BingoBoard();
            var cont = true;
            while (cont)
            {
                Console.WriteLine("Push any key to draw a new ball");
                Console.ReadLine();
                Game.GetBingoBall();
                Caller.Calls();
                cont = Game.BoardCheck();


            }
        }
    }
}
/* TO DO
 * Cteate Tests
 */


