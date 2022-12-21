using CarDealershipsSystem.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Forms
{
    public partial class AddManagerForm : Form
    {
        private readonly IManagerService _managerService;
        public AddManagerForm(IManagerService managerService)
        {
            _managerService = managerService;
            InitializeComponent();
        }

        private void button_AddManagerForm_UpdateBranches_Click(object sender, EventArgs e)
        {

        }

        private void button_AddManagerWindow_AddManager_Click(object sender, EventArgs e)
        {
            var mngrPassData = textBox_AddManagerForm_MngrPassword_Input.Text;
            var idBranch = textBox_AddManagerForm_IdBranch_Input.Text;
            var mngrSurname = textBox_AddManagerWindow_MngrSurname_Input.Text;
            var mngrName = textBox_AddManagerWindow_MngrName_Input.Text;
            var mngrMiddlename = textBox_AddManagerWindow_MngrMiddlename_Input.Text;
            var mngrPhoneNumber = textBox_AddManagerWindow_MngrPhoneNumber_Input.Text;
            var mngrSalary = textBox_AddManagerWindow_MngrSalary_Input.Text;
            var mngrPayDate = textBox_AddManagerWindow_MngrPayDate_Input.Text;
            if (!(String.IsNullOrWhiteSpace(mngrPassData) ||
                String.IsNullOrWhiteSpace(idBranch)||
                String.IsNullOrWhiteSpace(mngrSurname)||
                String.IsNullOrWhiteSpace(mngrName)||
                String.IsNullOrWhiteSpace(mngrMiddlename)||
                String.IsNullOrWhiteSpace(mngrPhoneNumber)||
                String.IsNullOrWhiteSpace(mngrSalary)||
                String.IsNullOrWhiteSpace(mngrPayDate)))
            {
                if (_branchService.AddBranch(branchName, branchAddress, idHead))
                {
                    MessageBox.Show($"Филиал {branchName} добавлен успешно.");
                }
                else
                    MessageBox.Show("ВОзникла ошибка при добавлении.");
            }
            else
                MessageBox.Show("Поля не должны оставаться пустыми.");
        }
    }
}
