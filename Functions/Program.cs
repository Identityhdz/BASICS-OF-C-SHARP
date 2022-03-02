using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Show();
            CalculateSum(10,12.4);
            Console.WriteLine(Multiply(3,5));
        }

        static double Multiply(double number1, double number2) {
            double mul = number1 * number2;
            return mul;
        }

        static void CalculateSum(double number1, double number2) {
            double sum = number1 + number2;
            Console.WriteLine(sum);
        }
        static void Show() {
            Console.WriteLine("Hello, this is a function");
        }
    }
}
