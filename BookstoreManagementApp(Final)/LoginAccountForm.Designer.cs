namespace BookstoreManagementApp_Final_
{
    partial class LoginAccountForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserNameTxb = new System.Windows.Forms.TextBox();
            this.PasswordTxb = new System.Windows.Forms.TextBox();
            this.forgotPassLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Login;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginButton.Location = new System.Drawing.Point(125, 357);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(82, 40);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNameTxb
            // 
            this.UserNameTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserNameTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.UserNameTxb.Location = new System.Drawing.Point(80, 212);
            this.UserNameTxb.Name = "UserNameTxb";
            this.UserNameTxb.Size = new System.Drawing.Size(218, 26);
            this.UserNameTxb.TabIndex = 1;
            this.UserNameTxb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserNameTxb_KeyDown);
            // 
            // PasswordTxb
            // 
            this.PasswordTxb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.PasswordTxb.Location = new System.Drawing.Point(80, 259);
            this.PasswordTxb.Name = "PasswordTxb";
            this.PasswordTxb.Size = new System.Drawing.Size(218, 26);
            this.PasswordTxb.TabIndex = 2;
            this.PasswordTxb.UseSystemPasswordChar = true;
            this.PasswordTxb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTxb_KeyDown);
            // 
            // forgotPassLabel
            // 
            this.forgotPassLabel.AutoSize = true;
            this.forgotPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.forgotPassLabel.ForeColor = System.Drawing.Color.Blue;
            this.forgotPassLabel.Location = new System.Drawing.Point(73, 303);
            this.forgotPassLabel.Name = "forgotPassLabel";
            this.forgotPassLabel.Size = new System.Drawing.Size(137, 20);
            this.forgotPassLabel.TabIndex = 4;
            this.forgotPassLabel.Text = "Forgot password?";
            this.forgotPassLabel.Visible = false;
            // 
            // LoginAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookstoreManagementApp_Final_.Properties.Resources.Login_eng;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 511);
            this.Controls.Add(this.forgotPassLabel);
            this.Controls.Add(this.PasswordTxb);
            this.Controls.Add(this.UserNameTxb);
            this.Controls.Add(this.LoginButton);
            this.Name = "LoginAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginAccountForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginAccountForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UserNameTxb;
        private System.Windows.Forms.TextBox PasswordTxb;
        private System.Windows.Forms.Label forgotPassLabel;
    }
}