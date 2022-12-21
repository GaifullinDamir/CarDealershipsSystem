using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using System;

using WinFormsApp.Forms;

namespace WinFormsApp
{
    public partial class HeadMainWindow : Form
    {
        private readonly IBranchService _branchService;
        private readonly IManagerService _managerService;
        private readonly IHeadService _headService;
        private readonly IAccountService _accountService;
        private readonly ICarService _carService;
        private readonly AddManagerForm _addManagerForm;
        private readonly IBranchRepository _branchRepository;

        private string _changeHeadData_ComboBoxOption;

        public HeadMainWindow(
            IBranchService branchService, IManagerService managerService,
            IHeadService headService, IAccountService accountService,
            ICarService carService, AddManagerForm addManagerForm,
            IBranchRepository branchRepository
            )
        {
            InitializeComponent();
            _branchService = branchService;
            _managerService = managerService;
            _headService = headService;
            _accountService = accountService;
            _carService = carService;
            _addManagerForm = addManagerForm;
            _branchRepository = branchRepository;
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
            var branches = _branchRepository.GetBranchesWithCarsExemplars().ToList();
            List<int> carsCount = new List<int>();
            foreach (var branch in branches)
            {
                int temp = 0;
                foreach (var car in branch.Cars)
                {
                    temp += car.CarExemplars.Count;
                }
                carsCount.Add(temp);
            }

            dataGridView_HeadMainWindow_Branches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_HeadMainWindow_Branches.AllowUserToAddRows = false;
            dataGridView_HeadMainWindow_Branches.ReadOnly = true;

            dataGridView_HeadMainWindow_Branches.ColumnCount = 4;
            dataGridView_HeadMainWindow_Branches.Columns[0].Width = 100;
            dataGridView_HeadMainWindow_Branches.Columns[1].Width = 200;
            dataGridView_HeadMainWindow_Branches.Columns[2].Width = 390;
            dataGridView_HeadMainWindow_Branches.Columns[3].Width = 130;
            dataGridView_HeadMainWindow_Branches.Columns[0].Name = "ID филиала";
            dataGridView_HeadMainWindow_Branches.Columns[1].Name = "Название филиала";
            dataGridView_HeadMainWindow_Branches.Columns[2].Name = "Адрес филиала";
            dataGridView_HeadMainWindow_Branches.Columns[3].Name = "Количество экземпляров авто";

            for (int i = 0; i < branches.Count(); i++)
            {
                if (dataGridView_HeadMainWindow_Branches.Rows.Count < branches.Count())
                {
                    dataGridView_HeadMainWindow_Branches.Rows.Add();
                }
                dataGridView_HeadMainWindow_Branches.Rows[i].Cells[0].Value = branches[i].IdBranch;
                dataGridView_HeadMainWindow_Branches.Rows[i].Cells[1].Value = branches[i].BranchName;
                dataGridView_HeadMainWindow_Branches.Rows[i].Cells[2].Value = branches[i].BranchAddress;
                dataGridView_HeadMainWindow_Branches.Rows[i].Cells[3].Value = carsCount[i];
            }

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
        private void updateData_HeadMainWindow_PersonalArea_Label()
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
        private void button_HeadMainWindow_PersonalArea_UpdateData_Click(object sender, EventArgs e)
        {
            updateData_HeadMainWindow_PersonalArea_Label();
        }

        private void comboBox_HeadMainWindow_PersonalArea_ChangeHeadData_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBoxOption = comboBox_HeadMainWindow_PersonalArea_ChangeHeadData.SelectedItem.ToString();
            if(!String.IsNullOrWhiteSpace(comboBoxOption))
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
                    updateData_HeadMainWindow_PersonalArea_Label();
                    MessageBox.Show("Данные успешно изменены.");
                }
                else
                    MessageBox.Show("Ошибка зименения данных.");
            }
            else
                MessageBox.Show("Поле данных не должно быть пустым.");
        }

        private void button_HeadMainWindow_AddBranch_Click(object sender, EventArgs e)
        {
            var branchName = textBox_HeadMainWindow_BranchName_Input.Text;
            var branchAddress = textBox_HeadMainWindow_BranchAddress_Input.Text;
            var idHead = _headService.GetHeads().FirstOrDefault().IdHead;
            if (!(String.IsNullOrWhiteSpace(branchName) || String.IsNullOrWhiteSpace(branchAddress)))
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

        private void button_HeadMainWindow_DataGridView_UpdateBranches_Click(object sender, EventArgs e)
        {
            Init_DataGridView_Branches();
        }

        private void button_HeadMainWindow_SearchBranch_Click(object sender, EventArgs e)
        {
            var branchName = textBox_HeadMainWindow_SearchByBranchName_BranchName_Input.Text;
            if (!(String.IsNullOrWhiteSpace(branchName)))
            {
                var branches = _branchService.SearchBranch(branchName).ToList();
                Init_DataGridView_Branches();
            }
            else
                MessageBox.Show("Введите имя филиала.");
            
        }

        private void button_HeadMainWindow_AddManager_Add_Click(object sender, EventArgs e)
        {
            _addManagerForm.Show();
        }
        //private void groupBox_HeadMainWindow_ChangeManagerInfo_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox1_HeadMainWindow_Cars_Enter(object sender, EventArgs e)
        //{

        //}



    }
}
