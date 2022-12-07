namespace WinFormsApp
{
    partial class HeadMainWindow
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
            this.tabControl_HeadMainWindow = new System.Windows.Forms.TabControl();
            this.tabPage_Branches = new System.Windows.Forms.TabPage();
            this.groupBox_HeadMainWindow_Branches = new System.Windows.Forms.GroupBox();
            this.button_HeadMainWindow_DataGridView_UpdateBranches = new System.Windows.Forms.Button();
            this.dataGridView_HeadMainWindow_Branches = new System.Windows.Forms.DataGridView();
            this.groupBox_HeadMainWindow_SearchBranch = new System.Windows.Forms.GroupBox();
            this.button_HeadMainWindow_SearchBranch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox_MainWindow_DeleteBranch = new System.Windows.Forms.GroupBox();
            this.groupBox_HeadMainWindow_AddBranch = new System.Windows.Forms.GroupBox();
            this.button_HeadMainWindow_AddBranch = new System.Windows.Forms.Button();
            this.textBox_HeadMainWindow_BranchAddress_Input = new System.Windows.Forms.TextBox();
            this.label_HeadMainWindow_BranchAddress = new System.Windows.Forms.Label();
            this.label_HeadMainWindow_BranchName = new System.Windows.Forms.Label();
            this.textBox_HeadMainWindow_BranchName_Input = new System.Windows.Forms.TextBox();
            this.tabPage_Managers = new System.Windows.Forms.TabPage();
            this.groupBox_HeadMainWindow_ChangeManagerInfo = new System.Windows.Forms.GroupBox();
            this.label_HeadMainWindow_ChangeManager_MngrPassData = new System.Windows.Forms.Label();
            this.label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename = new System.Windows.Forms.Label();
            this.button_HeadMainWindow_ChangeManagerInfo_Change = new System.Windows.Forms.Button();
            this.groupBox_HeadMainWindow_Managers = new System.Windows.Forms.GroupBox();
            this.button_HeadMainWindow_DataGridView_UpdateManagers = new System.Windows.Forms.Button();
            this.dataGridView_HeadMainWindow_Managers = new System.Windows.Forms.DataGridView();
            this.groupBox_HeadMainWindow_SearchManager = new System.Windows.Forms.GroupBox();
            this.button_HeadMainWindow_SearchManager_Search = new System.Windows.Forms.Button();
            this.label_HeadMainWindow_SearchManager_MngrPassData = new System.Windows.Forms.Label();
            this.textBox_HeadMainWIndow_SearchManager_MngrPassData_Input = new System.Windows.Forms.TextBox();
            this.groupBox_HeadMainWindow_DeleteManager = new System.Windows.Forms.GroupBox();
            this.button_HeadMainWindow_DeleteManager_Delete = new System.Windows.Forms.Button();
            this.groupBox_HeadMainWindow_AddManager = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.tabControl_HeadMainWindow.SuspendLayout();
            this.tabPage_Branches.SuspendLayout();
            this.groupBox_HeadMainWindow_Branches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HeadMainWindow_Branches)).BeginInit();
            this.groupBox_HeadMainWindow_SearchBranch.SuspendLayout();
            this.groupBox_HeadMainWindow_AddBranch.SuspendLayout();
            this.tabPage_Managers.SuspendLayout();
            this.groupBox_HeadMainWindow_ChangeManagerInfo.SuspendLayout();
            this.groupBox_HeadMainWindow_Managers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HeadMainWindow_Managers)).BeginInit();
            this.groupBox_HeadMainWindow_SearchManager.SuspendLayout();
            this.groupBox_HeadMainWindow_DeleteManager.SuspendLayout();
            this.groupBox_HeadMainWindow_AddManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_HeadMainWindow
            // 
            this.tabControl_HeadMainWindow.Controls.Add(this.tabPage_Branches);
            this.tabControl_HeadMainWindow.Controls.Add(this.tabPage_Managers);
            this.tabControl_HeadMainWindow.Location = new System.Drawing.Point(11, 13);
            this.tabControl_HeadMainWindow.Name = "tabControl_HeadMainWindow";
            this.tabControl_HeadMainWindow.SelectedIndex = 0;
            this.tabControl_HeadMainWindow.Size = new System.Drawing.Size(818, 569);
            this.tabControl_HeadMainWindow.TabIndex = 0;
            this.tabControl_HeadMainWindow.SelectedIndexChanged += new System.EventHandler(this.tabControl_HeadMainWindow_SelectedIndexChanged);
            // 
            // tabPage_Branches
            // 
            this.tabPage_Branches.Controls.Add(this.groupBox_HeadMainWindow_Branches);
            this.tabPage_Branches.Controls.Add(this.groupBox_HeadMainWindow_SearchBranch);
            this.tabPage_Branches.Controls.Add(this.groupBox_MainWindow_DeleteBranch);
            this.tabPage_Branches.Controls.Add(this.groupBox_HeadMainWindow_AddBranch);
            this.tabPage_Branches.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage_Branches.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Branches.Name = "tabPage_Branches";
            this.tabPage_Branches.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Branches.Size = new System.Drawing.Size(810, 536);
            this.tabPage_Branches.TabIndex = 0;
            this.tabPage_Branches.Text = "Филиалы";
            this.tabPage_Branches.UseVisualStyleBackColor = true;
            // 
            // groupBox_HeadMainWindow_Branches
            // 
            this.groupBox_HeadMainWindow_Branches.Controls.Add(this.button_HeadMainWindow_DataGridView_UpdateBranches);
            this.groupBox_HeadMainWindow_Branches.Controls.Add(this.dataGridView_HeadMainWindow_Branches);
            this.groupBox_HeadMainWindow_Branches.Location = new System.Drawing.Point(16, 17);
            this.groupBox_HeadMainWindow_Branches.Name = "groupBox_HeadMainWindow_Branches";
            this.groupBox_HeadMainWindow_Branches.Size = new System.Drawing.Size(388, 322);
            this.groupBox_HeadMainWindow_Branches.TabIndex = 6;
            this.groupBox_HeadMainWindow_Branches.TabStop = false;
            this.groupBox_HeadMainWindow_Branches.Text = "Филиалы";
            // 
            // button_HeadMainWindow_DataGridView_UpdateBranches
            // 
            this.button_HeadMainWindow_DataGridView_UpdateBranches.Location = new System.Drawing.Point(94, 270);
            this.button_HeadMainWindow_DataGridView_UpdateBranches.Name = "button_HeadMainWindow_DataGridView_UpdateBranches";
            this.button_HeadMainWindow_DataGridView_UpdateBranches.Size = new System.Drawing.Size(200, 35);
            this.button_HeadMainWindow_DataGridView_UpdateBranches.TabIndex = 1;
            this.button_HeadMainWindow_DataGridView_UpdateBranches.Text = "Обновить";
            this.button_HeadMainWindow_DataGridView_UpdateBranches.UseVisualStyleBackColor = true;
            // 
            // dataGridView_HeadMainWindow_Branches
            // 
            this.dataGridView_HeadMainWindow_Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HeadMainWindow_Branches.Location = new System.Drawing.Point(6, 29);
            this.dataGridView_HeadMainWindow_Branches.Name = "dataGridView_HeadMainWindow_Branches";
            this.dataGridView_HeadMainWindow_Branches.RowHeadersWidth = 51;
            this.dataGridView_HeadMainWindow_Branches.RowTemplate.Height = 29;
            this.dataGridView_HeadMainWindow_Branches.Size = new System.Drawing.Size(376, 225);
            this.dataGridView_HeadMainWindow_Branches.TabIndex = 0;
            // 
            // groupBox_HeadMainWindow_SearchBranch
            // 
            this.groupBox_HeadMainWindow_SearchBranch.Controls.Add(this.button_HeadMainWindow_SearchBranch);
            this.groupBox_HeadMainWindow_SearchBranch.Controls.Add(this.label1);
            this.groupBox_HeadMainWindow_SearchBranch.Controls.Add(this.textBox1);
            this.groupBox_HeadMainWindow_SearchBranch.Location = new System.Drawing.Point(16, 345);
            this.groupBox_HeadMainWindow_SearchBranch.Name = "groupBox_HeadMainWindow_SearchBranch";
            this.groupBox_HeadMainWindow_SearchBranch.Size = new System.Drawing.Size(388, 172);
            this.groupBox_HeadMainWindow_SearchBranch.TabIndex = 5;
            this.groupBox_HeadMainWindow_SearchBranch.TabStop = false;
            this.groupBox_HeadMainWindow_SearchBranch.Text = "Поиск филиала";
            // 
            // button_HeadMainWindow_SearchBranch
            // 
            this.button_HeadMainWindow_SearchBranch.Location = new System.Drawing.Point(94, 118);
            this.button_HeadMainWindow_SearchBranch.Name = "button_HeadMainWindow_SearchBranch";
            this.button_HeadMainWindow_SearchBranch.Size = new System.Drawing.Size(200, 35);
            this.button_HeadMainWindow_SearchBranch.TabIndex = 6;
            this.button_HeadMainWindow_SearchBranch.Text = "Найти";
            this.button_HeadMainWindow_SearchBranch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название филиала";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 30);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox_MainWindow_DeleteBranch
            // 
            this.groupBox_MainWindow_DeleteBranch.Location = new System.Drawing.Point(425, 277);
            this.groupBox_MainWindow_DeleteBranch.Name = "groupBox_MainWindow_DeleteBranch";
            this.groupBox_MainWindow_DeleteBranch.Size = new System.Drawing.Size(360, 240);
            this.groupBox_MainWindow_DeleteBranch.TabIndex = 4;
            this.groupBox_MainWindow_DeleteBranch.TabStop = false;
            this.groupBox_MainWindow_DeleteBranch.Text = "Удалить филиал";
            // 
            // groupBox_HeadMainWindow_AddBranch
            // 
            this.groupBox_HeadMainWindow_AddBranch.Controls.Add(this.button_HeadMainWindow_AddBranch);
            this.groupBox_HeadMainWindow_AddBranch.Controls.Add(this.textBox_HeadMainWindow_BranchAddress_Input);
            this.groupBox_HeadMainWindow_AddBranch.Controls.Add(this.label_HeadMainWindow_BranchAddress);
            this.groupBox_HeadMainWindow_AddBranch.Controls.Add(this.label_HeadMainWindow_BranchName);
            this.groupBox_HeadMainWindow_AddBranch.Controls.Add(this.textBox_HeadMainWindow_BranchName_Input);
            this.groupBox_HeadMainWindow_AddBranch.Location = new System.Drawing.Point(425, 17);
            this.groupBox_HeadMainWindow_AddBranch.Name = "groupBox_HeadMainWindow_AddBranch";
            this.groupBox_HeadMainWindow_AddBranch.Size = new System.Drawing.Size(360, 254);
            this.groupBox_HeadMainWindow_AddBranch.TabIndex = 3;
            this.groupBox_HeadMainWindow_AddBranch.TabStop = false;
            this.groupBox_HeadMainWindow_AddBranch.Text = "Добавить филиал";
            // 
            // button_HeadMainWindow_AddBranch
            // 
            this.button_HeadMainWindow_AddBranch.Location = new System.Drawing.Point(80, 200);
            this.button_HeadMainWindow_AddBranch.Name = "button_HeadMainWindow_AddBranch";
            this.button_HeadMainWindow_AddBranch.Size = new System.Drawing.Size(200, 35);
            this.button_HeadMainWindow_AddBranch.TabIndex = 5;
            this.button_HeadMainWindow_AddBranch.Text = "Добавить";
            this.button_HeadMainWindow_AddBranch.UseVisualStyleBackColor = true;
            // 
            // textBox_HeadMainWindow_BranchAddress_Input
            // 
            this.textBox_HeadMainWindow_BranchAddress_Input.Location = new System.Drawing.Point(30, 160);
            this.textBox_HeadMainWindow_BranchAddress_Input.Name = "textBox_HeadMainWindow_BranchAddress_Input";
            this.textBox_HeadMainWindow_BranchAddress_Input.Size = new System.Drawing.Size(300, 30);
            this.textBox_HeadMainWindow_BranchAddress_Input.TabIndex = 4;
            // 
            // label_HeadMainWindow_BranchAddress
            // 
            this.label_HeadMainWindow_BranchAddress.AutoSize = true;
            this.label_HeadMainWindow_BranchAddress.Location = new System.Drawing.Point(150, 120);
            this.label_HeadMainWindow_BranchAddress.Name = "label_HeadMainWindow_BranchAddress";
            this.label_HeadMainWindow_BranchAddress.Size = new System.Drawing.Size(59, 23);
            this.label_HeadMainWindow_BranchAddress.TabIndex = 3;
            this.label_HeadMainWindow_BranchAddress.Text = "Адрес";
            // 
            // label_HeadMainWindow_BranchName
            // 
            this.label_HeadMainWindow_BranchName.AutoSize = true;
            this.label_HeadMainWindow_BranchName.Location = new System.Drawing.Point(99, 40);
            this.label_HeadMainWindow_BranchName.Name = "label_HeadMainWindow_BranchName";
            this.label_HeadMainWindow_BranchName.Size = new System.Drawing.Size(162, 23);
            this.label_HeadMainWindow_BranchName.TabIndex = 2;
            this.label_HeadMainWindow_BranchName.Text = "Название филиала";
            // 
            // textBox_HeadMainWindow_BranchName_Input
            // 
            this.textBox_HeadMainWindow_BranchName_Input.Location = new System.Drawing.Point(30, 80);
            this.textBox_HeadMainWindow_BranchName_Input.Name = "textBox_HeadMainWindow_BranchName_Input";
            this.textBox_HeadMainWindow_BranchName_Input.Size = new System.Drawing.Size(300, 30);
            this.textBox_HeadMainWindow_BranchName_Input.TabIndex = 1;
            // 
            // tabPage_Managers
            // 
            this.tabPage_Managers.Controls.Add(this.groupBox_HeadMainWindow_ChangeManagerInfo);
            this.tabPage_Managers.Controls.Add(this.groupBox_HeadMainWindow_Managers);
            this.tabPage_Managers.Controls.Add(this.groupBox_HeadMainWindow_SearchManager);
            this.tabPage_Managers.Controls.Add(this.groupBox_HeadMainWindow_DeleteManager);
            this.tabPage_Managers.Controls.Add(this.groupBox_HeadMainWindow_AddManager);
            this.tabPage_Managers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage_Managers.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Managers.Name = "tabPage_Managers";
            this.tabPage_Managers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Managers.Size = new System.Drawing.Size(810, 536);
            this.tabPage_Managers.TabIndex = 1;
            this.tabPage_Managers.Text = "Менеджеры";
            this.tabPage_Managers.UseVisualStyleBackColor = true;
            // 
            // groupBox_HeadMainWindow_ChangeManagerInfo
            // 
            this.groupBox_HeadMainWindow_ChangeManagerInfo.Controls.Add(this.label_HeadMainWindow_ChangeManager_MngrPassData);
            this.groupBox_HeadMainWindow_ChangeManagerInfo.Controls.Add(this.label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename);
            this.groupBox_HeadMainWindow_ChangeManagerInfo.Controls.Add(this.button_HeadMainWindow_ChangeManagerInfo_Change);
            this.groupBox_HeadMainWindow_ChangeManagerInfo.Location = new System.Drawing.Point(437, 198);
            this.groupBox_HeadMainWindow_ChangeManagerInfo.Name = "groupBox_HeadMainWindow_ChangeManagerInfo";
            this.groupBox_HeadMainWindow_ChangeManagerInfo.Size = new System.Drawing.Size(360, 141);
            this.groupBox_HeadMainWindow_ChangeManagerInfo.TabIndex = 11;
            this.groupBox_HeadMainWindow_ChangeManagerInfo.TabStop = false;
            this.groupBox_HeadMainWindow_ChangeManagerInfo.Text = "Изменить данные о менеджере";
            this.groupBox_HeadMainWindow_ChangeManagerInfo.Enter += new System.EventHandler(this.groupBox_HeadMainWindow_ChangeManagerInfo_Enter);
            // 
            // label_HeadMainWindow_ChangeManager_MngrPassData
            // 
            this.label_HeadMainWindow_ChangeManager_MngrPassData.AutoSize = true;
            this.label_HeadMainWindow_ChangeManager_MngrPassData.Location = new System.Drawing.Point(93, 59);
            this.label_HeadMainWindow_ChangeManager_MngrPassData.Name = "label_HeadMainWindow_ChangeManager_MngrPassData";
            this.label_HeadMainWindow_ChangeManager_MngrPassData.Size = new System.Drawing.Size(175, 23);
            this.label_HeadMainWindow_ChangeManager_MngrPassData.TabIndex = 7;
            this.label_HeadMainWindow_ChangeManager_MngrPassData.Text = "Паспортные данные";
            // 
            // label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename
            // 
            this.label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename.AutoSize = true;
            this.label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename.Location = new System.Drawing.Point(155, 30);
            this.label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename.Name = "label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename";
            this.label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename.Size = new System.Drawing.Size(49, 23);
            this.label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename.TabIndex = 6;
            this.label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename.Text = "ФИО";
            // 
            // button_HeadMainWindow_ChangeManagerInfo_Change
            // 
            this.button_HeadMainWindow_ChangeManagerInfo_Change.Location = new System.Drawing.Point(80, 92);
            this.button_HeadMainWindow_ChangeManagerInfo_Change.Name = "button_HeadMainWindow_ChangeManagerInfo_Change";
            this.button_HeadMainWindow_ChangeManagerInfo_Change.Size = new System.Drawing.Size(200, 35);
            this.button_HeadMainWindow_ChangeManagerInfo_Change.TabIndex = 5;
            this.button_HeadMainWindow_ChangeManagerInfo_Change.Text = "Изменить";
            this.button_HeadMainWindow_ChangeManagerInfo_Change.UseVisualStyleBackColor = true;
            // 
            // groupBox_HeadMainWindow_Managers
            // 
            this.groupBox_HeadMainWindow_Managers.Controls.Add(this.button_HeadMainWindow_DataGridView_UpdateManagers);
            this.groupBox_HeadMainWindow_Managers.Controls.Add(this.dataGridView_HeadMainWindow_Managers);
            this.groupBox_HeadMainWindow_Managers.Location = new System.Drawing.Point(16, 17);
            this.groupBox_HeadMainWindow_Managers.Name = "groupBox_HeadMainWindow_Managers";
            this.groupBox_HeadMainWindow_Managers.Size = new System.Drawing.Size(403, 322);
            this.groupBox_HeadMainWindow_Managers.TabIndex = 10;
            this.groupBox_HeadMainWindow_Managers.TabStop = false;
            this.groupBox_HeadMainWindow_Managers.Text = "Менеджеры";
            this.groupBox_HeadMainWindow_Managers.Enter += new System.EventHandler(this.groupBox_HeadMainWindow_Managers_Enter);
            // 
            // button_HeadMainWindow_DataGridView_UpdateManagers
            // 
            this.button_HeadMainWindow_DataGridView_UpdateManagers.Location = new System.Drawing.Point(98, 270);
            this.button_HeadMainWindow_DataGridView_UpdateManagers.Name = "button_HeadMainWindow_DataGridView_UpdateManagers";
            this.button_HeadMainWindow_DataGridView_UpdateManagers.Size = new System.Drawing.Size(200, 35);
            this.button_HeadMainWindow_DataGridView_UpdateManagers.TabIndex = 1;
            this.button_HeadMainWindow_DataGridView_UpdateManagers.Text = "Обновить";
            this.button_HeadMainWindow_DataGridView_UpdateManagers.UseVisualStyleBackColor = true;
            // 
            // dataGridView_HeadMainWindow_Managers
            // 
            this.dataGridView_HeadMainWindow_Managers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HeadMainWindow_Managers.Location = new System.Drawing.Point(6, 29);
            this.dataGridView_HeadMainWindow_Managers.Name = "dataGridView_HeadMainWindow_Managers";
            this.dataGridView_HeadMainWindow_Managers.RowHeadersWidth = 51;
            this.dataGridView_HeadMainWindow_Managers.RowTemplate.Height = 29;
            this.dataGridView_HeadMainWindow_Managers.Size = new System.Drawing.Size(382, 225);
            this.dataGridView_HeadMainWindow_Managers.TabIndex = 0;
            // 
            // groupBox_HeadMainWindow_SearchManager
            // 
            this.groupBox_HeadMainWindow_SearchManager.Controls.Add(this.button_HeadMainWindow_SearchManager_Search);
            this.groupBox_HeadMainWindow_SearchManager.Controls.Add(this.label_HeadMainWindow_SearchManager_MngrPassData);
            this.groupBox_HeadMainWindow_SearchManager.Controls.Add(this.textBox_HeadMainWIndow_SearchManager_MngrPassData_Input);
            this.groupBox_HeadMainWindow_SearchManager.Location = new System.Drawing.Point(16, 345);
            this.groupBox_HeadMainWindow_SearchManager.Name = "groupBox_HeadMainWindow_SearchManager";
            this.groupBox_HeadMainWindow_SearchManager.Size = new System.Drawing.Size(403, 172);
            this.groupBox_HeadMainWindow_SearchManager.TabIndex = 9;
            this.groupBox_HeadMainWindow_SearchManager.TabStop = false;
            this.groupBox_HeadMainWindow_SearchManager.Text = "Поиск менеджера";
            this.groupBox_HeadMainWindow_SearchManager.Enter += new System.EventHandler(this.groupBox2_HeadMainWindow_SearchManager_Enter);
            // 
            // button_HeadMainWindow_SearchManager_Search
            // 
            this.button_HeadMainWindow_SearchManager_Search.Location = new System.Drawing.Point(94, 118);
            this.button_HeadMainWindow_SearchManager_Search.Name = "button_HeadMainWindow_SearchManager_Search";
            this.button_HeadMainWindow_SearchManager_Search.Size = new System.Drawing.Size(200, 35);
            this.button_HeadMainWindow_SearchManager_Search.TabIndex = 6;
            this.button_HeadMainWindow_SearchManager_Search.Text = "Найти";
            this.button_HeadMainWindow_SearchManager_Search.UseVisualStyleBackColor = true;
            // 
            // label_HeadMainWindow_SearchManager_MngrPassData
            // 
            this.label_HeadMainWindow_SearchManager_MngrPassData.AutoSize = true;
            this.label_HeadMainWindow_SearchManager_MngrPassData.Location = new System.Drawing.Point(108, 36);
            this.label_HeadMainWindow_SearchManager_MngrPassData.Name = "label_HeadMainWindow_SearchManager_MngrPassData";
            this.label_HeadMainWindow_SearchManager_MngrPassData.Size = new System.Drawing.Size(175, 23);
            this.label_HeadMainWindow_SearchManager_MngrPassData.TabIndex = 3;
            this.label_HeadMainWindow_SearchManager_MngrPassData.Text = "Паспортные данные";
            // 
            // textBox_HeadMainWIndow_SearchManager_MngrPassData_Input
            // 
            this.textBox_HeadMainWIndow_SearchManager_MngrPassData_Input.Location = new System.Drawing.Point(44, 71);
            this.textBox_HeadMainWIndow_SearchManager_MngrPassData_Input.Name = "textBox_HeadMainWIndow_SearchManager_MngrPassData_Input";
            this.textBox_HeadMainWIndow_SearchManager_MngrPassData_Input.Size = new System.Drawing.Size(300, 30);
            this.textBox_HeadMainWIndow_SearchManager_MngrPassData_Input.TabIndex = 2;
            // 
            // groupBox_HeadMainWindow_DeleteManager
            // 
            this.groupBox_HeadMainWindow_DeleteManager.Controls.Add(this.button_HeadMainWindow_DeleteManager_Delete);
            this.groupBox_HeadMainWindow_DeleteManager.Location = new System.Drawing.Point(437, 431);
            this.groupBox_HeadMainWindow_DeleteManager.Name = "groupBox_HeadMainWindow_DeleteManager";
            this.groupBox_HeadMainWindow_DeleteManager.Size = new System.Drawing.Size(360, 86);
            this.groupBox_HeadMainWindow_DeleteManager.TabIndex = 8;
            this.groupBox_HeadMainWindow_DeleteManager.TabStop = false;
            this.groupBox_HeadMainWindow_DeleteManager.Text = "Уволить менеджера";
            this.groupBox_HeadMainWindow_DeleteManager.Enter += new System.EventHandler(this.groupBox3_HeadMainWindow_DeleteManager_Enter);
            // 
            // button_HeadMainWindow_DeleteManager_Delete
            // 
            this.button_HeadMainWindow_DeleteManager_Delete.Location = new System.Drawing.Point(80, 33);
            this.button_HeadMainWindow_DeleteManager_Delete.Name = "button_HeadMainWindow_DeleteManager_Delete";
            this.button_HeadMainWindow_DeleteManager_Delete.Size = new System.Drawing.Size(200, 35);
            this.button_HeadMainWindow_DeleteManager_Delete.TabIndex = 6;
            this.button_HeadMainWindow_DeleteManager_Delete.Text = "Уволить";
            this.button_HeadMainWindow_DeleteManager_Delete.UseVisualStyleBackColor = true;
            // 
            // groupBox_HeadMainWindow_AddManager
            // 
            this.groupBox_HeadMainWindow_AddManager.Controls.Add(this.button3);
            this.groupBox_HeadMainWindow_AddManager.Location = new System.Drawing.Point(437, 345);
            this.groupBox_HeadMainWindow_AddManager.Name = "groupBox_HeadMainWindow_AddManager";
            this.groupBox_HeadMainWindow_AddManager.Size = new System.Drawing.Size(360, 84);
            this.groupBox_HeadMainWindow_AddManager.TabIndex = 7;
            this.groupBox_HeadMainWindow_AddManager.TabStop = false;
            this.groupBox_HeadMainWindow_AddManager.Text = "Добавить менеджера";
            this.groupBox_HeadMainWindow_AddManager.Enter += new System.EventHandler(this.groupBox4_HeadMainWindow_AddManager_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // HeadMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 593);
            this.Controls.Add(this.tabControl_HeadMainWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HeadMainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarDealershipsSystem";
            this.Load += new System.EventHandler(this.HeadMainWindow_Load);
            this.tabControl_HeadMainWindow.ResumeLayout(false);
            this.tabPage_Branches.ResumeLayout(false);
            this.groupBox_HeadMainWindow_Branches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HeadMainWindow_Branches)).EndInit();
            this.groupBox_HeadMainWindow_SearchBranch.ResumeLayout(false);
            this.groupBox_HeadMainWindow_SearchBranch.PerformLayout();
            this.groupBox_HeadMainWindow_AddBranch.ResumeLayout(false);
            this.groupBox_HeadMainWindow_AddBranch.PerformLayout();
            this.tabPage_Managers.ResumeLayout(false);
            this.groupBox_HeadMainWindow_ChangeManagerInfo.ResumeLayout(false);
            this.groupBox_HeadMainWindow_ChangeManagerInfo.PerformLayout();
            this.groupBox_HeadMainWindow_Managers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HeadMainWindow_Managers)).EndInit();
            this.groupBox_HeadMainWindow_SearchManager.ResumeLayout(false);
            this.groupBox_HeadMainWindow_SearchManager.PerformLayout();
            this.groupBox_HeadMainWindow_DeleteManager.ResumeLayout(false);
            this.groupBox_HeadMainWindow_AddManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl_HeadMainWindow;
        private TabPage tabPage_Branches;
        private GroupBox groupBox_HeadMainWindow_AddBranch;
        private Button button_HeadMainWindow_AddBranch;
        private TextBox textBox_HeadMainWindow_BranchAddress_Input;
        private Label label_HeadMainWindow_BranchAddress;
        private Label label_HeadMainWindow_BranchName;
        private TextBox textBox_HeadMainWindow_BranchName_Input;
        private TabPage tabPage_Managers;
        private GroupBox groupBox_HeadMainWindow_Branches;
        private Button button_HeadMainWindow_DataGridView_UpdateBranches;
        private DataGridView dataGridView_HeadMainWindow_Branches;
        private GroupBox groupBox_HeadMainWindow_SearchBranch;
        private Button button_HeadMainWindow_SearchBranch;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox_MainWindow_DeleteBranch;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private GroupBox groupBox_HeadMainWindow_Managers;
        private Button button_HeadMainWindow_DataGridView_UpdateManagers;
        private DataGridView dataGridView_HeadMainWindow_Managers;
        private GroupBox groupBox_HeadMainWindow_SearchManager;
        private Button button_HeadMainWindow_SearchManager_Search;
        private Label label_HeadMainWindow_SearchManager_MngrPassData;
        private TextBox textBox_HeadMainWIndow_SearchManager_MngrPassData_Input;
        private GroupBox groupBox_HeadMainWindow_DeleteManager;
        private GroupBox groupBox_HeadMainWindow_AddManager;
        private Button button3;
        private Button button_HeadMainWindow_DeleteManager_Delete;
        private GroupBox groupBox_HeadMainWindow_ChangeManagerInfo;
        private Label label_HeadMainWindow_ChangeManager_MngrPassData;
        private Label label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename;
        private Button button_HeadMainWindow_ChangeManagerInfo_Change;
    }
}