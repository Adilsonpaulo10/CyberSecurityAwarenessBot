using System;

namespace CyberSecurityAwarenessBot
{
    class ChatBot
    {
        public static void StartChat()
        {
            int questionCount = 0;

            while (true)
            {
                ShowMenu();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nSelect an option: ");
                Console.ResetColor();

                string choice = Console.ReadLine() ?? "";

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Bot: Use strong passwords with letters, numbers, and symbols.");
                        Console.WriteLine("Bot: Avoid using personal information.");
                        questionCount++;
                        break;

                    case "2":
                        Console.WriteLine("Bot: Phishing is when attackers trick you into revealing personal information.");
                        Console.WriteLine("Bot: Always check email senders and suspicious links.");
                        questionCount++;
                        break;

                    case "3":
                        Console.WriteLine("Bot: Always browse secure websites using HTTPS.");
                        Console.WriteLine("Bot: Avoid downloading files from unknown sources.");
                        questionCount++;
                        break;

                    case "4":
                        Console.WriteLine("Bot: Malware is malicious software designed to harm your computer.");
                        Console.WriteLine("Bot: Use antivirus software and keep systems updated.");
                        questionCount++;
                        break;

                    case "5":
                        Console.WriteLine("Bot: A VPN encrypts your internet connection and protects your privacy.");
                        questionCount++;
                        break;

                    case "6":
                        Console.WriteLine("Bot: Ransomware locks your files and demands payment to restore access.");
                        Console.WriteLine("Bot: Always backup important files.");
                        questionCount++;
                        break;

                    case "7":
                        Console.WriteLine("Bot: Public WiFi can be unsafe.");
                        Console.WriteLine("Bot: Avoid logging into sensitive accounts without a VPN.");
                        questionCount++;
                        break;

                    case "8":
                        ConsoleUI.ShowRandomTip();
                        questionCount++;
                        break;

                    case "0":
                        Console.WriteLine("\nBot: Thank you for using the Cybersecurity Awareness Bot.");
                        Console.WriteLine($"Bot: You asked {questionCount} questions today.");
                        Console.WriteLine("Bot: Stay safe online!");
                        return;

                    default:
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