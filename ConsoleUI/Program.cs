using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a list of names, seperate each one with a comma: ");
            string namesList = Console.ReadLine();
            
            string[] words = namesList.Split(",");

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Hello { words[i] }");
            }

            Console.ReadLine();

        }
    }
}
