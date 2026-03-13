using System;
using System.Media;
using System.Runtime.InteropServices;

namespace CyberSecurityAwarenessBot
{
    class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                try
                {
                    SoundPlayer player = new SoundPlayer(@"C:\Users\Student\Documents\CyberSecurityChatbot\CyberSecurityAwarenessBot\CyberSecurityAwarenessBot\greeting.wav");
                    player.PlaySync();
                }
                catch
                {
                    Console.WriteLine("Voice greeting could not be played.");
                }
            }
        }
    }
}



                   