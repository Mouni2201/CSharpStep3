using System;
namespace MathProgram
{
    class Program
    {
        static string[] ProcessArray(int[] numbers)
        {
            //create a string array to store result
            string[] result = new string[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    result[i] = $"number[i] is Even";
                }
                else
                {
                    result[i] = $"number[i] is Odd";
                }
            }
            return result;

        }

        static void Main()
        {
            int[] numbers = { 1, 45, 64, 37, 48, 59 };
            string[] output = ProcessArray(numbers);
            Console.WriteLine(output);
            foreach(string result in output)
            {
                Console.WriteLine(result);
            }

        }
    }
}