using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using System.Globalization;

namespace WinFormsApp.Forms
{
    public partial class ManagerMainWindow : Form
    {
        private readonly IBranchService _branchService;
        private readonly ICarService _carService;
        private readonly ICarExemplarService _carExemplarService;
        private readonly IBuyerService _buyerService;
        private readonly IManagerService _managerService;
        private readonly ICarOrderService _carOrderService;

        private int _carsExemplarRowIndex = -1;

        public ManagerMainWindow(
            IBranchService branchService,
            ICarService carService,
            ICarExemplarService carExemplarService,
            IBuyerService buyerService,
            IManagerService managerService,
            ICarOrderService carOrderService)
        {
            _branchService = branchService;
            _carService = carService;
            _carExemplarService = carExemplarService;
            _buyerService = buyerService;
            _managerService = managerService;
            _carOrderService = carOrderService;
            InitializeComponent();
        }

        private void ManagerMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ManagerMainWindow_Load(object sender, EventArgs e)
        {
            var cars = _carService.GetCars().ToList();
            var carOrders = _carOrderService.GetCarOrders().ToList();
            var buyers = _buyerService.GetBuyers().ToList();
            Init_DataGridView_Cars(cars);
            Init_DataGridView_CarExemplars(cars);
            Init_DataGridView_ManagerMainWindow_Orders_CarOrders(carOrders);
            Init_DataGridView_ManagerMainWindow_Orders_CarExemplars(cars);
            Init_DataGridView_ManagerMainWindow_Buyers(buyers);
        }

        private void Init_DataGridView_CarExemplars(List<CarDTO> cars)
        {
            List<CarDTO> cars1 = new List<CarDTO>();
            List<CarExemplarDTO> carExemplars = new List<CarExemplarDTO>();
            List<string> branchesNames = new List<string>();
            foreach (var car in cars)
            {
                var branchById = _branchService.GetBranchById(car.IdBranch);
                var branchName = branchById.BranchName +
                    " (" + branchById.IdBranch + ")";
                foreach (var exemplar in car.CarExemplars)
                {
                    cars1.Add(car);
                    carExemplars.Add(exemplar);
                    branchesNames.Add(branchName);
                }
            }
            dataGridView_ManagerMainWindow_CarExemplars.Rows.Clear();

            dataGridView_ManagerMainWindow_CarExemplars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ManagerMainWindow_CarExemplars.AllowUserToAddRows = false;
            dataGridView_ManagerMainWindow_CarExemplars.ReadOnly = true;

            dataGridView_ManagerMainWindow_CarExemplars.ColumnCount = 9;
            dataGridView_ManagerMainWindow_CarExemplars.Columns[0].Width = 140;
            dataGridView_ManagerMainWindow_CarExemplars.Columns[1].Width = 100;
            dataGridView_ManagerMainWindow_CarExemplars.Columns[2].Width = 100;
            dataGridView_ManagerMainWindow_CarExemplars.Columns[3].Width = 100;
            dataGridView_ManagerMainWindow_CarExemplars.Columns[4].Width = 100;
            dataGridView_ManagerMainWindow_CarExemplars.Columns[5].Width = 100;
            dataGridView_ManagerMainWindow_CarExemplars.Columns[6].Width = 100;
            dataGridView_ManagerMainWindow_CarExemplars.Columns[7].Width = 200;
            dataGridView_ManagerMainWindow_CarExemplars.Columns[8].Width = 200;

            dataGridView_ManagerMainWindow_CarExemplars.Columns[0].Name = "Филиал(ID)";
            dataGridView_ManagerMainWindow_CarExemplars.Columns[1].Name = "Бренд";
            dataGridView_ManagerMainWindow_CarExemplars.Columns[2].Name = "Модель";
            dataGridView_ManagerMainWindow_CarExemplars.Columns[3].Name = "Тип кузова";
            dataGridView_ManagerMainWindow_CarExemplars.Columns[4].Name = "Мощность";
            dataGridView_ManagerMainWindow_CarExemplars.Columns[5].Name = "Цена";
            dataGridView_ManagerMainWindow_CarExemplars.Columns[6].Name = "Цвет";
            dataGridView_ManagerMainWindow_CarExemplars.Columns[7].Name = "VIN-\nномер";
            dataGridView_ManagerMainWindow_CarExemplars.Columns[8].Name = "Дата\nпроизв-ва";

            for (int i = 0; i < dataGridView_ManagerMainWindow_CarExemplars.ColumnCount; i++)
            {
                dataGridView_ManagerMainWindow_CarExemplars.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < cars1.Count(); i++)
            {
                if (dataGridView_ManagerMainWindow_CarExemplars.Rows.Count < cars1.Count())
                {
                    dataGridView_ManagerMainWindow_CarExemplars.Rows.Add();
                }
                dataGridView_ManagerMainWindow_CarExemplars.Rows[i].Cells[0].Value = branchesNames[i];
                dataGridView_ManagerMainWindow_CarExemplars.Rows[i].Cells[1].Value = cars1[i].Brand;
                dataGridView_ManagerMainWindow_CarExemplars.Rows[i].Cells[2].Value = cars1[i].Model;
                dataGridView_ManagerMainWindow_CarExemplars.Rows[i].Cells[3].Value = cars1[i].BodyType;
                dataGridView_ManagerMainWindow_CarExemplars.Rows[i].Cells[4].Value = carExemplars[i].HorsePower;
                dataGridView_ManagerMainWindow_CarExemplars.Rows[i].Cells[5].Value = carExemplars[i].Price;
                dataGridView_ManagerMainWindow_CarExemplars.Rows[i].Cells[6].Value = carExemplars[i].Color;
                dataGridView_ManagerMainWindow_CarExemplars.Rows[i].Cells[7].Value = carExemplars[i].VinNumber;
                dataGridView_ManagerMainWindow_CarExemplars.Rows[i].Cells[8].Value = carExemplars[i].YearOfAssembly;


            }

        }

