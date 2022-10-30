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
    public partial class TopChartApplication_UC : UserControl
    {
        public TopChartApplication_UC()
        {
            InitializeComponent();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void TopChartApplication_UC_Load(object sender, EventArgs e)
        {

        }

        #region
        public String AppName;
        public Image AppImage;
        public String AppCompany;


        public string _appname
        {
            get { return AppName; }
            set { AppName = value; value = lblAppName.Text; }
        }

        public Image _AppImage
        {
            get { return AppImage; }
            set { AppImage = value; value = imgAppImage.Image; }
        }

        public String _AppCompany
        {
            get { return AppCompany; }
            set { AppCompany = value; value = lblAppCompany.Text; }
        }

        #endregion

    }
}
