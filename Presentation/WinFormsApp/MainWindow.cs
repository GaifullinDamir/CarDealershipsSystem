using CarDealershipsSystem.Domain;
using CarDealershipsSystem.Application.Interfaces;

namespace WinFormsApp
{
    public partial class MainWindow : Form
    {
        private readonly IBranchService _branchService;
        private readonly IBuyerService _buyerService;
        private readonly ICarExemplarService _carExemplarService;
        private readonly ICarOrderService _carOrderService;
        private readonly ICarService _carService;
        private readonly IManagerService _managerService;

        public MainWindow
            (IBranchService branchService
            , IBuyerService buyerService
            , ICarExemplarService carExemplarService
            , ICarOrderService carOrderService
            , ICarService carService
            , IManagerService managerService
            )
        {
            InitializeComponent();
            _branchService = branchService;
            _buyerService = buyerService;
            _carExemplarService = carExemplarService;
            _carOrderService = carOrderService;
            _carService = carService;
            _managerService = managerService;
        }

        private void button_test1_Click(object sender, EventArgs e)
        {
            var branches = _branchService.GetBranches();
            var buyers = _buyerService.GetBuyers();
            var carExemplars = _carExemplarService.GetCarExemplars();
            var carOrders = _carOrderService.GetCarOrders();
            var carServices = _carService.GetCars();
            var managerServices = _managerService.GetManagers();
        }
    }
}