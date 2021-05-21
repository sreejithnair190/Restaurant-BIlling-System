namespace RBSv2.UserControls.User
{
    partial class ViewUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDeleteUserFromDB = new Guna.UI2.WinForms.Guna2Button();
            this.viewUsersElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.viewUsersDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 21);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 21);
            this.panel2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(227, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 43);
            this.label7.TabIndex = 18;
            this.label7.Text = "Remove User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSearchUser.DefaultText = "";
            this.btnSearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnSearchUser.DisabledState.Parent = this.btnSearchUser;
            this.btnSearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnSearchUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearchUser.FocusedState.Parent = this.btnSearchUser;
            this.btnSearchUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearchUser.ForeColor = System.Drawing.Color.Black;
            this.btnSearchUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSearchUser.HoverState.Parent = this.btnSearchUser;
            this.btnSearchUser.Location = new System.Drawing.Point(135, 95);
            this.btnSearchUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.PasswordChar = '\0';
            this.btnSearchUser.PlaceholderForeColor = System.Drawing.Color.Black;
            this.btnSearchUser.PlaceholderText = "Search";
            this.btnSearchUser.SelectedText = "";
            this.btnSearchUser.ShadowDecoration.Parent = this.btnSearchUser;
            this.btnSearchUser.Size = new System.Drawing.Size(206, 36);
            this.btnSearchUser.TabIndex = 21;
            this.btnSearchUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearchUser.TextChanged += new System.EventHandler(this.btnSearchUser_TextChanged);
            // 
            // btnDeleteUserFromDB
            // 
            this.btnDeleteUserFromDB.BorderRadius = 16;
            this.btnDeleteUserFromDB.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDeleteUserFromDB.CheckedState.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteUserFromDB.CheckedState.Parent = this.btnDeleteUserFromDB;
            this.btnDeleteUserFromDB.CustomImages.Parent = this.btnDeleteUserFromDB;
            this.btnDeleteUserFromDB.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteUserFromDB.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUserFromDB.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUserFromDB.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDeleteUserFromDB.HoverState.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteUserFromDB.HoverState.Parent = this.btnDeleteUserFromDB;
            this.btnDeleteUserFromDB.Location = new System.Drawing.Point(458, 455);
            this.btnDeleteUserFromDB.Name = "btnDeleteUserFromDB";
            this.btnDeleteUserFromDB.ShadowDecoration.Parent = this.btnDeleteUserFromDB;
            this.btnDeleteUserFromDB.Size = new System.Drawing.Size(169, 38);
            this.btnDeleteUserFromDB.TabIndex = 22;
            this.btnDeleteUserFromDB.Text = "Delete";
            this.btnDeleteUserFromDB.Click += new System.EventHandler(this.btnDeleteUserFromDB_Click);
            // 
            // viewUsersElipse
            // 
            this.viewUsersElipse.BorderRadius = 20;
            this.viewUsersElipse.TargetControl = this;
            // 
            // viewUsersDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.viewUsersDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewUsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewUsersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.viewUsersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewUsersDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewUsersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewUsersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewUsersDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewUsersDataGridView.EnableHeadersVisualStyles = false;
            this.viewUsersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewUsersDataGridView.Location = new System.Drawing.Point(11, 139);
            this.viewUsersDataGridView.Name = "viewUsersDataGridView";
            this.viewUsersDataGridView.RowHeadersVisible = false;
            this.viewUsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewUsersDataGridView.Size = new System.Drawing.Size(633, 303);
            this.viewUsersDataGridView.TabIndex = 23;
            this.viewUsersDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.viewUsersDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.viewUsersDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.viewUsersDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.viewUsersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.viewUsersDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.viewUsersDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.viewUsersDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewUsersDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.viewUsersDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewUsersDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewUsersDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.viewUsersDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewUsersDataGridView.ThemeStyle.HeaderStyle.Height = 23;
            this.viewUsersDataGridView.ThemeStyle.ReadOnly = false;
            this.viewUsersDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.viewUsersDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewUsersDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewUsersDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewUsersDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.viewUsersDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewUsersDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewUsersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewUsersDataGridView_CellClick);
            this.viewUsersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewUsersDataGridView_CellContentClick);
            // 
            // btnReload
            // 
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnReload.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReload.Location = new System.Drawing.Point(348, 95);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(35, 35);
            this.btnReload.TabIndex = 24;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // ViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.viewUsersDataGridView);
            this.Controls.Add(this.btnDeleteUserFromDB);
            this.Controls.Add(this.btnSearchUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewUsers";
            this.Size = new System.Drawing.Size(662, 527);
            this.Load += new System.EventHandler(this.ViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewUsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox btnSearchUser;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUserFromDB;
        private Guna.UI2.WinForms.Guna2Elipse viewUsersElipse;
        private Guna.UI2.WinForms.Guna2DataGridView viewUsersDataGridView;
        private Guna.UI2.WinForms.Guna2CircleButton btnReload;
    }
}
