﻿namespace WinFormsApp.Forms
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
            this.groupBox_ManagerMainWindow_Cars_Cars = new System.Windows.Forms.GroupBox();
            this.button_ManagerMainWindow_DataGridView_Cars_Update = new System.Windows.Forms.Button();
            this.dataGridView_ManagerMainWindow_Cars = new System.Windows.Forms.DataGridView();
            this.groupBox_ManagerMainWindow_SearchCar = new System.Windows.Forms.GroupBox();
            this.label_ManagerMainWindow_SearchCar_Model = new System.Windows.Forms.Label();
            this.label_ManagerMainWindow_SearchCar_Brand = new System.Windows.Forms.Label();
            this.textBox_ManagerMainWindow_SearchCar_Model_Input = new System.Windows.Forms.TextBox();
            this.textBox_ManagerMainWindow_SearchCar_Brand_Input = new System.Windows.Forms.TextBox();
            this.button_ManagerMainWindow_SearchCar = new System.Windows.Forms.Button();
            this.dataGridView_ManagerMainWindow_Orders_CarOrders = new System.Windows.Forms.DataGridView();
            this.dataGridView_ManagerMainWindow_Orders_Buyers = new System.Windows.Forms.DataGridView();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.button_HeadMainWindow_DataGridView_Cars_Update = new System.Windows.Forms.Button();
            this.groupBox_ManagerMainWindow_AddOrder = new System.Windows.Forms.GroupBox();
            this.textBox_ManagerMainWindow_BuyerPassData_Input = new System.Windows.Forms.TextBox();
            this.textBox_ManagerMainWindow_ContractDate_Input = new System.Windows.Forms.TextBox();
            this.textBox_ManagerMainWindow_OrderAmount_Input = new System.Windows.Forms.TextBox();
            this.dataGridView_ManagerMainWindow_Orders_Cars = new System.Windows.Forms.DataGridView();
            this.textBox_ManagerMainWindow_BuyerSurname_Input = new System.Windows.Forms.TextBox();
            this.textBox_ManagerMainWindow_BuyerName_Input = new System.Windows.Forms.TextBox();
            this.textBox_ManagerMainWindow_BuyerPhoneNumber_Input = new System.Windows.Forms.TextBox();
            this.textBox_ManagerMainWindow_BuyerMiddlename_Input = new System.Windows.Forms.TextBox();
            this.label_ManagerMainWindow_BuyerPassData = new System.Windows.Forms.Label();
            this.label_ManagerMainWindow_ContractDate = new System.Windows.Forms.Label();
            this.label_ManagerMainWindow_OrderAmount = new System.Windows.Forms.Label();
            this.label_ManagerMainWindow_BuyerSurname = new System.Windows.Forms.Label();
            this.label_ManagerMainWindow_BuyerName = new System.Windows.Forms.Label();
            this.label_ManagerMainWindow_BuyerMiddlename = new System.Windows.Forms.Label();
            this.label_ManagerMainWindow_BuyerPhoneNumber = new System.Windows.Forms.Label();
            this.textBox_ManagerMainWindow_VinNumber_Input = new System.Windows.Forms.TextBox();
            this.label_ManagerMainWindow_VinNumber = new System.Windows.Forms.Label();
            this.button_ManagerMainWindow_AddOrder = new System.Windows.Forms.Button();
            this.tabControl_ManagerMainWindow.SuspendLayout();
            this.tabPage_ManagerMainWindow_Cars.SuspendLayout();
            this.tabPage_ManagerMainWindow_Orders.SuspendLayout();
            this.groupBox_ManagerMainWindow_Cars_Cars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Cars)).BeginInit();
            this.groupBox_ManagerMainWindow_SearchCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Orders_CarOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Orders_Buyers)).BeginInit();
            this.groupBox_ManagerMainWindow_AddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Orders_Cars)).BeginInit();
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
            this.tabPage_ManagerMainWindow_Cars.Controls.Add(this.groupBox_ManagerMainWindow_Cars_Cars);
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
            this.tabPage_ManagerMainWindow_Orders.Controls.Add(this.dataGridView_ManagerMainWindow_Orders_Cars);
            this.tabPage_ManagerMainWindow_Orders.Controls.Add(this.groupBox_ManagerMainWindow_AddOrder);
            this.tabPage_ManagerMainWindow_Orders.Controls.Add(this.button_HeadMainWindow_DataGridView_Cars_Update);
            this.tabPage_ManagerMainWindow_Orders.Controls.Add(this.dataGridView_ManagerMainWindow_Orders_Buyers);
            this.tabPage_ManagerMainWindow_Orders.Controls.Add(this.dataGridView_ManagerMainWindow_Orders_CarOrders);
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
            // groupBox_ManagerMainWindow_Cars_Cars
            // 
            this.groupBox_ManagerMainWindow_Cars_Cars.Controls.Add(this.button_ManagerMainWindow_DataGridView_Cars_Update);
            this.groupBox_ManagerMainWindow_Cars_Cars.Controls.Add(this.dataGridView_ManagerMainWindow_Cars);
            this.groupBox_ManagerMainWindow_Cars_Cars.Location = new System.Drawing.Point(5, -2);
            this.groupBox_ManagerMainWindow_Cars_Cars.Name = "groupBox_ManagerMainWindow_Cars_Cars";
            this.groupBox_ManagerMainWindow_Cars_Cars.Size = new System.Drawing.Size(900, 400);
            this.groupBox_ManagerMainWindow_Cars_Cars.TabIndex = 1;
            this.groupBox_ManagerMainWindow_Cars_Cars.TabStop = false;
            this.groupBox_ManagerMainWindow_Cars_Cars.Text = "Автомобили";
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
            // dataGridView_ManagerMainWindow_Orders_CarOrders
            // 
            this.dataGridView_ManagerMainWindow_Orders_CarOrders.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_ManagerMainWindow_Orders_CarOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ManagerMainWindow_Orders_CarOrders.Location = new System.Drawing.Point(3, 6);
            this.dataGridView_ManagerMainWindow_Orders_CarOrders.Name = "dataGridView_ManagerMainWindow_Orders_CarOrders";
            this.dataGridView_ManagerMainWindow_Orders_CarOrders.RowHeadersWidth = 51;
            this.dataGridView_ManagerMainWindow_Orders_CarOrders.RowTemplate.Height = 29;
            this.dataGridView_ManagerMainWindow_Orders_CarOrders.Size = new System.Drawing.Size(300, 300);
            this.dataGridView_ManagerMainWindow_Orders_CarOrders.TabIndex = 0;
            // 
            // dataGridView_ManagerMainWindow_Orders_Buyers
            // 
            this.dataGridView_ManagerMainWindow_Orders_Buyers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_ManagerMainWindow_Orders_Buyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ManagerMainWindow_Orders_Buyers.Location = new System.Drawing.Point(607, 6);
            this.dataGridView_ManagerMainWindow_Orders_Buyers.Name = "dataGridView_ManagerMainWindow_Orders_Buyers";
            this.dataGridView_ManagerMainWindow_Orders_Buyers.RowHeadersWidth = 51;
            this.dataGridView_ManagerMainWindow_Orders_Buyers.RowTemplate.Height = 29;
            this.dataGridView_ManagerMainWindow_Orders_Buyers.Size = new System.Drawing.Size(300, 300);
            this.dataGridView_ManagerMainWindow_Orders_Buyers.TabIndex = 1;
            // 
            // button_HeadMainWindow_DataGridView_Cars_Update
            // 
            this.button_HeadMainWindow_DataGridView_Cars_Update.Location = new System.Drawing.Point(355, 316);
            this.button_HeadMainWindow_DataGridView_Cars_Update.Name = "button_HeadMainWindow_DataGridView_Cars_Update";
            this.button_HeadMainWindow_DataGridView_Cars_Update.Size = new System.Drawing.Size(200, 35);
            this.button_HeadMainWindow_DataGridView_Cars_Update.TabIndex = 2;
            this.button_HeadMainWindow_DataGridView_Cars_Update.Text = "Обновить";
            this.button_HeadMainWindow_DataGridView_Cars_Update.UseVisualStyleBackColor = true;
            // 
            // groupBox_ManagerMainWindow_AddOrder
            // 
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.button_ManagerMainWindow_AddOrder);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.label_ManagerMainWindow_VinNumber);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.textBox_ManagerMainWindow_VinNumber_Input);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.label_ManagerMainWindow_BuyerPhoneNumber);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.label_ManagerMainWindow_BuyerMiddlename);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.label_ManagerMainWindow_BuyerName);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.label_ManagerMainWindow_BuyerSurname);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.label_ManagerMainWindow_OrderAmount);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.label_ManagerMainWindow_ContractDate);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.label_ManagerMainWindow_BuyerPassData);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.textBox_ManagerMainWindow_BuyerMiddlename_Input);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.textBox_ManagerMainWindow_BuyerPhoneNumber_Input);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.textBox_ManagerMainWindow_BuyerName_Input);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.textBox_ManagerMainWindow_BuyerSurname_Input);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.textBox_ManagerMainWindow_OrderAmount_Input);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.textBox_ManagerMainWindow_ContractDate_Input);
            this.groupBox_ManagerMainWindow_AddOrder.Controls.Add(this.textBox_ManagerMainWindow_BuyerPassData_Input);
            this.groupBox_ManagerMainWindow_AddOrder.Location = new System.Drawing.Point(5, 355);
            this.groupBox_ManagerMainWindow_AddOrder.Name = "groupBox_ManagerMainWindow_AddOrder";
            this.groupBox_ManagerMainWindow_AddOrder.Size = new System.Drawing.Size(900, 255);
            this.groupBox_ManagerMainWindow_AddOrder.TabIndex = 3;
            this.groupBox_ManagerMainWindow_AddOrder.TabStop = false;
            this.groupBox_ManagerMainWindow_AddOrder.Text = "Добавить заказ";
            // 
            // textBox_ManagerMainWindow_BuyerPassData_Input
            // 
            this.textBox_ManagerMainWindow_BuyerPassData_Input.Location = new System.Drawing.Point(112, 60);
            this.textBox_ManagerMainWindow_BuyerPassData_Input.Name = "textBox_ManagerMainWindow_BuyerPassData_Input";
            this.textBox_ManagerMainWindow_BuyerPassData_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_ManagerMainWindow_BuyerPassData_Input.TabIndex = 0;
            // 
            // textBox_ManagerMainWindow_ContractDate_Input
            // 
            this.textBox_ManagerMainWindow_ContractDate_Input.Location = new System.Drawing.Point(112, 120);
            this.textBox_ManagerMainWindow_ContractDate_Input.Name = "textBox_ManagerMainWindow_ContractDate_Input";
            this.textBox_ManagerMainWindow_ContractDate_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_ManagerMainWindow_ContractDate_Input.TabIndex = 1;
            // 
            // textBox_ManagerMainWindow_OrderAmount_Input
            // 
            this.textBox_ManagerMainWindow_OrderAmount_Input.Location = new System.Drawing.Point(112, 180);
            this.textBox_ManagerMainWindow_OrderAmount_Input.Name = "textBox_ManagerMainWindow_OrderAmount_Input";
            this.textBox_ManagerMainWindow_OrderAmount_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_ManagerMainWindow_OrderAmount_Input.TabIndex = 2;
            // 
            // dataGridView_ManagerMainWindow_Orders_Cars
            // 
            this.dataGridView_ManagerMainWindow_Orders_Cars.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_ManagerMainWindow_Orders_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ManagerMainWindow_Orders_Cars.Location = new System.Drawing.Point(305, 6);
            this.dataGridView_ManagerMainWindow_Orders_Cars.Name = "dataGridView_ManagerMainWindow_Orders_Cars";
            this.dataGridView_ManagerMainWindow_Orders_Cars.RowHeadersWidth = 51;
            this.dataGridView_ManagerMainWindow_Orders_Cars.RowTemplate.Height = 29;
            this.dataGridView_ManagerMainWindow_Orders_Cars.Size = new System.Drawing.Size(300, 300);
            this.dataGridView_ManagerMainWindow_Orders_Cars.TabIndex = 4;
            // 
            // textBox_ManagerMainWindow_BuyerSurname_Input
            // 
            this.textBox_ManagerMainWindow_BuyerSurname_Input.Location = new System.Drawing.Point(375, 60);
            this.textBox_ManagerMainWindow_BuyerSurname_Input.Name = "textBox_ManagerMainWindow_BuyerSurname_Input";
            this.textBox_ManagerMainWindow_BuyerSurname_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_ManagerMainWindow_BuyerSurname_Input.TabIndex = 3;
            // 
            // textBox_ManagerMainWindow_BuyerName_Input
            // 
            this.textBox_ManagerMainWindow_BuyerName_Input.Location = new System.Drawing.Point(375, 120);
            this.textBox_ManagerMainWindow_BuyerName_Input.Name = "textBox_ManagerMainWindow_BuyerName_Input";
            this.textBox_ManagerMainWindow_BuyerName_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_ManagerMainWindow_BuyerName_Input.TabIndex = 4;
            // 
            // textBox_ManagerMainWindow_BuyerPhoneNumber_Input
            // 
            this.textBox_ManagerMainWindow_BuyerPhoneNumber_Input.Location = new System.Drawing.Point(637, 60);
            this.textBox_ManagerMainWindow_BuyerPhoneNumber_Input.Name = "textBox_ManagerMainWindow_BuyerPhoneNumber_Input";
            this.textBox_ManagerMainWindow_BuyerPhoneNumber_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_ManagerMainWindow_BuyerPhoneNumber_Input.TabIndex = 5;
            // 
            // textBox_ManagerMainWindow_BuyerMiddlename_Input
            // 
            this.textBox_ManagerMainWindow_BuyerMiddlename_Input.Location = new System.Drawing.Point(375, 180);
            this.textBox_ManagerMainWindow_BuyerMiddlename_Input.Name = "textBox_ManagerMainWindow_BuyerMiddlename_Input";
            this.textBox_ManagerMainWindow_BuyerMiddlename_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_ManagerMainWindow_BuyerMiddlename_Input.TabIndex = 6;
            // 
            // label_ManagerMainWindow_BuyerPassData
            // 
            this.label_ManagerMainWindow_BuyerPassData.AutoSize = true;
            this.label_ManagerMainWindow_BuyerPassData.Location = new System.Drawing.Point(100, 30);
            this.label_ManagerMainWindow_BuyerPassData.Name = "label_ManagerMainWindow_BuyerPassData";
            this.label_ManagerMainWindow_BuyerPassData.Size = new System.Drawing.Size(175, 23);
            this.label_ManagerMainWindow_BuyerPassData.TabIndex = 7;
            this.label_ManagerMainWindow_BuyerPassData.Text = "Паспортные данные";
            // 
            // label_ManagerMainWindow_ContractDate
            // 
            this.label_ManagerMainWindow_ContractDate.AutoSize = true;
            this.label_ManagerMainWindow_ContractDate.Location = new System.Drawing.Point(164, 93);
            this.label_ManagerMainWindow_ContractDate.Name = "label_ManagerMainWindow_ContractDate";
            this.label_ManagerMainWindow_ContractDate.Size = new System.Drawing.Size(47, 23);
            this.label_ManagerMainWindow_ContractDate.TabIndex = 8;
            this.label_ManagerMainWindow_ContractDate.Text = "Дата";
            // 
            // label_ManagerMainWindow_OrderAmount
            // 
            this.label_ManagerMainWindow_OrderAmount.AutoSize = true;
            this.label_ManagerMainWindow_OrderAmount.Location = new System.Drawing.Point(126, 153);
            this.label_ManagerMainWindow_OrderAmount.Name = "label_ManagerMainWindow_OrderAmount";
            this.label_ManagerMainWindow_OrderAmount.Size = new System.Drawing.Size(122, 23);
            this.label_ManagerMainWindow_OrderAmount.TabIndex = 9;
            this.label_ManagerMainWindow_OrderAmount.Text = "Сумма заказа";
            // 
            // label_ManagerMainWindow_BuyerSurname
            // 
            this.label_ManagerMainWindow_BuyerSurname.AutoSize = true;
            this.label_ManagerMainWindow_BuyerSurname.Location = new System.Drawing.Point(410, 30);
            this.label_ManagerMainWindow_BuyerSurname.Name = "label_ManagerMainWindow_BuyerSurname";
            this.label_ManagerMainWindow_BuyerSurname.Size = new System.Drawing.Size(84, 23);
            this.label_ManagerMainWindow_BuyerSurname.TabIndex = 10;
            this.label_ManagerMainWindow_BuyerSurname.Text = "Фамилия";
            // 
            // label_ManagerMainWindow_BuyerName
            // 
            this.label_ManagerMainWindow_BuyerName.AutoSize = true;
            this.label_ManagerMainWindow_BuyerName.Location = new System.Drawing.Point(429, 93);
            this.label_ManagerMainWindow_BuyerName.Name = "label_ManagerMainWindow_BuyerName";
            this.label_ManagerMainWindow_BuyerName.Size = new System.Drawing.Size(45, 23);
            this.label_ManagerMainWindow_BuyerName.TabIndex = 11;
            this.label_ManagerMainWindow_BuyerName.Text = "Имя";
            // 
            // label_ManagerMainWindow_BuyerMiddlename
            // 
            this.label_ManagerMainWindow_BuyerMiddlename.AutoSize = true;
            this.label_ManagerMainWindow_BuyerMiddlename.Location = new System.Drawing.Point(409, 154);
            this.label_ManagerMainWindow_BuyerMiddlename.Name = "label_ManagerMainWindow_BuyerMiddlename";
            this.label_ManagerMainWindow_BuyerMiddlename.Size = new System.Drawing.Size(83, 23);
            this.label_ManagerMainWindow_BuyerMiddlename.TabIndex = 12;
            this.label_ManagerMainWindow_BuyerMiddlename.Text = "Отчество";
            // 
            // label_ManagerMainWindow_BuyerPhoneNumber
            // 
            this.label_ManagerMainWindow_BuyerPhoneNumber.AutoSize = true;
            this.label_ManagerMainWindow_BuyerPhoneNumber.Location = new System.Drawing.Point(639, 30);
            this.label_ManagerMainWindow_BuyerPhoneNumber.Name = "label_ManagerMainWindow_BuyerPhoneNumber";
            this.label_ManagerMainWindow_BuyerPhoneNumber.Size = new System.Drawing.Size(146, 23);
            this.label_ManagerMainWindow_BuyerPhoneNumber.TabIndex = 13;
            this.label_ManagerMainWindow_BuyerPhoneNumber.Text = "Номер телефона";
            // 
            // textBox_ManagerMainWindow_VinNumber_Input
            // 
            this.textBox_ManagerMainWindow_VinNumber_Input.Location = new System.Drawing.Point(637, 120);
            this.textBox_ManagerMainWindow_VinNumber_Input.Name = "textBox_ManagerMainWindow_VinNumber_Input";
            this.textBox_ManagerMainWindow_VinNumber_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_ManagerMainWindow_VinNumber_Input.TabIndex = 14;
            // 
            // label_ManagerMainWindow_VinNumber
            // 
            this.label_ManagerMainWindow_VinNumber.AutoSize = true;
            this.label_ManagerMainWindow_VinNumber.Location = new System.Drawing.Point(664, 94);
            this.label_ManagerMainWindow_VinNumber.Name = "label_ManagerMainWindow_VinNumber";
            this.label_ManagerMainWindow_VinNumber.Size = new System.Drawing.Size(98, 23);
            this.label_ManagerMainWindow_VinNumber.TabIndex = 15;
            this.label_ManagerMainWindow_VinNumber.Text = "VIN-номер";
            // 
            // button_ManagerMainWindow_AddOrder
            // 
            this.button_ManagerMainWindow_AddOrder.Location = new System.Drawing.Point(613, 178);
            this.button_ManagerMainWindow_AddOrder.Name = "button_ManagerMainWindow_AddOrder";
            this.button_ManagerMainWindow_AddOrder.Size = new System.Drawing.Size(200, 35);
            this.button_ManagerMainWindow_AddOrder.TabIndex = 16;
            this.button_ManagerMainWindow_AddOrder.Text = "Добавить ";
            this.button_ManagerMainWindow_AddOrder.UseVisualStyleBackColor = true;
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
            this.tabPage_ManagerMainWindow_Orders.ResumeLayout(false);
            this.groupBox_ManagerMainWindow_Cars_Cars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Cars)).EndInit();
            this.groupBox_ManagerMainWindow_SearchCar.ResumeLayout(false);
            this.groupBox_ManagerMainWindow_SearchCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Orders_CarOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Orders_Buyers)).EndInit();
            this.groupBox_ManagerMainWindow_AddOrder.ResumeLayout(false);
            this.groupBox_ManagerMainWindow_AddOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ManagerMainWindow_Orders_Cars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl_ManagerMainWindow;
        private TabPage tabPage_ManagerMainWindow_Cars;
        private TabPage tabPage_ManagerMainWindow_Orders;
        private TabPage tabPage_ManagerMainWindow_Buyers;
        private GroupBox groupBox_ManagerMainWindow_Cars_Cars;
        private Button button_ManagerMainWindow_DataGridView_Cars_Update;
        private DataGridView dataGridView_ManagerMainWindow_Cars;
        private GroupBox groupBox_ManagerMainWindow_SearchCar;
        private Label label_ManagerMainWindow_SearchCar_Model;
        private Label label_ManagerMainWindow_SearchCar_Brand;
        private TextBox textBox_ManagerMainWindow_SearchCar_Model_Input;
        private TextBox textBox_ManagerMainWindow_SearchCar_Brand_Input;
        private Button button_ManagerMainWindow_SearchCar;
        private DataGridView dataGridView_ManagerMainWindow_Orders_Buyers;
        private DataGridView dataGridView_ManagerMainWindow_Orders_CarOrders;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private DataGridView dataGridView_ManagerMainWindow_Orders_Cars;
        private GroupBox groupBox_ManagerMainWindow_AddOrder;
        private TextBox textBox_ManagerMainWindow_OrderAmount_Input;
        private TextBox textBox_ManagerMainWindow_ContractDate_Input;
        private TextBox textBox_ManagerMainWindow_BuyerPassData_Input;
        private Button button_HeadMainWindow_DataGridView_Cars_Update;
        private TextBox textBox_ManagerMainWindow_BuyerMiddlename_Input;
        private TextBox textBox_ManagerMainWindow_BuyerPhoneNumber_Input;
        private TextBox textBox_ManagerMainWindow_BuyerName_Input;
        private TextBox textBox_ManagerMainWindow_BuyerSurname_Input;
        private Label label_ManagerMainWindow_BuyerPassData;
        private Label label_ManagerMainWindow_ContractDate;
        private Label label_ManagerMainWindow_OrderAmount;
        private Label label_ManagerMainWindow_BuyerSurname;
        private Label label_ManagerMainWindow_BuyerName;
        private Label label_ManagerMainWindow_BuyerMiddlename;
        private Button button_ManagerMainWindow_AddOrder;
        private Label label_ManagerMainWindow_VinNumber;
        private TextBox textBox_ManagerMainWindow_VinNumber_Input;
        private Label label_ManagerMainWindow_BuyerPhoneNumber;
    }
}