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

namespace WinFormsApp
{
    public partial class HeadMainWindow : Form
    {
        private readonly IBranchService _branchService;
        private readonly IManagerService _managerService;
        private readonly IHeadService _headService;
        private readonly IAccountService _accountService;

        private string _changeHeadData_ComboBoxOption;

        public HeadMainWindow(
            IBranchService branchService, IManagerService managerService,
            IHeadService headService, IAccountService accountService
            )
        {
            InitializeComponent();
            _branchService = branchService;
            _managerService = managerService;
            _headService = headService;
            _accountService = accountService;
      
        }

        //private void tabControl_HeadMainWindow_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void groupBox_HeadMainWindow_Managers_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox4_HeadMainWindow_AddManager_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox3_HeadMainWindow_DeleteManager_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox2_HeadMainWindow_SearchManager_Enter(object sender, EventArgs e)
        //{

        //}

        private void HeadMainWindow_Load(object sender, EventArgs e)
        {
            Init_DataGridView_Branches();
            Init_DataGridView_Managers();
        }

        private void Init_DataGridView_Branches()
        {
            dataGridView_HeadMainWindow_Branches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_HeadMainWindow_Branches.AllowUserToAddRows = false;
            dataGridView_HeadMainWindow_Branches.ReadOnly = true;
            //dataGridView_HeadMainWindow_Branches.ColumnCount = 3;
            dataGridView_HeadMainWindow_Branches.DataSource = _branchService.GetBranches().ToList();
            dataGridView_HeadMainWindow_Branches.Columns[0].Width = 80;
            dataGridView_HeadMainWindow_Branches.Columns[1].Width = 100;
            dataGridView_HeadMainWindow_Branches.Columns[2].Width = 140;
            dataGridView_HeadMainWindow_Branches.Columns[0].HeaderText = "ID филиала";
            dataGridView_HeadMainWindow_Branches.Columns[1].HeaderText = "Название филиала";
            dataGridView_HeadMainWindow_Branches.Columns[2].HeaderText = "Адрес филиала";
        }

        private void Init_DataGridView_Managers()
        {
            dataGridView_HeadMainWindow_Managers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_HeadMainWindow_Managers.AllowUserToAddRows= false;
            dataGridView_HeadMainWindow_Managers.ReadOnly = true;
            dataGridView_HeadMainWindow_Managers.DataSource = _managerService.GetManagers().ToList();

        }

        private void HeadMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button_HeadMainWindow_PersonalArea_UpdateData_Click(object sender, EventArgs e)
        {
            var head = _headService.GetHeads().ToList();
            label_HeadMainWindow_PeronalArea_HeadPassPata.Text =
                "Паспортные данные:    " + head[0].HeadPassData;
            label_HeadMainWindow_PersonalArea_HeadName.Text =
                "Имя:    " + head[0].HeadName;
            label_HeadMainWindow_PersonalArea_HeadSurname.Text =
                "Фамилия:    " + head[0].HeadSurname;
            label_HeadMainWindow_PersonalArea_HeadMiddlename.Text =
                "Отчество:    " + head[0].HeadMiddlename;
            label_HeadMainWindow_PersonalArea_HeadPhoneNumber.Text =
                "Номер телефона:    " + head[0].HeadPhoneNumber;
            label_HeadMainWindow_PersonalArea_HeadLogin.Text =
                "Логин:    " + head[0].HeadLogin;
            label_HeadMainWindow_PersonalArea_HeadPassword.Text =
                "Пароль:    " + head[0].HeadPassword;

        }

        private void comboBox_HeadMainWindow_PersonalArea_ChangeHeadData_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBoxOption = comboBox_HeadMainWindow_PersonalArea_ChangeHeadData.SelectedItem.ToString();
            if(String.IsNullOrWhiteSpace(comboBoxOption))
            {
                _changeHeadData_ComboBoxOption = comboBoxOption;
            }
            
        }

        private void button_HeadMainWindow_PersonalArea_ChahngeHeadData_Change_Click(object sender, EventArgs e)
        {
            var inputData = textBox_HeadMainWindow_PersonalArea_ChangeHeadData_Input.Text;
            if (!String.IsNullOrWhiteSpace(inputData))
            {
                if (_accountService.HeadChangeData(_changeHeadData_ComboBoxOption, inputData))
                {
                    MessageBox.Show("Данные успешно изменены.");
                }
                else
                    MessageBox.Show("Ошибка зименения данных.");
            }
            else
                MessageBox.Show("Поле данных не должно быть пустым.");
        }
        //private void groupBox_HeadMainWindow_ChangeManagerInfo_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox1_HeadMainWindow_Cars_Enter(object sender, EventArgs e)
        //{

        //}



    }
}
