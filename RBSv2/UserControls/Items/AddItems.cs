using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RBSv2.User_Controls.Items
{
    public partial class AddItems : UserControl
    {
        Function fn =new Function();
        String query;
        //SqlConnection con = new SqlConnection("data source=DESKTOP-O3E46DB;integrated security=true;Initial catalog=restro");


        public AddItems()
        {
            InitializeComponent();
        }

        private void AddItems_Load(object sender, EventArgs e)
        {
            /*con.Open();
            SqlCommand cmd = new SqlCommand("select * from category", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();

            ComboBoxCategory.DataSource = ds.Tables[0];
            ComboBoxCategory.DisplayMember = "category_name";
            ComboBoxCategory.ValueMember = "category_id";*/
        }

        private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItemsToDB_Click(object sender, EventArgs e)
        {
            query = "insert into items(item_name,category,price) values('"+txtItemName.Text+ "','"+ComboBoxCategory.Text+ "',"+txtPrice.Text+")";
            fn.setData(query);
          
        }
        public void ClearAll()
        {
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
