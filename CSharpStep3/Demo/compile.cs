using System;

namespace compileDemo
{


    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(3, 4));

            Console.WriteLine(calc.Add(3.5, 4.2));
        }
    }
}