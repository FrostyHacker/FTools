using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTools
{
    public partial class XorForm : Form
    {
        public static string key = "z0c8pwApJ";

        public XorForm()
        {
            InitializeComponent();
        }

        private void oldkeyButton_Click(object sender, EventArgs e)
        {
            keyTextBox.Text = "z0c8pwApJ";
            key = keyTextBox.Text;
        }

        private void newkeyButton_Click(object sender, EventArgs e)
        {
            keyTextBox.Text = "ToIb3aUNgiaI";
            key = keyTextBox.Text;
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Xor.XOR(TextBox.Text.ToString(), keyTextBox.Text, true);
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            TextBox3.Text = Xor.XOR(TextBox2.Text.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
