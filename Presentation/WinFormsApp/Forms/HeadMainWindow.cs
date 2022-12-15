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
    public partial class HeadMainWindow : Form
    {
        private readonly IBranchService _branchService;
        private readonly IManagerService _managerService;
        public HeadMainWindow(IBranchService branchService, IManagerService managerService)
        {
            _branchService = branchService;
            _managerService = managerService;
            InitializeComponent();
        }

        //private void tabControl_HeadMainWindow_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void groupBox_HeadMainWindow_Managers_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox4_HeadMainWindow_AddManager_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox3_HeadMainWindow_DeleteManager_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox2_HeadMainWindow_SearchManager_Enter(object sender, EventArgs e)
        //{

        //}

        private void HeadMainWindow_Load(object sender, EventArgs e)
        {
            Init_DataGridView_Branches();
            Init_DataGridView_Managers();
        }

        private void Init_DataGridView_Branches()
        {
            dataGridView_HeadMainWindow_Branches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_HeadMainWindow_Branches.AllowUserToAddRows = false;
            dataGridView_HeadMainWindow_Branches.ReadOnly = true;
            //dataGridView_HeadMainWindow_Branches.ColumnCount = 3;
            dataGridView_HeadMainWindow_Branches.DataSource = _branchService.GetBranches().ToList();
            dataGridView_HeadMainWindow_Branches.Columns[0].Width = 80;
            dataGridView_HeadMainWindow_Branches.Columns[1].Width = 100;
            dataGridView_HeadMainWindow_Branches.Columns[2].Width = 140;
            dataGridView_HeadMainWindow_Branches.Columns[0].HeaderText = "ID филиала";
            dataGridView_HeadMainWindow_Branches.Columns[1].HeaderText = "Название филиала";
            dataGridView_HeadMainWindow_Branches.Columns[2].HeaderText = "Адрес филиала";
        }

        private void Init_DataGridView_Managers()
        {
            dataGridView_HeadMainWindow_Managers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_HeadMainWindow_Managers.AllowUserToAddRows= false;
            dataGridView_HeadMainWindow_Managers.ReadOnly = true;
            dataGridView_HeadMainWindow_Managers.DataSource = _managerService.GetManagers().ToList();

        }

        private void HeadMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        //private void groupBox_HeadMainWindow_ChangeManagerInfo_Enter(object sender, EventArgs e)
        //{

        //}

        //private void groupBox1_HeadMainWindow_Cars_Enter(object sender, EventArgs e)
        //{

        //}



    }
}
