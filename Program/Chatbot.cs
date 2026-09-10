using System;

namespace Program
{
    class Chatbot
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("       CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("======================================");

            Console.ResetColor();

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User";
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome, " + name + "!");
            Console.WriteLine("I am the Cybersecurity Awareness Bot.");
            Console.WriteLine("I can help you with passwords, phishing, and safe browsing.");
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Type your question below.");
            Console.WriteLine("Type 'exit' to close the chatbot.");
            Console.WriteLine();

            ResponseSystem responseSystem = new ResponseSystem();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(name + ": ");
                Console.ResetColor();

                string userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a question.");
                    Console.ResetColor();
                    continue;
                }

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine();
                    Console.WriteLine("Goodbye, " + name + "!");
                    break;
                }

                responseSystem.GetResponse(userInput);
                Console.WriteLine();
            }
        }
    }
}