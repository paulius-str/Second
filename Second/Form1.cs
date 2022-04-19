using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Second
{
    public partial class Form1 : Form
    {
        private byte[] bytes;

        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptClick(object sender, EventArgs e)
        {
            CipherMode cipherMode = 0;

            if (modeCbcButton.Checked)
                cipherMode = CipherMode.CBC;
            else if (ModeEcbButton.Checked)
                cipherMode = CipherMode.ECB;
         
            bytes = Encryption.EncryptString(textInput.Text, cipherMode, keyInput.Text);
            var @string = Convert.ToBase64String(bytes);
            cipherOutput.Text = @string;
        }

        private void DecryptClick(object sender, EventArgs e)
        {
            CipherMode cipherMode = 0;

            if (modeCbcButton.Checked)
                cipherMode = CipherMode.CBC;
            else if (ModeEcbButton.Checked)
                cipherMode = CipherMode.ECB;

            bytes = Convert.FromBase64String(textInput.Text);
            decipherOutput.Text = Encryption.DecryptToString(bytes, cipherMode, keyInput.Text);
        }

        private void SaveClick(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text|*.txt";
            saveFileDialog1.Title = "Save text file";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();


                byte[] bytes = Encoding.UTF8.GetBytes(cipherOutput.Text);

                fs.Write(bytes, 0, bytes.Length);

                fs.Close();
            }
        }

        private void LoadFromFileClick(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            textInput.Text = fileContent;
        }

        private void InputTextChanged(object sender, EventArgs e)
        {
           
        }

        private void InputKeyTextChanged(object sender, EventArgs e)
        {
            
        }

        private void g(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textInput.Text = cipherOutput.Text;
        }
    }
}
