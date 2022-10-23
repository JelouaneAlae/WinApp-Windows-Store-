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
        UC_DM_AddApp UCDMAA = new UC_DM_AddApp();
        UC_DM_DeleteApp UCDMDA = new UC_DM_DeleteApp();
        UC_DM_ManageAPP UCDMMA = new UC_DM_ManageAPP();
        UC_DM_ManageDevInfo UCMDVI = new UC_DM_ManageDevInfo();
        public Developer_Mode_UC()
        {
            InitializeComponent();
        }

        private void Add_App_UC_Load(object sender, EventArgs e)
        {
            SwitchBetweenUC("AddApp");
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


        internal void SwitchBetweenUC(String UC)
        {
            switch (UC)
            {

                case "AddApp":
                    Clearform();
                    this.Controls.Add(UCDMAA);
                    UCDMAA.Location = new Point(206, 58);
                    break;

                case "ManageApp":
                    Clearform();
                    this.Controls.Add(UCDMMA);
                    UCDMMA.Location = new Point(206, 58);
                    break;

                case "DeleteApp":
                    Clearform();
                    this.Controls.Add(UCDMDA);
                    UCDMDA.Location = new Point(206, 58);
                    break;

                case "ManageDevInfo":
                    Clearform();
                    this.Controls.Add(UCMDVI);
                    UCMDVI.Location = new Point(206, 58);

                    break;

            }

        }



       



        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddApplication_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }



        private void BtnBackToHome_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SwitchBetweenUC("AddApp");
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

        private void btnManageApp_Click(object sender, EventArgs e)
        {
            SwitchBetweenUC("ManageApp");
        }

        private void btnDeleteApp_Click(object sender, EventArgs e)
        {
            SwitchBetweenUC("DeleteApp");
        }

        private void btnManageInfoDV_Click(object sender, EventArgs e)
        {
            SwitchBetweenUC("ManageDevInfo");
        }
    }
}
