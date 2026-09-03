using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace BankSampah
{
    public static class SoundHelper
    {
        public static void PlayLoginSound()
        {
            PlaySound("Assets/Audio/login_success.wav");
        }

        public static void PlaySaveSound()
        {
            PlaySound("Assets/Audio/save_success.wav");
        }

        public static void PlayAlertSound()
        {
            PlaySound("Assets/Audio/alert.wav");
        }

        private static void PlaySound(string relativePath)
        {
            try
            {
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
                if (!File.Exists(fullPath))
                {
                    // Fallback to project root directory if running from bin/Debug
                    fullPath = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, relativePath);
                }

                if (File.Exists(fullPath))
                {
                    using (SoundPlayer player = new SoundPlayer(fullPath))
                    {
                        player.Play();
                    }
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                }
            }
            catch
            {
                // Fallback system beep if sound file is unreadable
                SystemSounds.Beep.Play();
            }
        }
    }
}
