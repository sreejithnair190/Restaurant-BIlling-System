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
    public partial class UpdateUser : UserControl
    {
        Function fn = new Function();
        String query;
        DataSet ds;

        public UpdateUser()
        {
            InitializeComponent();
        }

        public void displayUser()
        {
            //To get the database contents and display it in datagridview
            query = "select * from users03";
            ds = fn.getData(query);
            viewUsersDataGridView.DataSource = ds.Tables[0];
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            displayUser();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users03 where username like '" + txtSearchUser.Text + "%'";
            DataSet ds = fn.getData(query);
            viewUsersDataGridView.DataSource = ds.Tables[0];
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            displayUser();
        }

        int id;
        private void viewUsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(viewUsersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                String role = viewUsersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                String name = viewUsersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                String dob = viewUsersDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                Int64 mobile = Int64.Parse(viewUsersDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
                String email = viewUsersDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                String pass = viewUsersDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();

                txtUserRole.Text = role;
                txtName.Text = name;
                txtDOB.Text = dob;
                txtMobile.Text = mobile.ToString();
                txtEmail.Text = email;
                txtPassword.Text = pass;
            }
            catch { }
        }

        private void btnUpdateUserToDB_Click(object sender, EventArgs e)
        {
            query = "update users03 set userRole='"+txtUserRole.Text+ "', cshname ='" + txtName.Text + "',dob='" + txtDOB.Text + "', mobile=" + txtMobile.Text + ", email='" + txtEmail.Text + "', pass='" + txtPassword.Text + "' where id =" + id + "";
            fn.setData(query);
            displayUser();
        }
    }
}
