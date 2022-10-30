
namespace WinApp_Application
{
    partial class UC_Category_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Category_item));
            this.lblCategoryName = new Bunifu.UI.WinForms.BunifuLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AllowParentOverrides = false;
            this.lblCategoryName.AutoEllipsis = false;
            this.lblCategoryName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblCategoryName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCategoryName.Location = new System.Drawing.Point(3, 3);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCategoryName.Size = new System.Drawing.Size(109, 25);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "bunifuLabel1";
            this.lblCategoryName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategoryName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(746, 182);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // UC_Category_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblCategoryName);
            this.Name = "UC_Category_item";
            this.Size = new System.Drawing.Size(752, 219);
            this.Load += new System.EventHandler(this.UC_Category_item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lblCategoryName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
