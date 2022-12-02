namespace WinFormsApp
{
    partial class AuthorizationWindow
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
            this.textBox_AuthorizationWindow_Login_Input = new System.Windows.Forms.TextBox();
            this.textBox_AuthorizationWindow_Password_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_AuthorizationWindow_Login_Input
            // 
            this.textBox_AuthorizationWindow_Login_Input.Location = new System.Drawing.Point(183, 58);
            this.textBox_AuthorizationWindow_Login_Input.Name = "textBox_AuthorizationWindow_Login_Input";
            this.textBox_AuthorizationWindow_Login_Input.Size = new System.Drawing.Size(160, 27);
            this.textBox_AuthorizationWindow_Login_Input.TabIndex = 0;
            // 
            // textBox_AuthorizationWindow_Password_Input
            // 
            this.textBox_AuthorizationWindow_Password_Input.Location = new System.Drawing.Point(183, 145);
            this.textBox_AuthorizationWindow_Password_Input.Name = "textBox_AuthorizationWindow_Password_Input";
            this.textBox_AuthorizationWindow_Password_Input.Size = new System.Drawing.Size(160, 27);
            this.textBox_AuthorizationWindow_Password_Input.TabIndex = 1;
            // 
            // AuthorizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 313);
            this.Controls.Add(this.textBox_AuthorizationWindow_Password_Input);
            this.Controls.Add(this.textBox_AuthorizationWindow_Login_Input);
            this.Name = "AuthorizationWindow";
            this.Text = "AuthorizationWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_AuthorizationWindow_Login_Input;
        private TextBox textBox_AuthorizationWindow_Password_Input;
    }
}