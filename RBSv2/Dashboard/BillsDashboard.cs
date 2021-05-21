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
    public partial class BillsDashboard : Form
    {
        Function fn = new Function();
        String query;
        DataSet ds;

        public BillsDashboard()
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

        private void BillsDashboard_Load(object sender, EventArgs e)
        {
            displayBills();
        }

        private void btnSearchUser_TextChanged(object sender, EventArgs e)
        {
            query = "select * from bills where bill_id like '" + txtSearchBills.Text + "%'";
            DataSet ds = fn.getData(query);
            viewBillsDataGridView.DataSource = ds.Tables[0];
        }

        int id;
        private void viewBillsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Remove Bill?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    id = int.Parse(viewBillsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

                    query = "delete from bills where bill_id =" + id + "";
                    fn.setData(query);

                    displayBills();
                }
            }
            catch { }
        }

        public void displayBills()
        {
            query = "select * from bills";
            ds = fn.getData(query);
            viewBillsDataGridView.DataSource = ds.Tables[0];
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            displayBills();
        }

    }
}
