using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Game
    {
        public string GetBingoBall()
        {
            string bingoBall = Convert.ToString($"{Caller.CharGenerator()}{Caller.NumGenerator()}");
            return bingoBall;
        }
        public void DupeCheck()
        {
            List<string> ballPit = new List<string>();
            // Part of DupeCheck Test
            for (int i = 0; i < 5; i++)
            {
                string bingoBall = GetBingoBall();
                ballPit.Add(bingoBall);
                if (ballPit.Distinct().Count() != ballPit.Count())
                {
                    GetBingoBall();
                }
            }
            // Part of DupeCheck Test
            //foreach (var ball in ballPit)
            //{
            //    Console.WriteLine(ball);
            //}
        }
    }
}
