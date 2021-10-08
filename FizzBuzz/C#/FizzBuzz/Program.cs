using System;

namespace FizzBuzz
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var result = "";
            for (var i = 1; i <= 100; i++)
            {
                result += $"{FizzBuzzConverter.Convert(i)} ";
            }
            
            Console.Write(result);
            
            // for (var i = 1; i <= 100; i++)
            // {
            //     Console.Write($"{FizzBuzzConverter.Convert(i)} ");
            // }
            //
        }
    }
}