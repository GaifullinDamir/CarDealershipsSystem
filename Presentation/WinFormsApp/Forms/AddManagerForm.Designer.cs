namespace WinFormsApp.Forms
{
    partial class AddManagerForm
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
            this.dataGridView_AddManagerForm_Branches = new System.Windows.Forms.DataGridView();
            this.groupBox_AddManagerForm_Branches = new System.Windows.Forms.GroupBox();
            this.label_AddManagerWindow_IdBranch = new System.Windows.Forms.Label();
            this.textBox_AddManagerForm_IdBranch_Input = new System.Windows.Forms.TextBox();
            this.button_AddManagerForm_UpdateBranches = new System.Windows.Forms.Button();
            this.groupBox_AddmanagerWindow_InputManagerData = new System.Windows.Forms.GroupBox();
            this.button_AddManagerWindow_AddManager = new System.Windows.Forms.Button();
            this.label_AddManagerForm_MngrPassword_Input = new System.Windows.Forms.Label();
            this.textBox_AddManagerForm_MngrPassword_Input = new System.Windows.Forms.TextBox();
            this.textBox_AddManagerWindow_MngrLogin_Input = new System.Windows.Forms.TextBox();
            this.label_AddManagerWindow_MngrLogin = new System.Windows.Forms.Label();
            this.label_AddManagerWindow_MngrPayDate = new System.Windows.Forms.Label();
            this.textBox_AddManagerWindow_MngrPayDate_Input = new System.Windows.Forms.TextBox();
            this.label_AddManagerWindow_MngrSalary = new System.Windows.Forms.Label();
            this.textBox_AddManagerWindow_MngrSalary_Input = new System.Windows.Forms.TextBox();
            this.textBox_AddManagerWindow_MngrPhoneNumber_Input = new System.Windows.Forms.TextBox();
            this.label_AddManagerWindow_MngrPhoneNumber = new System.Windows.Forms.Label();
            this.label_AddManagerWindow_MngrMiddlename = new System.Windows.Forms.Label();
            this.textBox_AddManagerWindow_MngrMiddlename_Input = new System.Windows.Forms.TextBox();
            this.textBox_AddManagerWindow_MngrName_Input = new System.Windows.Forms.TextBox();
            this.label_AddmanagerWindow_MngrName = new System.Windows.Forms.Label();
            this.label_AddManagerWindow_MngrSurname = new System.Windows.Forms.Label();
            this.textBox_AddManagerWindow_MngrSurname_Input = new System.Windows.Forms.TextBox();
            this.label_AddManagerWindow_MngrPassData = new System.Windows.Forms.Label();
            this.textBox_AddManagerWindow_MngrPassData_Input = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddManagerForm_Branches)).BeginInit();
            this.groupBox_AddManagerForm_Branches.SuspendLayout();
            this.groupBox_AddmanagerWindow_InputManagerData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_AddManagerForm_Branches
            // 
            this.dataGridView_AddManagerForm_Branches.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_AddManagerForm_Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AddManagerForm_Branches.Location = new System.Drawing.Point(6, 29);
            this.dataGridView_AddManagerForm_Branches.Name = "dataGridView_AddManagerForm_Branches";
            this.dataGridView_AddManagerForm_Branches.RowHeadersWidth = 51;
            this.dataGridView_AddManagerForm_Branches.RowTemplate.Height = 29;
            this.dataGridView_AddManagerForm_Branches.Size = new System.Drawing.Size(880, 300);
            this.dataGridView_AddManagerForm_Branches.TabIndex = 0;
            // 
            // groupBox_AddManagerForm_Branches
            // 
            this.groupBox_AddManagerForm_Branches.Controls.Add(this.label_AddManagerWindow_IdBranch);
            this.groupBox_AddManagerForm_Branches.Controls.Add(this.textBox_AddManagerForm_IdBranch_Input);
            this.groupBox_AddManagerForm_Branches.Controls.Add(this.button_AddManagerForm_UpdateBranches);
            this.groupBox_AddManagerForm_Branches.Controls.Add(this.dataGridView_AddManagerForm_Branches);
            this.groupBox_AddManagerForm_Branches.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_AddManagerForm_Branches.Location = new System.Drawing.Point(20, 0);
            this.groupBox_AddManagerForm_Branches.Name = "groupBox_AddManagerForm_Branches";
            this.groupBox_AddManagerForm_Branches.Size = new System.Drawing.Size(900, 400);
            this.groupBox_AddManagerForm_Branches.TabIndex = 1;
            this.groupBox_AddManagerForm_Branches.TabStop = false;
            this.groupBox_AddManagerForm_Branches.Text = "Филиалы";
            // 
            // label_AddManagerWindow_IdBranch
            // 
            this.label_AddManagerWindow_IdBranch.AutoSize = true;
            this.label_AddManagerWindow_IdBranch.Location = new System.Drawing.Point(540, 358);
            this.label_AddManagerWindow_IdBranch.Name = "label_AddManagerWindow_IdBranch";
            this.label_AddManagerWindow_IdBranch.Size = new System.Drawing.Size(144, 23);
            this.label_AddManagerWindow_IdBranch.TabIndex = 18;
            this.label_AddManagerWindow_IdBranch.Text = "Номер филиала:";
            // 
            // textBox_AddManagerForm_IdBranch_Input
            // 
            this.textBox_AddManagerForm_IdBranch_Input.Location = new System.Drawing.Point(686, 355);
            this.textBox_AddManagerForm_IdBranch_Input.Name = "textBox_AddManagerForm_IdBranch_Input";
            this.textBox_AddManagerForm_IdBranch_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerForm_IdBranch_Input.TabIndex = 17;
            // 
            // button_AddManagerForm_UpdateBranches
            // 
            this.button_AddManagerForm_UpdateBranches.Location = new System.Drawing.Point(6, 350);
            this.button_AddManagerForm_UpdateBranches.Name = "button_AddManagerForm_UpdateBranches";
            this.button_AddManagerForm_UpdateBranches.Size = new System.Drawing.Size(200, 35);
            this.button_AddManagerForm_UpdateBranches.TabIndex = 1;
            this.button_AddManagerForm_UpdateBranches.Text = "Обновить";
            this.button_AddManagerForm_UpdateBranches.UseVisualStyleBackColor = true;
            this.button_AddManagerForm_UpdateBranches.Click += new System.EventHandler(this.button_AddManagerForm_UpdateBranches_Click);
            // 
            // groupBox_AddmanagerWindow_InputManagerData
            // 
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.button_AddManagerWindow_AddManager);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.label_AddManagerForm_MngrPassword_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.textBox_AddManagerForm_MngrPassword_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.textBox_AddManagerWindow_MngrLogin_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.label_AddManagerWindow_MngrLogin);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.label_AddManagerWindow_MngrPayDate);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.textBox_AddManagerWindow_MngrPayDate_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.label_AddManagerWindow_MngrSalary);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.textBox_AddManagerWindow_MngrSalary_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.textBox_AddManagerWindow_MngrPhoneNumber_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.label_AddManagerWindow_MngrPhoneNumber);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.label_AddManagerWindow_MngrMiddlename);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.textBox_AddManagerWindow_MngrMiddlename_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.textBox_AddManagerWindow_MngrName_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.label_AddmanagerWindow_MngrName);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.label_AddManagerWindow_MngrSurname);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.textBox_AddManagerWindow_MngrSurname_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.label_AddManagerWindow_MngrPassData);
            this.groupBox_AddmanagerWindow_InputManagerData.Controls.Add(this.textBox_AddManagerWindow_MngrPassData_Input);
            this.groupBox_AddmanagerWindow_InputManagerData.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_AddmanagerWindow_InputManagerData.Location = new System.Drawing.Point(20, 406);
            this.groupBox_AddmanagerWindow_InputManagerData.Name = "groupBox_AddmanagerWindow_InputManagerData";
            this.groupBox_AddmanagerWindow_InputManagerData.Size = new System.Drawing.Size(900, 250);
            this.groupBox_AddmanagerWindow_InputManagerData.TabIndex = 2;
            this.groupBox_AddmanagerWindow_InputManagerData.TabStop = false;
            this.groupBox_AddmanagerWindow_InputManagerData.Text = "Данные менеджера";
            // 
            // button_AddManagerWindow_AddManager
            // 
            this.button_AddManagerWindow_AddManager.Location = new System.Drawing.Point(350, 215);
            this.button_AddManagerWindow_AddManager.Name = "button_AddManagerWindow_AddManager";
            this.button_AddManagerWindow_AddManager.Size = new System.Drawing.Size(200, 35);
            this.button_AddManagerWindow_AddManager.TabIndex = 18;
            this.button_AddManagerWindow_AddManager.Text = "Добавить";
            this.button_AddManagerWindow_AddManager.UseVisualStyleBackColor = true;
            this.button_AddManagerWindow_AddManager.Click += new System.EventHandler(this.button_AddManagerWindow_AddManager_Click);
            // 
            // label_AddManagerForm_MngrPassword_Input
            // 
            this.label_AddManagerForm_MngrPassword_Input.AutoSize = true;
            this.label_AddManagerForm_MngrPassword_Input.Location = new System.Drawing.Point(694, 138);
            this.label_AddManagerForm_MngrPassword_Input.Name = "label_AddManagerForm_MngrPassword_Input";
            this.label_AddManagerForm_MngrPassword_Input.Size = new System.Drawing.Size(71, 23);
            this.label_AddManagerForm_MngrPassword_Input.TabIndex = 17;
            this.label_AddManagerForm_MngrPassword_Input.Text = "Пароль";
            // 
            // textBox_AddManagerForm_MngrPassword_Input
            // 
            this.textBox_AddManagerForm_MngrPassword_Input.Location = new System.Drawing.Point(625, 160);
            this.textBox_AddManagerForm_MngrPassword_Input.Name = "textBox_AddManagerForm_MngrPassword_Input";
            this.textBox_AddManagerForm_MngrPassword_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerForm_MngrPassword_Input.TabIndex = 16;
            // 
            // textBox_AddManagerWindow_MngrLogin_Input
            // 
            this.textBox_AddManagerWindow_MngrLogin_Input.Location = new System.Drawing.Point(625, 105);
            this.textBox_AddManagerWindow_MngrLogin_Input.Name = "textBox_AddManagerWindow_MngrLogin_Input";
            this.textBox_AddManagerWindow_MngrLogin_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerWindow_MngrLogin_Input.TabIndex = 15;
            // 
            // label_AddManagerWindow_MngrLogin
            // 
            this.label_AddManagerWindow_MngrLogin.AutoSize = true;
            this.label_AddManagerWindow_MngrLogin.Location = new System.Drawing.Point(698, 83);
            this.label_AddManagerWindow_MngrLogin.Name = "label_AddManagerWindow_MngrLogin";
            this.label_AddManagerWindow_MngrLogin.Size = new System.Drawing.Size(59, 23);
            this.label_AddManagerWindow_MngrLogin.TabIndex = 14;
            this.label_AddManagerWindow_MngrLogin.Text = "Логин";
            // 
            // label_AddManagerWindow_MngrPayDate
            // 
            this.label_AddManagerWindow_MngrPayDate.AutoSize = true;
            this.label_AddManagerWindow_MngrPayDate.Location = new System.Drawing.Point(664, 25);
            this.label_AddManagerWindow_MngrPayDate.Name = "label_AddManagerWindow_MngrPayDate";
            this.label_AddManagerWindow_MngrPayDate.Size = new System.Drawing.Size(128, 23);
            this.label_AddManagerWindow_MngrPayDate.TabIndex = 13;
            this.label_AddManagerWindow_MngrPayDate.Text = "Дата зарплаты";
            // 
            // textBox_AddManagerWindow_MngrPayDate_Input
            // 
            this.textBox_AddManagerWindow_MngrPayDate_Input.Location = new System.Drawing.Point(625, 50);
            this.textBox_AddManagerWindow_MngrPayDate_Input.Name = "textBox_AddManagerWindow_MngrPayDate_Input";
            this.textBox_AddManagerWindow_MngrPayDate_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerWindow_MngrPayDate_Input.TabIndex = 12;
            // 
            // label_AddManagerWindow_MngrSalary
            // 
            this.label_AddManagerWindow_MngrSalary.AutoSize = true;
            this.label_AddManagerWindow_MngrSalary.Location = new System.Drawing.Point(408, 138);
            this.label_AddManagerWindow_MngrSalary.Name = "label_AddManagerWindow_MngrSalary";
            this.label_AddManagerWindow_MngrSalary.Size = new System.Drawing.Size(83, 23);
            this.label_AddManagerWindow_MngrSalary.TabIndex = 11;
            this.label_AddManagerWindow_MngrSalary.Text = "Зарплата";
            // 
            // textBox_AddManagerWindow_MngrSalary_Input
            // 
            this.textBox_AddManagerWindow_MngrSalary_Input.Location = new System.Drawing.Point(350, 160);
            this.textBox_AddManagerWindow_MngrSalary_Input.Name = "textBox_AddManagerWindow_MngrSalary_Input";
            this.textBox_AddManagerWindow_MngrSalary_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerWindow_MngrSalary_Input.TabIndex = 10;
            // 
            // textBox_AddManagerWindow_MngrPhoneNumber_Input
            // 
            this.textBox_AddManagerWindow_MngrPhoneNumber_Input.Location = new System.Drawing.Point(350, 105);
            this.textBox_AddManagerWindow_MngrPhoneNumber_Input.Name = "textBox_AddManagerWindow_MngrPhoneNumber_Input";
            this.textBox_AddManagerWindow_MngrPhoneNumber_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerWindow_MngrPhoneNumber_Input.TabIndex = 9;
            // 
            // label_AddManagerWindow_MngrPhoneNumber
            // 
            this.label_AddManagerWindow_MngrPhoneNumber.AutoSize = true;
            this.label_AddManagerWindow_MngrPhoneNumber.Location = new System.Drawing.Point(375, 83);
            this.label_AddManagerWindow_MngrPhoneNumber.Name = "label_AddManagerWindow_MngrPhoneNumber";
            this.label_AddManagerWindow_MngrPhoneNumber.Size = new System.Drawing.Size(146, 23);
            this.label_AddManagerWindow_MngrPhoneNumber.TabIndex = 8;
            this.label_AddManagerWindow_MngrPhoneNumber.Text = "Номер телефона";
            // 
            // label_AddManagerWindow_MngrMiddlename
            // 
            this.label_AddManagerWindow_MngrMiddlename.AutoSize = true;
            this.label_AddManagerWindow_MngrMiddlename.Location = new System.Drawing.Point(136, 138);
            this.label_AddManagerWindow_MngrMiddlename.Name = "label_AddManagerWindow_MngrMiddlename";
            this.label_AddManagerWindow_MngrMiddlename.Size = new System.Drawing.Size(83, 23);
            this.label_AddManagerWindow_MngrMiddlename.TabIndex = 7;
            this.label_AddManagerWindow_MngrMiddlename.Text = "Отчество";
            // 
            // textBox_AddManagerWindow_MngrMiddlename_Input
            // 
            this.textBox_AddManagerWindow_MngrMiddlename_Input.Location = new System.Drawing.Point(75, 160);
            this.textBox_AddManagerWindow_MngrMiddlename_Input.Name = "textBox_AddManagerWindow_MngrMiddlename_Input";
            this.textBox_AddManagerWindow_MngrMiddlename_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerWindow_MngrMiddlename_Input.TabIndex = 6;
            // 
            // textBox_AddManagerWindow_MngrName_Input
            // 
            this.textBox_AddManagerWindow_MngrName_Input.Location = new System.Drawing.Point(75, 105);
            this.textBox_AddManagerWindow_MngrName_Input.Name = "textBox_AddManagerWindow_MngrName_Input";
            this.textBox_AddManagerWindow_MngrName_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerWindow_MngrName_Input.TabIndex = 5;
            // 
            // label_AddmanagerWindow_MngrName
            // 
            this.label_AddmanagerWindow_MngrName.AutoSize = true;
            this.label_AddmanagerWindow_MngrName.Location = new System.Drawing.Point(151, 83);
            this.label_AddmanagerWindow_MngrName.Name = "label_AddmanagerWindow_MngrName";
            this.label_AddmanagerWindow_MngrName.Size = new System.Drawing.Size(45, 23);
            this.label_AddmanagerWindow_MngrName.TabIndex = 4;
            this.label_AddmanagerWindow_MngrName.Text = "Имя";
            // 
            // label_AddManagerWindow_MngrSurname
            // 
            this.label_AddManagerWindow_MngrSurname.AutoSize = true;
            this.label_AddManagerWindow_MngrSurname.Location = new System.Drawing.Point(130, 25);
            this.label_AddManagerWindow_MngrSurname.Name = "label_AddManagerWindow_MngrSurname";
            this.label_AddManagerWindow_MngrSurname.Size = new System.Drawing.Size(84, 23);
            this.label_AddManagerWindow_MngrSurname.TabIndex = 3;
            this.label_AddManagerWindow_MngrSurname.Text = "Фамилия";
            // 
            // textBox_AddManagerWindow_MngrSurname_Input
            // 
            this.textBox_AddManagerWindow_MngrSurname_Input.Location = new System.Drawing.Point(75, 50);
            this.textBox_AddManagerWindow_MngrSurname_Input.Name = "textBox_AddManagerWindow_MngrSurname_Input";
            this.textBox_AddManagerWindow_MngrSurname_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerWindow_MngrSurname_Input.TabIndex = 2;
            // 
            // label_AddManagerWindow_MngrPassData
            // 
            this.label_AddManagerWindow_MngrPassData.AutoSize = true;
            this.label_AddManagerWindow_MngrPassData.Location = new System.Drawing.Point(362, 25);
            this.label_AddManagerWindow_MngrPassData.Name = "label_AddManagerWindow_MngrPassData";
            this.label_AddManagerWindow_MngrPassData.Size = new System.Drawing.Size(175, 23);
            this.label_AddManagerWindow_MngrPassData.TabIndex = 1;
            this.label_AddManagerWindow_MngrPassData.Text = "Паспортные данные";
            // 
            // textBox_AddManagerWindow_MngrPassData_Input
            // 
            this.textBox_AddManagerWindow_MngrPassData_Input.Location = new System.Drawing.Point(350, 50);
            this.textBox_AddManagerWindow_MngrPassData_Input.Name = "textBox_AddManagerWindow_MngrPassData_Input";
            this.textBox_AddManagerWindow_MngrPassData_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_AddManagerWindow_MngrPassData_Input.TabIndex = 0;
            // 
            // AddManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 673);
            this.Controls.Add(this.groupBox_AddmanagerWindow_InputManagerData);
            this.Controls.Add(this.groupBox_AddManagerForm_Branches);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddManagerForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarDealershipsSystem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddManagerForm_Branches)).EndInit();
            this.groupBox_AddManagerForm_Branches.ResumeLayout(false);
            this.groupBox_AddManagerForm_Branches.PerformLayout();
            this.groupBox_AddmanagerWindow_InputManagerData.ResumeLayout(false);
            this.groupBox_AddmanagerWindow_InputManagerData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_AddManagerForm_Branches;
        private GroupBox groupBox_AddManagerForm_Branches;
        private GroupBox groupBox_AddmanagerWindow_InputManagerData;
        private Label label_AddManagerWindow_MngrLogin;
        private Label label_AddManagerWindow_MngrPayDate;
        private TextBox textBox_AddManagerWindow_MngrPayDate_Input;
        private Label label_AddManagerWindow_MngrSalary;
        private TextBox textBox_AddManagerWindow_MngrSalary_Input;
        private TextBox textBox_AddManagerWindow_MngrPhoneNumber_Input;
        private Label label_AddManagerWindow_MngrPhoneNumber;
        private Label label_AddManagerWindow_MngrMiddlename;
        private TextBox textBox_AddManagerWindow_MngrMiddlename_Input;
        private TextBox textBox_AddManagerWindow_MngrName_Input;
        private Label label_AddmanagerWindow_MngrName;
        private Label label_AddManagerWindow_MngrSurname;
        private TextBox textBox_AddManagerWindow_MngrSurname_Input;
        private Label label_AddManagerWindow_MngrPassData;
        private TextBox textBox_AddManagerWindow_MngrPassData_Input;
        private TextBox textBox_AddManagerWindow_MngrLogin_Input;
        private Button button_AddManagerForm_UpdateBranches;
        private Label label_AddManagerForm_MngrPassword_Input;
        private TextBox textBox_AddManagerForm_MngrPassword_Input;
        private Button button_AddManagerWindow_AddManager;
        private Label label_AddManagerWindow_IdBranch;
        private TextBox textBox_AddManagerForm_IdBranch_Input;
    }
}