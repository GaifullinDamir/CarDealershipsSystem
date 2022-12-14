namespace WinFormsApp.Forms
{
    partial class ManagerMainWindow
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
            this.tabControl_ManagerMainWindow = new System.Windows.Forms.TabControl();
            this.tabPage_ManagerMainWindow_Cars = new System.Windows.Forms.TabPage();
            this.tabPage_ManagerMainWindow_Orders = new System.Windows.Forms.TabPage();
            this.tabPage_ManagerMainWindow_Buyers = new System.Windows.Forms.TabPage();
            this.groupBox_ManagerMainWindow_Cars = new System.Windows.Forms.GroupBox();
            this.button_ManagerMainWindow_DataGridView_Cars_Update = new System.Windows.Forms.Button();
            this.dataGridView_ManagerMainWindow_Cars = new System.Windows.Forms.DataGridView();
            this.groupBox_ManagerMainWindow_SearchCar = new System.Windows.Forms.GroupBox();
            this.label_ManagerMainWindow_SearchCar_Model = new System.Windows.Forms.Label();
            this.label_ManagerMainWindow_SearchCar_Brand = new System.Windows.Forms.Label();
            this.textBox_ManagerMainWindow_SearchCar_Model_Input = new System.Windows.Forms.TextBox();
            this.textBox_ManagerMainWindow_SearchCar_Brand_Input = new System.Windows.Forms.TextBox();
            this.button_ManagerMainWindow_SearchCar = new System.Windows.Forms.Button();
            this.tabControl_ManagerMainWindow.SuspendLayout();
            this.tabPage_ManagerMainWindow_Cars.SuspendLayout();
            this.groupBox_ManagerMainWindow_Cars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Cars)).BeginInit();
            this.groupBox_ManagerMainWindow_SearchCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_ManagerMainWindow
            // 
            this.tabControl_ManagerMainWindow.Controls.Add(this.tabPage_ManagerMainWindow_Cars);
            this.tabControl_ManagerMainWindow.Controls.Add(this.tabPage_ManagerMainWindow_Orders);
            this.tabControl_ManagerMainWindow.Controls.Add(this.tabPage_ManagerMainWindow_Buyers);
            this.tabControl_ManagerMainWindow.Location = new System.Drawing.Point(12, 12);
            this.tabControl_ManagerMainWindow.Name = "tabControl_ManagerMainWindow";
            this.tabControl_ManagerMainWindow.SelectedIndex = 0;
            this.tabControl_ManagerMainWindow.Size = new System.Drawing.Size(918, 649);
            this.tabControl_ManagerMainWindow.TabIndex = 0;
            // 
            // tabPage_ManagerMainWindow_Cars
            // 
            this.tabPage_ManagerMainWindow_Cars.Controls.Add(this.groupBox_ManagerMainWindow_SearchCar);
            this.tabPage_ManagerMainWindow_Cars.Controls.Add(this.groupBox_ManagerMainWindow_Cars);
            this.tabPage_ManagerMainWindow_Cars.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_ManagerMainWindow_Cars.Location = new System.Drawing.Point(4, 29);
            this.tabPage_ManagerMainWindow_Cars.Name = "tabPage_ManagerMainWindow_Cars";
            this.tabPage_ManagerMainWindow_Cars.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ManagerMainWindow_Cars.Size = new System.Drawing.Size(910, 616);
            this.tabPage_ManagerMainWindow_Cars.TabIndex = 0;
            this.tabPage_ManagerMainWindow_Cars.Text = "Автомобили";
            this.tabPage_ManagerMainWindow_Cars.UseVisualStyleBackColor = true;
            // 
            // tabPage_ManagerMainWindow_Orders
            // 
            this.tabPage_ManagerMainWindow_Orders.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage_ManagerMainWindow_Orders.Location = new System.Drawing.Point(4, 29);
            this.tabPage_ManagerMainWindow_Orders.Name = "tabPage_ManagerMainWindow_Orders";
            this.tabPage_ManagerMainWindow_Orders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ManagerMainWindow_Orders.Size = new System.Drawing.Size(910, 616);
            this.tabPage_ManagerMainWindow_Orders.TabIndex = 1;
            this.tabPage_ManagerMainWindow_Orders.Text = "Заказы";
            this.tabPage_ManagerMainWindow_Orders.UseVisualStyleBackColor = true;
            // 
            // tabPage_ManagerMainWindow_Buyers
            // 
            this.tabPage_ManagerMainWindow_Buyers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage_ManagerMainWindow_Buyers.Location = new System.Drawing.Point(4, 29);
            this.tabPage_ManagerMainWindow_Buyers.Name = "tabPage_ManagerMainWindow_Buyers";
            this.tabPage_ManagerMainWindow_Buyers.Size = new System.Drawing.Size(910, 616);
            this.tabPage_ManagerMainWindow_Buyers.TabIndex = 2;
            this.tabPage_ManagerMainWindow_Buyers.Text = "Покупатели";
            this.tabPage_ManagerMainWindow_Buyers.UseVisualStyleBackColor = true;
            // 
            // groupBox_ManagerMainWindow_Cars
            // 
            this.groupBox_ManagerMainWindow_Cars.Controls.Add(this.button_ManagerMainWindow_DataGridView_Cars_Update);
            this.groupBox_ManagerMainWindow_Cars.Controls.Add(this.dataGridView_ManagerMainWindow_Cars);
            this.groupBox_ManagerMainWindow_Cars.Location = new System.Drawing.Point(5, -2);
            this.groupBox_ManagerMainWindow_Cars.Name = "groupBox_ManagerMainWindow_Cars";
            this.groupBox_ManagerMainWindow_Cars.Size = new System.Drawing.Size(900, 400);
            this.groupBox_ManagerMainWindow_Cars.TabIndex = 1;
            this.groupBox_ManagerMainWindow_Cars.TabStop = false;
            this.groupBox_ManagerMainWindow_Cars.Text = "Автомобили";
            // 
            // button_ManagerMainWindow_DataGridView_Cars_Update
            // 
            this.button_ManagerMainWindow_DataGridView_Cars_Update.Location = new System.Drawing.Point(350, 350);
            this.button_ManagerMainWindow_DataGridView_Cars_Update.Name = "button_ManagerMainWindow_DataGridView_Cars_Update";
            this.button_ManagerMainWindow_DataGridView_Cars_Update.Size = new System.Drawing.Size(200, 35);
            this.button_ManagerMainWindow_DataGridView_Cars_Update.TabIndex = 1;
            this.button_ManagerMainWindow_DataGridView_Cars_Update.Text = "Обновить";
            this.button_ManagerMainWindow_DataGridView_Cars_Update.UseVisualStyleBackColor = true;
            // 
            // dataGridView_ManagerMainWindow_Cars
            // 
            this.dataGridView_ManagerMainWindow_Cars.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_ManagerMainWindow_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ManagerMainWindow_Cars.Location = new System.Drawing.Point(10, 30);
            this.dataGridView_ManagerMainWindow_Cars.Name = "dataGridView_ManagerMainWindow_Cars";
            this.dataGridView_ManagerMainWindow_Cars.RowHeadersWidth = 51;
            this.dataGridView_ManagerMainWindow_Cars.RowTemplate.Height = 29;
            this.dataGridView_ManagerMainWindow_Cars.Size = new System.Drawing.Size(880, 300);
            this.dataGridView_ManagerMainWindow_Cars.TabIndex = 0;
            // 
            // groupBox_ManagerMainWindow_SearchCar
            // 
            this.groupBox_ManagerMainWindow_SearchCar.Controls.Add(this.label_ManagerMainWindow_SearchCar_Model);
            this.groupBox_ManagerMainWindow_SearchCar.Controls.Add(this.label_ManagerMainWindow_SearchCar_Brand);
            this.groupBox_ManagerMainWindow_SearchCar.Controls.Add(this.textBox_ManagerMainWindow_SearchCar_Model_Input);
            this.groupBox_ManagerMainWindow_SearchCar.Controls.Add(this.textBox_ManagerMainWindow_SearchCar_Brand_Input);
            this.groupBox_ManagerMainWindow_SearchCar.Controls.Add(this.button_ManagerMainWindow_SearchCar);
            this.groupBox_ManagerMainWindow_SearchCar.Location = new System.Drawing.Point(230, 395);
            this.groupBox_ManagerMainWindow_SearchCar.Name = "groupBox_ManagerMainWindow_SearchCar";
            this.groupBox_ManagerMainWindow_SearchCar.Size = new System.Drawing.Size(450, 214);
            this.groupBox_ManagerMainWindow_SearchCar.TabIndex = 4;
            this.groupBox_ManagerMainWindow_SearchCar.TabStop = false;
            this.groupBox_ManagerMainWindow_SearchCar.Text = "Поиск автомобиля";
            // 
            // label_ManagerMainWindow_SearchCar_Model
            // 
            this.label_ManagerMainWindow_SearchCar_Model.AutoSize = true;
            this.label_ManagerMainWindow_SearchCar_Model.Location = new System.Drawing.Point(41, 110);
            this.label_ManagerMainWindow_SearchCar_Model.Name = "label_ManagerMainWindow_SearchCar_Model";
            this.label_ManagerMainWindow_SearchCar_Model.Size = new System.Drawing.Size(75, 23);
            this.label_ManagerMainWindow_SearchCar_Model.TabIndex = 6;
            this.label_ManagerMainWindow_SearchCar_Model.Text = "Модель:";
            // 
            // label_ManagerMainWindow_SearchCar_Brand
            // 
            this.label_ManagerMainWindow_SearchCar_Brand.AutoSize = true;
            this.label_ManagerMainWindow_SearchCar_Brand.Location = new System.Drawing.Point(56, 60);
            this.label_ManagerMainWindow_SearchCar_Brand.Name = "label_ManagerMainWindow_SearchCar_Brand";
            this.label_ManagerMainWindow_SearchCar_Brand.Size = new System.Drawing.Size(62, 23);
            this.label_ManagerMainWindow_SearchCar_Brand.TabIndex = 5;
            this.label_ManagerMainWindow_SearchCar_Brand.Text = "Бренд:";
            // 
            // textBox_ManagerMainWindow_SearchCar_Model_Input
            // 
            this.textBox_ManagerMainWindow_SearchCar_Model_Input.Location = new System.Drawing.Point(125, 110);
            this.textBox_ManagerMainWindow_SearchCar_Model_Input.Name = "textBox_ManagerMainWindow_SearchCar_Model_Input";
            this.textBox_ManagerMainWindow_SearchCar_Model_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_ManagerMainWindow_SearchCar_Model_Input.TabIndex = 4;
            // 
            // textBox_ManagerMainWindow_SearchCar_Brand_Input
            // 
            this.textBox_ManagerMainWindow_SearchCar_Brand_Input.Location = new System.Drawing.Point(125, 60);
            this.textBox_ManagerMainWindow_SearchCar_Brand_Input.Name = "textBox_ManagerMainWindow_SearchCar_Brand_Input";
            this.textBox_ManagerMainWindow_SearchCar_Brand_Input.Size = new System.Drawing.Size(200, 30);
            this.textBox_ManagerMainWindow_SearchCar_Brand_Input.TabIndex = 3;
            // 
            // button_ManagerMainWindow_SearchCar
            // 
            this.button_ManagerMainWindow_SearchCar.Location = new System.Drawing.Point(125, 161);
            this.button_ManagerMainWindow_SearchCar.Name = "button_ManagerMainWindow_SearchCar";
            this.button_ManagerMainWindow_SearchCar.Size = new System.Drawing.Size(200, 35);
            this.button_ManagerMainWindow_SearchCar.TabIndex = 2;
            this.button_ManagerMainWindow_SearchCar.Text = "Найти автомобиль";
            this.button_ManagerMainWindow_SearchCar.UseVisualStyleBackColor = true;
            // 
            // ManagerMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 673);
            this.Controls.Add(this.tabControl_ManagerMainWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ManagerMainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarDealershipSystem";
            this.tabControl_ManagerMainWindow.ResumeLayout(false);
            this.tabPage_ManagerMainWindow_Cars.ResumeLayout(false);
            this.groupBox_ManagerMainWindow_Cars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Cars)).EndInit();
            this.groupBox_ManagerMainWindow_SearchCar.ResumeLayout(false);
            this.groupBox_ManagerMainWindow_SearchCar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl_ManagerMainWindow;
        private TabPage tabPage_ManagerMainWindow_Cars;
        private TabPage tabPage_ManagerMainWindow_Orders;
        private TabPage tabPage_ManagerMainWindow_Buyers;
        private GroupBox groupBox_ManagerMainWindow_Cars;
        private Button button_ManagerMainWindow_DataGridView_Cars_Update;
        private DataGridView dataGridView_ManagerMainWindow_Cars;
        private GroupBox groupBox_ManagerMainWindow_SearchCar;
        private Label label_ManagerMainWindow_SearchCar_Model;
        private Label label_ManagerMainWindow_SearchCar_Brand;
        private TextBox textBox_ManagerMainWindow_SearchCar_Model_Input;
        private TextBox textBox_ManagerMainWindow_SearchCar_Brand_Input;
        private Button button_ManagerMainWindow_SearchCar;
    }
}