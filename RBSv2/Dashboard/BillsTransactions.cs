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
    public partial class BillsTransactions : Form
    {
        Function fn = new Function();
        String query;
        DataSet ds;

        public BillsTransactions()
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

        public void displayTransactions()
        {
            query = "select * from billTransactions";
            ds = fn.getData(query);
            viewTransactionDataGridView.DataSource = ds.Tables[0];
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            displayTransactions();
        }

        private void BillsTransactions_Load(object sender, EventArgs e)
        {
            displayTransactions();
        }

        private void txtSearchCustomerId_TextChanged(object sender, EventArgs e)
        {
            txtSearchBillId.Clear();
            query = "select * from billTransactions where customerId like '" + txtSearchCustomerId.Text + "%'";
            DataSet ds = fn.getData(query);
            viewTransactionDataGridView.DataSource = ds.Tables[0];
        }

        private void txtSearchBillId_TextChanged(object sender, EventArgs e)
        {
            txtSearchCustomerId.Clear();
            query = "select * from billTransactions where BillId like '" + txtSearchBillId.Text + "%'";
            DataSet ds = fn.getData(query);
            viewTransactionDataGridView.DataSource = ds.Tables[0];
        }

        int id;
        private void viewTransactionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Remove Bill?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    id = int.Parse(viewTransactionDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                    query = "delete from billTransactions where TrnsId =" + id + "";
                    fn.setData(query);

                    displayTransactions();
                }
            }
            catch { }
        }
    }
}
