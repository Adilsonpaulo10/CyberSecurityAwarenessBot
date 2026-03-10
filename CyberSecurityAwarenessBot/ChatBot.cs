using System;

namespace CyberSecurityAwarenessBot
{
    class ChatBot
    {
        public static void StartChat()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine() ?? "";
                input = input.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter a valid question.");
                    continue;
                }

                input = input.ToLower();

                if (input == "exit")
                {
                    Console.WriteLine("\nBot: Thank you for using the Cybersecurity Awareness Bot.");
                    Console.WriteLine("Bot: Stay safe online! Goodbye!");
                    break;
                }

                Respond(input);
            }
        }

        static void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Bot: ");
            Console.ResetColor();

            if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm functioning perfectly and ready to help you stay safe online!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to educate users about cybersecurity and safe internet practices.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Use strong passwords with uppercase, lowercase, numbers, and symbols.");
                Console.WriteLine("Avoid using personal information in your passwords.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Phishing is when attackers trick you into revealing sensitive information through fake emails or websites.");
                Console.WriteLine("Always verify links and sender email addresses.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Use secure websites (https), avoid suspicious downloads, and keep your browser updated.");
            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("You can ask about:");
                Console.WriteLine("- Password safety");
                Console.WriteLine("- Phishing");
                Console.WriteLine("- Safe browsing");
                Console.WriteLine("- My purpose");
            }
            else
            {
                Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
            }
        }
    }
}
//Trigger CI workflow