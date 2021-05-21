namespace RBSv2.User_Controls.Cashier
{
    partial class CashierHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierHome));
            this.CashierImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CashierHomeElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CashierImage)).BeginInit();
            this.SuspendLayout();
            // 
            // CashierImage
            // 
            this.CashierImage.Image = ((System.Drawing.Image)(resources.GetObject("CashierImage.Image")));
            this.CashierImage.Location = new System.Drawing.Point(41, 59);
            this.CashierImage.Name = "CashierImage";
            this.CashierImage.ShadowDecoration.Parent = this.CashierImage;
            this.CashierImage.Size = new System.Drawing.Size(555, 408);
            this.CashierImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CashierImage.TabIndex = 0;
            this.CashierImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 24);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(679, 24);
            this.panel2.TabIndex = 9;
            // 
            // CashierHomeElipse
            // 
            this.CashierHomeElipse.BorderRadius = 20;
            this.CashierHomeElipse.TargetControl = this;
            // 
            // CashierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CashierImage);
            this.Name = "CashierHome";
            this.Size = new System.Drawing.Size(662, 527);
            ((System.ComponentModel.ISupportInitialize)(this.CashierImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox CashierImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse CashierHomeElipse;
    }
}
