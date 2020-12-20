using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTools
{
    public partial class AesForm : Form
    {
        public AesForm()
        {
            InitializeComponent();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
                TextBox1.Text = AesEncryptor.Encrypt(TextBox.Text.ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            TextBox3.Text = AesEncryptor.DecryptString(TextBox2.Text.ToString());
        }
    }
}
