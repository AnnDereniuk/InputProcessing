using System;

namespace InputProcessing
{
    class Program
    {
        static void Main()
        {
            int[] value = new int[5];
            string input;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Value № {0}", (i + 1));
                input = Console.ReadLine();
                value[i] = Convert.ToInt32(input);
            }
            Console.WriteLine("Your input is");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(value[i]);
            }
            Console.WriteLine("Your output is");
            for (int i = 0; i < 5; i++)
            {
                value[i] = value[i] * 10;
                Console.WriteLine(value[i]);
            }
            Console.ReadKey();

        }
    }
}
