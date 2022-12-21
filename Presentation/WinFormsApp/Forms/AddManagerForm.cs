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

            int intIdBranch = 0;
            decimal decMngrSalary = 0;
            DateTime dateMngrPayDate;
            
            if (!(String.IsNullOrWhiteSpace(mngrPassData) ||
                String.IsNullOrWhiteSpace(idBranch)||
                String.IsNullOrWhiteSpace(mngrSurname)||
                String.IsNullOrWhiteSpace(mngrName)||
                String.IsNullOrWhiteSpace(mngrMiddlename)||
                String.IsNullOrWhiteSpace(mngrPhoneNumber)||
                String.IsNullOrWhiteSpace(mngrSalary)||
                String.IsNullOrWhiteSpace(mngrPayDate)))
            {
                try
                {
                    intIdBranch = Convert.ToInt32(idBranch);
                }
                catch (Exception)
                {
                    MessageBox.Show("ID филиала - целое число.");
                }

                try
                {
                    if (!mngrSalary.Contains(','))
                    {
                        decMngrSalary = Convert.ToDecimal(mngrSalary);
                    }
                    else
                        MessageBox.Show("Разедлителем между целой частью числа\n и десятичной должна быть точка ('.')");
                }
                catch (Exception)
                {
                    MessageBox.Show("Зарплата - число.");
                }

                try
                {
                    dateMngrPayDate = DateTime.Parse(mngrPayDate);
                }
                catch (Exception)
                {
                    MessageBox.Show("Формат записи даты:\n" +
                        "yyyy.mm.dd\n" +
                        "mm.dd.yyyy\n" +
                        "yyyy-mm-dd\n" +
                        "yyyy/mm/dd");
                }
            }
            else
                MessageBox.Show("Поля не должны оставаться пустыми.");
        }


    }
}
