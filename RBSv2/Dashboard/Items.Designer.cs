namespace RBSv2.Dashboard
{
    partial class Items
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
            this.btnItemsPanel = new System.Windows.Forms.Panel();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.exitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnUpdateItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveItems = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddItems = new Guna.UI2.WinForms.Guna2Button();
            this.UsrControlItemPanel = new System.Windows.Forms.Panel();
            this.removeItems1 = new RBSv2.User_Controls.Items.RemoveItems();
            this.updateItems1 = new RBSv2.User_Controls.Items.UpdateItems();
            this.addItems1 = new RBSv2.User_Controls.Items.AddItems();
            this.itemsHome1 = new RBSv2.User_Controls.Items.ItemsHome();
            this.btnItemsPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UCItemsPanelElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ItemsHomeElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.AddItemsElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UpdateItemsElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.RemoveItemsElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnItemsPanel.SuspendLayout();
            this.UsrControlItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnItemsPanel
            // 
            this.btnItemsPanel.BackColor = System.Drawing.Color.Orange;
            this.btnItemsPanel.Controls.Add(this.btnReturn);
            this.btnItemsPanel.Controls.Add(this.exitButton);
            this.btnItemsPanel.Controls.Add(this.btnUpdateItems);
            this.btnItemsPanel.Controls.Add(this.btnRemoveItems);
            this.btnItemsPanel.Controls.Add(this.btnAddItems);
            this.btnItemsPanel.Location = new System.Drawing.Point(12, 12);
            this.btnItemsPanel.Name = "btnItemsPanel";
            this.btnItemsPanel.Size = new System.Drawing.Size(221, 527);
            this.btnItemsPanel.TabIndex = 0;
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
            // btnUpdateItems
            // 
            this.btnUpdateItems.BorderRadius = 18;
            this.btnUpdateItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdateItems.CheckedState.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateItems.CheckedState.Parent = this.btnUpdateItems;
            this.btnUpdateItems.CustomImages.Parent = this.btnUpdateItems;
            this.btnUpdateItems.FillColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateItems.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateItems.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItems.HoverState.Parent = this.btnUpdateItems;
            this.btnUpdateItems.Location = new System.Drawing.Point(51, 180);
            this.btnUpdateItems.Name = "btnUpdateItems";
            this.btnUpdateItems.ShadowDecoration.Parent = this.btnUpdateItems;
            this.btnUpdateItems.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateItems.TabIndex = 3;
            this.btnUpdateItems.Text = "Update Items";
            this.btnUpdateItems.Click += new System.EventHandler(this.btnUpdateItems_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.BorderRadius = 18;
            this.btnRemoveItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemoveItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemoveItems.CheckedState.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveItems.CheckedState.Parent = this.btnRemoveItems;
            this.btnRemoveItems.CustomImages.Parent = this.btnRemoveItems;
            this.btnRemoveItems.FillColor = System.Drawing.Color.DarkOrange;
            this.btnRemoveItems.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItems.HoverState.Parent = this.btnRemoveItems;
            this.btnRemoveItems.Location = new System.Drawing.Point(51, 289);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.ShadowDecoration.Parent = this.btnRemoveItems;
            this.btnRemoveItems.Size = new System.Drawing.Size(180, 45);
            this.btnRemoveItems.TabIndex = 2;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BorderRadius = 18;
            this.btnAddItems.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddItems.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddItems.CheckedState.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddItems.CheckedState.Parent = this.btnAddItems;
            this.btnAddItems.CustomImages.Parent = this.btnAddItems;
            this.btnAddItems.FillColor = System.Drawing.Color.DarkOrange;
            this.btnAddItems.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.HoverState.Parent = this.btnAddItems;
            this.btnAddItems.Location = new System.Drawing.Point(51, 81);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.ShadowDecoration.Parent = this.btnAddItems;
            this.btnAddItems.Size = new System.Drawing.Size(180, 45);
            this.btnAddItems.TabIndex = 0;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // UsrControlItemPanel
            // 
            this.UsrControlItemPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsrControlItemPanel.Controls.Add(this.removeItems1);
            this.UsrControlItemPanel.Controls.Add(this.updateItems1);
            this.UsrControlItemPanel.Controls.Add(this.addItems1);
            this.UsrControlItemPanel.Controls.Add(this.itemsHome1);
            this.UsrControlItemPanel.Location = new System.Drawing.Point(230, 12);
            this.UsrControlItemPanel.Name = "UsrControlItemPanel";
            this.UsrControlItemPanel.Size = new System.Drawing.Size(679, 527);
            this.UsrControlItemPanel.TabIndex = 1;
            // 
            // removeItems1
            // 
            this.removeItems1.BackColor = System.Drawing.Color.White;
            this.removeItems1.Location = new System.Drawing.Point(0, 0);
            this.removeItems1.Name = "removeItems1";
            this.removeItems1.Size = new System.Drawing.Size(679, 527);
            this.removeItems1.TabIndex = 4;
            // 
            // updateItems1
            // 
            this.updateItems1.BackColor = System.Drawing.Color.White;
            this.updateItems1.Location = new System.Drawing.Point(0, 0);
            this.updateItems1.Name = "updateItems1";
            this.updateItems1.Size = new System.Drawing.Size(679, 527);
            this.updateItems1.TabIndex = 3;
            // 
            // addItems1
            // 
            this.addItems1.Location = new System.Drawing.Point(0, 0);
            this.addItems1.Name = "addItems1";
            this.addItems1.Size = new System.Drawing.Size(679, 527);
            this.addItems1.TabIndex = 1;
            // 
            // itemsHome1
            // 
            this.itemsHome1.BackColor = System.Drawing.Color.White;
            this.itemsHome1.Location = new System.Drawing.Point(3, 0);
            this.itemsHome1.Name = "itemsHome1";
            this.itemsHome1.Size = new System.Drawing.Size(679, 527);
            this.itemsHome1.TabIndex = 0;
            // 
            // btnItemsPanelElipse
            // 
            this.btnItemsPanelElipse.BorderRadius = 20;
            this.btnItemsPanelElipse.TargetControl = this.btnItemsPanel;
            // 
            // UCItemsPanelElipse
            // 
            this.UCItemsPanelElipse.BorderRadius = 20;
            this.UCItemsPanelElipse.TargetControl = this.UsrControlItemPanel;
            // 
            // ItemsHomeElipse
            // 
            this.ItemsHomeElipse.BorderRadius = 20;
            this.ItemsHomeElipse.TargetControl = this.UsrControlItemPanel;
            // 
            // AddItemsElipse
            // 
            this.AddItemsElipse.BorderRadius = 20;
            this.AddItemsElipse.TargetControl = this.UsrControlItemPanel;
            // 
            // UpdateItemsElipse
            // 
            this.UpdateItemsElipse.BorderRadius = 20;
            this.UpdateItemsElipse.TargetControl = this.UsrControlItemPanel;
            // 
            // RemoveItemsElipse
            // 
            this.RemoveItemsElipse.BorderRadius = 20;
            this.RemoveItemsElipse.TargetControl = this.UsrControlItemPanel;
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(911, 549);
            this.Controls.Add(this.UsrControlItemPanel);
            this.Controls.Add(this.btnItemsPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            this.btnItemsPanel.ResumeLayout(false);
            this.UsrControlItemPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnItemsPanel;
        private System.Windows.Forms.Panel UsrControlItemPanel;
        private Guna.UI2.WinForms.Guna2Elipse btnItemsPanelElipse;
        private Guna.UI2.WinForms.Guna2Elipse UCItemsPanelElipse;
        private Guna.UI2.WinForms.Guna2Elipse ItemsHomeElipse;
        private User_Controls.Items.ItemsHome itemsHome1;
        private Guna.UI2.WinForms.Guna2Button btnUpdateItems;
        private Guna.UI2.WinForms.Guna2Button btnRemoveItems;
        private Guna.UI2.WinForms.Guna2Button btnAddItems;
        private Guna.UI2.WinForms.Guna2CircleButton exitButton;
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2Elipse AddItemsElipse;
        private User_Controls.Items.AddItems addItems1;
        private Guna.UI2.WinForms.Guna2Elipse UpdateItemsElipse;
        private User_Controls.Items.UpdateItems updateItems1;
        private Guna.UI2.WinForms.Guna2Elipse RemoveItemsElipse;
        private User_Controls.Items.RemoveItems removeItems1;
    }
}