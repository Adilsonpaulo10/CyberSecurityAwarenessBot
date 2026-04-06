using System;
using System.Net.Security;

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

            while (string.IsNullOrWhiteSpace(userName)) // if the username is null or empty 
            {
                Console.WriteLine("Please enter a valid name:"); 
                userName = Console.ReadLine() ?? ""; 
            }

            Console.Clear(); // after the loop the program will clear every output or message
            ConsoleUI.DisplayLogo(); 
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"Today's date: {DateTime.Now:dd MMMM yyyy}");
            Console.WriteLine($"Current time: {DateTime.Now:HH:mm}");

            Console.ResetColor();

            ConsoleUI.TypeText($"Hello {userName}! Welcome to the Cybersecurity Awareness Bot."); // type text method will then be called, and then it will display a message
            ConsoleUI.TypeText("Insert a number to learn the terms below\n"); 

            ConsoleUI.ShowRandomTip(); // A random tip will display after this method is called

            ChatBot.StartChat(); // Then the program starts after this method is called
        }
    }
}