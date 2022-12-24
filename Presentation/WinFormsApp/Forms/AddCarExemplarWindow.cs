using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using System.Globalization;

namespace WinFormsApp.Forms
{
    public partial class AddCarExemplarWindow : Form
    {
        private readonly IBranchRepository _branchRepository;
        private readonly ICarService _carService;
        private readonly IBranchService _branchService;
        private readonly ICarExemplarService _carExemplarService;

        private int carsRowIndex = -1;
        public AddCarExemplarWindow(IBranchRepository branchRepository,
            ICarService carService,
            IBranchService branchService,
            ICarExemplarService carExemplarService)
        {
            _branchRepository = branchRepository;
            _carService = carService;
            _branchService = branchService;
            InitializeComponent();
            _carExemplarService = carExemplarService;
        }

        private void AddCarExemplarWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void AddCarExemplarWindow_Load(object sender, EventArgs e)
        {
            var cars = _carService.GetCars().ToList();
            Init_DataGridView_AddCarExemplarsWindow_Cars(cars);
        }

        private void Init_DataGridView_AddCarExemplarsWindow_Cars(List<CarDTO> cars)
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

            dataGridView_AddCarExemplarsWindow_Cars.Rows.Clear();

            dataGridView_AddCarExemplarsWindow_Cars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_AddCarExemplarsWindow_Cars.AllowUserToAddRows = false;
            dataGridView_AddCarExemplarsWindow_Cars.ReadOnly = true;

            dataGridView_AddCarExemplarsWindow_Cars.ColumnCount = 5;
            dataGridView_AddCarExemplarsWindow_Cars.Columns[0].Width = 140;
            dataGridView_AddCarExemplarsWindow_Cars.Columns[1].Width = 70;
            dataGridView_AddCarExemplarsWindow_Cars.Columns[2].Width = 100;
            dataGridView_AddCarExemplarsWindow_Cars.Columns[3].Width = 100;
            dataGridView_AddCarExemplarsWindow_Cars.Columns[4].Width = 100;

            dataGridView_AddCarExemplarsWindow_Cars.Columns[0].Name = "Филиал(ID)";
            dataGridView_AddCarExemplarsWindow_Cars.Columns[1].Name = "Кол\n-во";
            dataGridView_AddCarExemplarsWindow_Cars.Columns[2].Name = "Бренд\n(ID)";
            dataGridView_AddCarExemplarsWindow_Cars.Columns[3].Name = "Модель";
            dataGridView_AddCarExemplarsWindow_Cars.Columns[4].Name = "Тип кузова";

            for (int i = 0; i < dataGridView_AddCarExemplarsWindow_Cars.ColumnCount; i++)
            {
                dataGridView_AddCarExemplarsWindow_Cars.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < cars.Count(); i++)
            {
                if (dataGridView_AddCarExemplarsWindow_Cars.Rows.Count < cars.Count())
                {
                    dataGridView_AddCarExemplarsWindow_Cars.Rows.Add();
                }
                dataGridView_AddCarExemplarsWindow_Cars.Rows[i].Cells[0].Value = branchesNames[i];
                dataGridView_AddCarExemplarsWindow_Cars.Rows[i].Cells[1].Value = countExemplars[i];
                dataGridView_AddCarExemplarsWindow_Cars.Rows[i].Cells[2].Value = cars[i].Brand + " (" + cars[i].IdCar + ")";
                dataGridView_AddCarExemplarsWindow_Cars.Rows[i].Cells[3].Value = cars[i].Model;
                dataGridView_AddCarExemplarsWindow_Cars.Rows[i].Cells[4].Value = cars[i].BodyType;
            }
        }

        private void dataGridView_AddCarExemplarsWindow_Cars_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                carsRowIndex = e.RowIndex;
                if (carsRowIndex == -1)
                {
                    return;
                }
            }
            catch (Exception)
            {
                return;
            }
            var cars = _carService.GetCars().ToList();
            var idCar = cars[carsRowIndex].IdCar;
            textBox_AddCarExemplarWindow_IdCar_Input.Text = idCar.ToString();
        }

        private void button_AddCarExemplarWindow_AddCarExemplar_Click(object sender, EventArgs e)
        {
            var idCar = textBox_AddCarExemplarWindow_IdCar_Input.Text;
            var carPower = textBox_AddCarExemplarWindow_Power_Input.Text;
            var carPrice = textBox_AddCarExemplarWindow_Price_Input.Text;
            var carColor = textBox_AddCarExemplarWindow_CarColor_Input.Text;
            var yearOfAssembly = textBox_AddCarExemplarWindow_YearOffAssebly_Input.Text;
            var vinNumber = textBox_AddCarExemplarWindow_VinNumber_Input.Text;

            int intIdCar;
            int intCarPower;
            decimal decCarPrice;
            DateTime dateYearOfAssembly = new DateTime();
            string errorMessage = "";

            if (!(String.IsNullOrWhiteSpace(idCar) ||
            String.IsNullOrWhiteSpace(carPower) ||
            String.IsNullOrWhiteSpace(carPrice) ||
            String.IsNullOrWhiteSpace(carColor)||
            String.IsNullOrWhiteSpace(yearOfAssembly)||
            String.IsNullOrWhiteSpace(vinNumber)
                ))
            {
                try
                {
                    intIdCar = Convert.ToInt32(idCar);
                }
                catch (Exception)
                {
                    MessageBox.Show("ID машины - число!");
                    return;
                }
                try
                {
                    intCarPower = Convert.ToInt32(carPower);
                }
                catch (Exception)
                {
                    MessageBox.Show("Мощность машины - число!");
                    return;
                }

                try
                {
                    if (!carPrice.Contains(','))
                    {
                        decCarPrice = Decimal.Parse(carPrice, CultureInfo.InvariantCulture);
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
                    dateYearOfAssembly = DateTime.Parse(yearOfAssembly);
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
                if (_carExemplarService.AddCarExemplar(vinNumber, intIdCar, intCarPower,
                    decCarPrice, carColor, dateYearOfAssembly, ref errorMessage))
                {
                    MessageBox.Show("Автомобиль добавлен в филиал.");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            else
            {
                MessageBox.Show("Поля не должны оставаться пустыми.");
                return;
            }
        }
    }
}
