using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBSv2.UserControls.User
{
    public partial class ViewUsers : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;
        String CurrentUserName;

        public ViewUsers()
        {
            InitializeComponent();
        }

        public string CurrentUserN
        {
            set { CurrentUserName = value; }
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            query = "select * from users03";
            ds = fn.getData(query);
            viewUsersDataGridView.DataSource = ds.Tables[0];
        }

        private void btnSearchUser_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users03 where username like '" + btnSearchUser.Text + "%'";
            DataSet ds = fn.getData(query);
            viewUsersDataGridView.DataSource = ds.Tables[0];
        }

        String username;
        private void viewUsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                username = viewUsersDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch 
            { }
        }

        private void btnDeleteUserFromDB_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ARE YOU SURE?", "CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            { 
                if (CurrentUserName != username)
                {
                    query = "delete from users03 where username ='" + username + "'";
                    fn.setData(query);
                    ViewUsers_Load(this,null);
                }
                else
                {
                    MessageBox.Show("YOU ARE TRYING TO DELETE \nYOUR OWN ACCOUNT", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ViewUsers_Load(this, null);
        }

        private void viewUsersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
