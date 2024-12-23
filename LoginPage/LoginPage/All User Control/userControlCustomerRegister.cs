using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage.All_User_Control
{
    public partial class userControlCustomerRegister : UserControl
    {
        functionDb func = new functionDb();
        String query;


        public userControlCustomerRegister()
        {
            InitializeComponent();
        }

        private void userControlCustomerRegister_Load(object sender, EventArgs e)
        {

        }

        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = func.getforCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNumber.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from Rooms where bed = '"+txtBed.Text+"' and roomType='"+txtRoomType.Text+"' and booked = 'No' ";
            setComboBox(query, txtRoomNumber);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomType.SelectedIndex = -1;
            txtRoomNumber.Items.Clear();
            txtPrice.Clear();
        }

        int rid;
        private void txtRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, roomId from Rooms where roomNo = '"+txtRoomNumber.Text+"'";
            DataSet ds = func.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void btnReserveRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text !="" && txtGender.Text !="" && txtDob.Text !="" && txtID.Text !="" && txtAddress.Text !="" && txtCheckIn.Text !="" && txtPrice.Text !="")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String nationality = txtNationality.Text;
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                String idproof = txtID.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckIn.Text;

                query = "INSERT INTO Customer (cname, mobile, nationality, gender, dob, idproof, adress, checkin, roomId)  VALUES ('" + name + "','" + mobile + "','" + nationality + "','" + gender + "', '" + dob + "', '" + idproof + "', '" + address + "', '" + checkin + "', '"+rid+"') update Rooms set booked = 'YES' where roomNo = '" + txtRoomNumber.Text + "' ";

                func.setData(query,"Room No" +txtRoomNumber.Text+ "Room Successfully Reserved.");
                clearAll();
            }

           

            else
            {
                MessageBox.Show("! Fill all fields !", "! Information !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtID.ResetText();
            txtAddress.ResetText();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoomNumber.Items.Clear();
            txtRoomType.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void userControlCustomerRegister_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
 