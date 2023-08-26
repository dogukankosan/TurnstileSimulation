using System.Data.SqlClient;

namespace Turnstile.Classes
{
    internal class TurnstileImage
    {
        internal static async void OpenClose(PictureBox pct, Label lbl, TextBox txt)
        {
            List<byte[]> list = new();
            SqlCommand cmd = new("EXEC PCD_IMAGELIST", SQLDatabase.sqlConnection);
            SQLDatabase.sqlConnection.Open();
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add((byte[])rd[0]);
                }
            }
            catch (Exception ex)
            {
                SQLDatabase.sqlConnection.Close();
                new FileLogger(ex.Message); 
                return;
            }
            SQLDatabase.sqlConnection.Close();
            pct.Image = ImageConvert.Base64ToImage(list[1]);
            await Task.Delay(3000);
            pct.Image = ImageConvert.Base64ToImage(list[0]);
            lbl.Text = null;
            txt.Text = null;
        }
    }
}