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
    public partial class KidsPage_UC : UserControl
    {
        public KidsPage_UC()
        {
            InitializeComponent();
        }

        private void KidsPage_UC_Load(object sender, EventArgs e)
        {
            AppItems();
        }
        public void AppItems()
        {
            TopChartApplication_UC[] App = new TopChartApplication_UC[20];

            for (int i = 0; i < App.Length; i++)
            {
                App[i] = new TopChartApplication_UC();
                flowLayoutPanel1.Controls.Add(App[i]);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
