using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Caller
    {
       

        public static char CharGenerator()
        {
            Random dnr = new Random();
            char[] myLetters = { 'B', 'I', 'N', 'G', 'O' };
            int bingoIndex = dnr.Next(0, myLetters.Length);
            return myLetters[bingoIndex];
        }

        public static int NumGenerator()
        {
            Random rnd = new Random();
            int callNum = rnd.Next(1, 75);
            return callNum;
        }

        public Caller()
        {
            Console.WriteLine($"Grabbing the Bingo Ball... \n\n   Bingo Ball:{CharGenerator()}{NumGenerator()}!");
        }
     //public void BingoCaller()
     //   {
     //       Console.WriteLine($"Grabbing the Bingo Ball... \n\n   Bingo Ball:{CharGenerator()}{NumGenerator()}!");
     //}  
    }
}
