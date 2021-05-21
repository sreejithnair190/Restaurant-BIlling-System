using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBSv2.User_Controls.Items
{
    public partial class RemoveItems : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;

        public RemoveItems()
        {
            InitializeComponent();
        }

        private void txtSearchRemoveItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where item_name like '" + txtSearchRemoveItem.Text + "%'";
            ds = fn.getData(query);
            ItemsGridViewRemove.DataSource = ds.Tables[0];
        }
        public void displayItem()
        {
            //To get the database contents and display it in datagridview
            query = "select * from items";
            ds = fn.getData(query);
            ItemsGridViewRemove.DataSource = ds.Tables[0];
        }

        private void RemoveItems_Load(object sender, EventArgs e)
        {
            displayItem();
        }

        private void ItemsGridViewRemove_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Remove Item?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(ItemsGridViewRemove.Rows[e.RowIndex].Cells[0].Value.ToString());

                query = "delete from items where item_id =" + id + "";
                fn.setData(query);

                displayItem();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            displayItem();
        }
    }
}
