
namespace WinApp_Application
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ScrollHome = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 424);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // ScrollHome
            // 
            this.ScrollHome.AllowCursorChanges = true;
            this.ScrollHome.AllowHomeEndKeysDetection = false;
            this.ScrollHome.AllowIncrementalClickMoves = true;
            this.ScrollHome.AllowMouseDownEffects = true;
            this.ScrollHome.AllowMouseHoverEffects = true;
            this.ScrollHome.AllowScrollingAnimations = true;
            this.ScrollHome.AllowScrollKeysDetection = true;
            this.ScrollHome.AllowScrollOptionsMenu = true;
            this.ScrollHome.AllowShrinkingOnFocusLost = false;
            this.ScrollHome.BackgroundColor = System.Drawing.Color.White;
            this.ScrollHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ScrollHome.BackgroundImage")));
            this.ScrollHome.BindingContainer = null;
            this.ScrollHome.BorderColor = System.Drawing.Color.Transparent;
            this.ScrollHome.BorderRadius = 1;
            this.ScrollHome.BorderThickness = 1;
            this.ScrollHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScrollHome.DurationBeforeShrink = 2000;
            this.ScrollHome.LargeChange = 10;
            this.ScrollHome.Location = new System.Drawing.Point(874, 0);
            this.ScrollHome.Maximum = 100;
            this.ScrollHome.Minimum = 0;
            this.ScrollHome.MinimumThumbLength = 18;
            this.ScrollHome.Name = "ScrollHome";
            this.ScrollHome.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.ScrollHome.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.ScrollHome.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.ScrollHome.ScrollBarBorderColor = System.Drawing.Color.Transparent;
            this.ScrollHome.ScrollBarColor = System.Drawing.Color.White;
            this.ScrollHome.ShrinkSizeLimit = 3;
            this.ScrollHome.Size = new System.Drawing.Size(12, 424);
            this.ScrollHome.SmallChange = 1;
            this.ScrollHome.TabIndex = 1;
            this.ScrollHome.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ScrollHome.ThumbLength = 41;
            this.ScrollHome.ThumbMargin = 1;
            this.ScrollHome.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.ScrollHome.Value = 0;
            this.ScrollHome.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.ScrollHome_Scroll);
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScrollHome);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(886, 424);
            this.Load += new System.EventHandler(this.Home_UC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuVScrollBar ScrollHome;
    }
}
