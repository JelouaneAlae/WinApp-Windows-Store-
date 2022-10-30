
namespace WinApp_Application
{
    partial class UC_ApplicationItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ApplicationItems));
            this.imageAppli = new Bunifu.UI.WinForms.BunifuImageButton();
            this.txtAppname = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtPriceApp = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // imageAppli
            // 
            this.imageAppli.ActiveImage = null;
            this.imageAppli.AllowAnimations = true;
            this.imageAppli.AllowBuffering = false;
            this.imageAppli.AllowToggling = false;
            this.imageAppli.AllowZooming = true;
            this.imageAppli.AllowZoomingOnFocus = false;
            this.imageAppli.BackColor = System.Drawing.Color.Transparent;
            this.imageAppli.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imageAppli.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imageAppli.ErrorImage")));
            this.imageAppli.FadeWhenInactive = false;
            this.imageAppli.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imageAppli.Image = ((System.Drawing.Image)(resources.GetObject("imageAppli.Image")));
            this.imageAppli.ImageActive = null;
            this.imageAppli.ImageLocation = null;
            this.imageAppli.ImageMargin = 20;
            this.imageAppli.ImageSize = new System.Drawing.Size(95, 88);
            this.imageAppli.ImageZoomSize = new System.Drawing.Size(115, 108);
            this.imageAppli.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageAppli.InitialImage")));
            this.imageAppli.Location = new System.Drawing.Point(3, 1);
            this.imageAppli.Name = "imageAppli";
            this.imageAppli.Rotation = 0;
            this.imageAppli.ShowActiveImage = true;
            this.imageAppli.ShowCursorChanges = true;
            this.imageAppli.ShowImageBorders = true;
            this.imageAppli.ShowSizeMarkers = false;
            this.imageAppli.Size = new System.Drawing.Size(115, 108);
            this.imageAppli.TabIndex = 0;
            this.imageAppli.ToolTipText = "";
            this.imageAppli.WaitOnLoad = false;
            this.imageAppli.Zoom = 20;
            this.imageAppli.ZoomSpeed = 10;
            this.imageAppli.Click += new System.EventHandler(this.imageAppli_Click);
            // 
            // txtAppname
            // 
            this.txtAppname.AllowParentOverrides = false;
            this.txtAppname.AutoEllipsis = false;
            this.txtAppname.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAppname.CursorType = System.Windows.Forms.Cursors.Default;
            this.txtAppname.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppname.Location = new System.Drawing.Point(9, 110);
            this.txtAppname.Name = "txtAppname";
            this.txtAppname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAppname.Size = new System.Drawing.Size(94, 21);
            this.txtAppname.TabIndex = 1;
            this.txtAppname.Text = "Pubg Mobile";
            this.txtAppname.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtAppname.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.txtAppname.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // txtPriceApp
            // 
            this.txtPriceApp.AllowParentOverrides = false;
            this.txtPriceApp.AutoEllipsis = false;
            this.txtPriceApp.CursorType = null;
            this.txtPriceApp.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceApp.Location = new System.Drawing.Point(9, 136);
            this.txtPriceApp.Name = "txtPriceApp";
            this.txtPriceApp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPriceApp.Size = new System.Drawing.Size(22, 15);
            this.txtPriceApp.TabIndex = 2;
            this.txtPriceApp.Text = "Free";
            this.txtPriceApp.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtPriceApp.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ApplicationItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPriceApp);
            this.Controls.Add(this.txtAppname);
            this.Controls.Add(this.imageAppli);
            this.Name = "ApplicationItems";
            this.Size = new System.Drawing.Size(121, 154);
            this.Load += new System.EventHandler(this.ApplicationItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton imageAppli;
        private Bunifu.UI.WinForms.BunifuLabel txtAppname;
        private Bunifu.UI.WinForms.BunifuLabel txtPriceApp;
    }
}
