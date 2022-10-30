
namespace WinApp_Application
{
    partial class TopChartApplication_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopChartApplication_UC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAppName = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAppCompany = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblAppVersion = new Bunifu.UI.WinForms.BunifuLabel();
            this.imgAppImage = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnNext = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imgAppImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 76);
            this.panel1.TabIndex = 0;
            // 
            // lblAppName
            // 
            this.lblAppName.AllowParentOverrides = false;
            this.lblAppName.AutoEllipsis = false;
            this.lblAppName.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppName.Location = new System.Drawing.Point(116, 13);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppName.Size = new System.Drawing.Size(88, 25);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "App name";
            this.lblAppName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblAppCompany
            // 
            this.lblAppCompany.AllowParentOverrides = false;
            this.lblAppCompany.AutoEllipsis = false;
            this.lblAppCompany.CursorType = null;
            this.lblAppCompany.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppCompany.Location = new System.Drawing.Point(116, 44);
            this.lblAppCompany.Name = "lblAppCompany";
            this.lblAppCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppCompany.Size = new System.Drawing.Size(105, 17);
            this.lblAppCompany.TabIndex = 2;
            this.lblAppCompany.Text = "App company";
            this.lblAppCompany.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppCompany.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblAppCompany.Click += new System.EventHandler(this.bunifuLabel2_Click);
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AllowParentOverrides = false;
            this.lblAppVersion.AutoEllipsis = false;
            this.lblAppVersion.CursorType = null;
            this.lblAppVersion.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppVersion.Location = new System.Drawing.Point(430, 39);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAppVersion.Size = new System.Drawing.Size(57, 17);
            this.lblAppVersion.TabIndex = 3;
            this.lblAppVersion.Text = "Version";
            this.lblAppVersion.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAppVersion.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // imgAppImage
            // 
            this.imgAppImage.ActiveImage = null;
            this.imgAppImage.AllowAnimations = true;
            this.imgAppImage.AllowBuffering = false;
            this.imgAppImage.AllowToggling = false;
            this.imgAppImage.AllowZooming = true;
            this.imgAppImage.AllowZoomingOnFocus = false;
            this.imgAppImage.BackColor = System.Drawing.Color.Transparent;
            this.imgAppImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imgAppImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgAppImage.ErrorImage")));
            this.imgAppImage.FadeWhenInactive = false;
            this.imgAppImage.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imgAppImage.Image = ((System.Drawing.Image)(resources.GetObject("imgAppImage.Image")));
            this.imgAppImage.ImageActive = null;
            this.imgAppImage.ImageLocation = null;
            this.imgAppImage.ImageMargin = 20;
            this.imgAppImage.ImageSize = new System.Drawing.Size(65, 53);
            this.imgAppImage.ImageZoomSize = new System.Drawing.Size(85, 73);
            this.imgAppImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgAppImage.InitialImage")));
            this.imgAppImage.Location = new System.Drawing.Point(12, 3);
            this.imgAppImage.Name = "imgAppImage";
            this.imgAppImage.Rotation = 0;
            this.imgAppImage.ShowActiveImage = true;
            this.imgAppImage.ShowCursorChanges = true;
            this.imgAppImage.ShowImageBorders = true;
            this.imgAppImage.ShowSizeMarkers = false;
            this.imgAppImage.Size = new System.Drawing.Size(85, 73);
            this.imgAppImage.TabIndex = 5;
            this.imgAppImage.ToolTipText = "";
            this.imgAppImage.WaitOnLoad = false;
            this.imgAppImage.Zoom = 20;
            this.imgAppImage.ZoomSpeed = 10;
            // 
            // btnNext
            // 
            this.btnNext.AllowAnimations = true;
            this.btnNext.AllowMouseEffects = true;
            this.btnNext.AllowToggling = false;
            this.btnNext.AnimationSpeed = 200;
            this.btnNext.AutoGenerateColors = false;
            this.btnNext.AutoRoundBorders = false;
            this.btnNext.AutoSizeLeftIcon = true;
            this.btnNext.AutoSizeRightIcon = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNext.ButtonText = "ADD";
            this.btnNext.ButtonTextMarginLeft = 0;
            this.btnNext.ColorContrastOnClick = 45;
            this.btnNext.ColorContrastOnHover = 45;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNext.CustomizableEdges = borderEdges1;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNext.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNext.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNext.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNext.IconMarginLeft = 11;
            this.btnNext.IconPadding = 10;
            this.btnNext.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNext.IconSize = 25;
            this.btnNext.IdleBorderColor = System.Drawing.Color.White;
            this.btnNext.IdleBorderRadius = 15;
            this.btnNext.IdleBorderThickness = 1;
            this.btnNext.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNext.IdleIconLeftImage = null;
            this.btnNext.IdleIconRightImage = null;
            this.btnNext.IndicateFocus = false;
            this.btnNext.Location = new System.Drawing.Point(669, 22);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNext.OnDisabledState.BorderRadius = 15;
            this.btnNext.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNext.OnDisabledState.BorderThickness = 1;
            this.btnNext.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNext.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNext.OnDisabledState.IconLeftImage = null;
            this.btnNext.OnDisabledState.IconRightImage = null;
            this.btnNext.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNext.onHoverState.BorderRadius = 15;
            this.btnNext.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNext.onHoverState.BorderThickness = 1;
            this.btnNext.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNext.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNext.onHoverState.IconLeftImage = null;
            this.btnNext.onHoverState.IconRightImage = null;
            this.btnNext.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.btnNext.OnIdleState.BorderRadius = 15;
            this.btnNext.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNext.OnIdleState.BorderThickness = 1;
            this.btnNext.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNext.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNext.OnIdleState.IconLeftImage = null;
            this.btnNext.OnIdleState.IconRightImage = null;
            this.btnNext.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNext.OnPressedState.BorderRadius = 15;
            this.btnNext.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnNext.OnPressedState.BorderThickness = 1;
            this.btnNext.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNext.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNext.OnPressedState.IconLeftImage = null;
            this.btnNext.OnPressedState.IconRightImage = null;
            this.btnNext.Size = new System.Drawing.Size(150, 39);
            this.btnNext.TabIndex = 119;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext.TextMarginLeft = 0;
            this.btnNext.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNext.UseDefaultRadiusAndThickness = true;
            // 
            // TopChartApplication_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.lblAppCompany);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.panel1);
            this.Name = "TopChartApplication_UC";
            this.Size = new System.Drawing.Size(853, 76);
            this.Load += new System.EventHandler(this.TopChartApplication_UC_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel lblAppName;
        private Bunifu.UI.WinForms.BunifuLabel lblAppCompany;
        private Bunifu.UI.WinForms.BunifuLabel lblAppVersion;
        private Bunifu.UI.WinForms.BunifuImageButton imgAppImage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnNext;
    }
}
