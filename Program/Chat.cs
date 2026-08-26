using System;

namespace Program
{
    internal class Chat
    {
        public void StartChat()
        {
            Console.WriteLine("What is your name?");

            string user = Console.ReadLine();

            Console.WriteLine("Hello, " + user + ".You can ask me questions about basic cybersecurity awareness and online safety tips.");


            Console.WriteLine("Please enter a question.");
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Please enter a question.");
                return;
            }

            userInput = userInput.ToLower();

            if (userInput.Contains("hello") || userInput.Contains("hi"))
            {
                Console.WriteLine("Hello! How can I assist you today?");
            }
            else if (userInput.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to provide basic cybersecurity awareness and online safety tips.");
            }
            else if (userInput.Contains("password"))
            {
                Console.WriteLine("Use strong passwords and avoid using the same password for multiple accounts.");
            }
            else if (userInput.Contains("phishing"))
            {
                Console.WriteLine("Phishing is when someone tries to trick you into giving away personal information. Be careful with suspicious emails and links.");
            }
            else if (userInput.Contains("safe browsing") || userInput.Contains("browsing"))
            {
                Console.WriteLine("For safe browsing, avoid suspicious websites, check website addresses carefully, and do not download unknown files.");
            }
            else if (userInput.Contains("security"))
            {
                Console.WriteLine("Cybersecurity helps protect your devices, accounts and personal information from online threats.");
            }
            else if (userInput.Contains("what can i ask"))
            {
                Console.WriteLine("You can ask me about passwords, phishing, safe browsing and basic cybersecurity.");
            }
            else
            {
                Console.WriteLine("I'm not sure how to answer that. Try asking about passwords, phishing or safe browsing.");
            }
        }
    }
}