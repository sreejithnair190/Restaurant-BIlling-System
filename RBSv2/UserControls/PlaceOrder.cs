using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace RBSv2.User_Controls
{
    public partial class PlaceOrder : UserControl
    {   
        
        Function fn = new Function();
        String query;
        
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void ComboBoxPlaceOrderCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = ComboBoxPlaceOrderCategory.Text;
            query = "Select item_name from items where category='" + category + "'";
            showItemsList(query);
        }

        public void showItemsList(String query)
        {
            itemsListBox.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                itemsListBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String category = ComboBoxPlaceOrderCategory.Text;
            query = "Select item_name from items where category='" + category + "' and item_name like '" + txtSearch.Text + "%'";
            showItemsList(query);
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuantityUpDown.ResetText();
            txtTotal.Clear();

            String text = itemsListBox.GetItemText(itemsListBox.SelectedItem);
            txtItemName.Text = text;

            query = "select price from items where item_name = '" + text + "'";
            DataSet ds = fn.getData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }

        }

        private void QuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 quantity = Int64.Parse(QuantityUpDown.Value.ToString());
                Int64 price = Int64.Parse(txtPrice.Text);
                txtTotal.Text = (quantity * price).ToString();
            }
            catch
            {
                MessageBox.Show("Select An Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected int n, total = 0;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = CartGridView.Rows.Add();
                CartGridView.Rows[n].Cells[0].Value = txtItemName.Text;
                CartGridView.Rows[n].Cells[1].Value = txtPrice.Text;
                CartGridView.Rows[n].Cells[2].Value = QuantityUpDown.Value;
                CartGridView.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);

                GrandTotal(total);
            }
            else
            {
                MessageBox.Show("Minimum Quantity must be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int amount;
        private void CartGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(CartGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            try
            {
                CartGridView.Rows.RemoveAt(this.CartGridView.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            GrandTotal(total);
            
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GrandTotal(total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            CartGridView.Rows.Clear();
            labelGrandTotal.Text = "Rs. 0" + total;
        }

        public void GrandTotal(int total)
        {
            //Getting The Value
            double discount = double.Parse(txtDiscount.Text);
            double SGST = double.Parse(txtSGST.Text);
            double CGST = double.Parse(txtCGST.Text);

            //Final Discount And Tax
            double finaldiscount = total * (discount / 100);
            double fianlTax = total * ((SGST/100) + (CGST/100));

            //Calculating GrandTotal
            double GrandTotal = total + fianlTax - finaldiscount;
            labelGrandTotal.Text = "Rs. " + GrandTotal;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = printer.Footer = "Discount : " + txtDiscount.Text + "\nCGST : "+txtCGST.Text+ "\nSGST : " + txtSGST.Text + "\nTotal Amount : " + labelGrandTotal.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(CartGridView);
            transactionDatabase();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {           
            try
            {
                billsDatabase();
                customerDatabase();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Fill All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void customerDatabase()
        {
            //Getting The Values
            String CustomerName = txtCustomerName.Text;
            Int64 CustomerPhonenum = Int64.Parse(txtCustomerPhoneNumber.Text);
            String CustomerAddress = txtCustomerAddress.Text;

            //Enter values into database table
            query = "insert into customers(customer_name,phone_number,address,date_and_time) values('" + CustomerName+ "',"+CustomerPhonenum+ ",'" + CustomerAddress+ "','"+DateTime.Now+"')";
            fn.setData(query);
        }
        
        public void billsDatabase()
        {
            //Getting The Values
            String GrandTotal = labelGrandTotal.Text;
            float sgst = float.Parse(txtSGST.Text);
            float cgst = float.Parse(txtCGST.Text);
            float discount = float.Parse(txtDiscount.Text);

            //Enter values into database table
            query = "insert into bills(grand_total,sgst,cgst,discount,date_and_time) values('" + GrandTotal + "',"+ sgst +"," + cgst + "," + discount + ",'" + DateTime.Now + "')";
            fn.setSetData(query);
        }
        
        public void transactionDatabase()
        {
            //Getting The Values

            //GrandTotal
            String GrandTotal = labelGrandTotal.Text;

            //customer ID
            query = "SELECT TOP 1 customer_id FROM customers ORDER BY customer_id DESC;";
            DataSet ds = fn.getData(query);
            int customerID = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            //Bill ID
            query = "SELECT TOP 1 bill_id FROM bills ORDER BY bill_id DESC;";
            DataSet dss = fn.getData(query);
            int billID = int.Parse(dss.Tables[0].Rows[0][0].ToString());

            query = "insert into billTransactions(billId,customerId,grandTotal,dateAndTime) values("+billID+","+customerID+",'" + GrandTotal + "','" + DateTime.Now + "')";
            fn.setData(query);

        }
        public void user(int id)
        {
            int userId = id;
        }
      
    }
}
