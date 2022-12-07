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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_HeadMainWindow_Branches = new System.Windows.Forms.DataGridView();
            this.textBox_HeadMainWindow_BranchName_Input = new System.Windows.Forms.TextBox();
            this.label_HeadMainWindow_BranchName = new System.Windows.Forms.Label();
            this.groupBox_HeadMainWindow_AddBranch = new System.Windows.Forms.GroupBox();
            this.label_HeadMainWindow_BranchAddress = new System.Windows.Forms.Label();
            this.textBox_HeadMainWindow_BranchAddress_Input = new System.Windows.Forms.TextBox();
            this.button_HeadMainWindow_AddBranch = new System.Windows.Forms.Button();
            this.tabControl_HeadMainWindow.SuspendLayout();
            this.tabPage_Branches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HeadMainWindow_Branches)).BeginInit();
            this.groupBox_HeadMainWindow_AddBranch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_HeadMainWindow
            // 
            this.tabControl_HeadMainWindow.Controls.Add(this.tabPage_Branches);
            this.tabControl_HeadMainWindow.Controls.Add(this.tabPage2);
            this.tabControl_HeadMainWindow.Location = new System.Drawing.Point(12, 12);
            this.tabControl_HeadMainWindow.Name = "tabControl_HeadMainWindow";
            this.tabControl_HeadMainWindow.SelectedIndex = 0;
            this.tabControl_HeadMainWindow.Size = new System.Drawing.Size(818, 569);
            this.tabControl_HeadMainWindow.TabIndex = 0;
            // 
            // tabPage_Branches
            // 
            this.tabPage_Branches.Controls.Add(this.groupBox_HeadMainWindow_AddBranch);
            this.tabPage_Branches.Controls.Add(this.dataGridView_HeadMainWindow_Branches);
            this.tabPage_Branches.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage_Branches.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Branches.Name = "tabPage_Branches";
            this.tabPage_Branches.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Branches.Size = new System.Drawing.Size(810, 536);
            this.tabPage_Branches.TabIndex = 0;
            this.tabPage_Branches.Text = "Филиалы";
            this.tabPage_Branches.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(810, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_HeadMainWindow_Branches
            // 
            this.dataGridView_HeadMainWindow_Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HeadMainWindow_Branches.Location = new System.Drawing.Point(16, 29);
            this.dataGridView_HeadMainWindow_Branches.Name = "dataGridView_HeadMainWindow_Branches";
            this.dataGridView_HeadMainWindow_Branches.RowHeadersWidth = 51;
            this.dataGridView_HeadMainWindow_Branches.RowTemplate.Height = 29;
            this.dataGridView_HeadMainWindow_Branches.Size = new System.Drawing.Size(348, 232);
            this.dataGridView_HeadMainWindow_Branches.TabIndex = 0;
            // 
            // textBox_HeadMainWindow_BranchName_Input
            // 
            this.textBox_HeadMainWindow_BranchName_Input.Location = new System.Drawing.Point(30, 80);
            this.textBox_HeadMainWindow_BranchName_Input.Name = "textBox_HeadMainWindow_BranchName_Input";
            this.textBox_HeadMainWindow_BranchName_Input.Size = new System.Drawing.Size(300, 30);
            this.textBox_HeadMainWindow_BranchName_Input.TabIndex = 1;
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
            // label_HeadMainWindow_BranchAddress
            // 
            this.label_HeadMainWindow_BranchAddress.AutoSize = true;
            this.label_HeadMainWindow_BranchAddress.Location = new System.Drawing.Point(150, 120);
            this.label_HeadMainWindow_BranchAddress.Name = "label_HeadMainWindow_BranchAddress";
            this.label_HeadMainWindow_BranchAddress.Size = new System.Drawing.Size(59, 23);
            this.label_HeadMainWindow_BranchAddress.TabIndex = 3;
            this.label_HeadMainWindow_BranchAddress.Text = "Адрес";
            // 
            // textBox_HeadMainWindow_BranchAddress_Input
            // 
            this.textBox_HeadMainWindow_BranchAddress_Input.Location = new System.Drawing.Point(30, 160);
            this.textBox_HeadMainWindow_BranchAddress_Input.Name = "textBox_HeadMainWindow_BranchAddress_Input";
            this.textBox_HeadMainWindow_BranchAddress_Input.Size = new System.Drawing.Size(300, 30);
            this.textBox_HeadMainWindow_BranchAddress_Input.TabIndex = 4;
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
            this.tabControl_HeadMainWindow.ResumeLayout(false);
            this.tabPage_Branches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HeadMainWindow_Branches)).EndInit();
            this.groupBox_HeadMainWindow_AddBranch.ResumeLayout(false);
            this.groupBox_HeadMainWindow_AddBranch.PerformLayout();
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
        private DataGridView dataGridView_HeadMainWindow_Branches;
        private TabPage tabPage2;
    }
}