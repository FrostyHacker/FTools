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

namespace FTools
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public static string MD5(string text)
        {
            UTF8Encoding utf8Encoding = new UTF8Encoding();
            byte[] bytes = utf8Encoding.GetBytes(text);
            MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            byte[] array = md5CryptoServiceProvider.ComputeHash(bytes);
            string text2 = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                text2 += Convert.ToString(array[i], 16).PadLeft(2, '0');
            }
            return text2.PadLeft(32, '0');
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog1.Filter = "DLL (*.dll)|*.dll" + "|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog2.Filter = "DEX (*.dex)|*.dex" + "|All files (*.*)|*.*";
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {

                    keyTextBox.Text = MD5(File.ReadAllBytes(openFileDialog2.FileName).Length +File.ReadAllBytes(openFileDialog1.FileName).Length.ToString());
                }
            }
        }

        private void addByteButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "DLL (*.dll)|*.dll" + "|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Write))
                {
                
                    fileStream.Position = fileStream.Length;
                    byte[] array = new byte[String2Int(bytesTextBox.Text)];
                    fileStream.Write(array, 0, array.Length);
                    MessageBox.Show($"{String2Int(bytesTextBox.Text)}  Bytes Added");
                }
            }
        }

        private void originalDllTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] bytes = (string[])e.Data.GetData(DataFormats.FileDrop,false);
            foreach (string txt in bytes)
            originalDllTextBox.Text = File.ReadAllBytes(txt).Length.ToString();
        }

        private void originalDllTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void yourDllTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] bytes = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string txt in bytes)
                yourDllTextBox.Text = File.ReadAllBytes(txt).Length.ToString();
        }

        private void yourDllTextBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private static int String2Int(string text) => Convert.ToInt32(text);

        private void calculateButton_Click(object sender, EventArgs e)
        {
           bytesTextBox.Text = (String2Int(originalDllTextBox.Text) - String2Int(yourDllTextBox.Text)).ToString();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            using (XorForm xorForm = new XorForm())
            {
                xorForm.ShowDialog();
            }
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            using (AesForm aesForm = new AesForm())
            {
                aesForm.ShowDialog();
            }
        }
    }
}
