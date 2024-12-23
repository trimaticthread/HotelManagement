using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace LoginPage
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userControlAddRoom1.Visible = false;
            btnAddRoom.PerformClick();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            panelToggle.Left = btnCustomerRegistration.Left;
            userControlCustomerRegister1.Visible = true;
            userControlCustomerRegister1.BringToFront();
            userControlAddRoom1.Visible=false;
            userControlCheckOut1.Visible=false;
            userControlCustomerDetail1.Visible=false;
            userControlEmployee1.Visible = false;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            panelToggle.Left = btnAddRoom.Left;
            userControlAddRoom1.Visible = true;
            userControlAddRoom1.BringToFront();
            userControlCustomerRegister1.Visible = false;
            userControlCheckOut1.Visible = false;
            userControlCustomerDetail1.Visible = false;
            userControlEmployee1.Visible = false;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            panelToggle.Left = btnCheckOut.Left;
            userControlCheckOut1.Visible = true;
            userControlCheckOut1.BringToFront();
            userControlCustomerRegister1.Visible=false;
            userControlAddRoom1.Visible=false;
            userControlCustomerDetail1.Visible=false;
            userControlEmployee1.Visible = false;
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            panelToggle.Left = btnCustomerDetails.Left;
            userControlCustomerDetail1.Visible = true;
            userControlCustomerDetail1.BringToFront();
            userControlAddRoom1.Visible = false;
            userControlCustomerRegister1.Visible = false ;
            userControlCheckOut1.Visible = false;
            userControlEmployee1.Visible = false;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panelToggle.Left = btnEmployee.Left;
            userControlEmployee1.Visible = true;
            userControlEmployee1.BringToFront();
            userControlAddRoom1.Visible = false;
            userControlCustomerDetail1.Visible = false;
            userControlCustomerRegister1.Visible = false;
            userControlCheckOut1.Visible=false;


        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
