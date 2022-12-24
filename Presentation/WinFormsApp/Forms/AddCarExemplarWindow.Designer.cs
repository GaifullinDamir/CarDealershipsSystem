namespace WinFormsApp.Forms
{
    partial class AddCarExemplarWindow
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
            this.groupBox_AddCarExemplarWindow_Cars = new System.Windows.Forms.GroupBox();
            this.dataGridView_AddCarExemplarsWindow_Cars = new System.Windows.Forms.DataGridView();
            this.groupBox_AddCarExemplarWindow_CarData = new System.Windows.Forms.GroupBox();
            this.label_AddCarExemplarWindow_YearOfAssembly = new System.Windows.Forms.Label();
            this.textBox_AddCarExemplarWindow_YearOffAssebly_Input = new System.Windows.Forms.TextBox();
            this.textBox_AddCarExemplarWindow_Price_Input = new System.Windows.Forms.TextBox();
            this.label_AddCarExemplarWindow_Color = new System.Windows.Forms.Label();
            this.textBox_AddCarWindow_IdBranch_Input = new System.Windows.Forms.TextBox();
            this.label_AddCarExemplarWindow_IdCar = new System.Windows.Forms.Label();
            this.label_AddCarExemplarWindow_Price = new System.Windows.Forms.Label();
            this.textBox_AddCarExemplarWindow_Power_Input = new System.Windows.Forms.TextBox();
            this.textBox_AddCarExemplarWindow_IdCar_Input = new System.Windows.Forms.TextBox();
            this.label_AddCarExemplarWindow_Power = new System.Windows.Forms.Label();
            this.button_AddCarExemplarWindow_AddCarExemplar = new System.Windows.Forms.Button();
            this.groupBox_AddCarExemplarWindow_Cars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddCarExemplarsWindow_Cars)).BeginInit();
            this.groupBox_AddCarExemplarWindow_CarData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_AddCarExemplarWindow_Cars
            // 
            this.groupBox_AddCarExemplarWindow_Cars.Controls.Add(this.dataGridView_AddCarExemplarsWindow_Cars);
            this.groupBox_AddCarExemplarWindow_Cars.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_AddCarExemplarWindow_Cars.Location = new System.Drawing.Point(220, 12);
            this.groupBox_AddCarExemplarWindow_Cars.Name = "groupBox_AddCarExemplarWindow_Cars";
            this.groupBox_AddCarExemplarWindow_Cars.Size = new System.Drawing.Size(499, 407);
            this.groupBox_AddCarExemplarWindow_Cars.TabIndex = 0;
            this.groupBox_AddCarExemplarWindow_Cars.TabStop = false;
            this.groupBox_AddCarExemplarWindow_Cars.Text = "Автомобили";
            // 
            // dataGridView_AddCarExemplarsWindow_Cars
            // 
            this.dataGridView_AddCarExemplarsWindow_Cars.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_AddCarExemplarsWindow_Cars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AddCarExemplarsWindow_Cars.Location = new System.Drawing.Point(6, 29);
            this.dataGridView_AddCarExemplarsWindow_Cars.Name = "dataGridView_AddCarExemplarsWindow_Cars";
            this.dataGridView_AddCarExemplarsWindow_Cars.RowHeadersWidth = 51;
            this.dataGridView_AddCarExemplarsWindow_Cars.RowTemplate.Height = 29;
            this.dataGridView_AddCarExemplarsWindow_Cars.Size = new System.Drawing.Size(484, 375);
            this.dataGridView_AddCarExemplarsWindow_Cars.TabIndex = 0;
            // 
            // groupBox_AddCarExemplarWindow_CarData
            // 
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.label_AddCarExemplarWindow_YearOfAssembly);
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.textBox_AddCarExemplarWindow_YearOffAssebly_Input);
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.textBox_AddCarExemplarWindow_Price_Input);
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.label_AddCarExemplarWindow_Color);
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.textBox_AddCarWindow_IdBranch_Input);
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.label_AddCarExemplarWindow_IdCar);
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.label_AddCarExemplarWindow_Price);
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.textBox_AddCarExemplarWindow_Power_Input);
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.textBox_AddCarExemplarWindow_IdCar_Input);
            this.groupBox_AddCarExemplarWindow_CarData.Controls.Add(this.label_AddCarExemplarWindow_Power);
            this.groupBox_AddCarExemplarWindow_CarData.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_AddCarExemplarWindow_CarData.Location = new System.Drawing.Point(12, 12);
            this.groupBox_AddCarExemplarWindow_CarData.Name = "groupBox_AddCarExemplarWindow_CarData";
            this.groupBox_AddCarExemplarWindow_CarData.Size = new System.Drawing.Size(202, 361);
            this.groupBox_AddCarExemplarWindow_CarData.TabIndex = 9;
            this.groupBox_AddCarExemplarWindow_CarData.TabStop = false;
            this.groupBox_AddCarExemplarWindow_CarData.Text = "Данные экземпляра";
            // 
            // label_AddCarExemplarWindow_YearOfAssembly
            // 
            this.label_AddCarExemplarWindow_YearOfAssembly.AutoSize = true;
            this.label_AddCarExemplarWindow_YearOfAssembly.Location = new System.Drawing.Point(17, 298);
            this.label_AddCarExemplarWindow_YearOfAssembly.Name = "label_AddCarExemplarWindow_YearOfAssembly";
            this.label_AddCarExemplarWindow_YearOfAssembly.Size = new System.Drawing.Size(162, 23);
            this.label_AddCarExemplarWindow_YearOfAssembly.TabIndex = 12;
            this.label_AddCarExemplarWindow_YearOfAssembly.Text = "Дата производства";
            // 
            // textBox_AddCarExemplarWindow_YearOffAssebly_Input
            // 
            this.textBox_AddCarExemplarWindow_YearOffAssebly_Input.Location = new System.Drawing.Point(23, 324);
            this.textBox_AddCarExemplarWindow_YearOffAssebly_Input.Name = "textBox_AddCarExemplarWindow_YearOffAssebly_Input";
            this.textBox_AddCarExemplarWindow_YearOffAssebly_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_AddCarExemplarWindow_YearOffAssebly_Input.TabIndex = 11;
            // 
            // textBox_AddCarExemplarWindow_Price_Input
            // 
            this.textBox_AddCarExemplarWindow_Price_Input.Location = new System.Drawing.Point(23, 195);
            this.textBox_AddCarExemplarWindow_Price_Input.Name = "textBox_AddCarExemplarWindow_Price_Input";
            this.textBox_AddCarExemplarWindow_Price_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_AddCarExemplarWindow_Price_Input.TabIndex = 10;
            // 
            // label_AddCarExemplarWindow_Color
            // 
            this.label_AddCarExemplarWindow_Color.AutoSize = true;
            this.label_AddCarExemplarWindow_Color.Location = new System.Drawing.Point(73, 228);
            this.label_AddCarExemplarWindow_Color.Name = "label_AddCarExemplarWindow_Color";
            this.label_AddCarExemplarWindow_Color.Size = new System.Drawing.Size(48, 23);
            this.label_AddCarExemplarWindow_Color.TabIndex = 9;
            this.label_AddCarExemplarWindow_Color.Text = "Цвет";
            // 
            // textBox_AddCarWindow_IdBranch_Input
            // 
            this.textBox_AddCarWindow_IdBranch_Input.Location = new System.Drawing.Point(23, 254);
            this.textBox_AddCarWindow_IdBranch_Input.Name = "textBox_AddCarWindow_IdBranch_Input";
            this.textBox_AddCarWindow_IdBranch_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_AddCarWindow_IdBranch_Input.TabIndex = 8;
            // 
            // label_AddCarExemplarWindow_IdCar
            // 
            this.label_AddCarExemplarWindow_IdCar.AutoSize = true;
            this.label_AddCarExemplarWindow_IdCar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AddCarExemplarWindow_IdCar.Location = new System.Drawing.Point(15, 45);
            this.label_AddCarExemplarWindow_IdCar.Name = "label_AddCarExemplarWindow_IdCar";
            this.label_AddCarExemplarWindow_IdCar.Size = new System.Drawing.Size(167, 23);
            this.label_AddCarExemplarWindow_IdCar.TabIndex = 4;
            this.label_AddCarExemplarWindow_IdCar.Text = "Номер автомобиля";
            // 
            // label_AddCarExemplarWindow_Price
            // 
            this.label_AddCarExemplarWindow_Price.AutoSize = true;
            this.label_AddCarExemplarWindow_Price.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AddCarExemplarWindow_Price.Location = new System.Drawing.Point(71, 169);
            this.label_AddCarExemplarWindow_Price.Name = "label_AddCarExemplarWindow_Price";
            this.label_AddCarExemplarWindow_Price.Size = new System.Drawing.Size(51, 23);
            this.label_AddCarExemplarWindow_Price.TabIndex = 3;
            this.label_AddCarExemplarWindow_Price.Text = "Цена";
            // 
            // textBox_AddCarExemplarWindow_Power_Input
            // 
            this.textBox_AddCarExemplarWindow_Power_Input.Location = new System.Drawing.Point(23, 136);
            this.textBox_AddCarExemplarWindow_Power_Input.Name = "textBox_AddCarExemplarWindow_Power_Input";
            this.textBox_AddCarExemplarWindow_Power_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_AddCarExemplarWindow_Power_Input.TabIndex = 7;
            // 
            // textBox_AddCarExemplarWindow_IdCar_Input
            // 
            this.textBox_AddCarExemplarWindow_IdCar_Input.Location = new System.Drawing.Point(23, 73);
            this.textBox_AddCarExemplarWindow_IdCar_Input.Name = "textBox_AddCarExemplarWindow_IdCar_Input";
            this.textBox_AddCarExemplarWindow_IdCar_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_AddCarExemplarWindow_IdCar_Input.TabIndex = 6;
            // 
            // label_AddCarExemplarWindow_Power
            // 
            this.label_AddCarExemplarWindow_Power.AutoSize = true;
            this.label_AddCarExemplarWindow_Power.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AddCarExemplarWindow_Power.Location = new System.Drawing.Point(-1, 110);
            this.label_AddCarExemplarWindow_Power.Name = "label_AddCarExemplarWindow_Power";
            this.label_AddCarExemplarWindow_Power.Size = new System.Drawing.Size(197, 23);
            this.label_AddCarExemplarWindow_Power.TabIndex = 5;
            this.label_AddCarExemplarWindow_Power.Text = "Мощность автомобиля";
            // 
            // button_AddCarExemplarWindow_AddCarExemplar
            // 
            this.button_AddCarExemplarWindow_AddCarExemplar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AddCarExemplarWindow_AddCarExemplar.Location = new System.Drawing.Point(263, 425);
            this.button_AddCarExemplarWindow_AddCarExemplar.Name = "button_AddCarExemplarWindow_AddCarExemplar";
            this.button_AddCarExemplarWindow_AddCarExemplar.Size = new System.Drawing.Size(200, 35);
            this.button_AddCarExemplarWindow_AddCarExemplar.TabIndex = 10;
            this.button_AddCarExemplarWindow_AddCarExemplar.Text = "Добавить экземпляр";
            this.button_AddCarExemplarWindow_AddCarExemplar.UseVisualStyleBackColor = true;
            // 
            // AddCarExemplarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 483);
            this.Controls.Add(this.button_AddCarExemplarWindow_AddCarExemplar);
            this.Controls.Add(this.groupBox_AddCarExemplarWindow_CarData);
            this.Controls.Add(this.groupBox_AddCarExemplarWindow_Cars);
            this.Name = "AddCarExemplarWindow";
            this.ShowIcon = false;
            this.Text = "CarDealershipsSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCarExemplarWindow_FormClosing);
            this.Load += new System.EventHandler(this.AddCarExemplarWindow_Load);
            this.groupBox_AddCarExemplarWindow_Cars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddCarExemplarsWindow_Cars)).EndInit();
            this.groupBox_AddCarExemplarWindow_CarData.ResumeLayout(false);
            this.groupBox_AddCarExemplarWindow_CarData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox_AddCarExemplarWindow_Cars;
        private DataGridView dataGridView_AddCarExemplarsWindow_Cars;
        private GroupBox groupBox_AddCarExemplarWindow_CarData;
        private Label label_AddCarExemplarWindow_YearOfAssembly;
        private TextBox textBox_AddCarExemplarWindow_YearOffAssebly_Input;
        private TextBox textBox_AddCarExemplarWindow_Price_Input;
        private Label label_AddCarExemplarWindow_Color;
        private TextBox textBox_AddCarWindow_IdBranch_Input;
        private Label label_AddCarExemplarWindow_IdCar;
        private Label label_AddCarExemplarWindow_Price;
        private TextBox textBox_AddCarExemplarWindow_Power_Input;
        private TextBox textBox_AddCarExemplarWindow_IdCar_Input;
        private Label label_AddCarExemplarWindow_Power;
        private Button button_AddCarExemplarWindow_AddCarExemplar;
    }
}