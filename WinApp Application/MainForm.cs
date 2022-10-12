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
    public partial class Main_Form : Form
    {
        static Home_UC home = new Home_UC();
        static TopChartPage_UC TopChart = new TopChartPage_UC();
        static KidsPage_UC Kids = new KidsPage_UC();
        static GamingPage_UC Gaming = new GamingPage_UC();
        static Add_App_UC application = new Add_App_UC();
        public Main_Form()
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

        internal void NavigationUC(String UC)
        {
            switch (UC) 
            {
                case "home":
                    this.Controls.Remove(TopChart);
                    this.Controls.Remove(application);
                    this.Controls.Remove(Gaming);
                    this.Controls.Remove(Kids);
                    this.Controls.Add(home);
                    home.Location = new Point(12, 105);
                    break;


                case "topchart":
                    this.Controls.Remove(home);
                    this.Controls.Remove(application);
                    this.Controls.Add(TopChart);
                    this.Controls.Remove(Gaming);
                    this.Controls.Remove(Kids);
                    TopChart.Location = new Point(12, 105);
                    break;


                case "kids":
                    this.Controls.Remove(home);
                    this.Controls.Add(Kids);
                    this.Controls.Remove(application);
                    this.Controls.Remove(Gaming);
                    this.Controls.Remove(TopChart);
                    Kids.Location = new Point(12, 105);
                    break;


                case "gaming":
                    this.Controls.Remove(home);
                    this.Controls.Remove(Kids);
                    this.Controls.Remove(application);
                    this.Controls.Add(Gaming);
                    this.Controls.Remove(TopChart);
                    Gaming.Location = new Point(12, 105);
                    break;

                case "Application":
                    this.Controls.Remove(home);
                    this.Controls.Remove(Kids);
                    this.Controls.Remove(Gaming);
                    this.Controls.Remove(TopChart);
                    this.Controls.Add(application);
                    application.Location = new Point(10, 50);
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

        private void button6_Click(object sender, EventArgs e)
        {
            NavigationUC("kids");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NavigationUC("gaming");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            //btnProfile.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            pnlmenu.Visible = false;
            NavigationUC("Application");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //BackColor = Color.Transparent;
        }
        //internal void Remove_uc()
        //{
        //    foreach (Control C in this.Controls)
        //    {
        //        this.Controls.Remove(C);
        //    }
        //}

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        internal void HOME_ADDING()
        {
            this.Controls.Add(application);
            application.Location = new Point(10, 50);
        }
    }
}
