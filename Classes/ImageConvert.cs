namespace Turnstile.Classes
{
    internal class ImageConvert
    {
        internal static Image Base64ToImage(byte[] base64String)
        {
            MemoryStream ms = new(base64String);
            return Image.FromStream(ms);
        }
    }
}