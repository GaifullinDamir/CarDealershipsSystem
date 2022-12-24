using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

namespace WinFormsApp.Forms
{
    public partial class ManagerMainWindow : Form
    {
        private readonly IBranchService _branchService;
        private readonly ICarService _carService;

        public ManagerMainWindow(
            IBranchService branchService,
            ICarService carService)
        {
            _branchService = branchService;
            _carService = carService;
            InitializeComponent();
        }

        private void ManagerMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void ManagerMainWindow_Load(object sender, EventArgs e)
        {
            var cars = _carService.GetCars().ToList();
            Init_DataGridView_Cars(cars);
            Init_DataGridView_CarExemplars(cars);
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

        private void button_ManagerMainWindow_UpdateCarCarExemplarsTable_Click(object sender, EventArgs e)
        {
            var cars = _carService.GetCars().ToList();
            Init_DataGridView_Cars(cars);
            Init_DataGridView_CarExemplars(cars);
        }
    }
}
