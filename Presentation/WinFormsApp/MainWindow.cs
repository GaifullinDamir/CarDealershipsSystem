using CarDealershipsSystem.Domain;
using CarDealershipsSystem.Application.Interfaces;

namespace WinFormsApp
{
    public partial class MainWindow : Form
    {
        private readonly IBranchService _branchService;
        public MainWindow(IBranchService branchService)
        {
            _branchService = branchService;
            InitializeComponent();
        }

        private void button_test1_Click(object sender, EventArgs e)
        {
            var branches = _branchService.GetBranches();
        }
    }
}