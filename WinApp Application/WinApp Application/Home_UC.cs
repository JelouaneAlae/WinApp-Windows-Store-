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
    public partial class Home_UC : UserControl
    {
        public Home_UC()
        {
            InitializeComponent();
        }

        private void Home_UC_Load(object sender, EventArgs e)
        {
            ListApp();
        }
        public void ListApp()
        {
            //ApplicationItems[] Applist = new ApplicationItems[20];
            //for (int i = 0; i < Applist.Length; i++)
            //{
            //    Applist[i] = new ApplicationItems();
            //    flowLayoutPanel1.Controls.Add(Applist[i]);
            //    //flowLayoutPanel2.Controls.Add(Applist[i]);
            //}

            //for (int i = 0; i < Applist.Length; i++)
            //{
            //    Applist[i] = new ApplicationItems();
            //    //flowLayoutPanel1.Controls.Add(Applist[i]);
            //    flowLayoutPanel2.Controls.Add(Applist[i]);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (flowLayoutPanel1.HorizontalScroll.Value != 0)
            //{
            //    flowLayoutPanel1.HorizontalScroll.Value -= 60;
            //    flowLayoutPanel1.PerformLayout();
            //}

        }

        private void btnScrollNext_Click(object sender, EventArgs e)
        {

                //flowLayoutPanel1.HorizontalScroll.Value += 60;
                //flowLayoutPanel1.PerformLayout();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            
        }


        public void ListCategory()
        {

            //flowLayoutPanel1.SuspendLayout();
            //UC_Category_item[] CategoryList = new UC_Category_item[1];
            //for (int i = 0; i < CategoryList.Length; i++)
            //{
            //    CategoryList[i] = new UC_Category_item();
            //    flowLayoutPanel1.Controls.Add(CategoryList[i]);
            //}
            //flowLayoutPanel1.ResumeLayout();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            ListCategory();
        }
    }
}
