using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinApp_Application
{
    public partial class Developer_Mode_UC : UserControl
    {
        public Developer_Mode_UC()
        {
            InitializeComponent();
        }

        private void Add_App_UC_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddApplication_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //WinApp_DBEntities2 db = new WinApp_DBEntities2();
            //if (string.IsNullOrEmpty(txtAppName.Text) && string.IsNullOrEmpty(txtAppDescription.Text) && string.IsNullOrEmpty(txtAppPrice.Text)
            //    && listCategory.SelectedItem == null && ListLanguageApp.SelectedItem == null && imgAppImage == null)
            //{
            //    MessageBox.Show("You must complete all information","ERROR");
            //}
            //else
            //{
            //    // get object client from email 
            //    var Current_client = db.Clients.Where(o => o.Email_CL == CLs_Info.email_CL).FirstOrDefault();

            //    APP app = new APP();
            //    app.Name_APP = txtAppName.Text;
            //    // get object category from email 
            //    var Current_category = db.categories.Where(o => o.Name_CAT == listCategory.Text).FirstOrDefault();
            //    app.Id_CAT = Current_category.Id_CAT;
            //    app.Id_Dv = Current_client.Id_CL;
            //    app.Language_APP = ListLanguageApp.Text;
            //    app.Price_APP = int.Parse(txtAppPrice.Text);
            //    app.description_APP = txtAppDescription.Text;
            //    // covert img to binary 
            //    byte[] bin = (byte[])new ImageConverter().ConvertTo(imgAppImage, typeof(byte[]));
            //    app.Picture_APP = bin;
            //    app.DateCreate_APP = dtpCreated.Value;
            //    app.DatePublishin_APP = dtpPublishing.Value;
            //    db.APPs.Add(app);
            //    db.SaveChanges();

            //}
        }


        private void BtnBackToHome_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToHome_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBackToHome_Click_2(object sender, EventArgs e)
        {
            var frm = Form.ActiveForm as Main_Form;
            frm.Controls.Remove(this);
            frm.NavigationUC("home");
            frm.pnlmenu.Visible = true;
        }
    }
}
