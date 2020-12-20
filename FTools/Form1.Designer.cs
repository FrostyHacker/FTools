namespace FTools
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formSkin1 = new FlatUI.FormSkin();
            this.flatButton2 = new FlatUI.FlatButton();
            this.flatButton1 = new FlatUI.FlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.calculateButton = new FlatUI.FlatButton();
            this.bytesTextBox = new FlatUI.FlatTextBox();
            this.flatTextBox6 = new FlatUI.FlatTextBox();
            this.flatTextBox5 = new FlatUI.FlatTextBox();
            this.yourDllTextBox = new FlatUI.FlatTextBox();
            this.originalDllTextBox = new FlatUI.FlatTextBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.addbytesButton = new FlatUI.FlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.keyTextBox = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.openButton1 = new FlatUI.FlatButton();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.formSkin1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int) (((byte) (60)))), ((int) (((byte) (70)))), ((int) (((byte) (73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (58)))), ((int) (((byte) (60)))));
            this.formSkin1.Controls.Add(this.flatButton2);
            this.formSkin1.Controls.Add(this.flatButton1);
            this.formSkin1.Controls.Add(this.panel2);
            this.formSkin1.Controls.Add(this.panel1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.Black;
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int) (((byte) (45)))), ((int) (((byte) (47)))), ((int) (((byte) (49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(670, 455);
            this.formSkin1.TabIndex = 1;
            this.formSkin1.Text = "Block Strike Black Screen Bypass";
            // 
            // flatButton2
            // 
            this.flatButton2.BackColor = System.Drawing.Color.Transparent;
            this.flatButton2.BaseColor = System.Drawing.Color.Black;
            this.flatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton2.Location = new System.Drawing.Point(551, 419);
            this.flatButton2.Name = "flatButton2";
            this.flatButton2.Rounded = false;
            this.flatButton2.Size = new System.Drawing.Size(107, 29);
            this.flatButton2.TabIndex = 12;
            this.flatButton2.Text = "Aes";
            this.flatButton2.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (243)))), ((int) (((byte) (243)))));
            this.flatButton2.Click += new System.EventHandler(this.flatButton2_Click);
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.Black;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(12, 419);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(107, 29);
            this.flatButton1.TabIndex = 11;
            this.flatButton1.Text = "Xor";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (243)))), ((int) (((byte) (243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.panel2.Controls.Add(this.calculateButton);
            this.panel2.Controls.Add(this.bytesTextBox);
            this.panel2.Controls.Add(this.flatTextBox6);
            this.panel2.Controls.Add(this.flatTextBox5);
            this.panel2.Controls.Add(this.yourDllTextBox);
            this.panel2.Controls.Add(this.originalDllTextBox);
            this.panel2.Controls.Add(this.flatLabel2);
            this.panel2.Controls.Add(this.addbytesButton);
            this.panel2.Location = new System.Drawing.Point(12, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(646, 191);
            this.panel2.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Transparent;
            this.calculateButton.BaseColor = System.Drawing.Color.Black;
            this.calculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.calculateButton.Location = new System.Drawing.Point(384, 143);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Rounded = false;
            this.calculateButton.Size = new System.Drawing.Size(107, 29);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (243)))), ((int) (((byte) (243)))));
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // bytesTextBox
            // 
            this.bytesTextBox.BackColor = System.Drawing.Color.Transparent;
            this.bytesTextBox.FocusOnHover = false;
            this.bytesTextBox.Location = new System.Drawing.Point(385, 108);
            this.bytesTextBox.MaxLength = 32767;
            this.bytesTextBox.Multiline = false;
            this.bytesTextBox.Name = "bytesTextBox";
            this.bytesTextBox.ReadOnly = false;
            this.bytesTextBox.Size = new System.Drawing.Size(106, 29);
            this.bytesTextBox.TabIndex = 9;
            this.bytesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bytesTextBox.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.bytesTextBox.UseSystemPasswordChar = false;
            // 
            // flatTextBox6
            // 
            this.flatTextBox6.AllowDrop = true;
            this.flatTextBox6.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox6.FocusOnHover = false;
            this.flatTextBox6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTextBox6.Location = new System.Drawing.Point(8, 143);
            this.flatTextBox6.MaxLength = 32767;
            this.flatTextBox6.Multiline = false;
            this.flatTextBox6.Name = "flatTextBox6";
            this.flatTextBox6.ReadOnly = true;
            this.flatTextBox6.Size = new System.Drawing.Size(112, 29);
            this.flatTextBox6.TabIndex = 8;
            this.flatTextBox6.Text = "Your dll:";
            this.flatTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox6.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.flatTextBox6.UseSystemPasswordChar = false;
            // 
            // flatTextBox5
            // 
            this.flatTextBox5.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox5.FocusOnHover = false;
            this.flatTextBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatTextBox5.Location = new System.Drawing.Point(8, 108);
            this.flatTextBox5.MaxLength = 32767;
            this.flatTextBox5.Multiline = false;
            this.flatTextBox5.Name = "flatTextBox5";
            this.flatTextBox5.ReadOnly = true;
            this.flatTextBox5.Size = new System.Drawing.Size(112, 29);
            this.flatTextBox5.TabIndex = 7;
            this.flatTextBox5.Text = "Original dll:";
            this.flatTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox5.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.flatTextBox5.UseSystemPasswordChar = false;
            // 
            // yourDllTextBox
            // 
            this.yourDllTextBox.AllowDrop = true;
            this.yourDllTextBox.BackColor = System.Drawing.Color.Transparent;
            this.yourDllTextBox.FocusOnHover = false;
            this.yourDllTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yourDllTextBox.Location = new System.Drawing.Point(117, 143);
            this.yourDllTextBox.MaxLength = 32767;
            this.yourDllTextBox.Multiline = false;
            this.yourDllTextBox.Name = "yourDllTextBox";
            this.yourDllTextBox.ReadOnly = true;
            this.yourDllTextBox.Size = new System.Drawing.Size(261, 29);
            this.yourDllTextBox.TabIndex = 5;
            this.yourDllTextBox.Text = "Drag and drop";
            this.yourDllTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.yourDllTextBox.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.yourDllTextBox.UseSystemPasswordChar = false;
            this.yourDllTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.yourDllTextBox_DragDrop);
            this.yourDllTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.yourDllTextBox_DragEnter);
            // 
            // originalDllTextBox
            // 
            this.originalDllTextBox.AllowDrop = true;
            this.originalDllTextBox.BackColor = System.Drawing.Color.Transparent;
            this.originalDllTextBox.FocusOnHover = false;
            this.originalDllTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.originalDllTextBox.Location = new System.Drawing.Point(117, 108);
            this.originalDllTextBox.MaxLength = 32767;
            this.originalDllTextBox.Multiline = false;
            this.originalDllTextBox.Name = "originalDllTextBox";
            this.originalDllTextBox.ReadOnly = true;
            this.originalDllTextBox.Size = new System.Drawing.Size(261, 29);
            this.originalDllTextBox.TabIndex = 3;
            this.originalDllTextBox.Text = "Drag and drop";
            this.originalDllTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.originalDllTextBox.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.originalDllTextBox.UseSystemPasswordChar = false;
            this.originalDllTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.originalDllTextBox_DragDrop);
            this.originalDllTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.originalDllTextBox_DragEnter);
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(114, 19);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(378, 47);
            this.flatLabel2.TabIndex = 4;
            this.flatLabel2.Text = "Bypass for All Version";
            this.flatLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addbytesButton
            // 
            this.addbytesButton.BackColor = System.Drawing.Color.Transparent;
            this.addbytesButton.BaseColor = System.Drawing.Color.Black;
            this.addbytesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbytesButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.addbytesButton.Location = new System.Drawing.Point(503, 108);
            this.addbytesButton.Name = "addbytesButton";
            this.addbytesButton.Rounded = false;
            this.addbytesButton.Size = new System.Drawing.Size(134, 64);
            this.addbytesButton.TabIndex = 2;
            this.addbytesButton.Text = "Add Byte";
            this.addbytesButton.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (243)))), ((int) (((byte) (243)))));
            this.addbytesButton.Click += new System.EventHandler(this.addByteButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.panel1.Controls.Add(this.keyTextBox);
            this.panel1.Controls.Add(this.flatLabel1);
            this.panel1.Controls.Add(this.openButton1);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 157);
            this.panel1.TabIndex = 5;
            // 
            // keyTextBox
            // 
            this.keyTextBox.BackColor = System.Drawing.Color.Transparent;
            this.keyTextBox.FocusOnHover = false;
            this.keyTextBox.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.keyTextBox.Location = new System.Drawing.Point(7, 86);
            this.keyTextBox.MaxLength = 32767;
            this.keyTextBox.Multiline = false;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = false;
            this.keyTextBox.Size = new System.Drawing.Size(490, 35);
            this.keyTextBox.TabIndex = 3;
            this.keyTextBox.Text = "Key";
            this.keyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.keyTextBox.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.keyTextBox.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(114, 23);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(383, 46);
            this.flatLabel1.TabIndex = 4;
            this.flatLabel1.Text = "Bypass for 3.0.0 - 5.0.0";
            this.flatLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // openButton1
            // 
            this.openButton1.BackColor = System.Drawing.Color.Transparent;
            this.openButton1.BaseColor = System.Drawing.Color.Black;
            this.openButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.openButton1.Location = new System.Drawing.Point(503, 86);
            this.openButton1.Name = "openButton1";
            this.openButton1.Rounded = false;
            this.openButton1.Size = new System.Drawing.Size(134, 35);
            this.openButton1.TabIndex = 2;
            this.openButton1.Text = "Open";
            this.openButton1.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (243)))), ((int) (((byte) (243)))));
            this.openButton1.Click += new System.EventHandler(this.openButton_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int) (((byte) (168)))), ((int) (((byte) (35)))), ((int) (((byte) (35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(640, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 1;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (243)))), ((int) (((byte) (243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int) (((byte) (45)))), ((int) (((byte) (47)))), ((int) (((byte) (49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(603, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (243)))), ((int) (((byte) (243)))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 455);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FlatUI.FormSkin formSkin1;
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatTextBox keyTextBox;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatButton openButton1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatMini flatMini1;
        private System.Windows.Forms.Panel panel2;
        private FlatUI.FlatTextBox flatTextBox6;
        private FlatUI.FlatTextBox flatTextBox5;
        private FlatUI.FlatTextBox yourDllTextBox;
        private FlatUI.FlatTextBox originalDllTextBox;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatButton addbytesButton;
        private FlatUI.FlatButton calculateButton;
        private FlatUI.FlatTextBox bytesTextBox;
        private FlatUI.FlatButton flatButton1;
        private FlatUI.FlatButton flatButton2;
    }
}

