namespace WinFormsApp.Forms
{
    partial class ChangeManagerInfoWindow
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
            this.textBox_ChangeManagerInfoWindow_Salary_Input = new System.Windows.Forms.TextBox();
            this.textBox_ChangeManagerInfo_MngrPayDate_Input = new System.Windows.Forms.TextBox();
            this.textBox_ChangeManagerInfo_MngrPrize_Input = new System.Windows.Forms.TextBox();
            this.label_ChangeManagerInfoWindow_MngrSalary = new System.Windows.Forms.Label();
            this.label_ChangeManagerInfo_MngrPayDate = new System.Windows.Forms.Label();
            this.label_ChangeManagerInfo_MngrPrize = new System.Windows.Forms.Label();
            this.button_ChangeManagerInfoWindow_Change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_ChangeManagerInfoWindow_Salary_Input
            // 
            this.textBox_ChangeManagerInfoWindow_Salary_Input.Location = new System.Drawing.Point(150, 60);
            this.textBox_ChangeManagerInfoWindow_Salary_Input.Name = "textBox_ChangeManagerInfoWindow_Salary_Input";
            this.textBox_ChangeManagerInfoWindow_Salary_Input.Size = new System.Drawing.Size(150, 27);
            this.textBox_ChangeManagerInfoWindow_Salary_Input.TabIndex = 0;
            // 
            // textBox_ChangeManagerInfo_MngrPayDate_Input
            // 
            this.textBox_ChangeManagerInfo_MngrPayDate_Input.Location = new System.Drawing.Point(150, 100);
            this.textBox_ChangeManagerInfo_MngrPayDate_Input.Name = "textBox_ChangeManagerInfo_MngrPayDate_Input";
            this.textBox_ChangeManagerInfo_MngrPayDate_Input.Size = new System.Drawing.Size(150, 27);
            this.textBox_ChangeManagerInfo_MngrPayDate_Input.TabIndex = 1;
            // 
            // textBox_ChangeManagerInfo_MngrPrize_Input
            // 
            this.textBox_ChangeManagerInfo_MngrPrize_Input.Location = new System.Drawing.Point(150, 140);
            this.textBox_ChangeManagerInfo_MngrPrize_Input.Name = "textBox_ChangeManagerInfo_MngrPrize_Input";
            this.textBox_ChangeManagerInfo_MngrPrize_Input.Size = new System.Drawing.Size(150, 27);
            this.textBox_ChangeManagerInfo_MngrPrize_Input.TabIndex = 2;
            // 
            // label_ChangeManagerInfoWindow_MngrSalary
            // 
            this.label_ChangeManagerInfoWindow_MngrSalary.AutoSize = true;
            this.label_ChangeManagerInfoWindow_MngrSalary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ChangeManagerInfoWindow_MngrSalary.Location = new System.Drawing.Point(50, 60);
            this.label_ChangeManagerInfoWindow_MngrSalary.Name = "label_ChangeManagerInfoWindow_MngrSalary";
            this.label_ChangeManagerInfoWindow_MngrSalary.Size = new System.Drawing.Size(87, 23);
            this.label_ChangeManagerInfoWindow_MngrSalary.TabIndex = 3;
            this.label_ChangeManagerInfoWindow_MngrSalary.Text = "Зарплата:";
            // 
            // label_ChangeManagerInfo_MngrPayDate
            // 
            this.label_ChangeManagerInfo_MngrPayDate.AutoSize = true;
            this.label_ChangeManagerInfo_MngrPayDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ChangeManagerInfo_MngrPayDate.Location = new System.Drawing.Point(5, 100);
            this.label_ChangeManagerInfo_MngrPayDate.Name = "label_ChangeManagerInfo_MngrPayDate";
            this.label_ChangeManagerInfo_MngrPayDate.Size = new System.Drawing.Size(132, 23);
            this.label_ChangeManagerInfo_MngrPayDate.TabIndex = 4;
            this.label_ChangeManagerInfo_MngrPayDate.Text = "Дата зарплаты:";
            // 
            // label_ChangeManagerInfo_MngrPrize
            // 
            this.label_ChangeManagerInfo_MngrPrize.AutoSize = true;
            this.label_ChangeManagerInfo_MngrPrize.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ChangeManagerInfo_MngrPrize.Location = new System.Drawing.Point(60, 140);
            this.label_ChangeManagerInfo_MngrPrize.Name = "label_ChangeManagerInfo_MngrPrize";
            this.label_ChangeManagerInfo_MngrPrize.Size = new System.Drawing.Size(78, 23);
            this.label_ChangeManagerInfo_MngrPrize.TabIndex = 5;
            this.label_ChangeManagerInfo_MngrPrize.Text = "Премия:";
            // 
            // button_ChangeManagerInfoWindow_Change
            // 
            this.button_ChangeManagerInfoWindow_Change.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_ChangeManagerInfoWindow_Change.Location = new System.Drawing.Point(105, 200);
            this.button_ChangeManagerInfoWindow_Change.Name = "button_ChangeManagerInfoWindow_Change";
            this.button_ChangeManagerInfoWindow_Change.Size = new System.Drawing.Size(150, 35);
            this.button_ChangeManagerInfoWindow_Change.TabIndex = 6;
            this.button_ChangeManagerInfoWindow_Change.Text = "Сохранить";
            this.button_ChangeManagerInfoWindow_Change.UseVisualStyleBackColor = true;
            this.button_ChangeManagerInfoWindow_Change.Click += new System.EventHandler(this.button_ChangeManagerInfoWindow_Change_Click);
            // 
            // ChangeManagerInfoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 253);
            this.Controls.Add(this.button_ChangeManagerInfoWindow_Change);
            this.Controls.Add(this.label_ChangeManagerInfo_MngrPrize);
            this.Controls.Add(this.label_ChangeManagerInfo_MngrPayDate);
            this.Controls.Add(this.label_ChangeManagerInfoWindow_MngrSalary);
            this.Controls.Add(this.textBox_ChangeManagerInfo_MngrPrize_Input);
            this.Controls.Add(this.textBox_ChangeManagerInfo_MngrPayDate_Input);
            this.Controls.Add(this.textBox_ChangeManagerInfoWindow_Salary_Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ChangeManagerInfoWindow";
            this.ShowIcon = false;
            this.Text = "CarDealershipsSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_ChangeManagerInfoWindow_Salary_Input;
        private TextBox textBox_ChangeManagerInfo_MngrPayDate_Input;
        private TextBox textBox_ChangeManagerInfo_MngrPrize_Input;
        private Label label_ChangeManagerInfoWindow_MngrSalary;
        private Label label_ChangeManagerInfo_MngrPayDate;
        private Label label_ChangeManagerInfo_MngrPrize;
        private Button button_ChangeManagerInfoWindow_Change;
    }
}