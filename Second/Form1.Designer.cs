
namespace Second
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.decipherOutput = new System.Windows.Forms.Label();
            this.cipherOutput = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.ModeEcbButton = new System.Windows.Forms.RadioButton();
            this.modeCbcButton = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.moveToInput = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(30, 52);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(100, 23);
            this.textInput.TabIndex = 0;
            this.textInput.TextChanged += new System.EventHandler(this.g);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key";
            // 
            // keyInput
            // 
            this.keyInput.Location = new System.Drawing.Point(30, 106);
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(100, 23);
            this.keyInput.TabIndex = 2;
            this.keyInput.TextChanged += new System.EventHandler(this.InputKeyTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deciphered text:";
            // 
            // decipherOutput
            // 
            this.decipherOutput.AutoSize = true;
            this.decipherOutput.Location = new System.Drawing.Point(446, 109);
            this.decipherOutput.Name = "decipherOutput";
            this.decipherOutput.Size = new System.Drawing.Size(27, 15);
            this.decipherOutput.TabIndex = 5;
            this.decipherOutput.Text = "text";
            // 
            // cipherOutput
            // 
            this.cipherOutput.AutoSize = true;
            this.cipherOutput.Location = new System.Drawing.Point(446, 144);
            this.cipherOutput.Name = "cipherOutput";
            this.cipherOutput.Size = new System.Drawing.Size(27, 15);
            this.cipherOutput.TabIndex = 7;
            this.cipherOutput.Text = "text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ciphered text:";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(30, 168);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 8;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.EncryptClick);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(111, 168);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 9;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.DecryptClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(192, 168);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Cipher";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveClick);
            // 
            // ModeEcbButton
            // 
            this.ModeEcbButton.AutoSize = true;
            this.ModeEcbButton.Checked = true;
            this.ModeEcbButton.Location = new System.Drawing.Point(30, 197);
            this.ModeEcbButton.Name = "ModeEcbButton";
            this.ModeEcbButton.Size = new System.Drawing.Size(46, 19);
            this.ModeEcbButton.TabIndex = 11;
            this.ModeEcbButton.TabStop = true;
            this.ModeEcbButton.Text = "ECB";
            this.ModeEcbButton.UseVisualStyleBackColor = true;
            // 
            // modeCbcButton
            // 
            this.modeCbcButton.AutoSize = true;
            this.modeCbcButton.Location = new System.Drawing.Point(82, 197);
            this.modeCbcButton.Name = "modeCbcButton";
            this.modeCbcButton.Size = new System.Drawing.Size(48, 19);
            this.modeCbcButton.TabIndex = 13;
            this.modeCbcButton.Text = "CBC";
            this.modeCbcButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(136, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "From File";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.LoadFromFileClick);
            // 
            // moveToInput
            // 
            this.moveToInput.Location = new System.Drawing.Point(347, 162);
            this.moveToInput.Name = "moveToInput";
            this.moveToInput.Size = new System.Drawing.Size(93, 23);
            this.moveToInput.TabIndex = 15;
            this.moveToInput.Text = "Move To Input";
            this.moveToInput.UseVisualStyleBackColor = true;
            this.moveToInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 223);
            this.Controls.Add(this.moveToInput);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.modeCbcButton);
            this.Controls.Add(this.ModeEcbButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.cipherOutput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.decipherOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label decipherOutput;
        private System.Windows.Forms.Label cipherOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton modeCbcButton;
        private System.Windows.Forms.RadioButton ModeEcbButton;
        private System.Windows.Forms.Button moveToInput;
    }
}

