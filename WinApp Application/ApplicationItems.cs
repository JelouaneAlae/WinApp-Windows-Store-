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
    }
}
