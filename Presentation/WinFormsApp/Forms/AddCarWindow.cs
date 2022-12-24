using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;

namespace WinFormsApp.Forms
{
    public partial class AddCarWindow : Form
    {
        private readonly IBranchService _branchService;
        private readonly ICarService _carService;
        private string _bodyType_comboBoxOption = "";
        private int _branchRowIndex = -1;
        public AddCarWindow(IBranchService branchService,
            ICarService carService)
        {
            _branchService = branchService;
            _carService = carService;
            InitializeComponent();
        }

        private void AddCarWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Init_DataGridView_AddCarWindow_Branches(List<BranchDTO> branches)
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

            dataGridView_AddCarWindow_Branches.Rows.Clear();
            
            dataGridView_AddCarWindow_Branches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_AddCarWindow_Branches.AllowUserToAddRows = false;
            dataGridView_AddCarWindow_Branches.ReadOnly = true;
            
            dataGridView_AddCarWindow_Branches.ColumnCount = 4;
            dataGridView_AddCarWindow_Branches.Columns[0].Width = 100;
            dataGridView_AddCarWindow_Branches.Columns[1].Width = 200;
            dataGridView_AddCarWindow_Branches.Columns[2].Width = 390;
            dataGridView_AddCarWindow_Branches.Columns[3].Width = 130;
            dataGridView_AddCarWindow_Branches.Columns[0].Name = "ID филиала";
            dataGridView_AddCarWindow_Branches.Columns[1].Name = "Название филиала";
            dataGridView_AddCarWindow_Branches.Columns[2].Name = "Адрес филиала";
            dataGridView_AddCarWindow_Branches.Columns[3].Name = "Количество экземпляров авто";

            for (int i = 0; i < dataGridView_AddCarWindow_Branches.ColumnCount; i++)
            {
                dataGridView_AddCarWindow_Branches.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            for (int i = 0; i < branches.Count(); i++)
            {
                if (dataGridView_AddCarWindow_Branches.Rows.Count < branches.Count())
                {
                    dataGridView_AddCarWindow_Branches.Rows.Add();
                }
                dataGridView_AddCarWindow_Branches.Rows[i].Cells[0].Value = branches[i].IdBranch;
                dataGridView_AddCarWindow_Branches.Rows[i].Cells[1].Value = branches[i].BranchName;
                dataGridView_AddCarWindow_Branches.Rows[i].Cells[2].Value = branches[i].BranchAddress;
                dataGridView_AddCarWindow_Branches.Rows[i].Cells[3].Value = carsCount[i];
            }
        }

        private void AddCarWindow_Load(object sender, EventArgs e)
        {
            var branches = _branchService.GetBranches().ToList();
            Init_DataGridView_AddCarWindow_Branches(branches);
        }

        private void button_AddCarWindow_AddCar_Click(object sender, EventArgs e)
        {
            var brand = textBox_AddCar_Window_Brand.Text;
            var model = textBox_AddCarWindow_Model.Text;
            var bodyType = _bodyType_comboBoxOption;
       
            var idBranch = textBox_AddCarWindow_IdBranch_Input.Text;
            int intIdBranch; 
            if (!(String.IsNullOrWhiteSpace(brand) ||
            String.IsNullOrWhiteSpace(model) ||
            String.IsNullOrWhiteSpace(bodyType) ||
            String.IsNullOrWhiteSpace(idBranch)
                ))
            {
                try
                {
                    intIdBranch = Convert.ToInt32(idBranch);
                }
                catch (Exception)
                {
                    MessageBox.Show("ID филиала - число!");
                    return;
                }
                if (_carService.AddCar(brand, model, bodyType, intIdBranch))
                {
                    MessageBox.Show("Автомобиль добавлен в филиал.");
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении.");
                }
            }
            else
            {
                MessageBox.Show("Поля не должны оставаться пустыми.");
                return;
            }
        }

        private void dataGridView_AddCarWindow_Branches_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                _branchRowIndex = e.RowIndex;
                if (!(_branchRowIndex == -1))
                {
                    var branches = _branchService.GetBranches().ToList();
                    textBox_AddCarWindow_IdBranch_Input.Text = branches[_branchRowIndex].IdBranch.ToString();
                }
                return;

            }
            catch (Exception)
            {
                return;
            }
        }

        private void comboBox_AddCarWindow_BodyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBoxOption = comboBox_AddCarWindow_BodyType.SelectedItem.ToString();
            if (!String.IsNullOrWhiteSpace(comboBoxOption))
            {
                _bodyType_comboBoxOption = comboBoxOption;
            }
        }
    }
}
