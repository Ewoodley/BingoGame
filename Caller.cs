using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Caller
    {
        public static List<string> CallerBall = new List<string>();

        public static char CharGenerator()
        {
            Random dnr = new Random();
            char[] myLetters = { 'B', 'I', 'N', 'G', 'O' };
            // Part of Ball Dupe Test
            //char[] myLetters = { 'B' };
            int bingoIndex = dnr.Next(0, myLetters.Length);
            return myLetters[bingoIndex];
        }

        public static int NumGenerator()
        {
            Random rnd = new Random();
            int callNum = rnd.Next(1, 75);
            // Part of Ball Dupe Test
            //int callNum = rnd.Next(1, 3);
            return callNum;
        }
       
        public static void Calls()
        {
            Console.WriteLine($"Grabbing the Bingo Ball... \n\n   Bingo Ball: {Game.BingoBall}!");
            CallerBall.Add(Game.BingoBall);
        }
     
    }
}
