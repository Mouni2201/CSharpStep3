using System;


namespace CompileTimeDemo
{
    class calculator
    {
        // Same name, same return type, different parameters
        public int Math(int a, int b)
        {
            return a + b;
        }

        public int Math(int a, int b, int c)
        {
            return a + (b - c);
        }

    }
}