        private void Init_DataGridView_Cars(List<CarDTO> cars)
        {

            List<string> branchesNames = new List<string>();
            List<int> countExemplars = new List<int>();

            foreach (var car in cars)
            {
                var branchById = _branchService.GetBranchById(car.IdBranch);
                var branchName = branchById.BranchName +
                    " (" + branchById.IdBranch + ")";
                branchesNames.Add(branchName);
                countExemplars.Add(car.CarExemplars.Count());
            }

            dataGridView_ManagerMainWindow_Cars.Rows.Clear();

            dataGridView_ManagerMainWindow_Cars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ManagerMainWindow_Cars.AllowUserToAddRows = false;
            dataGridView_ManagerMainWindow_Cars.ReadOnly = true;

            dataGridView_ManagerMainWindow_Cars.ColumnCount = 5;
            dataGridView_ManagerMainWindow_Cars.Columns[0].Width = 140;
            dataGridView_ManagerMainWindow_Cars.Columns[1].Width = 70;
            dataGridView_ManagerMainWindow_Cars.Columns[2].Width = 100;
            dataGridView_ManagerMainWindow_Cars.Columns[3].Width = 100;
            dataGridView_ManagerMainWindow_Cars.Columns[4].Width = 100;

            dataGridView_ManagerMainWindow_Cars.Columns[0].Name = "Филиал(ID)";
            dataGridView_ManagerMainWindow_Cars.Columns[1].Name = "Кол\n-во";
            dataGridView_ManagerMainWindow_Cars.Columns[2].Name = "Бренд\n(ID)";
            dataGridView_ManagerMainWindow_Cars.Columns[3].Name = "Модель";
            dataGridView_ManagerMainWindow_Cars.Columns[4].Name = "Тип кузова";

            for (int i = 0; i < dataGridView_ManagerMainWindow_Cars.ColumnCount; i++)
            {
                dataGridView_ManagerMainWindow_Cars.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < cars.Count(); i++)
            {
                if (dataGridView_ManagerMainWindow_Cars.Rows.Count < cars.Count())
                {
                    dataGridView_ManagerMainWindow_Cars.Rows.Add();
                }
                dataGridView_ManagerMainWindow_Cars.Rows[i].Cells[0].Value = branchesNames[i];
                dataGridView_ManagerMainWindow_Cars.Rows[i].Cells[1].Value = countExemplars[i];
                dataGridView_ManagerMainWindow_Cars.Rows[i].Cells[2].Value = cars[i].Brand + " (" + cars[i].IdCar + ")";
                dataGridView_ManagerMainWindow_Cars.Rows[i].Cells[3].Value = cars[i].Model;
                dataGridView_ManagerMainWindow_Cars.Rows[i].Cells[4].Value = cars[i].BodyType;
            }
        }
        
