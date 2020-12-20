namespace FTools
{
    partial class AesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formSkin1 = new FlatUI.FormSkin();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.RichTextBox();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.TextBox3 = new System.Windows.Forms.RichTextBox();
            this.TextBox2 = new System.Windows.Forms.RichTextBox();
            this.decrypt = new FlatUI.FlatButton();
            this.encrypt = new FlatUI.FlatButton();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.button1);
            this.formSkin1.Controls.Add(this.TextBox1);
            this.formSkin1.Controls.Add(this.TextBox);
            this.formSkin1.Controls.Add(this.TextBox3);
            this.formSkin1.Controls.Add(this.TextBox2);
            this.formSkin1.Controls.Add(this.decrypt);
            this.formSkin1.Controls.Add(this.encrypt);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.Black;
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(542, 325);
            this.formSkin1.TabIndex = 1;
            this.formSkin1.Text = "Aes";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Marlett", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.button1.Location = new System.Drawing.Point(505, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "r";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextBox1.ForeColor = System.Drawing.Color.White;
            this.TextBox1.Location = new System.Drawing.Point(311, 66);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(216, 96);
            this.TextBox1.TabIndex = 17;
            this.TextBox1.Text = "";
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextBox.ForeColor = System.Drawing.Color.White;
            this.TextBox.Location = new System.Drawing.Point(12, 66);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(216, 96);
            this.TextBox.TabIndex = 16;
            this.TextBox.Text = "";
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextBox3.ForeColor = System.Drawing.Color.White;
            this.TextBox3.Location = new System.Drawing.Point(311, 204);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(216, 96);
            this.TextBox3.TabIndex = 15;
            this.TextBox3.Text = "";
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextBox2.ForeColor = System.Drawing.Color.White;
            this.TextBox2.Location = new System.Drawing.Point(12, 204);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(216, 96);
            this.TextBox2.TabIndex = 13;
            this.TextBox2.Text = "";
            // 
            // decrypt
            // 
            this.decrypt.BackColor = System.Drawing.Color.Transparent;
            this.decrypt.BaseColor = System.Drawing.Color.Black;
            this.decrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decrypt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.decrypt.Location = new System.Drawing.Point(234, 234);
            this.decrypt.Name = "decrypt";
            this.decrypt.Rounded = false;
            this.decrypt.Size = new System.Drawing.Size(71, 29);
            this.decrypt.TabIndex = 11;
            this.decrypt.Text = "Decrypt";
            this.decrypt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encrypt
            // 
            this.encrypt.BackColor = System.Drawing.Color.Transparent;
            this.encrypt.BaseColor = System.Drawing.Color.Black;
            this.encrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encrypt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.encrypt.Location = new System.Drawing.Point(234, 99);
            this.encrypt.Name = "encrypt";
            this.encrypt.Rounded = false;
            this.encrypt.Size = new System.Drawing.Size(71, 29);
            this.encrypt.TabIndex = 7;
            this.encrypt.Text = "Encrypt";
            this.encrypt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // AesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 325);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AesForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox TextBox1;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.RichTextBox TextBox3;
        private System.Windows.Forms.RichTextBox TextBox2;
        private FlatUI.FlatButton decrypt;
        private FlatUI.FlatButton encrypt;
    }
}