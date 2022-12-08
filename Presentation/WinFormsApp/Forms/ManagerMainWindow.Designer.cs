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
            this.tabControl_ManagerMainWindow.SuspendLayout();
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl_ManagerMainWindow;
        private TabPage tabPage_ManagerMainWindow_Cars;
        private TabPage tabPage_ManagerMainWindow_Orders;
        private TabPage tabPage_ManagerMainWindow_Buyers;
    }
}