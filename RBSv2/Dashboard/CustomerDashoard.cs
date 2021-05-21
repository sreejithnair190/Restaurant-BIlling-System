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
    public partial class CustomerDashoard : Form
    {
        Function fn = new Function();
        String query;
        DataSet ds;

        public CustomerDashoard()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MainDashboard maindb = new MainDashboard();
            maindb.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void displayCustomers()
        {
            query = "select * from customers";
            ds = fn.getData(query);
            viewCustomersDataGridView.DataSource = ds.Tables[0];
        }

        private void CustomerDashoard_Load(object sender, EventArgs e)
        {
            displayCustomers();
        }

        private void txtSearchCustomersByID_TextChanged(object sender, EventArgs e)
        {
            txtSearchCustomerByName.Clear();
            query = "select * from customers where customer_id like '" + txtSearchCustomersByID.Text + "%'";
            DataSet ds = fn.getData(query);
            viewCustomersDataGridView.DataSource = ds.Tables[0];
        }

        private void txtSearchCustomerByName_TextChanged(object sender, EventArgs e)
        {
            txtSearchCustomersByID.Clear();
            query = "select * from customers where customer_name like '" + txtSearchCustomerByName.Text + "%'";
            DataSet ds = fn.getData(query);
            viewCustomersDataGridView.DataSource = ds.Tables[0];  
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            displayCustomers();
        }

        int id;
        private void viewCustomersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Remove Customer?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                id = int.Parse(viewCustomersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                query = "delete from customers where customer_id =" + id + "";
                fn.setData(query);

                /*
                query ="select billId from billTransactions where customerId = " + id + "";
                ds = fn.getData(query);
                int billId = int.Parse(ds.Tables[0].Rows[0][1].ToString());

                query = "delete from bills where bill_id =" + billId + "";
                fn.setData(query);
                */

                displayCustomers();
            }           
        }
    }
}
