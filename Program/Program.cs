using System;
using System.Media;

namespace Program
{
    class Program
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
            Chatbot chatbot = new Chatbot();
            chatbot.Start();
        }
    }
}