using System;
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    class ConsoleUI
    {
        public static void DisplayLogo() // the logo below will then display
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("================================================");
            Console.WriteLine("   _____      _                _____            ");
            Console.WriteLine("  / ____|    | |              |  __ \\           ");
            Console.WriteLine(" | |     __ _| |__   ___ _ __ | |__) |___  ___  ");
            Console.WriteLine(" | |    / _` | '_ \\ / _ \\ '_ \\|  _  // _ \\/ __| ");
            Console.WriteLine(" | |___| (_| | |_) |  __/ | | | | \\ \\  __/\\__ \\ ");
            Console.WriteLine("  \\_____\\__,_|_.__/ \\___|_| |_|_|  \\_\\___||___/ ");
            Console.WriteLine("        CYBERSECURITY AWARENESS BOT 🔒         ");
            Console.WriteLine("================================================");

            Console.ResetColor(); 
        }

        public static void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c); //  is an animation where for every character in a sentence is delayed by 20 milliseconds before it displays
                Thread.Sleep(20);
            }
            Console.WriteLine();
        }

        public static void ShowLoading()
        {
            Console.Write("Starting chatbot"); // This message will show

            for (int i = 0; i < 3; i++) // AS long as i is smaller then 3
            {
                Thread.Sleep(500); 
                Console.Write("."); // this dots will display 1 by 1 after 500 milliseconds
            }

            Console.WriteLine("\n");
        }

        public static void ShowRandomTip() 
        {
            string[] tips = // 1 of the random tips below will display
            {
                "Tip: Never reuse passwords across multiple websites.",
                "Tip: Enable two-factor authentication whenever possible.",
                "Tip: Always check email senders before clicking links.",
                "Tip: Keep your operating system updated.",
                "Tip: Avoid entering sensitive information on public WiFi."
            };

            Random rand = new Random();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(tips[rand.Next(tips.Length)]);
            Console.ResetColor();
        }
    }
}