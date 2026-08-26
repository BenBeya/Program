using System;
using System.Collections.Generic;
using System.Media;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Program  
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Logo logo = new Logo();
            logo.DisplayLogo();

            SoundPlayer player = new System.Media.SoundPlayer("C:\\Users\\Student\\source\\repos\\Program\\Program\\voice\\ai chatbox.wav");
            player.PlaySync(); 

            string userInput = Console.ReadLine();
            if(userInput.Contains("hello"))
            {
                Console.WriteLine("Hello! How can I assist you today?");
            }
            else if(userInput.Contains("Security"))
            {
                Console.WriteLine("Not sure yet ill tell u later.");
            }
            string.IsNullOrWhiteSpace(userInput);
        }
    }
}
