using System.Media;

namespace Turnstile.Classes
{
    internal class Sound
    {
        internal Sound(string openOrClose)
        {
            using (SoundPlayer sd = new())
            {
                try
                {
                    sd.SoundLocation = Application.StartupPath + "\\Music\\" + openOrClose + ".wav";
                    sd.Play();
                }
                catch (Exception)
                {
                    new FileLogger("MUZİK ÇALMIYOR !!");
                    MailSend.MailSendPassword();
                }
            };
        }
    }
}