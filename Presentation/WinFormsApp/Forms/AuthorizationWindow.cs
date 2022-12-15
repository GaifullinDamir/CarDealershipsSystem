using CarDealershipsSystem.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AuthorizationWindow : Form
    {
        private readonly IBranchService _branchService;
        private readonly IManagerService _managerService;
        private readonly IAccountService _accountService;
        public AuthorizationWindow(
            IBranchService branchService, IManagerService managerService, IAccountService accountService)
        {
            _branchService = branchService;
            _managerService = managerService;
            _accountService = accountService;
            InitializeComponent();
        }

        private void button_AuthorizationWindow_HeadAuthorize_Click(object sender, EventArgs e)
        {
            var headLogin = textBox_AuthorizationWindow_HeadLogin_Input.Text;
            var headPassword = textBox_AuthorizationWindow_HeadPassword_Input.Text;
            var isGoToHeadMainWindow = _accountService.IsCorrectHeadAuthorizationData(headLogin, headPassword);
            if (isGoToHeadMainWindow)
            {
                HeadMainWindow headMainWindow = new HeadMainWindow(_branchService, _managerService);
                headMainWindow.Show();
                this.Hide();

            }
        }

        private void button_AuthorizationWindow_HeadRegister_Click(object sender, EventArgs e)
        {
            HeadRegisterWindow headRegisterWindow = new HeadRegisterWindow();
            headRegisterWindow.Show();
        }
    }
}
