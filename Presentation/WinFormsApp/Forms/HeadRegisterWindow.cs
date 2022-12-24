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
    public partial class HeadRegisterWindow : Form
    {
        private readonly IAccountService _accountService;
        public HeadRegisterWindow(IAccountService accountService)
        {
            _accountService = accountService;
            InitializeComponent();
        }

        private void HeadRegisterWindow_Load(object sender, EventArgs e)
        {

        }

        private void button_HeadRegisterWindow_Register_Click(object sender, EventArgs e)
        {
            if (!_accountService.IsHeadAccountExist())
            {
                string headPassData = textBox_HeadRegistrWindow_HeadPassData_Input.Text;
                string headName = textBox_HeadRegistrWindow_HeadName_Input.Text;
                string headSurname = textBox_HeadRegistrWindow_HeadSurname_Input.Text;
                string headMiddlename = textBox_HeadRegistrWindow_HeadMiddlename_Input.Text;
                string headPhoneNumber = textBox_HeadRegistrWindow_HeadPhoneNumber_Input.Text;
                string headLogin = textBox_HeadRegisterWindow_HeadLogin_Input.Text;
                string headPassword = textBox_HeadRegisterWindow_HeadPassword_Input.Text;
                if (!(
                    String.IsNullOrWhiteSpace(headPassData) ||
                    String.IsNullOrWhiteSpace(headName) ||
                    String.IsNullOrWhiteSpace(headSurname) ||
                    String.IsNullOrWhiteSpace(headMiddlename) ||
                    String.IsNullOrWhiteSpace(headPhoneNumber) ||
                    String.IsNullOrWhiteSpace(headLogin) ||
                    String.IsNullOrWhiteSpace(headPassword)
                    ))
                {
                    if (headPassData.Length > 20 ||
                        headName.Length > 30 ||
                        headSurname.Length > 30 ||
                        headMiddlename.Length > 30 ||
                        headPhoneNumber.Length > 20 ||
                        headLogin.Length > 20 ||
                        headPassword.Length > 20
                        )
                    {
                        MessageBox.Show("Слишком длинное значение.");
                        return;
                    }
                    var result = _accountService.RegisterHeadUser(headPassData, headName, headSurname, headMiddlename,
                    headPhoneNumber, headLogin, headPassword);
                    if (!result)
                    {
                        MessageBox.Show("Вы ввели некорректные данные");
                    }
                    else
                        MessageBox.Show("Аккаунт создан.");
                }
                else
                    MessageBox.Show("Поля не должны оставаться пустыми.");
            }

            else
                MessageBox.Show("Аккаунт уже создан.");

            
        }

        /*При нажатии на [x] окна регистрации руководителя, окно не будет закрываться, а убедт лишь прятаться*/
        private void HeadRegisterWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
