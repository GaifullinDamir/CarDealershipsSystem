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
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void button_AuthorizationWindow_HeadAuthorize_Click(object sender, EventArgs e)
        {

        }

        private void button_AuthorizationWindow_HeadRegister_Click(object sender, EventArgs e)
        {
            HeadRegisterWindow headRegisterWindow = new HeadRegisterWindow();
            headRegisterWindow.Show();
        }
    }
}
