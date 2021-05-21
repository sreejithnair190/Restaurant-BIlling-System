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
    public partial class UpdateItems : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        public UpdateItems()
        {
            InitializeComponent();
        }

        private void UpdateItems_Load(object sender, EventArgs e)
        {
            displayItem();
        }
        public void displayItem()
        {
            //To get the database contents and display it in datagridview
            query = "select * from items";
            ds = fn.getData(query);
            ItemsGridViewUpdate.DataSource = ds.Tables[0];
        }

        private void txtSearchItemName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where item_name like '" + txtSearchItemName.Text + "%'";
            DataSet ds = fn.getData(query);
            ItemsGridViewUpdate.DataSource = ds.Tables[0];
        }

        int id;
        private void ItemsGridViewUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(ItemsGridViewUpdate.Rows[e.RowIndex].Cells[0].Value.ToString());
            String name = ItemsGridViewUpdate.Rows[e.RowIndex].Cells[1].Value.ToString();
            String category = ItemsGridViewUpdate.Rows[e.RowIndex].Cells[2].Value.ToString();
            int price = int.Parse(ItemsGridViewUpdate.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtItemName.Text = name;
            txtCategory.Text = category;
            txtPrice.Text = price.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update items set item_name ='" + txtItemName.Text + "',category='" + txtCategory.Text + "',price=" + txtPrice.Text + " where item_id =" + id + "";
            fn.setData(query);
            displayItem();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            displayItem();
        }
    }
}
