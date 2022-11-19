using CarDealershipsSystem.DAL.Interfaces;

namespace WinFormsApp
{
    public partial class MainWindow : Form
    {
        IBranchRepository _branchRepository
        public MainWindow(IBranchRepository branchRepository)
        {
            _branchRepository = branchRepository;
            InitializeComponent();
        }

        private void button_test1_Click(object sender, EventArgs e)
        {
            var branches = _branchRepository.GetBranches();
        }
    }
}