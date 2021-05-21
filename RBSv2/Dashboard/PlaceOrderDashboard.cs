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
    public partial class PlaceOrderDashboard : Form
    {
        public PlaceOrderDashboard()
        {
            InitializeComponent();
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

        private void PlaceOrderDashboard_Load(object sender, EventArgs e)
        {

        }

        private void placeOrder1_Load(object sender, EventArgs e)
        {

        }
    }
}
