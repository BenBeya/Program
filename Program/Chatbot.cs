using System;

namespace Program
{
    class Chatbot
    {
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================");
            Console.WriteLine("   CYBERSECURITY AWARENESS BOT");
            Console.WriteLine("==============================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User";
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome, " + name + "!");
            Console.WriteLine("I am here to help you with cybersecurity.");
            Console.WriteLine("You can ask me about passwords, phishing, and safe browsing.");
            Console.ResetColor();

            Console.WriteLine();

            Response response = new Response();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(name + ": ");
                string question = Console.ReadLine();
                Console.ResetColor();

                if (question.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye, " + name + "!");
                    break;
                }

                response.GetResponse(question);
            }
        }
    }
}