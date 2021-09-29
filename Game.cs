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
          //  for (int i = 0; i < 5; i++)
            //{
                string bingoBall = GetBingoBall();
                ballPit.Add(bingoBall);
                if (ballPit.Distinct().Count() != ballPit.Count())
                {
                    GetBingoBall();
                }
          //  }
            // Part of DupeCheck Test
            //foreach (var ball in ballPit)
            //{
            //    Console.WriteLine(ball);
            //}
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
}
