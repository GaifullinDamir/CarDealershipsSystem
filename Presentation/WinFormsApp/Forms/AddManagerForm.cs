using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp.Forms
{
    public partial class AddManagerForm : Form
    {
        private readonly IManagerService _managerService;
        private readonly IBranchService _branchService;
        private int rowIndex = -1;
        public AddManagerForm(IManagerService managerService,
            IBranchService branchService)
        {
            _managerService = managerService;
            InitializeComponent();
            _branchService = branchService;
        }

        private void button_AddManagerForm_UpdateBranches_Click(object sender, EventArgs e)
        {
            Initialize_dataGridView_AddManagerForm_Branches();
        }

        private void button_AddManagerWindow_AddManager_Click(object sender, EventArgs e)
        {
            var idBranch = "";

            idBranch = textBox_AddManagerForm_IdBranch_Input.Text;

            var mngrPassData = textBox_AddManagerWindow_MngrPassData_Input.Text;
            
            var mngrSurname = textBox_AddManagerWindow_MngrSurname_Input.Text;
            var mngrName = textBox_AddManagerWindow_MngrName_Input.Text;
            var mngrMiddlename = textBox_AddManagerWindow_MngrMiddlename_Input.Text;
            var mngrPhoneNumber = textBox_AddManagerWindow_MngrPhoneNumber_Input.Text;
            var mngrSalary = textBox_AddManagerWindow_MngrSalary_Input.Text;
            var mngrPayDate = textBox_AddManagerWindow_MngrPayDate_Input.Text;
            var managerPassword = textBox_AddManagerForm_MngrPassword_Input.Text;
            var managerLogin = textBox_AddManagerWindow_MngrLogin_Input.Text;

            int intIdBranch = 0;
            decimal decMngrSalary = 0;
            DateTime dateMngrPayDate = new DateTime();
            
            if (!(String.IsNullOrWhiteSpace(mngrPassData) ||
                String.IsNullOrWhiteSpace(idBranch)||
                String.IsNullOrWhiteSpace(mngrSurname)||
                String.IsNullOrWhiteSpace(mngrName)||
                String.IsNullOrWhiteSpace(mngrMiddlename)||
                String.IsNullOrWhiteSpace(mngrPhoneNumber)||
                String.IsNullOrWhiteSpace(mngrSalary)||
                String.IsNullOrWhiteSpace(mngrPayDate)||
                String.IsNullOrWhiteSpace(managerPassword)||
                String.IsNullOrWhiteSpace(managerLogin)))
            {

                if (_managerService.IsManagerDataNotUnique(mngrPassData, mngrPhoneNumber, managerLogin, managerPassword))
                {
                    MessageBox.Show("Менеджер с подобными данными уже существует.");
                }
                else
                {
                    try
                    {
                        intIdBranch = Convert.ToInt32(idBranch);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ID филиала - целое число.");
                        return;
                    }

                    try
                    {
                        if (!mngrSalary.Contains(','))
                        {
                            decMngrSalary = Decimal.Parse(mngrSalary, CultureInfo.InvariantCulture);
                        }
                        else 
                        {
                            MessageBox.Show("Разедлителем между целой частью числа\n и десятичной должна быть точка ('.')");
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Зарплата - число.");
                        return;
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
                        return;
                    }


                    if (!_managerService.AddManager(mngrPassData, intIdBranch, mngrSurname, mngrName, mngrMiddlename,
                        mngrPhoneNumber, decMngrSalary, dateMngrPayDate, managerPassword, managerLogin))
                    {
                        MessageBox.Show("Произошла ошибка при добавлении");
                    }
                    else
                    {
                        MessageBox.Show($"Менеджер {mngrName} успешно добавлен в базу данных.");
                    }
                }
                
            }
            else
                MessageBox.Show("Поля не должны оставаться пустыми.");
        }

        private void AddManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void AddManagerForm_Load(object sender, EventArgs e)
        {
            Initialize_dataGridView_AddManagerForm_Branches();
        }

        private void Initialize_dataGridView_AddManagerForm_Branches()
        {
            var branches = _branchService.GetBranches().ToList();

            dataGridView_AddManagerForm_Branches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_AddManagerForm_Branches.AllowUserToAddRows = false;
            dataGridView_AddManagerForm_Branches.ReadOnly = true;

            dataGridView_AddManagerForm_Branches.Rows.Clear();
            dataGridView_AddManagerForm_Branches.ColumnCount = 3;
            dataGridView_AddManagerForm_Branches.Columns[0].Name = "ID филиала";
            dataGridView_AddManagerForm_Branches.Columns[1].Name = "Имя филиала";
            dataGridView_AddManagerForm_Branches.Columns[2].Name = "Адрес филиала";
            dataGridView_AddManagerForm_Branches.Columns[0].Width = 100;
            dataGridView_AddManagerForm_Branches.Columns[1].Width = 300;
            dataGridView_AddManagerForm_Branches.Columns[2].Width = 450;

            for (int i = 0; i < branches.Count(); i++)
            {
                if (dataGridView_AddManagerForm_Branches.Rows.Count < branches.Count())
                {
                    dataGridView_AddManagerForm_Branches.Rows.Add();
                }
                dataGridView_AddManagerForm_Branches.Rows[i].Cells[0].Value = branches[i].IdBranch.ToString();
                dataGridView_AddManagerForm_Branches.Rows[i].Cells[1].Value = branches[i].BranchName;
                dataGridView_AddManagerForm_Branches.Rows[i].Cells[2].Value = branches[i].BranchAddress;
            }
        }

        //private void dataGridView_AddManagerForm_Branches_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
            
        //}

        private void dataGridView_AddManagerForm_Branches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowIndex = e.RowIndex;
                if (rowIndex != -1)
                {
                    textBox_AddManagerForm_IdBranch_Input.Text = dataGridView_AddManagerForm_Branches
                    .Rows[rowIndex]
                    .Cells[0]
                    .Value
                    .ToString();
                } 
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
