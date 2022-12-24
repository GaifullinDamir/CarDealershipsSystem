namespace WinFormsApp.Forms
{
    partial class AddCarWindow
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
            this.dataGridView_AddCarWindow_Branches = new System.Windows.Forms.DataGridView();
            this.groupBox_AddCarWindow_Branches = new System.Windows.Forms.GroupBox();
            this.comboBox_AddCarWindow_BodyType = new System.Windows.Forms.ComboBox();
            this.label_AddCarWindow_BodyType = new System.Windows.Forms.Label();
            this.label_AddCarWindow_Brand = new System.Windows.Forms.Label();
            this.label_AddCarWindow_Model = new System.Windows.Forms.Label();
            this.textBox_AddCar_Window_Brand = new System.Windows.Forms.TextBox();
            this.textBox_AddCarWindow_Model = new System.Windows.Forms.TextBox();
            this.groupBox_AddCarWindow_CarData = new System.Windows.Forms.GroupBox();
            this.label_AddCarWindow_IdBranch = new System.Windows.Forms.Label();
            this.textBox_AddCarWindow_IdBranch_Input = new System.Windows.Forms.TextBox();
            this.button_AddCarWindow_AddCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddCarWindow_Branches)).BeginInit();
            this.groupBox_AddCarWindow_Branches.SuspendLayout();
            this.groupBox_AddCarWindow_CarData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_AddCarWindow_Branches
            // 
            this.dataGridView_AddCarWindow_Branches.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_AddCarWindow_Branches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AddCarWindow_Branches.Location = new System.Drawing.Point(6, 26);
            this.dataGridView_AddCarWindow_Branches.Name = "dataGridView_AddCarWindow_Branches";
            this.dataGridView_AddCarWindow_Branches.RowHeadersWidth = 51;
            this.dataGridView_AddCarWindow_Branches.RowTemplate.Height = 29;
            this.dataGridView_AddCarWindow_Branches.Size = new System.Drawing.Size(365, 258);
            this.dataGridView_AddCarWindow_Branches.TabIndex = 0;
            this.dataGridView_AddCarWindow_Branches.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_AddCarWindow_Branches_CellMouseClick);
            // 
            // groupBox_AddCarWindow_Branches
            // 
            this.groupBox_AddCarWindow_Branches.Controls.Add(this.dataGridView_AddCarWindow_Branches);
            this.groupBox_AddCarWindow_Branches.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_AddCarWindow_Branches.Location = new System.Drawing.Point(214, 12);
            this.groupBox_AddCarWindow_Branches.Name = "groupBox_AddCarWindow_Branches";
            this.groupBox_AddCarWindow_Branches.Size = new System.Drawing.Size(377, 290);
            this.groupBox_AddCarWindow_Branches.TabIndex = 1;
            this.groupBox_AddCarWindow_Branches.TabStop = false;
            this.groupBox_AddCarWindow_Branches.Text = "Филиалы";
            // 
            // comboBox_AddCarWindow_BodyType
            // 
            this.comboBox_AddCarWindow_BodyType.FormattingEnabled = true;
            this.comboBox_AddCarWindow_BodyType.Items.AddRange(new object[] {
            "Седан",
            "Хэтчбек",
            "Универсал",
            "Кроссовер",
            "Кабриолет"});
            this.comboBox_AddCarWindow_BodyType.Location = new System.Drawing.Point(22, 176);
            this.comboBox_AddCarWindow_BodyType.Name = "comboBox_AddCarWindow_BodyType";
            this.comboBox_AddCarWindow_BodyType.Size = new System.Drawing.Size(151, 31);
            this.comboBox_AddCarWindow_BodyType.TabIndex = 2;
            this.comboBox_AddCarWindow_BodyType.SelectedIndexChanged += new System.EventHandler(this.comboBox_AddCarWindow_BodyType_SelectedIndexChanged);
            // 
            // label_AddCarWindow_BodyType
            // 
            this.label_AddCarWindow_BodyType.AutoSize = true;
            this.label_AddCarWindow_BodyType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AddCarWindow_BodyType.Location = new System.Drawing.Point(49, 150);
            this.label_AddCarWindow_BodyType.Name = "label_AddCarWindow_BodyType";
            this.label_AddCarWindow_BodyType.Size = new System.Drawing.Size(97, 23);
            this.label_AddCarWindow_BodyType.TabIndex = 3;
            this.label_AddCarWindow_BodyType.Text = "Тип кузова";
            // 
            // label_AddCarWindow_Brand
            // 
            this.label_AddCarWindow_Brand.AutoSize = true;
            this.label_AddCarWindow_Brand.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AddCarWindow_Brand.Location = new System.Drawing.Point(15, 26);
            this.label_AddCarWindow_Brand.Name = "label_AddCarWindow_Brand";
            this.label_AddCarWindow_Brand.Size = new System.Drawing.Size(165, 23);
            this.label_AddCarWindow_Brand.TabIndex = 4;
            this.label_AddCarWindow_Brand.Text = "Марка автомобиля";
            // 
            // label_AddCarWindow_Model
            // 
            this.label_AddCarWindow_Model.AutoSize = true;
            this.label_AddCarWindow_Model.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_AddCarWindow_Model.Location = new System.Drawing.Point(10, 91);
            this.label_AddCarWindow_Model.Name = "label_AddCarWindow_Model";
            this.label_AddCarWindow_Model.Size = new System.Drawing.Size(176, 23);
            this.label_AddCarWindow_Model.TabIndex = 5;
            this.label_AddCarWindow_Model.Text = "Модель автомобиля";
            // 
            // textBox_AddCar_Window_Brand
            // 
            this.textBox_AddCar_Window_Brand.Location = new System.Drawing.Point(23, 54);
            this.textBox_AddCar_Window_Brand.Name = "textBox_AddCar_Window_Brand";
            this.textBox_AddCar_Window_Brand.Size = new System.Drawing.Size(150, 30);
            this.textBox_AddCar_Window_Brand.TabIndex = 6;
            // 
            // textBox_AddCarWindow_Model
            // 
            this.textBox_AddCarWindow_Model.Location = new System.Drawing.Point(23, 117);
            this.textBox_AddCarWindow_Model.Name = "textBox_AddCarWindow_Model";
            this.textBox_AddCarWindow_Model.Size = new System.Drawing.Size(150, 30);
            this.textBox_AddCarWindow_Model.TabIndex = 7;
            // 
            // groupBox_AddCarWindow_CarData
            // 
            this.groupBox_AddCarWindow_CarData.Controls.Add(this.label_AddCarWindow_IdBranch);
            this.groupBox_AddCarWindow_CarData.Controls.Add(this.textBox_AddCarWindow_IdBranch_Input);
            this.groupBox_AddCarWindow_CarData.Controls.Add(this.label_AddCarWindow_Brand);
            this.groupBox_AddCarWindow_CarData.Controls.Add(this.comboBox_AddCarWindow_BodyType);
            this.groupBox_AddCarWindow_CarData.Controls.Add(this.label_AddCarWindow_BodyType);
            this.groupBox_AddCarWindow_CarData.Controls.Add(this.textBox_AddCarWindow_Model);
            this.groupBox_AddCarWindow_CarData.Controls.Add(this.textBox_AddCar_Window_Brand);
            this.groupBox_AddCarWindow_CarData.Controls.Add(this.label_AddCarWindow_Model);
            this.groupBox_AddCarWindow_CarData.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox_AddCarWindow_CarData.Location = new System.Drawing.Point(12, 12);
            this.groupBox_AddCarWindow_CarData.Name = "groupBox_AddCarWindow_CarData";
            this.groupBox_AddCarWindow_CarData.Size = new System.Drawing.Size(196, 290);
            this.groupBox_AddCarWindow_CarData.TabIndex = 8;
            this.groupBox_AddCarWindow_CarData.TabStop = false;
            this.groupBox_AddCarWindow_CarData.Text = "Данные автомобиля";
            // 
            // label_AddCarWindow_IdBranch
            // 
            this.label_AddCarWindow_IdBranch.AutoSize = true;
            this.label_AddCarWindow_IdBranch.Location = new System.Drawing.Point(28, 218);
            this.label_AddCarWindow_IdBranch.Name = "label_AddCarWindow_IdBranch";
            this.label_AddCarWindow_IdBranch.Size = new System.Drawing.Size(140, 23);
            this.label_AddCarWindow_IdBranch.TabIndex = 9;
            this.label_AddCarWindow_IdBranch.Text = "Номер филиала";
            // 
            // textBox_AddCarWindow_IdBranch_Input
            // 
            this.textBox_AddCarWindow_IdBranch_Input.Location = new System.Drawing.Point(23, 244);
            this.textBox_AddCarWindow_IdBranch_Input.Name = "textBox_AddCarWindow_IdBranch_Input";
            this.textBox_AddCarWindow_IdBranch_Input.Size = new System.Drawing.Size(150, 30);
            this.textBox_AddCarWindow_IdBranch_Input.TabIndex = 8;
            // 
            // button_AddCarWindow_AddCar
            // 
            this.button_AddCarWindow_AddCar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_AddCarWindow_AddCar.Location = new System.Drawing.Point(210, 315);
            this.button_AddCarWindow_AddCar.Name = "button_AddCarWindow_AddCar";
            this.button_AddCarWindow_AddCar.Size = new System.Drawing.Size(200, 35);
            this.button_AddCarWindow_AddCar.TabIndex = 9;
            this.button_AddCarWindow_AddCar.Text = "Добавить автомобиль";
            this.button_AddCarWindow_AddCar.UseVisualStyleBackColor = true;
            this.button_AddCarWindow_AddCar.Click += new System.EventHandler(this.button_AddCarWindow_AddCar_Click);
            // 
            // AddCarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 363);
            this.Controls.Add(this.button_AddCarWindow_AddCar);
            this.Controls.Add(this.groupBox_AddCarWindow_CarData);
            this.Controls.Add(this.groupBox_AddCarWindow_Branches);
            this.Name = "AddCarWindow";
            this.Text = "AddCarWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCarWindow_FormClosing);
            this.Load += new System.EventHandler(this.AddCarWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AddCarWindow_Branches)).EndInit();
            this.groupBox_AddCarWindow_Branches.ResumeLayout(false);
            this.groupBox_AddCarWindow_CarData.ResumeLayout(false);
            this.groupBox_AddCarWindow_CarData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_AddCarWindow_Branches;
        private GroupBox groupBox_AddCarWindow_Branches;
        private ComboBox comboBox_AddCarWindow_BodyType;
        private Label label_AddCarWindow_BodyType;
        private Label label_AddCarWindow_Brand;
        private Label label_AddCarWindow_Model;
        private TextBox textBox_AddCar_Window_Brand;
        private TextBox textBox_AddCarWindow_Model;
        private GroupBox groupBox_AddCarWindow_CarData;
        private Label label_AddCarWindow_IdBranch;
        private TextBox textBox_AddCarWindow_IdBranch_Input;
        private Button button_AddCarWindow_AddCar;
    }
}