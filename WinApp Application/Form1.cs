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

        }

        public void ListApp()
        {
            ApplicationItems[] Applist = new ApplicationItems[20];
            for (int i = 0; i< Applist.Length; i++)
            {
                Applist[i] = new ApplicationItems();
                flowLayoutPanel1.Controls.Add(Applist[i]);
            }
        }
    }
}
