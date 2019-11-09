namespace Telex.WinForm.Forms
{
    partial class LoginForm
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
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.mobileLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(102, 82);
            this.mobileTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(152, 20);
            this.mobileTextBox.TabIndex = 0;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(102, 115);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(152, 20);
            this.codeTextBox.TabIndex = 1;
            // 
            // mobileLabel
            // 
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.Location = new System.Drawing.Point(45, 84);
            this.mobileLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(45, 15);
            this.mobileLabel.TabIndex = 2;
            this.mobileLabel.Text = "Mobile";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(51, 119);
            this.codeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(36, 15);
            this.codeLabel.TabIndex = 3;
            this.codeLabel.Text = "Code";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(115, 175);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(97, 31);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 307);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.mobileTextBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label mobileLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.Button loginButton;
    }
}

