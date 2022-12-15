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
using WinFormsApp.Forms;

namespace WinFormsApp
{
    public partial class AuthorizationWindow : Form

    {
        
        private readonly IAccountService _accountService;
        private readonly HeadMainWindow _headMainWindow;
        private readonly ManagerMainWindow _managerMainWindow;
        private readonly HeadRegisterWindow _headRegisterWindow;
        public AuthorizationWindow(
            IAccountService accountService
            , HeadMainWindow headMainWindow, ManagerMainWindow managerMainWindow, HeadRegisterWindow headRegisterWindow)
        {
            _accountService = accountService;
            _headMainWindow = headMainWindow;
            _managerMainWindow = managerMainWindow;
            _headRegisterWindow = headRegisterWindow;
            InitializeComponent();
        }

        

        private void button_AuthorizationWindow_HeadAuthorize_Click(object sender, EventArgs e)
        {
            var headLogin = textBox_AuthorizationWindow_HeadLogin_Input.Text;
            var headPassword = textBox_AuthorizationWindow_HeadPassword_Input.Text;
            var isGoToHeadMainWindow = _accountService.IsCorrectHeadAuthorizationData(headLogin, headPassword);
            if (isGoToHeadMainWindow)
            {
                _headMainWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Авторизационные данные не верны.");
            }
        }

        private void button_AuthorizationWindow_HeadRegister_Click(object sender, EventArgs e)
        {
            _headRegisterWindow.Show();
        }
    }
}
