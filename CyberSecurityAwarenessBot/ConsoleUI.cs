using System;
using System.Threading;

namespace CyberSecurityAwarenessBot
{
    class ConsoleUI
    {
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("================================================");
            Console.WriteLine("   _____      _                _____            ");
            Console.WriteLine("  / ____|    | |              |  __ \\           ");
            Console.WriteLine(" | |     __ _| |__   ___ _ __ | |__) |___  ___  ");
            Console.WriteLine(" | |    / _` | '_ \\ / _ \\ '_ \\|  _  // _ \\/ __| ");
            Console.WriteLine(" | |___| (_| | |_) |  __/ | | | | \\ \\  __/\\__ \\ ");
            Console.WriteLine("  \\_____\\__,_|_.__/ \\___|_| |_|_|  \\_\\___||___/ ");
            Console.WriteLine("                                                ");
            Console.WriteLine("        CYBERSECURITY AWARENESS BOT 🔒         ");
            Console.WriteLine("================================================");

            Console.ResetColor();
        }

        public static void TypeText(string text)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(20);
            }

            Console.WriteLine();
        }

        public static void ShowLoading()
        {
            Console.Write("Starting chatbot");

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }

            Console.WriteLine("\n");
        }
    }
}
