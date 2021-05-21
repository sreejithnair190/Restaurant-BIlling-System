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
    public partial class MainDashboard : Form
    {
        String userN = "";
        int userI;

        public MainDashboard()
        {
            InitializeComponent();
            PlaceOrderPanel.Hide();
        }

        public string CurrentUserN
        {
            get { return userN.ToString(); }
        }

        public int CurrentUserI
        {
            get { return userI; }
        }

        public MainDashboard(String userName,int userID)
        {
            InitializeComponent();
            /*userNameLabel.Text = userName;
            userIDLabel.Text = userID.ToString();*/

            userN = userName;
            userI = userID;

            //Passing it to View Users User Control 
            UserControls.User.ViewUsers vu = new UserControls.User.ViewUsers();
            vu.CurrentUserN = CurrentUserN;

            //Passing it to Cashier Dashboard
            CashierDashboard cd = new CashierDashboard();
            cd.CurrentUserN = CurrentUserN;
            cd.CurrentUserI = CurrentUserI;

            /*//Passing it to User Profile  User Control
            UserControls.User.UserProfile up = new UserControls.User.UserProfile();
            up.CurrentUser = CurrentUser;*/

            PlaceOrderPanel.Hide();
        }
        
        public MainDashboard(String userRole,String userName, int userID)
        {
            InitializeComponent();

            if (userRole == "Cashier")
            {
                ItemsPanel.Hide();
                CashierPanel.Hide();
                BillsPanel.Hide();
                CustomerPanel.Hide();
                TransactionPanel.Hide();
            }
            /*userNameLabel.Text = userName;
            userIDLabel.Text = userID.ToString();*/
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Dashboard.Items items = new Dashboard.Items();
            items.Show();
            this.Hide();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            Dashboard.CashierDashboard csh = new Dashboard.CashierDashboard();
            csh.Show();
            this.Hide();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            Dashboard.PlaceOrderDashboard plor = new Dashboard.PlaceOrderDashboard();
            plor.Show();
            this.Hide();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            BillsDashboard billsdb = new BillsDashboard();
            billsdb.Show();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CustomerDashoard customerdb = new CustomerDashoard();
            customerdb.Show();
            this.Hide();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            BillsTransactions billTr = new BillsTransactions();
            billTr.Show();
            this.Hide();
        }

        private void AdminDashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
