namespace MethodLabs
{
    partial class Program
    {
        public class Calculator
        {
            public int Add(string message, params int[] numbers)
            {
                System.Console.WriteLine(message);
                var value = 0;
                foreach (var number in numbers)
                {
                    value += number;
                }
                return value;
            }
        }
    }
}
