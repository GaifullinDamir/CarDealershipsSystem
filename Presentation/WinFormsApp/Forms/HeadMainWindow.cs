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
        private readonly AddCarWindow _addCarWindow;

        private string _changeHeadData_ComboBoxOption;
        private string _changeManagerInfo_ComboBoxOption;
        private int managersRowIndex = -1;

        public HeadMainWindow(
            IBranchService branchService, IManagerService managerService,
            IHeadService headService, IAccountService accountService,
            ICarService carService, AddManagerForm addManagerForm,
            IBranchRepository branchRepository, AddCarWindow addCarWindow
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
            _addCarWindow = addCarWindow;
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
            var branches = _branchService.GetBranches().ToList();
            var managers = _managerService.GetManagers().ToList();
            var cars = _carService.GetCars().ToList();
            Init_DataGridView_Branches(branches);
            Init_DataGridView_Managers(managers);
            Init_DataGridView_Cars(cars);
        }

        private void Init_DataGridView_Branches(List<BranchDTO> branches)
        {
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
            dataGridView_HeadMainWindow_Branches.Rows.Clear();

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

            for (int i = 0; i < dataGridView_HeadMainWindow_Branches.ColumnCount; i++)
            {
                dataGridView_HeadMainWindow_Branches.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

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

        private void Init_DataGridView_Managers(List<ManagerDTO> managers)
        {
            dataGridView_HeadMainWindow_Managers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_HeadMainWindow_Managers.AllowUserToAddRows= false;
            dataGridView_HeadMainWindow_Managers.ReadOnly = true;

            List<int> carOrdersCount = new List<int>();
            List<string> managersBranches = new List<string>();

            foreach (var manager in managers)
            {
                carOrdersCount.Add(manager.CarOrders.Count());
                managersBranches.Add(_branchService.GetBranchById(manager.IdBranch).BranchName);
            }
            //for (int i = 0; i < managers.Count(); i++)
            //{
            //    carOrdersCount.Add(managers[i].CarOrders.Count());

            //    managersBranches.Add(_branchService
            //        .GetBranchById(managers[i].IdBranch)
            //        .BranchName);
            //}

            dataGridView_HeadMainWindow_Managers.Rows.Clear();

            dataGridView_HeadMainWindow_Managers.ColumnCount = 12;
            dataGridView_HeadMainWindow_Managers.Columns[0].Width = 100;
            dataGridView_HeadMainWindow_Managers.Columns[1].Width = 100;
            dataGridView_HeadMainWindow_Managers.Columns[2].Width = 100;
            dataGridView_HeadMainWindow_Managers.Columns[3].Width = 120;
            dataGridView_HeadMainWindow_Managers.Columns[4].Width = 120;
            dataGridView_HeadMainWindow_Managers.Columns[5].Width = 100;
            dataGridView_HeadMainWindow_Managers.Columns[6].Width = 100;
            dataGridView_HeadMainWindow_Managers.Columns[7].Width = 70;
            dataGridView_HeadMainWindow_Managers.Columns[8].Width = 120;
            dataGridView_HeadMainWindow_Managers.Columns[9].Width = 100;
            dataGridView_HeadMainWindow_Managers.Columns[10].Width = 120;
            dataGridView_HeadMainWindow_Managers.Columns[11].Width = 100;
                                        
            dataGridView_HeadMainWindow_Managers.Columns[0].Name = "Фамилия";
            dataGridView_HeadMainWindow_Managers.Columns[1].Name = "Имя";
            dataGridView_HeadMainWindow_Managers.Columns[2].Name = "Отчество";
            dataGridView_HeadMainWindow_Managers.Columns[3].Name = "Филиал";
            dataGridView_HeadMainWindow_Managers.Columns[4].Name = "Паспортные\nданные";

            dataGridView_HeadMainWindow_Managers.Columns[5].Name = "Логин";
            dataGridView_HeadMainWindow_Managers.Columns[6].Name = "Пароль";
            dataGridView_HeadMainWindow_Managers.Columns[7].Name = "Cдеки";
            dataGridView_HeadMainWindow_Managers.Columns[8].Name = "Номер\nтелефона";
            dataGridView_HeadMainWindow_Managers.Columns[9].Name = "Зарплата";
            dataGridView_HeadMainWindow_Managers.Columns[10].Name = "Дата\nзарплаты";
            dataGridView_HeadMainWindow_Managers.Columns[11].Name = "Премия";

            for (int i = 0; i < dataGridView_HeadMainWindow_Managers.ColumnCount; i++)
            {
                dataGridView_HeadMainWindow_Managers.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < managers.Count(); i++)
            {
                if (dataGridView_HeadMainWindow_Managers.Rows.Count < managers.Count())
                {
                    dataGridView_HeadMainWindow_Managers.Rows.Add();
                }
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[0].Value = managers[i].MngrSurname;
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[1].Value = managers[i].MngrName;
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[2].Value = managers[i].MngrMiddlename;
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[3].Value = managersBranches[i];
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[4].Value = managers[i].MngrPassData;
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[5].Value = managers[i].ManagerLogin;
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[6].Value = managers[i].ManagerPassword;
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[7].Value = carOrdersCount[i];
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[8].Value = managers[i].MngrPhoneNumber;
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[9].Value = managers[i].MngrSalary;
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[10].Value = managers[i].MngrPayDate;
                dataGridView_HeadMainWindow_Managers.Rows[i].Cells[11].Value = managers[i].MngrPrize;
            }


        }

        private void Init_DataGridView_Cars(List<CarDTO> cars)
        {
            List<CarDTO> cars1 = new List<CarDTO>();
            List<CarExemplarDTO> carExemplars = new List<CarExemplarDTO>();
            foreach (var car in cars)
            {
                foreach (var exemplar in car.CarExemplars)
                {
                    cars1.Add(car);
                    carExemplars.Add(exemplar);
                }
            }
            dataGridView_HeadMainWindow_Cars.Rows.Clear();

            dataGridView_HeadMainWindow_Cars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_HeadMainWindow_Cars.AllowUserToAddRows = false;
            dataGridView_HeadMainWindow_Cars.ReadOnly = true;

            dataGridView_HeadMainWindow_Cars.ColumnCount = 8;
            dataGridView_HeadMainWindow_Cars.Columns[0].Width = 100;
            dataGridView_HeadMainWindow_Cars.Columns[1].Width = 100;
            dataGridView_HeadMainWindow_Cars.Columns[2].Width = 100;
            dataGridView_HeadMainWindow_Cars.Columns[3].Width = 100;
            dataGridView_HeadMainWindow_Cars.Columns[4].Width = 100;
            dataGridView_HeadMainWindow_Cars.Columns[5].Width = 100;
            dataGridView_HeadMainWindow_Cars.Columns[6].Width = 200;
            dataGridView_HeadMainWindow_Cars.Columns[7].Width = 200;

            dataGridView_HeadMainWindow_Cars.Columns[0].Name = "Бренд";
            dataGridView_HeadMainWindow_Cars.Columns[1].Name = "Модель";
            dataGridView_HeadMainWindow_Cars.Columns[2].Name = "Тип кузова";
            dataGridView_HeadMainWindow_Cars.Columns[3].Name = "Мощность";
            dataGridView_HeadMainWindow_Cars.Columns[4].Name = "Цена";
            dataGridView_HeadMainWindow_Cars.Columns[5].Name = "Цвет";
            dataGridView_HeadMainWindow_Cars.Columns[6].Name = "VIN-\nномер";
            dataGridView_HeadMainWindow_Cars.Columns[7].Name = "Дата\nпроизв-ва";

            for (int i = 0; i < dataGridView_HeadMainWindow_Cars.ColumnCount; i++)
            {
                dataGridView_HeadMainWindow_Cars.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < cars1.Count(); i++)
            {
                if (dataGridView_HeadMainWindow_Cars.Rows.Count < cars1.Count())
                {
                    dataGridView_HeadMainWindow_Cars.Rows.Add();
                }
                dataGridView_HeadMainWindow_Cars.Rows[i].Cells[0].Value = cars1[i].Brand;
                dataGridView_HeadMainWindow_Cars.Rows[i].Cells[1].Value = cars1[i].Model;
                dataGridView_HeadMainWindow_Cars.Rows[i].Cells[2].Value = cars1[i].BodyType;
                dataGridView_HeadMainWindow_Cars.Rows[i].Cells[3].Value = carExemplars[i].HorsePower;
                dataGridView_HeadMainWindow_Cars.Rows[i].Cells[4].Value = carExemplars[i].Price;
                dataGridView_HeadMainWindow_Cars.Rows[i].Cells[5].Value = carExemplars[i].Color;
                dataGridView_HeadMainWindow_Cars.Rows[i].Cells[6].Value = carExemplars[i].VinNumber;
                dataGridView_HeadMainWindow_Cars.Rows[i].Cells[7].Value = carExemplars[i].YearOfAssembly;


            }

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
                if (!_branchService.IsBranchExistByNameOrByAddress(branchAddress))
                {
                    if (_branchService.AddBranch(branchName, branchAddress, idHead))
                    {
                        MessageBox.Show($"Филиал {branchName} добавлен успешно.");
                    }
                    else
                        MessageBox.Show("Возникла ошибка при добавлении.");
                }
                else
                    MessageBox.Show("По этому адресу уже имеется филиал");
                
            }
            else
                MessageBox.Show("Поля не должны оставаться пустыми.");
           
        }

        private void button_HeadMainWindow_DataGridView_UpdateBranches_Click(object sender, EventArgs e)
        {
            var branches = _branchService.GetBranches().ToList();
            Init_DataGridView_Branches(branches);
        }

        private void button_HeadMainWindow_SearchBranch_Click(object sender, EventArgs e)
        {
            var branchName = textBox_HeadMainWindow_SearchByBranchName_BranchName_Input.Text;
            if (!(String.IsNullOrWhiteSpace(branchName)))
            {
                var branches = _branchService.SearchBranch(branchName).ToList();
                Init_DataGridView_Branches(branches);
            }
            else
                MessageBox.Show("Введите имя филиала.");
        }

        private void button_HeadMainWindow_AddManager_Add_Click(object sender, EventArgs e)
        {
            _addManagerForm.Show();
        }

        private void HeadMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView_HeadMainWindow_Managers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                managersRowIndex = e.RowIndex;
                if (managersRowIndex == -1)
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }

            var managers = _managerService.GetManagers().ToList();
            var mngrSurname = managers[managersRowIndex].MngrSurname;
            var mngrName = managers[managersRowIndex].MngrName;
            var mngrMiddlename = managers[managersRowIndex].MngrMiddlename;

            label_HeadMainWindow_ChangeManager_MngrNameSurnameMiddlename.Text = mngrSurname + "\n" + mngrName + "\n" + mngrMiddlename;
            label_HeadMainWindow_ChangeManager_MngrPassData.Text = managers[managersRowIndex].MngrPassData;
        }

        private void button_HeadMainWindow_ChangeManagerInfo_Change_Click(object sender, EventArgs e)
        {
            string mngrPassData = "";
            if (managersRowIndex != -1)
            {
                var managers = _managerService.GetManagers().ToList();
                mngrPassData = managers[managersRowIndex].MngrPassData;
                
            }
            else
                return;

            var inputData = textBox_HeadMainWindow_NewManagerIfno_Input.Text;
            string errorMessage = "Ошибка при изменении.";
            if (!String.IsNullOrWhiteSpace(inputData))
            {
                if (_managerService.ManagerChangeData(_changeManagerInfo_ComboBoxOption,
                    mngrPassData, inputData, ref errorMessage))
                {
                    
                    MessageBox.Show("Данные успешно изменены.");
                }
                else
                    MessageBox.Show(errorMessage);
            }
            else
                MessageBox.Show("Поле данных не должно быть пустым.");

        }

        private void comboBox_HeadMainWindow_ChangeManagerInfo_Change_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBoxOption = comboBox_HeadMainWindow_ChangeManagerInfo_Change.SelectedItem.ToString();
            if (!String.IsNullOrWhiteSpace(comboBoxOption))
            {
                _changeManagerInfo_ComboBoxOption = comboBoxOption;
            }
        }

        private void button_HeadMainWindow_DataGridView_UpdateManagers_Click(object sender, EventArgs e)
        {
            var managers = _managerService.GetManagers().ToList();
            Init_DataGridView_Managers(managers);
        }

        private void button_HeadMainWindow_SearchManager_Search_Click(object sender, EventArgs e)
        {
            var mngrPassData = textBox_HeadMainWIndow_SearchManager_MngrPassData_Input.Text;

            if (!String.IsNullOrWhiteSpace(mngrPassData))
            {
                List<ManagerDTO> managers = new List<ManagerDTO>();
                var manager = _managerService.GetManagerByPassData(mngrPassData);
                if (manager != null)
                {
                    managers.Add(manager);
                }
               
                Init_DataGridView_Managers(managers);
            }
            else
                MessageBox.Show("Поля не должны оставаться пустыми.");
        }

        private void button_HeadMainWindow_DataGridView_Cars_Update_Click(object sender, EventArgs e)
        {
            var cars = _carService.GetCars().ToList();
            Init_DataGridView_Cars(cars);
        }

        private void button_HeadMainWindow_AddCar_Click(object sender, EventArgs e)
        {
            _addCarWindow.Show();
        }
    }
}
