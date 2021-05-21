using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBSv2.User_Controls.Cashier
{
    public partial class AddCashier : UserControl
    {
        Function fn = new Function();
        String query;

        public AddCashier()
        {
            InitializeComponent();
        }

        private void btnAddCashierToDB_Click(object sender, EventArgs e)
        {
            //Get those valuse from Textbox
            String role = txtUserRole.Text;
            String name = txtCashierName.Text;
            String dob = txtDOB.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            String email = txtEmail.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            try
            {
                query = "insert into users03(userRole,cshname,dob,mobile,email,username,pass) values('"+role+"','" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + password + "')";
                fn.setData(query);
            }
            catch (Exception)
            {
                MessageBox.Show("Username Already Exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void ClearAll()
        {
            txtCashierName.Clear();
            txtDOB.ResetText();
            txtEmail.Clear();
            txtMobileNo.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users03 where username='" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count==0)
            {
                Validate.ImageLocation = @"D:\Project\RBS\Files\images\right.png";
            }
            else
            {
                Validate.ImageLocation = @"D:\Project\RBS\Files\images\wrong.jpg";
            }
        }
    }
}
