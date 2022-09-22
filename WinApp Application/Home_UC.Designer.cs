
namespace WinApp_Application
{
    partial class Home_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_UC));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnScrollForward = new System.Windows.Forms.Button();
            this.btnScrollNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(43, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(780, 177);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(65, 25);
            this.bunifuLabel1.TabIndex = 7;
            this.bunifuLabel1.Text = "For you";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.Location = new System.Drawing.Point(3, 217);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(76, 25);
            this.bunifuLabel2.TabIndex = 8;
            this.bunifuLabel2.Text = "Trending";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 248);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(860, 247);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnScrollForward
            // 
            this.btnScrollForward.BackColor = System.Drawing.Color.Transparent;
            this.btnScrollForward.FlatAppearance.BorderSize = 0;
            this.btnScrollForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrollForward.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnScrollForward.Image = ((System.Drawing.Image)(resources.GetObject("btnScrollForward.Image")));
            this.btnScrollForward.Location = new System.Drawing.Point(3, 93);
            this.btnScrollForward.Name = "btnScrollForward";
            this.btnScrollForward.Size = new System.Drawing.Size(34, 34);
            this.btnScrollForward.TabIndex = 12;
            this.btnScrollForward.UseVisualStyleBackColor = false;
            this.btnScrollForward.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnScrollNext
            // 
            this.btnScrollNext.BackColor = System.Drawing.Color.Transparent;
            this.btnScrollNext.FlatAppearance.BorderSize = 0;
            this.btnScrollNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrollNext.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnScrollNext.Image = ((System.Drawing.Image)(resources.GetObject("btnScrollNext.Image")));
            this.btnScrollNext.Location = new System.Drawing.Point(829, 93);
            this.btnScrollNext.Name = "btnScrollNext";
            this.btnScrollNext.Size = new System.Drawing.Size(34, 34);
            this.btnScrollNext.TabIndex = 12;
            this.btnScrollNext.UseVisualStyleBackColor = false;
            this.btnScrollNext.Click += new System.EventHandler(this.btnScrollNext_Click);
            // 
            // Home_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnScrollNext);
            this.Controls.Add(this.btnScrollForward);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Home_UC";
            this.Size = new System.Drawing.Size(866, 495);
            this.Load += new System.EventHandler(this.Home_UC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnScrollForward;
        private System.Windows.Forms.Button btnScrollNext;
    }
}
