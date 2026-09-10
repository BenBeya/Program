using System;

namespace Program
{
    class ResponseSystem
    {
        public void GetResponse(string userInput)
        {
            string input = userInput.ToLower();

            if (input.Contains("how are you"))
            {
                Console.WriteLine("Bot: I am ready to help you stay safe online.");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("Bot: My purpose is to provide cybersecurity awareness and safety tips.");
            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("Bot: You can ask me about passwords, phishing, and safe browsing.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: Use a strong and unique password for each account. Avoid using easy-to-guess information.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing is when someone tries to trick you into giving away information. Be careful with suspicious emails, messages, and links.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Bot: For safe browsing, avoid suspicious websites, check website addresses carefully, and do not download unknown files.");
            }
            else
            {
                Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
            }
        }
    }
}