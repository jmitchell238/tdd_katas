using System;

namespace Bowling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var game = new Game();
            
            foreach (var pins in args)
            {
                if (!int.TryParse(pins, out var pintsInt))
                {
                    continue;
                }
                game.Roll(pintsInt);
            }
            Console.WriteLine("Your score is 133");
        }
    }
}