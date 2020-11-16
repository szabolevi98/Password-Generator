namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordGenerator));
            this.passWordTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.lengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numberCheckBox = new System.Windows.Forms.CheckBox();
            this.specialCheckBox = new System.Windows.Forms.CheckBox();
            this.capitalLetterCheckBox = new System.Windows.Forms.CheckBox();
            this.copyPassButton = new System.Windows.Forms.Button();
            this.md5TextBox = new System.Windows.Forms.TextBox();
            this.copyMD5Button = new System.Windows.Forms.Button();
            this.sha1TextBox = new System.Windows.Forms.TextBox();
            this.copySHA1Button = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.passPreTextBox = new System.Windows.Forms.TextBox();
            this.md5PreTextBox = new System.Windows.Forms.TextBox();
            this.sha1PreTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // passWordTextBox
            // 
            this.passWordTextBox.Location = new System.Drawing.Point(47, 11);
            this.passWordTextBox.Name = "passWordTextBox";
            this.passWordTextBox.Size = new System.Drawing.Size(174, 20);
            this.passWordTextBox.TabIndex = 0;
            this.passWordTextBox.Click += new System.EventHandler(this.PassWordTextBox_Click);
            this.passWordTextBox.TextChanged += new System.EventHandler(this.PassWordTextBox_TextChanged);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(151, 112);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(95, 22);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Generálás";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // lengthNumericUpDown
            // 
            this.lengthNumericUpDown.Location = new System.Drawing.Point(73, 113);
            this.lengthNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.lengthNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.lengthNumericUpDown.Name = "lengthNumericUpDown";
            this.lengthNumericUpDown.Size = new System.Drawing.Size(72, 20);
            this.lengthNumericUpDown.TabIndex = 6;
            this.lengthNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hosszúság";
            // 
            // numberCheckBox
            // 
            this.numberCheckBox.AutoSize = true;
            this.numberCheckBox.Location = new System.Drawing.Point(86, 90);
            this.numberCheckBox.Name = "numberCheckBox";
            this.numberCheckBox.Size = new System.Drawing.Size(64, 17);
            this.numberCheckBox.TabIndex = 4;
            this.numberCheckBox.Text = "Számok";
            this.numberCheckBox.UseVisualStyleBackColor = true;
            // 
            // specialCheckBox
            // 
            this.specialCheckBox.AutoSize = true;
            this.specialCheckBox.Location = new System.Drawing.Point(151, 90);
            this.specialCheckBox.Name = "specialCheckBox";
            this.specialCheckBox.Size = new System.Drawing.Size(96, 17);
            this.specialCheckBox.TabIndex = 5;
            this.specialCheckBox.Text = "Spec. karakter";
            this.specialCheckBox.UseVisualStyleBackColor = true;
            // 
            // capitalLetterCheckBox
            // 
            this.capitalLetterCheckBox.AutoSize = true;
            this.capitalLetterCheckBox.Location = new System.Drawing.Point(10, 90);
            this.capitalLetterCheckBox.Name = "capitalLetterCheckBox";
            this.capitalLetterCheckBox.Size = new System.Drawing.Size(72, 17);
            this.capitalLetterCheckBox.TabIndex = 3;
            this.capitalLetterCheckBox.Text = "Nagybetű";
            this.capitalLetterCheckBox.UseVisualStyleBackColor = true;
            // 
            // copyPassButton
            // 
            this.copyPassButton.BackgroundImage = global::PasswordGenerator.Properties.Resources.Copy;
            this.copyPassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyPassButton.Location = new System.Drawing.Point(219, 10);
            this.copyPassButton.Name = "copyPassButton";
            this.copyPassButton.Size = new System.Drawing.Size(27, 22);
            this.copyPassButton.TabIndex = 8;
            this.copyPassButton.UseVisualStyleBackColor = true;
            this.copyPassButton.Click += new System.EventHandler(this.CopyPassButton_Click);
            this.copyPassButton.MouseHover += new System.EventHandler(this.CopyButton_MouseHover);
            // 
            // md5TextBox
            // 
            this.md5TextBox.Location = new System.Drawing.Point(47, 37);
            this.md5TextBox.Name = "md5TextBox";
            this.md5TextBox.ReadOnly = true;
            this.md5TextBox.Size = new System.Drawing.Size(174, 20);
            this.md5TextBox.TabIndex = 1;
            // 
            // copyMD5Button
            // 
            this.copyMD5Button.BackgroundImage = global::PasswordGenerator.Properties.Resources.Copy;
            this.copyMD5Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyMD5Button.Location = new System.Drawing.Point(219, 36);
            this.copyMD5Button.Name = "copyMD5Button";
            this.copyMD5Button.Size = new System.Drawing.Size(27, 22);
            this.copyMD5Button.TabIndex = 9;
            this.copyMD5Button.UseVisualStyleBackColor = true;
            this.copyMD5Button.Click += new System.EventHandler(this.CopyMD5Button_Click);
            this.copyMD5Button.MouseHover += new System.EventHandler(this.CopyButton_MouseHover);
            // 
            // sha1TextBox
            // 
            this.sha1TextBox.Location = new System.Drawing.Point(47, 64);
            this.sha1TextBox.Name = "sha1TextBox";
            this.sha1TextBox.ReadOnly = true;
            this.sha1TextBox.Size = new System.Drawing.Size(174, 20);
            this.sha1TextBox.TabIndex = 2;
            // 
            // copySHA1Button
            // 
            this.copySHA1Button.BackgroundImage = global::PasswordGenerator.Properties.Resources.Copy;
            this.copySHA1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copySHA1Button.Location = new System.Drawing.Point(219, 63);
            this.copySHA1Button.Name = "copySHA1Button";
            this.copySHA1Button.Size = new System.Drawing.Size(27, 22);
            this.copySHA1Button.TabIndex = 10;
            this.copySHA1Button.UseVisualStyleBackColor = true;
            this.copySHA1Button.Click += new System.EventHandler(this.CopySHA1Button_Click);
            this.copySHA1Button.MouseHover += new System.EventHandler(this.CopyButton_MouseHover);
            // 
            // passPreTextBox
            // 
            this.passPreTextBox.Location = new System.Drawing.Point(10, 11);
            this.passPreTextBox.Name = "passPreTextBox";
            this.passPreTextBox.ReadOnly = true;
            this.passPreTextBox.Size = new System.Drawing.Size(38, 20);
            this.passPreTextBox.TabIndex = 11;
            this.passPreTextBox.Text = "Jelszó:";
            // 
            // md5PreTextBox
            // 
            this.md5PreTextBox.Location = new System.Drawing.Point(10, 37);
            this.md5PreTextBox.Name = "md5PreTextBox";
            this.md5PreTextBox.ReadOnly = true;
            this.md5PreTextBox.Size = new System.Drawing.Size(38, 20);
            this.md5PreTextBox.TabIndex = 12;
            this.md5PreTextBox.Text = "MD5:";
            // 
            // sha1PreTextBox
            // 
            this.sha1PreTextBox.Location = new System.Drawing.Point(10, 64);
            this.sha1PreTextBox.Name = "sha1PreTextBox";
            this.sha1PreTextBox.ReadOnly = true;
            this.sha1PreTextBox.Size = new System.Drawing.Size(38, 20);
            this.sha1PreTextBox.TabIndex = 13;
            this.sha1PreTextBox.Text = "SHA1:";
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 144);
            this.Controls.Add(this.sha1PreTextBox);
            this.Controls.Add(this.md5PreTextBox);
            this.Controls.Add(this.passPreTextBox);
            this.Controls.Add(this.sha1TextBox);
            this.Controls.Add(this.copySHA1Button);
            this.Controls.Add(this.md5TextBox);
            this.Controls.Add(this.copyMD5Button);
            this.Controls.Add(this.capitalLetterCheckBox);
            this.Controls.Add(this.specialCheckBox);
            this.Controls.Add(this.numberCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lengthNumericUpDown);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.passWordTextBox);
            this.Controls.Add(this.copyPassButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password & Hash Generator";
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passWordTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.NumericUpDown lengthNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox numberCheckBox;
        private System.Windows.Forms.CheckBox specialCheckBox;
        private System.Windows.Forms.CheckBox capitalLetterCheckBox;
        private System.Windows.Forms.Button copyPassButton;
        private System.Windows.Forms.TextBox md5TextBox;
        private System.Windows.Forms.Button copyMD5Button;
        private System.Windows.Forms.TextBox sha1TextBox;
        private System.Windows.Forms.Button copySHA1Button;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TextBox passPreTextBox;
        private System.Windows.Forms.TextBox md5PreTextBox;
        private System.Windows.Forms.TextBox sha1PreTextBox;
    }
}

