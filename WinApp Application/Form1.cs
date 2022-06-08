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
    public partial class Form1 : Form
    {
        static Home_UC home = new Home_UC();
        static TopChart_UC TopChart = new TopChart_UC();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NavigationUC("home");
        }

        public void NavigationUC(String UC)
        {
            switch (UC) 
            {
                case "home":
                    this.Controls.Remove(TopChart);
                    this.Controls.Add(home);
                    home.Location = new Point(12, 105);

                    break;


                case "topchart":
                    this.Controls.Remove(home);
                    this.Controls.Add(TopChart);
                    TopChart.Location = new Point(12, 105);
                    break;

            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigationUC("home");
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NavigationUC("topchart");
        }
    }
}
