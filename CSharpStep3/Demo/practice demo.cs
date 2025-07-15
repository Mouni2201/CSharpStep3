using System;


namespace CompileTimeDemo
{
    class Calculator
    {
        // Same name, same return type, different parameters
        public int Math(int a, int b)
        {
            return a + b;
        }

        public int Math (int a, int b, int c)
        {
            return a + (b - c);
        }

        public int Math ( double a, double b, double c )
        {
            return Convert.ToInt32((a + (b * c)));
        }

        public int Math (int a, double b)
        {
            return a + (int)b;
        }
    }

    class Program
    {
        static void Main()
        {
            var calci = new Calculator();
            //calci.Math(3, 9);
            int sum1 = calci.Math(3, 9);
            int sum2 = calci.Math(3, 9, 4);
            int sum3 = calci.Math(2.5, 3.0, 4.0);
            int sum4 = calci.Math(5, 3.7);


            Console.WriteLine($"sum1: {sum1}" );  // 12
            Console.WriteLine($"sum2: {sum2}");  // 3  (3 + (9 − 4))
            Console.WriteLine($"sum3: {sum3}");  // (int)(2.5 + (3.0 × 4.0)) = 14
            Console.WriteLine($"sum4: {sum4}");  // 8
        }
    }
}