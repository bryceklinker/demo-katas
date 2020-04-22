using System;
using Xunit;

namespace Bowling.Game.Test
{
    public class BowlingGameTest
    {
        [Fact]
        public void StartHere()
        {
            var game = new BowlingGame();

            Assert.Equal(-1, game.Score());
        }
    }
}
