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
            ApplicationItems[] Applist = new ApplicationItems[20];
            for (int i = 0; i < Applist.Length; i++)
            {
                Applist[i] = new ApplicationItems();
                flowLayoutPanel1.Controls.Add(Applist[i]);
                //flowLayoutPanel2.Controls.Add(Applist[i]);
            }

            for (int i = 0; i < Applist.Length; i++)
            {
                Applist[i] = new ApplicationItems();
                //flowLayoutPanel1.Controls.Add(Applist[i]);
                flowLayoutPanel2.Controls.Add(Applist[i]);
            }
        }
    }
}
