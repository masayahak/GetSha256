using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace GetSha256
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeHash_Click(object sender, EventArgs e)
        {
            var inStr = txtIn.Text;
            if (inStr.Length== 0 ) { return; }

            var Hased = SHA256(inStr);

            txtHashed.Text = Hased;

        }

        public static string SHA256(string sTextToHash)
        {
            byte[] TextToHash = Encoding.UTF8.GetBytes(sTextToHash);
            SHA256Managed sha256 = new SHA256Managed();
            byte[] bytes = sha256.ComputeHash(TextToHash);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2"));
            }
            return builder.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHashed.Text);
        }
    }
}
