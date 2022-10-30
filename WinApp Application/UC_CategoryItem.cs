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
    public partial class UC_CategoryItem : UserControl
    {
        public UC_CategoryItem()
        {
            InitializeComponent();
        }

        private void UC_CategoryItem_Load(object sender, EventArgs e)
        {
            ListApp();
            
        }
        public void ListApp()
        {
            ApplicationItems[] Applist = new ApplicationItems[7];
            for (int i = 0; i < Applist.Length; i++)
            {
                Applist[i] = new ApplicationItems();
                flowapp.Controls.Add(Applist[i]);
                //flowapp.HorizontalScroll.Visible = false;
            }
        }

        private void flowapp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
