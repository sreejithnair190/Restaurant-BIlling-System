using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBSv2.Login
{
    public partial class Login : Form
    {

        Function fn = new Function();
        String query;
        DataSet ds;

        public Login()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Return Button
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        protected void btnCashierLogin_Click(object sender, EventArgs e)
        {
            query = "select * from users03";
            ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No User Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "select * from users03 where username='" + txtCashierUsername.Text + "' and pass='" + txtCashierPassword.Text + "'";
                ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {

                    //Extracting User Role
                    String role = ds.Tables[0].Rows[0][1].ToString();
                    //Extracting User ID
                    int userID = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                    if (role == "Cashier")
                    {
                        /*Dashboard.MainDashboard dashboard = new Dashboard.MainDashboard("Cashier",txtCashierUsername.Text, userID);
                        dashboard.Show();
                        this.Hide();*/

                        Dashboard.PlaceOrderDashboard plor = new Dashboard.PlaceOrderDashboard();
                        plor.Show();
                        this.Hide();
                    }
                    else if(role=="Admin")
                    {
                        Dashboard.MainDashboard dashboard = new Dashboard.MainDashboard(txtCashierUsername.Text,userID);
                        dashboard.Show();
                        this.Hide();
                    }    
                }
                else
                {
                    MessageBox.Show("No User Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCashierPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCashierUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
