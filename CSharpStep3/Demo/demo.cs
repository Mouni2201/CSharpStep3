using System;


namespace TextMessage
{
    

    class TextProcessor
    {
        
        public void SampleName(string text)
        {
            text = text?.Trim();
            //The ?. operator ensures we only call Trim() if text isn’t null. 
            Console.WriteLine($"Processed text: \"{text}\"");
        }

        public void SampleName(string text, int repeatingCount)
        {
            text = text?.Trim();
            for (int i = 1; i <= repeatingCount; i++)
                Console.WriteLine($"Repeat {i}: \"{text}\"");
        }

        
        
    }

    class Program
    {
        static void Main()
        {
            var Tprocess = new TextProcessor();

            // Overload #1
            Tprocess.SampleName("   Hello India   ");

            // Overload #2: cleans input before repeating
            Tprocess.SampleName("  Csharp  ", 3);

           
        }
    }
}
