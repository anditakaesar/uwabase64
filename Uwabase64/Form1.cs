namespace Uwabase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static async Task<string> EncodeText(string txt)
        {
            return await Task.Run(() => Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(txt)));
        }

        private static async Task<string> DecodeText(string base64txt)
        {
            return await Task.Run(() => System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(base64txt)));
        }

        private async void decodeBtn_Click(object sender, EventArgs e)
        {
            // take encoded text
            string encTxt = encodedTextBox.Text;
            // encode into base64
            if (!string.IsNullOrEmpty(encTxt))
            {
                string decTxt = await DecodeText(encTxt);
                decodedTextBox.Text = decTxt;
                SetStatusText("string decoded...");
            }
        }

        private async void encodeBtn_Click(object sender, EventArgs e)
        {
            string decTxt = decodedTextBox.Text;
            if (!string.IsNullOrEmpty(decTxt))
            {
                string encTxt = await EncodeText(decTxt);
                encodedTextBox.Text = encTxt;
                SetStatusText("string encoded...");
            }
        }

        private void SetStatusText(string message)
        {
            statusLabel1.Text = message;
        }
    }
}