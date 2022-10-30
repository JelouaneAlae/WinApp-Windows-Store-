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
    public partial class UC_Category_item : UserControl
    {
        public UC_Category_item()
        {
            InitializeComponent();
        }

        private void UC_Category_item_Load(object sender, EventArgs e)
        {
            //ListApp();
        }

        public void ListApp()
        {
            flowLayoutPanel1.SuspendLayout();

            ApplicationItems[] Applist = new ApplicationItems[8];
            for (int i = 0; i < Applist.Length; i++)
            {
                Applist[i] = new ApplicationItems();
                flowLayoutPanel1.Controls.Add(Applist[i]);
            }
            flowLayoutPanel1.ResumeLayout();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
