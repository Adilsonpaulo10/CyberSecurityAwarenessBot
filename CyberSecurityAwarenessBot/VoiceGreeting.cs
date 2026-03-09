using System;
using System.Media;

namespace CyberSecurityAwarenessBot
{
    class VoiceGreeting
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Voice greeting file not found.");
            }
        }
    }
}