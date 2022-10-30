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
    public partial class ApplicationItems : UserControl
    {
        public ApplicationItems()
        {
            InitializeComponent();
        }

        #region proprety


        public Image Imageapp;
        public string NameApp;
        public string PriceApp;



        [Category ("Cusom Props")]
        public Image _imageapp
        {
            get { return Imageapp; }
            set { Imageapp = value; }
        }



        [Category("Cusom Props")]
        public string _NameApp
        {
            get { return NameApp; }
            set { NameApp=value ; }
        }



        [Category("Cusom Props")]
        public string _PriceApp
        {
            get { return PriceApp; }
            set { PriceApp= value ; }
        }


        #endregion

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ApplicationItems_Load(object sender, EventArgs e)
        {

        }

        #region
        public String AppName;
        public Image AppImage;
        public String AppPrice;


        public string _appname
        {
            get { return AppName; }
            set { AppName = value;  value = txtAppname.Text; }
        }

        public Image _AppImage
        {
            get { return AppImage; }
            set { AppImage = value;value = imageAppli.Image; }
        }

        public String _AppPrice
        {
            get { return AppPrice; }
            set { AppPrice = value; value = txtPriceApp.Text; }
        }

        #endregion
    }
}
