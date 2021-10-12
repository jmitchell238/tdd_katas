using System;
using System.IO;
using FluentAssertions;
using Xunit;

namespace Bowling.IntegrationTests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_RunsExpectedOutput()
        {
            using var sw = new StringWriter();
            Console.SetOut(sw);

            var moves = new[]
            {
                "1", "4",       // 5
                "4", "5",       // 5 + 9 = 14
                "6", "4",       // spare 14 + 10 + 10(bonus) = 29
                "5", "5",       // spare 29 + 10 + 10(bonus) = 49
                "10", "strike", // 49 + 10 + 1(bonus) = 60
                "0", "1",       // 60 + 1 = 61
                "7", "3",       // 61 + 10 + 6(bonus) = 77
                "6", "4",       // 77 + 10 + 10(bonus) = 97
                "10",           // 97 + 10 + 10(bonus) = 117
                "2", "8", "6",  // 117 + 10 + 6(bonus) = 133
            };

            Program.Main(moves);

            sw.ToString().Should().Be("Your score is 133\n");

        }
    }
}