using System.Data.SqlClient;
using Turnstile.Classes;

namespace Turnstile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private async void btnEntry_Click(object sender, EventArgs e)
        {
            try
            {
                lblWorkerName.Text = SQLDatabase.BarcodeControl(txtBarcode.Text);
                SQLDatabase.TransActionControl(txtBarcode.Text, true);
                new Sound("open");
                TurnstileImage.OpenClose(pctDoor, lblWorkerName, txtBarcode);
                lblWorkerName.Text += " HOÞGELDÝNÝZ";
            }
            catch (HandleException ex)
            {
                lblErrorMessage.Text = ex.Message;
                new Sound("close");
                await Task.Delay(2000);
                txtBarcode.Clear();
                txtBarcode.Focus();
                lblWorkerName.Text = null;
                lblErrorMessage.Text = null;
            }
        }
        private async void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                lblWorkerName.Text = SQLDatabase.BarcodeControl(txtBarcode.Text);
                SQLDatabase.TransActionControl(txtBarcode.Text, false);
                new Sound("open");
                TurnstileImage.OpenClose(pctDoor, lblWorkerName, txtBarcode);
                lblWorkerName.Text += " HOÞÇAKALIN";
            }
            catch (HandleException ex)
            {
                lblErrorMessage.Text = ex.Message;
                new Sound("close");
                await Task.Delay(2000);
                txtBarcode.Clear();
                txtBarcode.Focus();
                lblWorkerName.Text = null;
                lblErrorMessage.Text = null;
            }
        }
    }
}