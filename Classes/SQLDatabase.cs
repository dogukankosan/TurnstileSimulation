using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace Turnstile.Classes
{
    internal class SQLDatabase
    {
        internal static SqlConnection sqlConnection = new SqlConnection("Server=.;Database=HumanResources;User=sa;Pwd=Password1");
        internal static string BarcodeControl(string barcode)
        {
            object name = string.Empty;
            if (string.IsNullOrEmpty(barcode))
                throw new HandleException("KART NUMARASI BOŞ OLAMAZ !!");
            else if (barcode.Length < 36)
                throw new HandleException("KART NUMARASI 36 HANEDEN AZ OLAMAZ !!");
            else if (barcode.Length > 36)
                throw new HandleException("KART NUMARASI 36 HANEDEN FAZLA OLAMAZ !!");
            SqlCommand cmd = new("exec SP_CARD_CONTROL '" + barcode + "'", sqlConnection);
            try
            {
                sqlConnection.Open();
                name = cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                sqlConnection.Close();
                throw new HandleException("OKUTULAN KART SİSTEMDE BULUNAMADI !!");
            }
            sqlConnection.Close();
            return (string)name;
        }
        internal static void TransActionControl(string barcode, bool type)
        {
            object id = string.Empty;
            bool? IOType = false;
            SqlCommand cmd = new("exec SP_CARD_CONTROLRETURNID '" + barcode + "'", sqlConnection);
            try
            {
                sqlConnection.Open();
                id = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                new FileLogger(ex.Message);
                new HandleException("OKUTULAN KART SİSTEMDE BULUNAMADI !!");
            }
            SqlCommand cmd2 = new("EXEC PCD_WORKERTRANS '" + id + "'", sqlConnection);
            try
            {
                IOType = cmd2.ExecuteScalar() as bool?;
            }
            catch (Exception ex)
            {
                new FileLogger(ex.Message);
                sqlConnection.Close();
            }
            sqlConnection.Close();
            if (IOType == type)
            {
                if (type)
                    throw new HandleException("ŞUAN İÇERİDENİZ TEKRAR GİRİŞ YAPAMAZSINIZ !!");
                else
                    throw new HandleException("ŞUAN DIŞARIDASINIZ TEKRARDAN ÇIKAMAZSINIZ !!");
            }
            char value = type ? '1' : '0';
            sqlConnection.Open();
            SqlCommand cmd3 = new("EXEC PCD_WORKERTRANSINSERT '" + id + "','" + value + "'", sqlConnection);
            try
            {
                cmd3.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                new FileLogger(ex.Message);
                sqlConnection.Close();
            }
            sqlConnection.Close();
        }
    }
}