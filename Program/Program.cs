using System;
using System.Media;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display logo
            Logo logo = new Logo();
            logo.DisplayLogo();

            // Play greeting
            SoundPlayer player = new SoundPlayer(
                "C:\\Users\\Student\\source\\repos\\Program\\Program\\voice\\ai chatbox.wav"
            );

            player.PlaySync();

            // Start chatbot
            Class2 chatbot = new Class2();
            chatbot.StartChat();
        }
    }
}