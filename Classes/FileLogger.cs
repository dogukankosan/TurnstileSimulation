namespace Turnstile.Classes
{
    internal class FileLogger
    {
        internal FileLogger(string message)
        {
            try
            {
                File.AppendAllText("filelog.txt", message + Environment.NewLine);
            }
            catch (Exception)
            {
   
            }
        }
    }
}