using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;

namespace WinFormsApp.Forms
{
    public partial class AddCarExemplarWindow : Form
    {
        private readonly IBranchRepository _branchRepository;
        private readonly ICarService _carService;
        private readonly IBranchService _branchService;
        public AddCarExemplarWindow(IBranchRepository branchRepository,
            ICarService carService,
            IBranchService branchService)
        {
            _branchRepository = branchRepository;
            _carService = carService;
            _branchService = branchService;
            InitializeComponent();
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
    }
}
