using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinApp_Application
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void Home_UC_Load(object sender, EventArgs e)
        {
            ListCategory();
            ScrollHome.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            ScrollHome.Maximum= flowLayoutPanel1.VerticalScroll.Maximum;
        }
        public void ListCategory()
        {

            UC_CategoryItem[] Categlist = new UC_CategoryItem[10];
            for (int i = 0; i < Categlist.Length; i++)
            {
                Categlist[i] = new UC_CategoryItem();
                flowLayoutPanel1.Controls.Add(Categlist[i]);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ScrollHome_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
           
            flowLayoutPanel1.VerticalScroll.Value = ScrollHome.Value;
            ScrollHome.Minimum = flowLayoutPanel1.VerticalScroll.Minimum;
            ScrollHome.Maximum = flowLayoutPanel1.VerticalScroll.Maximum;
        }
    }
}
