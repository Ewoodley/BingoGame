using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Caller
    {
        public static List<int> CallerBall = new List<int>();

        public static int NumGenerator()
        {
            Random rnd = new Random();
            int callNum = rnd.Next(1, 25);
            return callNum;
        }
       
        public static void Calls()
        {
            Console.WriteLine($"Grabbing the Bingo Ball... \n\n   Bingo Ball: {Game.BingoBall}!");
            CallerBall.Add(Game.BingoBall);
        }
     
    }
}
