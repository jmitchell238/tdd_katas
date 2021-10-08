namespace FizzBuzz
{
    public static class FizzBuzzConverter
    {
        public static string Convert(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (value % 3 == 0)
            {
                return "Fizz";
            }

            return value % 5 == 0 ? "Buzz" : $"{value.ToString()}";
        }
    }
}