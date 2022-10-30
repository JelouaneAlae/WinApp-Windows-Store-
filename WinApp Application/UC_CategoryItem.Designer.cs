
namespace WinApp_Application
{
    partial class UC_CategoryItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CategoryItem));
            this.flowapp = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // flowapp
            // 
            this.flowapp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowapp.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowapp.Location = new System.Drawing.Point(0, 35);
            this.flowapp.Name = "flowapp";
            this.flowapp.Size = new System.Drawing.Size(867, 160);
            this.flowapp.TabIndex = 0;
            this.flowapp.Paint += new System.Windows.Forms.PaintEventHandler(this.flowapp_Paint);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(8, 4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(131, 25);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Category name";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UC_CategoryItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.flowapp);
            this.Name = "UC_CategoryItem";
            this.Size = new System.Drawing.Size(867, 195);
            this.Load += new System.EventHandler(this.UC_CategoryItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowapp;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}
