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
            this.textBox_AuthorizationWindow_HeadLogin_Input = new System.Windows.Forms.TextBox();
            this.textBox_AuthorizationWindow_HeadPassword_Input = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_AuthorizationWindow_HeadLogin = new System.Windows.Forms.Label();
            this.label_AuthorizationWindow_HeadPassword = new System.Windows.Forms.Label();
            this.button_AuthorizationWindow_HeadAuthorize = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_AuthorizationWindow_HeadLogin_Input
            // 
            this.textBox_AuthorizationWindow_HeadLogin_Input.Location = new System.Drawing.Point(156, 39);
            this.textBox_AuthorizationWindow_HeadLogin_Input.Name = "textBox_AuthorizationWindow_HeadLogin_Input";
            this.textBox_AuthorizationWindow_HeadLogin_Input.Size = new System.Drawing.Size(160, 27);
            this.textBox_AuthorizationWindow_HeadLogin_Input.TabIndex = 0;
            // 
            // textBox_AuthorizationWindow_HeadPassword_Input
            // 
            this.textBox_AuthorizationWindow_HeadPassword_Input.Location = new System.Drawing.Point(156, 85);
            this.textBox_AuthorizationWindow_HeadPassword_Input.Name = "textBox_AuthorizationWindow_HeadPassword_Input";
            this.textBox_AuthorizationWindow_HeadPassword_Input.Size = new System.Drawing.Size(160, 27);
            this.textBox_AuthorizationWindow_HeadPassword_Input.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 289);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.button_AuthorizationWindow_HeadAuthorize);
            this.tabPage1.Controls.Add(this.label_AuthorizationWindow_HeadPassword);
            this.tabPage1.Controls.Add(this.label_AuthorizationWindow_HeadLogin);
            this.tabPage1.Controls.Add(this.textBox_AuthorizationWindow_HeadLogin_Input);
            this.tabPage1.Controls.Add(this.textBox_AuthorizationWindow_HeadPassword_Input);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 92);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label_AuthorizationWindow_HeadLogin
            // 
            this.label_AuthorizationWindow_HeadLogin.AutoSize = true;
            this.label_AuthorizationWindow_HeadLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AuthorizationWindow_HeadLogin.Location = new System.Drawing.Point(87, 39);
            this.label_AuthorizationWindow_HeadLogin.Name = "label_AuthorizationWindow_HeadLogin";
            this.label_AuthorizationWindow_HeadLogin.Size = new System.Drawing.Size(63, 23);
            this.label_AuthorizationWindow_HeadLogin.TabIndex = 2;
            this.label_AuthorizationWindow_HeadLogin.Text = "Логин:";
            // 
            // label_AuthorizationWindow_HeadPassword
            // 
            this.label_AuthorizationWindow_HeadPassword.AutoSize = true;
            this.label_AuthorizationWindow_HeadPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AuthorizationWindow_HeadPassword.Location = new System.Drawing.Point(75, 86);
            this.label_AuthorizationWindow_HeadPassword.Name = "label_AuthorizationWindow_HeadPassword";
            this.label_AuthorizationWindow_HeadPassword.Size = new System.Drawing.Size(75, 23);
            this.label_AuthorizationWindow_HeadPassword.TabIndex = 3;
            this.label_AuthorizationWindow_HeadPassword.Text = "Пароль:";
            // 
            // button_AuthorizationWindow_HeadAuthorize
            // 
            this.button_AuthorizationWindow_HeadAuthorize.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AuthorizationWindow_HeadAuthorize.Location = new System.Drawing.Point(173, 180);
            this.button_AuthorizationWindow_HeadAuthorize.Name = "button_AuthorizationWindow_HeadAuthorize";
            this.button_AuthorizationWindow_HeadAuthorize.Size = new System.Drawing.Size(94, 29);
            this.button_AuthorizationWindow_HeadAuthorize.TabIndex = 4;
            this.button_AuthorizationWindow_HeadAuthorize.Text = "Войти";
            this.button_AuthorizationWindow_HeadAuthorize.UseVisualStyleBackColor = true;
            // 
            // AuthorizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 313);
            this.Controls.Add(this.tabControl1);
            this.Name = "AuthorizationWindow";
            this.Text = "AuthorizationWindow";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox_AuthorizationWindow_HeadLogin_Input;
        private TextBox textBox_AuthorizationWindow_HeadPassword_Input;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button_AuthorizationWindow_HeadAuthorize;
        private Label label_AuthorizationWindow_HeadPassword;
        private Label label_AuthorizationWindow_HeadLogin;
    }
}