using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bingo;

namespace BingoTests
{
    [TestClass]
    public class GetBall_Test
    {
        // Check BingoBall is int
        [TestMethod]
        public void GetBall_IsNum()
        {
            List<int> expected = new List<int>()
                { 1, 2, 3, 4, 5,
                  6, 7, 8, 9, 10,
                  11, 12, 13, 14, 15,
                  16, 17, 18, 19, 20,
                  21, 22, 23, 24, 25 };

            Game.GetBingoBall();

            var actual = Game.BingoBall;

            Assert.IsTrue(expected.Contains(Game.BingoBall));
        }
    }
}
