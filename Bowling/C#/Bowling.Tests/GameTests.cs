using FluentAssertions;
using Xunit;

namespace Bowling.Tests
{
    public class GameTests
    {
        private readonly Game game;

        public GameTests()
        {
            game = new Game();
        }
        
        [Fact]
        public void Roll_WhenNoPinsHit_ScoreReturns0()
        {
            RollMany(20, 0);
            var score = game.Score();

            score.Should().Be(0);
        }
        
        [Fact]
        public void Roll_When1PinHitEachRoll_ScoreReturns20()
        {
            RollMany(20, 1);
            var score = game.Score();
        
            score.Should().Be(20);
        }
        
        [Fact]
        public void Roll_WithOneSpare_ScoreReturnsExpectedScore()
        {
            RollSpare();
            game.Roll(3);
            RollMany(17, 0);
        
            var score = game.Score();
        
            score.Should().Be(16);
        }
        
        [Fact]
        public void Roll_WithOneStrike_ScoreReturnsExpectedScore()
        {
            RollStrike();
            game.Roll(3);
            game.Roll(4);
            RollMany(16,0);
        
            var score = game.Score();
        
            score.Should().Be(24);
        }
        
        [Fact]
        public void Roll_WithPerfectGame_ScoreReturns300()
        {
            RollMany(12, 10);
        
            var score = game.Score();
        
            score.Should().Be(300);
        }
        
        private void RollMany(int numberOfRolls, int numberOfPins)
        {
            for (var i = 0; i < numberOfRolls; i++)
            {
                game.Roll(numberOfPins);
            }
        }

        private void RollSpare()
        {
            game.Roll(5);
            game.Roll(5);
        }

        private void RollStrike()
        {
            game.Roll(10);
        }
    }
}