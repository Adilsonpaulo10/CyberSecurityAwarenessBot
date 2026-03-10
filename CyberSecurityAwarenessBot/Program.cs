using System;

namespace CyberSecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.ShowLoading();

            // Play voice greeting
            VoiceGreeting.PlayGreeting();

            // Show ASCII logo
            ConsoleUI.DisplayLogo();

            // Ask for user name
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nEnter your name: ");
            Console.ResetColor();

            string userName = Console.ReadLine() ?? "";

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Name cannot be empty. Please enter your name:");
                userName = Console.ReadLine() ?? "";
            }

            Console.Clear();
            ConsoleUI.DisplayLogo();

            ConsoleUI.TypeText($"\nHello {userName}! Welcome to the Cybersecurity Awareness Bot.");
            ConsoleUI.TypeText("I can help you learn about staying safe online.\n");

            ChatBot.StartChat();
        }
    }
}
