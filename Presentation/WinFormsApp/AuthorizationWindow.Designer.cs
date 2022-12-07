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
            this.tabPage_AutorizationWindow_Head = new System.Windows.Forms.TabPage();
            this.button_AuthorizationWindow_HeadRegister = new System.Windows.Forms.Button();
            this.button_AuthorizationWindow_HeadAuthorize = new System.Windows.Forms.Button();
            this.label_AuthorizationWindow_HeadPassword = new System.Windows.Forms.Label();
            this.label_AuthorizationWindow_HeadLogin = new System.Windows.Forms.Label();
            this.tabPage_AuthorizationWindow_Manager = new System.Windows.Forms.TabPage();
            this.button_AuthorizationWindow_ManagerAuthorize = new System.Windows.Forms.Button();
            this.label_AuthorizationWindow_ManagerPassword = new System.Windows.Forms.Label();
            this.label_AuthorizationWindow_ManagerLogin = new System.Windows.Forms.Label();
            this.textBox_AuthorizationWindow_ManagerLogin_Input = new System.Windows.Forms.TextBox();
            this.textBox_AuthorizationWindow_ManagerPassword_Input = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_AutorizationWindow_Head.SuspendLayout();
            this.tabPage_AuthorizationWindow_Manager.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_AuthorizationWindow_HeadLogin_Input
            // 
            this.textBox_AuthorizationWindow_HeadLogin_Input.Location = new System.Drawing.Point(135, 40);
            this.textBox_AuthorizationWindow_HeadLogin_Input.Name = "textBox_AuthorizationWindow_HeadLogin_Input";
            this.textBox_AuthorizationWindow_HeadLogin_Input.Size = new System.Drawing.Size(160, 30);
            this.textBox_AuthorizationWindow_HeadLogin_Input.TabIndex = 0;
            // 
            // textBox_AuthorizationWindow_HeadPassword_Input
            // 
            this.textBox_AuthorizationWindow_HeadPassword_Input.Location = new System.Drawing.Point(135, 85);
            this.textBox_AuthorizationWindow_HeadPassword_Input.Name = "textBox_AuthorizationWindow_HeadPassword_Input";
            this.textBox_AuthorizationWindow_HeadPassword_Input.Size = new System.Drawing.Size(160, 30);
            this.textBox_AuthorizationWindow_HeadPassword_Input.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_AutorizationWindow_Head);
            this.tabControl1.Controls.Add(this.tabPage_AuthorizationWindow_Manager);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(438, 289);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_AutorizationWindow_Head
            // 
            this.tabPage_AutorizationWindow_Head.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_AutorizationWindow_Head.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_AutorizationWindow_Head.Controls.Add(this.button_AuthorizationWindow_HeadRegister);
            this.tabPage_AutorizationWindow_Head.Controls.Add(this.button_AuthorizationWindow_HeadAuthorize);
            this.tabPage_AutorizationWindow_Head.Controls.Add(this.label_AuthorizationWindow_HeadPassword);
            this.tabPage_AutorizationWindow_Head.Controls.Add(this.label_AuthorizationWindow_HeadLogin);
            this.tabPage_AutorizationWindow_Head.Controls.Add(this.textBox_AuthorizationWindow_HeadLogin_Input);
            this.tabPage_AutorizationWindow_Head.Controls.Add(this.textBox_AuthorizationWindow_HeadPassword_Input);
            this.tabPage_AutorizationWindow_Head.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage_AutorizationWindow_Head.Location = new System.Drawing.Point(4, 29);
            this.tabPage_AutorizationWindow_Head.Name = "tabPage_AutorizationWindow_Head";
            this.tabPage_AutorizationWindow_Head.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AutorizationWindow_Head.Size = new System.Drawing.Size(430, 256);
            this.tabPage_AutorizationWindow_Head.TabIndex = 0;
            this.tabPage_AutorizationWindow_Head.Text = "Руководитель";
            // 
            // button_AuthorizationWindow_HeadRegister
            // 
            this.button_AuthorizationWindow_HeadRegister.AutoSize = true;
            this.button_AuthorizationWindow_HeadRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_AuthorizationWindow_HeadRegister.BackColor = System.Drawing.Color.White;
            this.button_AuthorizationWindow_HeadRegister.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_AuthorizationWindow_HeadRegister.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AuthorizationWindow_HeadRegister.Location = new System.Drawing.Point(115, 200);
            this.button_AuthorizationWindow_HeadRegister.Name = "button_AuthorizationWindow_HeadRegister";
            this.button_AuthorizationWindow_HeadRegister.Size = new System.Drawing.Size(184, 32);
            this.button_AuthorizationWindow_HeadRegister.TabIndex = 5;
            this.button_AuthorizationWindow_HeadRegister.Text = "Зарегистрироваться";
            this.button_AuthorizationWindow_HeadRegister.UseVisualStyleBackColor = false;
            // 
            // button_AuthorizationWindow_HeadAuthorize
            // 
            this.button_AuthorizationWindow_HeadAuthorize.BackColor = System.Drawing.Color.White;
            this.button_AuthorizationWindow_HeadAuthorize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_AuthorizationWindow_HeadAuthorize.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AuthorizationWindow_HeadAuthorize.Location = new System.Drawing.Point(115, 160);
            this.button_AuthorizationWindow_HeadAuthorize.Name = "button_AuthorizationWindow_HeadAuthorize";
            this.button_AuthorizationWindow_HeadAuthorize.Size = new System.Drawing.Size(200, 35);
            this.button_AuthorizationWindow_HeadAuthorize.TabIndex = 4;
            this.button_AuthorizationWindow_HeadAuthorize.Text = "Войти";
            this.button_AuthorizationWindow_HeadAuthorize.UseVisualStyleBackColor = false;
            // 
            // label_AuthorizationWindow_HeadPassword
            // 
            this.label_AuthorizationWindow_HeadPassword.AutoSize = true;
            this.label_AuthorizationWindow_HeadPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AuthorizationWindow_HeadPassword.Location = new System.Drawing.Point(57, 87);
            this.label_AuthorizationWindow_HeadPassword.Name = "label_AuthorizationWindow_HeadPassword";
            this.label_AuthorizationWindow_HeadPassword.Size = new System.Drawing.Size(75, 23);
            this.label_AuthorizationWindow_HeadPassword.TabIndex = 3;
            this.label_AuthorizationWindow_HeadPassword.Text = "Пароль:";
            // 
            // label_AuthorizationWindow_HeadLogin
            // 
            this.label_AuthorizationWindow_HeadLogin.AutoSize = true;
            this.label_AuthorizationWindow_HeadLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AuthorizationWindow_HeadLogin.Location = new System.Drawing.Point(69, 42);
            this.label_AuthorizationWindow_HeadLogin.Name = "label_AuthorizationWindow_HeadLogin";
            this.label_AuthorizationWindow_HeadLogin.Size = new System.Drawing.Size(63, 23);
            this.label_AuthorizationWindow_HeadLogin.TabIndex = 2;
            this.label_AuthorizationWindow_HeadLogin.Text = "Логин:";
            // 
            // tabPage_AuthorizationWindow_Manager
            // 
            this.tabPage_AuthorizationWindow_Manager.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_AuthorizationWindow_Manager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_AuthorizationWindow_Manager.Controls.Add(this.button_AuthorizationWindow_ManagerAuthorize);
            this.tabPage_AuthorizationWindow_Manager.Controls.Add(this.label_AuthorizationWindow_ManagerPassword);
            this.tabPage_AuthorizationWindow_Manager.Controls.Add(this.label_AuthorizationWindow_ManagerLogin);
            this.tabPage_AuthorizationWindow_Manager.Controls.Add(this.textBox_AuthorizationWindow_ManagerLogin_Input);
            this.tabPage_AuthorizationWindow_Manager.Controls.Add(this.textBox_AuthorizationWindow_ManagerPassword_Input);
            this.tabPage_AuthorizationWindow_Manager.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_AuthorizationWindow_Manager.Location = new System.Drawing.Point(4, 29);
            this.tabPage_AuthorizationWindow_Manager.Name = "tabPage_AuthorizationWindow_Manager";
            this.tabPage_AuthorizationWindow_Manager.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AuthorizationWindow_Manager.Size = new System.Drawing.Size(430, 256);
            this.tabPage_AuthorizationWindow_Manager.TabIndex = 1;
            this.tabPage_AuthorizationWindow_Manager.Text = "Менеджер";
            // 
            // button_AuthorizationWindow_ManagerAuthorize
            // 
            this.button_AuthorizationWindow_ManagerAuthorize.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AuthorizationWindow_ManagerAuthorize.Location = new System.Drawing.Point(115, 160);
            this.button_AuthorizationWindow_ManagerAuthorize.Name = "button_AuthorizationWindow_ManagerAuthorize";
            this.button_AuthorizationWindow_ManagerAuthorize.Size = new System.Drawing.Size(200, 35);
            this.button_AuthorizationWindow_ManagerAuthorize.TabIndex = 9;
            this.button_AuthorizationWindow_ManagerAuthorize.Text = "Войти";
            this.button_AuthorizationWindow_ManagerAuthorize.UseVisualStyleBackColor = true;
            // 
            // label_AuthorizationWindow_ManagerPassword
            // 
            this.label_AuthorizationWindow_ManagerPassword.AutoSize = true;
            this.label_AuthorizationWindow_ManagerPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AuthorizationWindow_ManagerPassword.Location = new System.Drawing.Point(57, 87);
            this.label_AuthorizationWindow_ManagerPassword.Name = "label_AuthorizationWindow_ManagerPassword";
            this.label_AuthorizationWindow_ManagerPassword.Size = new System.Drawing.Size(75, 23);
            this.label_AuthorizationWindow_ManagerPassword.TabIndex = 8;
            this.label_AuthorizationWindow_ManagerPassword.Text = "Пароль:";
            // 
            // label_AuthorizationWindow_ManagerLogin
            // 
            this.label_AuthorizationWindow_ManagerLogin.AutoSize = true;
            this.label_AuthorizationWindow_ManagerLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AuthorizationWindow_ManagerLogin.Location = new System.Drawing.Point(69, 42);
            this.label_AuthorizationWindow_ManagerLogin.Name = "label_AuthorizationWindow_ManagerLogin";
            this.label_AuthorizationWindow_ManagerLogin.Size = new System.Drawing.Size(63, 23);
            this.label_AuthorizationWindow_ManagerLogin.TabIndex = 7;
            this.label_AuthorizationWindow_ManagerLogin.Text = "Логин:";
            // 
            // textBox_AuthorizationWindow_ManagerLogin_Input
            // 
            this.textBox_AuthorizationWindow_ManagerLogin_Input.Location = new System.Drawing.Point(135, 40);
            this.textBox_AuthorizationWindow_ManagerLogin_Input.Name = "textBox_AuthorizationWindow_ManagerLogin_Input";
            this.textBox_AuthorizationWindow_ManagerLogin_Input.Size = new System.Drawing.Size(160, 30);
            this.textBox_AuthorizationWindow_ManagerLogin_Input.TabIndex = 5;
            // 
            // textBox_AuthorizationWindow_ManagerPassword_Input
            // 
            this.textBox_AuthorizationWindow_ManagerPassword_Input.Location = new System.Drawing.Point(135, 85);
            this.textBox_AuthorizationWindow_ManagerPassword_Input.Name = "textBox_AuthorizationWindow_ManagerPassword_Input";
            this.textBox_AuthorizationWindow_ManagerPassword_Input.Size = new System.Drawing.Size(160, 30);
            this.textBox_AuthorizationWindow_ManagerPassword_Input.TabIndex = 6;
            // 
            // AuthorizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 313);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "AuthorizationWindow";
            this.ShowIcon = false;
            this.tabControl1.ResumeLayout(false);
            this.tabPage_AutorizationWindow_Head.ResumeLayout(false);
            this.tabPage_AutorizationWindow_Head.PerformLayout();
            this.tabPage_AuthorizationWindow_Manager.ResumeLayout(false);
            this.tabPage_AuthorizationWindow_Manager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textBox_AuthorizationWindow_HeadLogin_Input;
        private TextBox textBox_AuthorizationWindow_HeadPassword_Input;
        private TabControl tabControl1;
        private TabPage tabPage_AutorizationWindow_Head;
        private TabPage tabPage_AuthorizationWindow_Manager;
        private Button button_AuthorizationWindow_HeadAuthorize;
        private Label label_AuthorizationWindow_HeadPassword;
        private Label label_AuthorizationWindow_HeadLogin;
        private Button button_AuthorizationWindow_HeadRegister;
        private Button button_AuthorizationWindow_ManagerAuthorize;
        private Label label_AuthorizationWindow_ManagerPassword;
        private Label label_AuthorizationWindow_ManagerLogin;
        private TextBox textBox_AuthorizationWindow_ManagerLogin_Input;
        private TextBox textBox_AuthorizationWindow_ManagerPassword_Input;
    }
}