using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine($"I wish I knew how to add...");
                    break;
                case "english":
                    Console.WriteLine($"Reading is boring, but I suppose necessary.");
                    break;
                case "foreign language":
                    Console.WriteLine($"I envy those at restaurants that can order in correct tongue.");
                    break;
                case "science":
                    Console.WriteLine($"Science is fake news");
                    break;
                case "social studies":
                    Console.WriteLine($"How does one study social?!?!");
                    break;
                default:
                    Console.WriteLine($"I slept through that class.");
                    break;
            }
        }
    }
}
