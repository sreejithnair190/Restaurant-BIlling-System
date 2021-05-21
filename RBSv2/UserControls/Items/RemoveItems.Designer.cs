namespace RBSv2.User_Controls.Items
{
    partial class RemoveItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveItems));
            this.txtSearchRemoveItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemsGridViewRemove = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RemoveItemsElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnReload = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridViewRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchRemoveItem
            // 
            this.txtSearchRemoveItem.BorderColor = System.Drawing.Color.Black;
            this.txtSearchRemoveItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchRemoveItem.DefaultText = "";
            this.txtSearchRemoveItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchRemoveItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchRemoveItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRemoveItem.DisabledState.Parent = this.txtSearchRemoveItem;
            this.txtSearchRemoveItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRemoveItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRemoveItem.FocusedState.Parent = this.txtSearchRemoveItem;
            this.txtSearchRemoveItem.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSearchRemoveItem.ForeColor = System.Drawing.Color.Black;
            this.txtSearchRemoveItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRemoveItem.HoverState.Parent = this.txtSearchRemoveItem;
            this.txtSearchRemoveItem.Location = new System.Drawing.Point(400, 103);
            this.txtSearchRemoveItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchRemoveItem.Name = "txtSearchRemoveItem";
            this.txtSearchRemoveItem.PasswordChar = '\0';
            this.txtSearchRemoveItem.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearchRemoveItem.PlaceholderText = "Search";
            this.txtSearchRemoveItem.SelectedText = "";
            this.txtSearchRemoveItem.ShadowDecoration.Parent = this.txtSearchRemoveItem;
            this.txtSearchRemoveItem.Size = new System.Drawing.Size(224, 37);
            this.txtSearchRemoveItem.TabIndex = 8;
            this.txtSearchRemoveItem.TextChanged += new System.EventHandler(this.txtSearchRemoveItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(395, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(35, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 49);
            this.label2.TabIndex = 6;
            this.label2.Text = "Remove Item";
            // 
            // ItemsGridViewRemove
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ItemsGridViewRemove.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ItemsGridViewRemove.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGridViewRemove.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGridViewRemove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ItemsGridViewRemove.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsGridViewRemove.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsGridViewRemove.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsGridViewRemove.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGridViewRemove.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsGridViewRemove.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ItemsGridViewRemove.EnableHeadersVisualStyles = false;
            this.ItemsGridViewRemove.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsGridViewRemove.Location = new System.Drawing.Point(24, 198);
            this.ItemsGridViewRemove.Name = "ItemsGridViewRemove";
            this.ItemsGridViewRemove.RowHeadersVisible = false;
            this.ItemsGridViewRemove.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGridViewRemove.Size = new System.Drawing.Size(622, 222);
            this.ItemsGridViewRemove.TabIndex = 17;
            this.ItemsGridViewRemove.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ItemsGridViewRemove.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsGridViewRemove.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemsGridViewRemove.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemsGridViewRemove.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemsGridViewRemove.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemsGridViewRemove.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ItemsGridViewRemove.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsGridViewRemove.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ItemsGridViewRemove.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemsGridViewRemove.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsGridViewRemove.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemsGridViewRemove.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemsGridViewRemove.ThemeStyle.HeaderStyle.Height = 4;
            this.ItemsGridViewRemove.ThemeStyle.ReadOnly = false;
            this.ItemsGridViewRemove.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsGridViewRemove.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsGridViewRemove.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsGridViewRemove.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsGridViewRemove.ThemeStyle.RowsStyle.Height = 22;
            this.ItemsGridViewRemove.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsGridViewRemove.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsGridViewRemove.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGridViewRemove_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 24);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 24);
            this.panel2.TabIndex = 27;
            // 
            // RemoveItemsElipse
            // 
            this.RemoveItemsElipse.BorderRadius = 20;
            this.RemoveItemsElipse.TargetControl = this;
            // 
            // btnReload
            // 
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageSize = new System.Drawing.Size(49, 48);
            this.btnReload.Location = new System.Drawing.Point(597, 426);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(49, 48);
            this.btnReload.TabIndex = 28;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // RemoveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ItemsGridViewRemove);
            this.Controls.Add(this.txtSearchRemoveItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "RemoveItems";
            this.Size = new System.Drawing.Size(679, 527);
            this.Load += new System.EventHandler(this.RemoveItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGridViewRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearchRemoveItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsGridViewRemove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse RemoveItemsElipse;
        private Guna.UI2.WinForms.Guna2CircleButton btnReload;
    }
}
