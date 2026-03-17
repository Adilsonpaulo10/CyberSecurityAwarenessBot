using System;
using System.Runtime.CompilerServices;

namespace CyberSecurityAwarenessBot
{
    class ChatBot
    {
        public static void StartChat()
        {
            int questionCount = 0; // the number of question will be stored 

            while (true)
            {
                ShowMenu(); // ShowMenu will be called where...

                Console.ForegroundColor = ConsoleColor.Green; 
                Console.Write("\nSelect an option: "); 
                Console.ResetColor(); 

                string choice = Console.ReadLine() ?? ""; // choice will store the values from the prompt

                Console.WriteLine(); // This creates an empty line

                switch (choice) // We then initialize a switch 
                {
                    case "1": // 1st case explains about "passwords safety" as defined below
                        Console.WriteLine("Bot: Use strong passwords with letters, numbers, and symbols.");
                        Console.WriteLine("Bot: Avoid using personal information.");
                        questionCount++;
                        break;

                    case "2": // 2nd case "Phishing"
                        Console.WriteLine("Bot: Phishing is when attackers trick you into revealing personal information.");
                        Console.WriteLine("Bot: Always check email senders and suspicious links.");
                        questionCount++;
                        break;

                    case "3": //3rd case "Safe Browsing"
                        Console.WriteLine("Bot: Always browse secure websites using HTTPS.");
                        Console.WriteLine("Bot: Avoid downloading files from unknown sources.");
                        questionCount++;
                        break;

                    case "4": //4th case "Malware"
                        Console.WriteLine("Bot: Malware is malicious software designed to harm your computer.");
                        Console.WriteLine("Bot: Use antivirus software and keep systems updated.");
                        questionCount++;
                        break;

                    case "5": //5th case "VPN"
                        Console.WriteLine("Bot: A VPN encrypts your internet connection and protects your privacy.");
                        questionCount++;
                        break;

                    case "6": //6th case "Ransomeware"
                        Console.WriteLine("Bot: Ransomware locks your files and demands payment to restore access.");
                        Console.WriteLine("Bot: Always backup important files.");
                        questionCount++;
                        break;

                    case "7": //7th case "Public WiFi Safety"
                        Console.WriteLine("Bot: Public WiFi can be unsafe.");
                        Console.WriteLine("Bot: Avoid logging into sensitive accounts without a VPN.");
                        questionCount++;
                        break;

                    case "8": //8th case "Show Security Tip"
                        ConsoleUI.ShowRandomTip();
                        questionCount++;
                        break;

                    case "0": // And if the input was 0 the program would "Exit"
                        Console.WriteLine("\nBot: Thank you for using the Cybersecurity Awareness Bot.");
                        Console.WriteLine($"Bot: You asked {questionCount} questions today.");
                        Console.WriteLine("Bot: Stay safe online!");
                        return;

                    default: // if a user enters a value not defined this would display
                        Console.WriteLine("Bot: Invalid option. Please choose a number from the menu.");
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\n====== CYBERSECURITY MENU ======");
            Console.WriteLine("1 - Password Safety");
            Console.WriteLine("2 - Phishing");
            Console.WriteLine("3 - Safe Browsing");
            Console.WriteLine("4 - Malware");
            Console.WriteLine("5 - VPN");
            Console.WriteLine("6 - Ransomware");
            Console.WriteLine("7 - Public WiFi Safety");
            Console.WriteLine("8 - Show Security Tip");
            Console.WriteLine("0 - Exit");

            Console.ResetColor();
        }
    }
}