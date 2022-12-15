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
        public HeadRegisterWindow()
        {
            InitializeComponent();
        }

        private void HeadRegisterWindow_Load(object sender, EventArgs e)
        {

        }

        private void button_HeadRegisterWindow_Register_Click(object sender, EventArgs e)
        {

        }

        /*При нажатии на [x] окна регистрации руководителя, окно не будет закрываться, а убедт лишь прятаться*/
        private void HeadRegisterWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
