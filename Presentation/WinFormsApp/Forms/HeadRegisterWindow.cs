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
            long headPassData = Convert.ToInt64(textBox_HeadRegistrWindow_HeadPassData_Input.Text);
            string headName = textBox_HeadRegistrWindow_HeadName_Input.Text;
            string headSurname = textBox_HeadRegistrWindow_HeadSurname_Input.Text;
            string headMiddlename = textBox_HeadRegistrWindow_HeadMiddlename_Input.Text;
            string headPhoneNumber = textBox_HeadRegistrWindow_HeadPhoneNumber_Input.Text;
            string headLogin = textBox_HeadRegisterWindow_HeadLogin_Input.Text;
            string headPassword = textBox_HeadRegisterWindow_HeadPassword_Input.Text;
            //Проверку для все сразу через или
            var result = _accountService.RegisterHeadUser(headPassData, headName, headSurname, headMiddlename,
                headPhoneNumber, headLogin, headPassword);
            if(!result)
            {
                MessageBox.Show("Вы ввели некорректные данные");
            }
        }

        /*При нажатии на [x] окна регистрации руководителя, окно не будет закрываться, а убедт лишь прятаться*/
        private void HeadRegisterWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
