using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBSv2.Dashboard
{
    public partial class CashierDashboard : Form
    {
        String CurrentUserName="";
        int CurrentUserId;

        public CashierDashboard()
        {
            InitializeComponent();
        }

        public string CurrentUserN
        {
            set { CurrentUserName = value; }
        }

        public int CurrentUserI
        {
            set { CurrentUserId = value; }
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            addCashier2.Visible = false;
            viewUsers1.Visible = false;
            updateUser1.Visible = false;
        }

        private void btnAddCashier_Click(object sender, EventArgs e)
        {
            addCashier2.Visible = true;
            addCashier2.BringToFront();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Dashboard.MainDashboard amdb = new Dashboard.MainDashboard(CurrentUserName,CurrentUserId);
            amdb.Show();
            this.Hide();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            viewUsers1.Visible = true;
            viewUsers1.BringToFront();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            updateUser1.Visible = true;
            updateUser1.BringToFront();
        }
    }
}