        private void Init_DataGridView_ManagerMainWindow_Orders_CarOrders(List<CarOrderDTO> carOrders)
        {
            List<CarExemplarDTO> carExemplars = new List<CarExemplarDTO>();
            List<BuyerDTO> buyers = new List<BuyerDTO>();
            List<ManagerDTO> managers = new List<ManagerDTO>();
            List<BranchDTO> branches = new List<BranchDTO>();
            var cars = _carService.GetCars().ToList();
            foreach (var carOrder in carOrders)
            {
                carExemplars.Add(_carExemplarService.GetCarExemplarByVinNumber(carOrder.VinNumber));
                buyers.Add(_buyerService.GetBuyerById(carOrder.IdBuyer));
                managers.Add(_managerService.GetManagerById(carOrder.IdMngr)); 

            }

            dataGridView_ManagerMainWindow_Orders_CarOrders.Rows.Clear();

            dataGridView_ManagerMainWindow_Orders_CarOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ManagerMainWindow_Orders_CarOrders.AllowUserToAddRows = false;
            dataGridView_ManagerMainWindow_Orders_CarOrders.ReadOnly = true;

            dataGridView_ManagerMainWindow_Orders_CarOrders.ColumnCount = 11;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[0].Width = 90;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[1].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[2].Width = 200;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[3].Width = 200;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[4].Width = 150;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[5].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[6].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[7].Width = 80;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[8].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[9].Width = 80;
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[10].Width = 100;

            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[0].Name = "ID заказа";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[1].Name = "Стоимость";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[2].Name = "ФИО покуп-\nтеля";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[3].Name = "ФИО мене-\nджера";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[4].Name = "Филиал(ID)";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[5].Name = "Дата";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[6].Name = "Бренд(ID)";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[7].Name = "Модель";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[8].Name = "VIN-номер";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[9].Name = "Цвет";
            dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[10].Name = "Мощность";

            for (int i = 0; i < dataGridView_ManagerMainWindow_Orders_CarOrders.ColumnCount; i++)
            {
                dataGridView_ManagerMainWindow_Orders_CarOrders.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < carOrders.Count(); i++)
            {
                if (dataGridView_ManagerMainWindow_Orders_CarOrders.Rows.Count < carOrders.Count())
                {
                    dataGridView_ManagerMainWindow_Orders_CarOrders.Rows.Add();
                }
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[0].Value = carOrders[i].IdOrder;
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[1].Value = carExemplars[i].Price;
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[2].Value = buyers[i].BuyerSurname + " " +
                    buyers[i].BuyerName + " " + buyers[i].BuyerMiddlename;
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[3].Value = managers[i].MngrSurname + " " +
                    managers[i].MngrName + " " + managers[i].MngrMiddlename;
                var branch1 = _branchService
                    .GetBranchById(_carService
                    .GetCarByID(Convert.ToInt32(carExemplars[i].IdCar)).IdBranch);
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[4].Value = branch1.BranchName + $" ({branch1.IdBranch})";
                    ;
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[5].Value = carOrders[i].ContractDate;
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[6].Value = cars[i].Brand + " (" + cars[i].IdCar + ")";
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[7].Value = cars[i].Model;
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[8].Value = carExemplars[i].VinNumber;
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[9].Value = carExemplars[i].Color;
                dataGridView_ManagerMainWindow_Orders_CarOrders.Rows[i].Cells[10].Value = carExemplars[i].HorsePower;

            }

        }

        private void Init_DataGridView_ManagerMainWindow_Orders_CarExemplars(List<CarDTO> cars)
        {
            List<CarDTO> cars1 = new List<CarDTO>();
            List<CarExemplarDTO> carExemplars = new List<CarExemplarDTO>();
            List<string> branchesNames = new List<string>();
            foreach (var car in cars)
            {
                var branchById = _branchService.GetBranchById(car.IdBranch);
                var branchName = branchById.BranchName +
                    " (" + branchById.IdBranch + ")";
                foreach (var exemplar in car.CarExemplars)
                {
                    cars1.Add(car);
                    carExemplars.Add(exemplar);
                    branchesNames.Add(branchName);
                }
            }
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows.Clear();

            dataGridView_ManagerMainWindow_Orders_CarExemplars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.AllowUserToAddRows = false;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.ReadOnly = true;

            dataGridView_ManagerMainWindow_Orders_CarExemplars.ColumnCount = 9;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[0].Width = 140;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[1].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[2].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[3].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[4].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[5].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[6].Width = 100;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[7].Width = 200;
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[8].Width = 200;

            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[0].Name = "Филиал(ID)";
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[1].Name = "Бренд";
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[2].Name = "Модель";
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[3].Name = "Тип кузова";
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[4].Name = "Мощность";
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[5].Name = "Цена";
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[6].Name = "Цвет";
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[7].Name = "VIN-\nномер";
            dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[8].Name = "Дата\nпроизв-ва";

            for (int i = 0; i < dataGridView_ManagerMainWindow_Orders_CarExemplars.ColumnCount; i++)
            {
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < cars1.Count(); i++)
            {
                if (dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows.Count < cars1.Count())
                {
                    dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows.Add();
                }
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows[i].Cells[0].Value = branchesNames[i];
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows[i].Cells[1].Value = cars1[i].Brand;
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows[i].Cells[2].Value = cars1[i].Model;
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows[i].Cells[3].Value = cars1[i].BodyType;
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows[i].Cells[4].Value = carExemplars[i].HorsePower;
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows[i].Cells[5].Value = carExemplars[i].Price;
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows[i].Cells[6].Value = carExemplars[i].Color;
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows[i].Cells[7].Value = carExemplars[i].VinNumber;
                dataGridView_ManagerMainWindow_Orders_CarExemplars.Rows[i].Cells[8].Value = carExemplars[i].YearOfAssembly;


            }
        }

