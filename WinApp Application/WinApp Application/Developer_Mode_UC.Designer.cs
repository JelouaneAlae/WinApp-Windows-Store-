
using System;

namespace WinApp_Application
{
    partial class Developer_Mode_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Developer_Mode_UC));
            this.btnAddApp = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnBackToHome = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnManageInfoDV = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageApp = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteApp = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddApp
            // 
            this.btnAddApp.Animated = true;
            this.btnAddApp.AnimatedGIF = true;
            this.btnAddApp.BackColor = System.Drawing.Color.Transparent;
            this.btnAddApp.BorderRadius = 8;
            this.btnAddApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddApp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddApp.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddApp.ForeColor = System.Drawing.Color.White;
            this.btnAddApp.Location = new System.Drawing.Point(17, 26);
            this.btnAddApp.Name = "btnAddApp";
            this.btnAddApp.Size = new System.Drawing.Size(167, 38);
            this.btnAddApp.TabIndex = 7;
            this.btnAddApp.Text = "Add Application";
            this.btnAddApp.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 18.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(285, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(315, 32);
            this.bunifuLabel1.TabIndex = 8;
            this.bunifuLabel1.Text = "Welcome to developer mode";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnBackToHome);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(884, 55);
            this.bunifuPanel1.TabIndex = 9;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.Animated = true;
            this.btnBackToHome.AnimatedGIF = true;
            this.btnBackToHome.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToHome.BorderRadius = 8;
            this.btnBackToHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackToHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackToHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackToHome.FillColor = System.Drawing.Color.White;
            this.btnBackToHome.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnBackToHome.ForeColor = System.Drawing.Color.Black;
            this.btnBackToHome.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToHome.Image")));
            this.btnBackToHome.ImageSize = new System.Drawing.Size(37, 37);
            this.btnBackToHome.Location = new System.Drawing.Point(17, 12);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(34, 34);
            this.btnBackToHome.TabIndex = 18;
            this.btnBackToHome.Click += new System.EventHandler(this.btnBackToHome_Click_2);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btnManageInfoDV);
            this.bunifuPanel2.Controls.Add(this.guna2Button4);
            this.bunifuPanel2.Controls.Add(this.btnAddApp);
            this.bunifuPanel2.Controls.Add(this.btnManageApp);
            this.bunifuPanel2.Controls.Add(this.btnDeleteApp);
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 58);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(200, 437);
            this.bunifuPanel2.TabIndex = 10;
            // 
            // btnManageInfoDV
            // 
            this.btnManageInfoDV.Animated = true;
            this.btnManageInfoDV.AnimatedGIF = true;
            this.btnManageInfoDV.BackColor = System.Drawing.Color.Transparent;
            this.btnManageInfoDV.BorderRadius = 7;
            this.btnManageInfoDV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageInfoDV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageInfoDV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageInfoDV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageInfoDV.FillColor = System.Drawing.Color.Red;
            this.btnManageInfoDV.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageInfoDV.ForeColor = System.Drawing.Color.White;
            this.btnManageInfoDV.Location = new System.Drawing.Point(17, 225);
            this.btnManageInfoDV.Name = "btnManageInfoDV";
            this.btnManageInfoDV.Size = new System.Drawing.Size(167, 51);
            this.btnManageInfoDV.TabIndex = 11;
            this.btnManageInfoDV.Text = "Manage developer information";
            this.btnManageInfoDV.Click += new System.EventHandler(this.btnManageInfoDV_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.AnimatedGIF = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 8;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button4.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(17, 181);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(167, 38);
            this.guna2Button4.TabIndex = 10;
            this.guna2Button4.Text = "Delete Application";
            // 
            // btnManageApp
            // 
            this.btnManageApp.Animated = true;
            this.btnManageApp.AnimatedGIF = true;
            this.btnManageApp.BackColor = System.Drawing.Color.Transparent;
            this.btnManageApp.BorderRadius = 8;
            this.btnManageApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageApp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnManageApp.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnManageApp.ForeColor = System.Drawing.Color.White;
            this.btnManageApp.Location = new System.Drawing.Point(17, 70);
            this.btnManageApp.Name = "btnManageApp";
            this.btnManageApp.Size = new System.Drawing.Size(167, 59);
            this.btnManageApp.TabIndex = 8;
            this.btnManageApp.Text = "manage existing Application";
            this.btnManageApp.Click += new System.EventHandler(this.btnManageApp_Click);
            // 
            // btnDeleteApp
            // 
            this.btnDeleteApp.Animated = true;
            this.btnDeleteApp.AnimatedGIF = true;
            this.btnDeleteApp.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteApp.BorderRadius = 8;
            this.btnDeleteApp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteApp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteApp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteApp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteApp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteApp.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteApp.ForeColor = System.Drawing.Color.White;
            this.btnDeleteApp.Location = new System.Drawing.Point(17, 135);
            this.btnDeleteApp.Name = "btnDeleteApp";
            this.btnDeleteApp.Size = new System.Drawing.Size(167, 38);
            this.btnDeleteApp.TabIndex = 9;
            this.btnDeleteApp.Text = "Delete Application";
            this.btnDeleteApp.Click += new System.EventHandler(this.btnDeleteApp_Click);
            // 
            // Developer_Mode_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "Developer_Mode_UC";
            this.Size = new System.Drawing.Size(884, 464);
            this.Load += new System.EventHandler(this.Add_App_UC_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddApp;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnDeleteApp;
        private Guna.UI2.WinForms.Guna2Button btnManageApp;
        private Guna.UI2.WinForms.Guna2Button btnManageInfoDV;
        private EventHandler btnBcackToHome_Click;
        private Guna.UI2.WinForms.Guna2Button btnBackToHome;
    }
}
