using System;

namespace CyberSecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.ShowLoading();

            VoiceGreeting.PlayGreeting();

            ConsoleUI.DisplayLogo();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter your name: ");
            Console.ResetColor();

            string userName = Console.ReadLine() ?? "";

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.WriteLine("Please enter a valid name:");
                userName = Console.ReadLine() ?? "";
            }

            Console.Clear();
            ConsoleUI.DisplayLogo();

            ConsoleUI.TypeText($"Hello {userName}! Welcome to the Cybersecurity Awareness Bot.");
            ConsoleUI.TypeText("Type 'help' to see what you can ask.\n");

            ConsoleUI.ShowRandomTip();

            ChatBot.StartChat();
        }
    }
}