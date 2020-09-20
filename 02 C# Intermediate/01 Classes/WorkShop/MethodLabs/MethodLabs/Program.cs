using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLabs
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            //var numbers = new int[3] { 10, 20, 30 };
            //var result = calc.Add(numbers);
            //var result = calc.Add("Add is starting", 10, 20, 30, 40, 50, 60);
            //Console.WriteLine(result);
            //int number = 1;
            //Increment(ref number);
            //Console.WriteLine(number);

            //int outNumber;
            //Set(out outNumber);
            //Console.WriteLine(outNumber);

            string value = "123";
            int formatedNumber;
            var result = int.TryParse(value, out formatedNumber);
        }

        static void Increment(ref int a)
        {
            a += 2;
        }

        static void Set(out int number)
        {
            number = 10;
        }
    }
}
