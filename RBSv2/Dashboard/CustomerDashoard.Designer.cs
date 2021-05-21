namespace RBSv2.Dashboard
{
    partial class CustomerDashoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.viewCustomersDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCustomersByID = new Guna.UI2.WinForms.Guna2TextBox();
            this.exitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchCustomerByName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BorderRadius = 15;
            this.btnReturn.CheckedState.Parent = this.btnReturn;
            this.btnReturn.CustomImages.Parent = this.btnReturn;
            this.btnReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReturn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.HoverState.Parent = this.btnReturn;
            this.btnReturn.Location = new System.Drawing.Point(787, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.ShadowDecoration.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(61, 27);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "return";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchCustomerByName);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.viewCustomersDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchCustomersByID);
            this.panel1.Location = new System.Drawing.Point(5, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 506);
            this.panel1.TabIndex = 24;
            // 
            // btnReload
            // 
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageOffset = new System.Drawing.Point(1, 5);
            this.btnReload.ImageSize = new System.Drawing.Size(50, 50);
            this.btnReload.Location = new System.Drawing.Point(194, 9);
            this.btnReload.Name = "btnReload";
            this.btnReload.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(35, 35);
            this.btnReload.TabIndex = 31;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 49);
            this.label7.TabIndex = 26;
            this.label7.Text = "Customers";
            // 
            // viewCustomersDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.viewCustomersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewCustomersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewCustomersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.viewCustomersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewCustomersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewCustomersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewCustomersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCustomersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewCustomersDataGridView.EnableHeadersVisualStyles = false;
            this.viewCustomersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewCustomersDataGridView.Location = new System.Drawing.Point(16, 134);
            this.viewCustomersDataGridView.Name = "viewCustomersDataGridView";
            this.viewCustomersDataGridView.RowHeadersVisible = false;
            this.viewCustomersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewCustomersDataGridView.Size = new System.Drawing.Size(870, 355);
            this.viewCustomersDataGridView.TabIndex = 30;
            this.viewCustomersDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.viewCustomersDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.viewCustomersDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.viewCustomersDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.viewCustomersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.viewCustomersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.viewCustomersDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.viewCustomersDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewCustomersDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.viewCustomersDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewCustomersDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewCustomersDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.viewCustomersDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewCustomersDataGridView.ThemeStyle.HeaderStyle.Height = 23;
            this.viewCustomersDataGridView.ThemeStyle.ReadOnly = false;
            this.viewCustomersDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.viewCustomersDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewCustomersDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewCustomersDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewCustomersDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.viewCustomersDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewCustomersDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewCustomersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewCustomersDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer ID";
            // 
            // txtSearchCustomersByID
            // 
            this.txtSearchCustomersByID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomersByID.DefaultText = "";
            this.txtSearchCustomersByID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomersByID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomersByID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomersByID.DisabledState.Parent = this.txtSearchCustomersByID;
            this.txtSearchCustomersByID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomersByID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomersByID.FocusedState.Parent = this.txtSearchCustomersByID;
            this.txtSearchCustomersByID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearchCustomersByID.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCustomersByID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomersByID.HoverState.Parent = this.txtSearchCustomersByID;
            this.txtSearchCustomersByID.Location = new System.Drawing.Point(173, 87);
            this.txtSearchCustomersByID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchCustomersByID.Name = "txtSearchCustomersByID";
            this.txtSearchCustomersByID.PasswordChar = '\0';
            this.txtSearchCustomersByID.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchCustomersByID.PlaceholderText = "Search";
            this.txtSearchCustomersByID.SelectedText = "";
            this.txtSearchCustomersByID.ShadowDecoration.Parent = this.txtSearchCustomersByID;
            this.txtSearchCustomersByID.Size = new System.Drawing.Size(206, 36);
            this.txtSearchCustomersByID.TabIndex = 28;
            this.txtSearchCustomersByID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchCustomersByID.TextChanged += new System.EventHandler(this.txtSearchCustomersByID_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(872, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(31, 26);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(461, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Customer Name";
            // 
            // txtSearchCustomerByName
            // 
            this.txtSearchCustomerByName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomerByName.DefaultText = "";
            this.txtSearchCustomerByName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomerByName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomerByName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomerByName.DisabledState.Parent = this.txtSearchCustomerByName;
            this.txtSearchCustomerByName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomerByName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomerByName.FocusedState.Parent = this.txtSearchCustomerByName;
            this.txtSearchCustomerByName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearchCustomerByName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCustomerByName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomerByName.HoverState.Parent = this.txtSearchCustomerByName;
            this.txtSearchCustomerByName.Location = new System.Drawing.Point(660, 90);
            this.txtSearchCustomerByName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchCustomerByName.Name = "txtSearchCustomerByName";
            this.txtSearchCustomerByName.PasswordChar = '\0';
            this.txtSearchCustomerByName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchCustomerByName.PlaceholderText = "Search";
            this.txtSearchCustomerByName.SelectedText = "";
            this.txtSearchCustomerByName.ShadowDecoration.Parent = this.txtSearchCustomerByName;
            this.txtSearchCustomerByName.Size = new System.Drawing.Size(206, 36);
            this.txtSearchCustomerByName.TabIndex = 34;
            this.txtSearchCustomerByName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchCustomerByName.TextChanged += new System.EventHandler(this.txtSearchCustomerByName_TextChanged);
            // 
            // CustomerDashoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(915, 549);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerDashoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerDashoard";
            this.Load += new System.EventHandler(this.CustomerDashoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnReload;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView viewCustomersDataGridView;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomersByID;
        private Guna.UI2.WinForms.Guna2CircleButton exitButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomerByName;
    }
}