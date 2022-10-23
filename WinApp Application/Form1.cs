using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_Application
{
    public partial class Form1 : Form
    {
        static Home_UC home = new Home_UC();
        static TopChartPage_UC TopChart = new TopChartPage_UC();
        static KidsPage_UC Kids = new KidsPage_UC();
        static GamingPage_UC Gaming = new GamingPage_UC();
<<<<<<< Updated upstream:WinApp Application/Form1.cs
        static Add_App_UC application = new Add_App_UC();
        public Form1()
=======
        static Developer_Mode_UC application = new Developer_Mode_UC();
        UC_Setting UCS = new UC_Setting();
        UC_Support UCSU = new UC_Support();
        UC_About UCA = new UC_About();
        
        public Main_Form()
>>>>>>> Stashed changes:WinApp Application/MainForm.cs
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
        public void Clearform()
        {
            foreach (Control C in this.Controls)
            {
                if (C.Name.Contains("UC"))
                {
                    this.Controls.Remove(C);
                }
            }
        }
         

        public void NavigationUC(String UC)
        {
            switch (UC)
            {

                case "home":
                    Clearform();
                    this.Controls.Add(home);
                    home.Location = new Point(12, 105);
                    pnlSlide.Location = new Point(3, 43);

                    break;


                case "topchart":                    
                    Clearform();
                    this.Controls.Add(TopChart);
                    TopChart.Location = new Point(12, 105);
                    pnlSlide.Location = new Point(194, 43);
                    break;


                case "kids":
                    Clearform();
                    this.Controls.Add(Kids);
                    Kids.Location = new Point(12, 105);
                    pnlSlide.Location = new Point(370, 43);
                    break;


                case "gaming":
                    Clearform();
                    this.Controls.Add(Gaming);
                    Gaming.Location = new Point(12, 105);
                    pnlSlide.Location = new Point(546, 43);
                    break;

                case "Application":
                    Clearform();
                    this.Controls.Add(application);
<<<<<<< Updated upstream:WinApp Application/Form1.cs
                    application.Location = new Point(12, 105);
=======
                    application.Location = new Point(0, 50);
                    pnlSlide.Location = new Point(726, 45);
>>>>>>> Stashed changes:WinApp Application/MainForm.cs
                    break;

                case "Setting":
                    this.Controls.Add(UCS);
                    UCS.Location = new Point(0, 50);
                    break;

                case "Support":
                    this.Controls.Add(UCSU);
                    UCSU.Location = new Point(0, 50);
                    break;


                case "About":
                    this.Controls.Add(UCA);
                    UCA.Location = new Point(0, 50);
                    break;

            }

        }


        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

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
            NavigationUC("Application");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //BackColor = Color.Transparent;
        }
<<<<<<< Updated upstream:WinApp Application/Form1.cs
=======
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


        private void button1_Click_3(object sender, EventArgs e)
        {
            pnlmenu.Visible = false;
            NavigationUC("Application");
        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            if (pnlBarObtion.Visible == true)
            {
                pnlBarObtion.Visible = false;
                pnlBarObtion.Location = new Point(707, 59);
                pnlBarObtion.BringToFront();
            }
            else
                pnlBarObtion.Visible = true;
            pnlBarObtion.Location = new Point(707, 59);
            pnlBarObtion.BringToFront();

        }

        private void btnBar_MouseHover(object sender, EventArgs e)
        {

            //pnlBarObtion.Visible = true;

        }

        private void btnBar_MouseLeave(object sender, EventArgs e)
        {
            //pnlBarObtion.Visible = false;
        }

        private void btnBar_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void pnlBarObtion_MouseHover(object sender, EventArgs e)
        {

            //pnlBarObtion.Visible = true;

        }

        private void pnlBarObtion_MouseLeave(object sender, EventArgs e)
        {


        }

        private void pnlBarObtion_MouseEnter(object sender, EventArgs e)
        {

        }

        private void Main_Form_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnTopChar_Click(object sender, EventArgs e)
        {
            NavigationUC("topchart");

        }

        private void btnKids_Click(object sender, EventArgs e)
        {
            NavigationUC("kids");

        }

        private void btnGaming_Click(object sender, EventArgs e)
        {
            NavigationUC("gaming");

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void btnBarSetting_Click(object sender, EventArgs e)
        {
            Clear_Form();
            pnlmenu.Visible = false;
            NavigationUC("Setting");

        }

        internal void Clear_Form()
        {
            foreach (Control C in this.Controls)
            {
                if (C.Name.Contains("UC"))
                {
                    this.Controls.Remove(C);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            NavigationUC("home");
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ////Image T  = Image. FromFile("bokeh_PNG7.png");
            //pictureBox1.Image = Image.FromFile("bokeh_PNG7.png");
            //pictureBox1.Visible = true;
            
        }

        private void btnBarSupport_Click(object sender, EventArgs e)
        {
            Clear_Form();
            pnlmenu.Visible = false;
            NavigationUC("Support");
        }

        private void btnBarAbout_Click(object sender, EventArgs e)
        {
            Clear_Form();
            pnlmenu.Visible = false;
            NavigationUC("About");
        }
>>>>>>> Stashed changes:WinApp Application/MainForm.cs
    }
}
