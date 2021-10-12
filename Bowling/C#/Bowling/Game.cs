namespace Bowling
{
    public class Game
    {
        private readonly int[] rolls = new int[21];
        private int currentRoll;

        public void Roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }

        public int Score()
        {
            var score = 0;
            var frameIndex = 0;
            for (var frame = 0; frame < 10; frame++)
            {
                if (IsStrike(frameIndex))
                {
                    score += 10 + StrikeBonus(frameIndex);
                    frameIndex++;
                    continue;
                }
                
                if (IsSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frameIndex);
                    frameIndex += 2;
                    continue;
                }

                score += SumOfBallsInFrame(frameIndex);
                frameIndex += 2;
            }

            return score;
        }

        private int SumOfBallsInFrame(int frameIndex) => rolls[frameIndex] + rolls[frameIndex + 1];

        private bool IsSpare(int frameIndex) => SumOfBallsInFrame(frameIndex) == 10;

        private bool IsStrike(int frameIndex) => rolls[frameIndex] == 10;

        private int SpareBonus(int frameIndex) => rolls[frameIndex + 2];

        private int StrikeBonus(int frameIndex) => SumOfBallsInFrame(frameIndex + 1);
    }
}