        private void Init_DataGridView_ManagerMainWindow_Buyers(List<BuyerDTO> buyers)
        {
            dataGridView_ManagerMainWindow_Buyers.Rows.Clear();

            dataGridView_ManagerMainWindow_Buyers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_ManagerMainWindow_Buyers.AllowUserToAddRows = false;
            dataGridView_ManagerMainWindow_Buyers.ReadOnly = true;

            dataGridView_ManagerMainWindow_Buyers.ColumnCount = 4;
            dataGridView_ManagerMainWindow_Buyers.Columns[0].Width = 140;
            dataGridView_ManagerMainWindow_Buyers.Columns[1].Width = 100;
            dataGridView_ManagerMainWindow_Buyers.Columns[2].Width = 100;
            dataGridView_ManagerMainWindow_Buyers.Columns[3].Width = 100;

            dataGridView_ManagerMainWindow_Buyers.Columns[0].Name = "ID";
            dataGridView_ManagerMainWindow_Buyers.Columns[1].Name = "Пасп-е\nданные";
            dataGridView_ManagerMainWindow_Buyers.Columns[2].Name = "ФИО";
            dataGridView_ManagerMainWindow_Buyers.Columns[3].Name = "Номер\nтелефона";

            for (int i = 0; i < dataGridView_ManagerMainWindow_Buyers.ColumnCount; i++)
            {
                dataGridView_ManagerMainWindow_Buyers.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < buyers.Count(); i++)
            {
                if (dataGridView_ManagerMainWindow_Buyers.Rows.Count < buyers.Count())
                {
                    dataGridView_ManagerMainWindow_Buyers.Rows.Add();
                }
                dataGridView_ManagerMainWindow_Buyers.Rows[i].Cells[0].Value = buyers[i].IdBuyer;
                dataGridView_ManagerMainWindow_Buyers.Rows[i].Cells[1].Value = buyers[i].BuyerPassData;
                dataGridView_ManagerMainWindow_Buyers.Rows[i].Cells[2].Value = buyers[i].BuyerSurname +
                    " " + buyers[i].BuyerName + " " + buyers[i].BuyerMiddlename;
                dataGridView_ManagerMainWindow_Buyers.Rows[i].Cells[3].Value = buyers[i].BuyerPhoneNumber;
            }
        }
        private void button_ManagerMainWindow_UpdateCarCarExemplarsTable_Click(object sender, EventArgs e)
        {
            var cars = _carService.GetCars().ToList();
            Init_DataGridView_Cars(cars);
            Init_DataGridView_CarExemplars(cars);
        }

        private void button_ManagerMainWindow_SearchCar_Click(object sender, EventArgs e)
        {
            var brand = textBox_ManagerMainWindow_SearchCar_Brand_Input.Text;
            var model = textBox_ManagerMainWindow_SearchCar_Model_Input.Text;

            if (!(String.IsNullOrWhiteSpace(brand) ||
                String.IsNullOrWhiteSpace(model)))
            {
                var cars = _carService.GetCarsByBrandModel(brand, model).ToList();
                Init_DataGridView_Cars(cars);
                Init_DataGridView_CarExemplars(cars);
            }
            else
                MessageBox.Show("Не оставляйте поля пустыми.");
        }

