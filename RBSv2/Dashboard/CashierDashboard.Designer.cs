namespace RBSv2.Dashboard
{
    partial class CashierDashboard
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
            this.components = new System.ComponentModel.Container();
            this.CashierButtonPaanelElipse = new System.Windows.Forms.Panel();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAddCashier = new Guna.UI2.WinForms.Guna2Button();
            this.Cashierpanel = new System.Windows.Forms.Panel();
            this.CashierButtonPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CashierPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CashierHomeElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AddCashierElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.viewUsersElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.updateUserElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.viewUsers1 = new RBSv2.UserControls.User.ViewUsers();
            this.addCashier2 = new RBSv2.User_Controls.Cashier.AddCashier();
            this.cashierHome1 = new RBSv2.User_Controls.Cashier.CashierHome();
            this.updateUser1 = new RBSv2.UserControls.User.UpdateUser();
            this.CashierButtonPaanelElipse.SuspendLayout();
            this.Cashierpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CashierButtonPaanelElipse
            // 
            this.CashierButtonPaanelElipse.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CashierButtonPaanelElipse.Controls.Add(this.btnUpdateUser);
            this.CashierButtonPaanelElipse.Controls.Add(this.btnViewUsers);
            this.CashierButtonPaanelElipse.Controls.Add(this.btnReturn);
            this.CashierButtonPaanelElipse.Controls.Add(this.exitButton);
            this.CashierButtonPaanelElipse.Controls.Add(this.btnAddCashier);
            this.CashierButtonPaanelElipse.Location = new System.Drawing.Point(24, 12);
            this.CashierButtonPaanelElipse.Name = "CashierButtonPaanelElipse";
            this.CashierButtonPaanelElipse.Size = new System.Drawing.Size(221, 527);
            this.CashierButtonPaanelElipse.TabIndex = 1;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BorderRadius = 18;
            this.btnUpdateUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateUser.CheckedState.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateUser.CheckedState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.CustomImages.Parent = this.btnUpdateUser;
            this.btnUpdateUser.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnUpdateUser.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.HoverState.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Location = new System.Drawing.Point(51, 169);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.ShadowDecoration.Parent = this.btnUpdateUser;
            this.btnUpdateUser.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateUser.TabIndex = 23;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.BorderRadius = 18;
            this.btnViewUsers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnViewUsers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnViewUsers.CheckedState.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewUsers.CheckedState.Parent = this.btnViewUsers;
            this.btnViewUsers.CustomImages.Parent = this.btnViewUsers;
            this.btnViewUsers.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnViewUsers.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUsers.ForeColor = System.Drawing.Color.White;
            this.btnViewUsers.HoverState.Parent = this.btnViewUsers;
            this.btnViewUsers.Location = new System.Drawing.Point(51, 255);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.ShadowDecoration.Parent = this.btnViewUsers;
            this.btnViewUsers.Size = new System.Drawing.Size(180, 45);
            this.btnViewUsers.TabIndex = 22;
            this.btnViewUsers.Text = "Remove User";
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
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
            this.btnReturn.Location = new System.Drawing.Point(3, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.ShadowDecoration.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(61, 27);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "return";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // exitButton
            // 
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(181, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(31, 26);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // btnAddCashier
            // 
            this.btnAddCashier.BorderRadius = 18;
            this.btnAddCashier.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddCashier.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddCashier.CheckedState.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCashier.CheckedState.Parent = this.btnAddCashier;
            this.btnAddCashier.CustomImages.Parent = this.btnAddCashier;
            this.btnAddCashier.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddCashier.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCashier.ForeColor = System.Drawing.Color.White;
            this.btnAddCashier.HoverState.Parent = this.btnAddCashier;
            this.btnAddCashier.Location = new System.Drawing.Point(51, 81);
            this.btnAddCashier.Name = "btnAddCashier";
            this.btnAddCashier.ShadowDecoration.Parent = this.btnAddCashier;
            this.btnAddCashier.Size = new System.Drawing.Size(180, 45);
            this.btnAddCashier.TabIndex = 0;
            this.btnAddCashier.Text = "Add User";
            this.btnAddCashier.Click += new System.EventHandler(this.btnAddCashier_Click);
            // 
            // Cashierpanel
            // 
            this.Cashierpanel.BackColor = System.Drawing.Color.White;
            this.Cashierpanel.Controls.Add(this.updateUser1);
            this.Cashierpanel.Controls.Add(this.viewUsers1);
            this.Cashierpanel.Controls.Add(this.addCashier2);
            this.Cashierpanel.Controls.Add(this.cashierHome1);
            this.Cashierpanel.Location = new System.Drawing.Point(242, 12);
            this.Cashierpanel.Name = "Cashierpanel";
            this.Cashierpanel.Size = new System.Drawing.Size(662, 527);
            this.Cashierpanel.TabIndex = 2;
            // 
            // CashierButtonPanelElipse
            // 
            this.CashierButtonPanelElipse.BorderRadius = 20;
            this.CashierButtonPanelElipse.TargetControl = this.CashierButtonPaanelElipse;
            // 
            // CashierPanelElipse
            // 
            this.CashierPanelElipse.BorderRadius = 20;
            this.CashierPanelElipse.TargetControl = this.Cashierpanel;
            // 
            // CashierHomeElipse
            // 
            this.CashierHomeElipse.BorderRadius = 20;
            this.CashierHomeElipse.TargetControl = this.Cashierpanel;
            // 
            // AddCashierElipse
            // 
            this.AddCashierElipse.BorderRadius = 20;
            this.AddCashierElipse.TargetControl = this.Cashierpanel;
            // 
            // viewUsersElipse
            // 
            this.viewUsersElipse.BorderRadius = 20;
            this.viewUsersElipse.TargetControl = this.Cashierpanel;
            // 
            // updateUserElipse
            // 
            this.updateUserElipse.BorderRadius = 20;
            this.updateUserElipse.TargetControl = this.Cashierpanel;
            // 
            // viewUsers1
            // 
            this.viewUsers1.Location = new System.Drawing.Point(0, 0);
            this.viewUsers1.Name = "viewUsers1";
            this.viewUsers1.Size = new System.Drawing.Size(662, 527);
            this.viewUsers1.TabIndex = 3;
            // 
            // addCashier2
            // 
            this.addCashier2.Location = new System.Drawing.Point(0, 0);
            this.addCashier2.Name = "addCashier2";
            this.addCashier2.Size = new System.Drawing.Size(662, 527);
            this.addCashier2.TabIndex = 2;
            // 
            // cashierHome1
            // 
            this.cashierHome1.Location = new System.Drawing.Point(0, 0);
            this.cashierHome1.Name = "cashierHome1";
            this.cashierHome1.Size = new System.Drawing.Size(662, 527);
            this.cashierHome1.TabIndex = 0;
            // 
            // updateUser1
            // 
            this.updateUser1.Location = new System.Drawing.Point(0, 0);
            this.updateUser1.Name = "updateUser1";
            this.updateUser1.Size = new System.Drawing.Size(662, 527);
            this.updateUser1.TabIndex = 4;
            // 
            // CashierDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(910, 547);
            this.Controls.Add(this.Cashierpanel);
            this.Controls.Add(this.CashierButtonPaanelElipse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierDashboard";
            this.Load += new System.EventHandler(this.CashierDashboard_Load);
            this.CashierButtonPaanelElipse.ResumeLayout(false);
            this.Cashierpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CashierButtonPaanelElipse;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2CircleButton exitButton;
        private Guna.UI2.WinForms.Guna2Button btnAddCashier;
        private System.Windows.Forms.Panel Cashierpanel;
        private Guna.UI2.WinForms.Guna2Elipse CashierButtonPanelElipse;
        private Guna.UI2.WinForms.Guna2Elipse CashierPanelElipse;
        private Guna.UI2.WinForms.Guna2Elipse CashierHomeElipse;
        private Guna.UI2.WinForms.Guna2Elipse AddCashierElipse;
        private User_Controls.Cashier.CashierHome cashierHome1;
        private User_Controls.Cashier.AddCashier addCashier2;
        private Guna.UI2.WinForms.Guna2Button btnViewUsers;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private Guna.UI2.WinForms.Guna2Elipse viewUsersElipse;
        private UserControls.User.ViewUsers viewUsers1;
        private Guna.UI2.WinForms.Guna2Elipse updateUserElipse;
        private UserControls.User.UpdateUser updateUser1;
    }
}