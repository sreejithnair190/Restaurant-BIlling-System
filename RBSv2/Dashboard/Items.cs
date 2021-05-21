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
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Return to admin Dashboard
            Dashboard.MainDashboard amdb = new Dashboard.MainDashboard();
            amdb.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            addItems1.Visible = true;
            addItems1.BringToFront();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            addItems1.Visible = false;
            updateItems1.Visible = false;
            removeItems1.Visible = false;
        }

        private void btnUpdateItems_Click(object sender, EventArgs e)
        {
            updateItems1.Visible = true;
            updateItems1.BringToFront();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            removeItems1.Visible = true;
            removeItems1.BringToFront();
        }
    }
}