        private void button_ManagerMainWindow_AddOrder_Click(object sender, EventArgs e)
        {
            var buyerPassData = textBox_ManagerMainWindow_BuyerPassData_Input.Text;
            var contractDate = textBox_ManagerMainWindow_ContractDate_Input.Text;
            var orderPrice = textBox_ManagerMainWindow_OrderAmount_Input.Text;
            var buyerSurname = textBox_ManagerMainWindow_BuyerSurname_Input.Text;
            var buyerName = textBox_ManagerMainWindow_BuyerName_Input.Text;
            var buyerMiddlename = textBox_ManagerMainWindow_BuyerMiddlename_Input.Text;
            var buyerPhoneNumber = textBox_ManagerMainWindow_BuyerPhoneNumber_Input.Text;
            var vinNumber = textBox_ManagerMainWindow_VinNumber_Input.Text;

            DateTime dtContractDate = new DateTime();
            decimal decOrderPrice;
            var idMngr = _managerService.GetManagerByLogPass(
                AuthorizationWindow.GetManagerLoginPassword()[0],
                AuthorizationWindow.GetManagerLoginPassword()[1]).IdMngr;
            int intIdBuyer;
            if (!(String.IsNullOrWhiteSpace(buyerPassData) ||
                String.IsNullOrWhiteSpace(contractDate)||
                String.IsNullOrWhiteSpace(orderPrice) ||
                String.IsNullOrWhiteSpace(buyerSurname) ||
                String.IsNullOrWhiteSpace(buyerName) ||
                String.IsNullOrWhiteSpace(buyerMiddlename) ||
                String.IsNullOrWhiteSpace(buyerPhoneNumber) ||
                String.IsNullOrWhiteSpace(vinNumber) 
                ))
            {
                if (buyerPassData.Length > 20 ||
                    buyerSurname.Length > 30 ||
                    buyerName.Length > 30 ||
                    buyerMiddlename.Length > 30 ||
                    buyerPhoneNumber.Length > 20 ||
                    vinNumber.Length > 17 
                    )
                {
                    MessageBox.Show("Введено слишком длинное значение.");
                    return;
                }
                //if (!_buyerService.IsBuyerExistByPassData(buyerPassData))
                //{

                //}
                //else
                //    MessageBox.Show("По этому адресу уже имеется филиал");
                if (!_buyerService.IsBuyerExistByAllData(buyerPassData, buyerSurname, buyerName, buyerMiddlename, buyerPhoneNumber))
                {
                    if (!_buyerService.AddBuyer(buyerPassData, buyerSurname, buyerName, buyerMiddlename, buyerPhoneNumber))
                    {
                        MessageBox.Show("Добавление покупателя не удалось.");
                        return;
                    }
                }
                
                if (!_carExemplarService.IsExistCarExemplarByVinNumber(vinNumber))
                {
                    MessageBox.Show("Автомобиля с таким VIN нет.");
                    return;
                }
                if (_carOrderService.IsExistCarOrderByVinNumber(vinNumber))
                {
                    MessageBox.Show("Этот автомобиль уже продан.");
                    return;
                }
                try
                {
                    dtContractDate = DateTime.Parse(contractDate);
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
                try
                {
                    if (!orderPrice.Contains(','))
                    {
                        decOrderPrice = Decimal.Parse(orderPrice, CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        MessageBox.Show("Разедлителем между целой частью числа\n и десятичной должна быть точка ('.')");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Стоимость - число.");
                    return;
                }
                intIdBuyer = _buyerService.GetBuyerByPassData(buyerPassData).IdBuyer;
                if (_carOrderService.AddCarOrder(vinNumber, idMngr, intIdBuyer, dtContractDate, decOrderPrice))
                {
                    MessageBox.Show($"Заказ добавлен.");
                }
                else
                    MessageBox.Show("Возникла ошибка при добавлении.");

            }
            else
                MessageBox.Show("Поля не должны оставаться пустыми.");
        }

        private void dataGridView_ManagerMainWindow_Orders_CarExemplars_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                _carsExemplarRowIndex = e.RowIndex;
                if (_carsExemplarRowIndex == -1)
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }
       
            List<CarExemplarDTO> carExemplars = new List<CarExemplarDTO>();
            var cars = _carService.GetCars().ToList();

            foreach (var car in cars)
            {
                foreach (var exemplar in car.CarExemplars)
                {
                    carExemplars.Add(exemplar);
                }
            }
            textBox_ManagerMainWindow_VinNumber_Input.Text = carExemplars[_carsExemplarRowIndex].VinNumber;
            textBox_ManagerMainWindow_OrderAmount_Input.Text = carExemplars[_carsExemplarRowIndex].Price.ToString();

        }
    }
}
