namespace RBSv2.Dashboard
{
    partial class BillsTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsTransactions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBillId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label7 = new System.Windows.Forms.Label();
            this.viewTransactionDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchCustomerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.exitButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTransactionDataGridView)).BeginInit();
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
            this.btnReturn.Location = new System.Drawing.Point(794, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.ShadowDecoration.Parent = this.btnReturn;
            this.btnReturn.Size = new System.Drawing.Size(61, 27);
            this.btnReturn.TabIndex = 29;
            this.btnReturn.Text = "return";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchBillId);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.viewTransactionDataGridView);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchCustomerId);
            this.panel1.Location = new System.Drawing.Point(5, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 506);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(572, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 32);
            this.label2.TabIndex = 33;
            this.label2.Text = "Bill Id";
            // 
            // txtSearchBillId
            // 
            this.txtSearchBillId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBillId.DefaultText = "";
            this.txtSearchBillId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBillId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBillId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBillId.DisabledState.Parent = this.txtSearchBillId;
            this.txtSearchBillId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBillId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBillId.FocusedState.Parent = this.txtSearchBillId;
            this.txtSearchBillId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearchBillId.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBillId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBillId.HoverState.Parent = this.txtSearchBillId;
            this.txtSearchBillId.Location = new System.Drawing.Point(660, 90);
            this.txtSearchBillId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchBillId.Name = "txtSearchBillId";
            this.txtSearchBillId.PasswordChar = '\0';
            this.txtSearchBillId.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchBillId.PlaceholderText = "Search";
            this.txtSearchBillId.SelectedText = "";
            this.txtSearchBillId.ShadowDecoration.Parent = this.txtSearchBillId;
            this.txtSearchBillId.Size = new System.Drawing.Size(206, 36);
            this.txtSearchBillId.TabIndex = 34;
            this.txtSearchBillId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBillId.TextChanged += new System.EventHandler(this.txtSearchBillId_TextChanged);
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
            this.btnReload.Location = new System.Drawing.Point(218, 10);
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
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 49);
            this.label7.TabIndex = 26;
            this.label7.Text = "Transaction";
            // 
            // viewTransactionDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.viewTransactionDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewTransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewTransactionDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.viewTransactionDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewTransactionDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewTransactionDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewTransactionDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewTransactionDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewTransactionDataGridView.EnableHeadersVisualStyles = false;
            this.viewTransactionDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewTransactionDataGridView.Location = new System.Drawing.Point(16, 134);
            this.viewTransactionDataGridView.Name = "viewTransactionDataGridView";
            this.viewTransactionDataGridView.RowHeadersVisible = false;
            this.viewTransactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewTransactionDataGridView.Size = new System.Drawing.Size(870, 355);
            this.viewTransactionDataGridView.TabIndex = 30;
            this.viewTransactionDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.viewTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.viewTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.viewTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.viewTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.viewTransactionDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.viewTransactionDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.viewTransactionDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewTransactionDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.viewTransactionDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewTransactionDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewTransactionDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.viewTransactionDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewTransactionDataGridView.ThemeStyle.HeaderStyle.Height = 23;
            this.viewTransactionDataGridView.ThemeStyle.ReadOnly = false;
            this.viewTransactionDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.viewTransactionDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewTransactionDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.viewTransactionDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewTransactionDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.viewTransactionDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewTransactionDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewTransactionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewTransactionDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(10, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer Id";
            // 
            // txtSearchCustomerId
            // 
            this.txtSearchCustomerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomerId.DefaultText = "";
            this.txtSearchCustomerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomerId.DisabledState.Parent = this.txtSearchCustomerId;
            this.txtSearchCustomerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomerId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomerId.FocusedState.Parent = this.txtSearchCustomerId;
            this.txtSearchCustomerId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtSearchCustomerId.ForeColor = System.Drawing.Color.Black;
            this.txtSearchCustomerId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomerId.HoverState.Parent = this.txtSearchCustomerId;
            this.txtSearchCustomerId.Location = new System.Drawing.Point(173, 87);
            this.txtSearchCustomerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchCustomerId.Name = "txtSearchCustomerId";
            this.txtSearchCustomerId.PasswordChar = '\0';
            this.txtSearchCustomerId.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchCustomerId.PlaceholderText = "Search";
            this.txtSearchCustomerId.SelectedText = "";
            this.txtSearchCustomerId.ShadowDecoration.Parent = this.txtSearchCustomerId;
            this.txtSearchCustomerId.Size = new System.Drawing.Size(206, 36);
            this.txtSearchCustomerId.TabIndex = 28;
            this.txtSearchCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchCustomerId.TextChanged += new System.EventHandler(this.txtSearchCustomerId_TextChanged);
            // 
            // exitButton
            // 
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(879, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(31, 26);
            this.exitButton.TabIndex = 28;
            this.exitButton.Text = "X";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // BillsTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(915, 549);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillsTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillsTransactions";
            this.Load += new System.EventHandler(this.BillsTransactions_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTransactionDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBillId;
        private Guna.UI2.WinForms.Guna2CircleButton btnReload;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView viewTransactionDataGridView;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomerId;
        private Guna.UI2.WinForms.Guna2CircleButton exitButton;
    }
}