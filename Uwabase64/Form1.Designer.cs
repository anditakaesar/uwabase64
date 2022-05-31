namespace Uwabase64
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.encodedTextBox = new System.Windows.Forms.TextBox();
            this.decodedTextBox = new System.Windows.Forms.TextBox();
            this.encodeBtn = new System.Windows.Forms.Button();
            this.decodeBtn = new System.Windows.Forms.Button();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // encodedTextBox
            // 
            this.encodedTextBox.Location = new System.Drawing.Point(335, 12);
            this.encodedTextBox.Multiline = true;
            this.encodedTextBox.Name = "encodedTextBox";
            this.encodedTextBox.PlaceholderText = "encoded text here";
            this.encodedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encodedTextBox.Size = new System.Drawing.Size(236, 274);
            this.encodedTextBox.TabIndex = 2;
            // 
            // decodedTextBox
            // 
            this.decodedTextBox.Location = new System.Drawing.Point(12, 12);
            this.decodedTextBox.Multiline = true;
            this.decodedTextBox.Name = "decodedTextBox";
            this.decodedTextBox.PlaceholderText = "decoded string here";
            this.decodedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decodedTextBox.Size = new System.Drawing.Size(236, 274);
            this.decodedTextBox.TabIndex = 0;
            // 
            // encodeBtn
            // 
            this.encodeBtn.Location = new System.Drawing.Point(254, 130);
            this.encodeBtn.Name = "encodeBtn";
            this.encodeBtn.Size = new System.Drawing.Size(75, 23);
            this.encodeBtn.TabIndex = 1;
            this.encodeBtn.Text = "Encode";
            this.encodeBtn.UseVisualStyleBackColor = true;
            this.encodeBtn.Click += new System.EventHandler(this.encodeBtn_Click);
            // 
            // decodeBtn
            // 
            this.decodeBtn.Location = new System.Drawing.Point(254, 159);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(75, 23);
            this.decodeBtn.TabIndex = 3;
            this.decodeBtn.Text = "Decode";
            this.decodeBtn.UseVisualStyleBackColor = true;
            this.decodeBtn.Click += new System.EventHandler(this.decodeBtn_Click);
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(48, 17);
            this.statusLabel1.Text = "Ready...";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 299);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "Ready...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.encodedTextBox);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.decodedTextBox);
            this.Controls.Add(this.encodeBtn);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Uwa-Base64";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox encodedTextBox;
        private TextBox decodedTextBox;
        private Button encodeBtn;
        private Button decodeBtn;
        private ToolStripStatusLabel statusLabel1;
        private StatusStrip statusStrip1;
    }
}