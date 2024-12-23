using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage.All_User_Control
{
    public partial class userControlEmployee : UserControl
    {
        functionDb fn = new functionDb();
        String query;



        public userControlEmployee()
        {
            InitializeComponent();
        }

        private void userControlEmployee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }

        private void btnEmpRegis_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtMail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile= Int64.Parse(txtMobile.Text);
                String gender = txtGender.Text;
                String mail = txtMail.Text; 
                String username = txtUsername.Text; 
                String password = txtPassword.Text;

                query = "insert into Employee(emp_name,mobile,gender,mail_id,username,pass) values('"+name+"','"+mobile+"','"+gender+"','"+mail+"','"+username+"','"+password+"')";
                fn.setData(query, "! Registration Successfull !");

                clearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill All Fields.", " ! Warning !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);

            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            if(txtEmpId.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Confirmed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where emp_id = '" + txtEmpId.Text + "'";
                    fn.setData(query, "! Deletion Successfull !");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }
        private void userControlEmployee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        // ----------------------------------------------------------------------------------------

        public void getMaxID()
        {
            query = "select max(emp_id) from Employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelSet.Text = (num + 1).ToString();
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtMail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        // Program gives error when i delete this so it stays.
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void setEmployee(DataGridView dgv)
        {
            query = "select * from Employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void userControlEmployee_Leave(object sender, EventArgs e)
        {

        }
    }
}
