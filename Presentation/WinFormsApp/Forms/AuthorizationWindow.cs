using CarDealershipsSystem.Application.Interfaces;
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
            if (!(String.IsNullOrWhiteSpace(headLogin) || String.IsNullOrWhiteSpace(headPassword)))
            {
                var isGoToHeadMainWindow = _accountService.IsCorrectHeadAuthorizationData(headLogin, headPassword);
                if (isGoToHeadMainWindow)
                {
                    _headMainWindow.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Авторизационные данные не верны.");
            }
            else
                MessageBox.Show("Не оставляйте поля пустыми.");

            
        }

        private void button_AuthorizationWindow_HeadRegister_Click(object sender, EventArgs e)
        {
            if (!_accountService.IsHeadAccountExist())
            { _headRegisterWindow.Show(); }
            else
                MessageBox.Show("Аккаунт уже создан.");
            
        }
    }
}
