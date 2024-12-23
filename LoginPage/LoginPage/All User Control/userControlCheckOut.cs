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
    public partial class userControlCheckOut : UserControl
    {
        functionDb func = new functionDb();
        String query;



        public userControlCheckOut()
        {
            InitializeComponent();
        }

        private void userControlCheckOut_Load(object sender, EventArgs e)
        {
            query = "select Customer.cid,Customer.cname,Customer.mobile,Customer.nationality,Customer.gender,Customer.dob,Customer.idproof,Customer.adress,Customer.checkin,Rooms.roomNo,Rooms.roomType,Rooms.bed,Rooms.price from Customer INNER JOIN Rooms on Customer.roomId = Rooms.roomId where checkout = 'NO'";
            DataSet ds = func.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select Customer.cid,Customer.cname,Customer.mobile,Customer.nationality,Customer.gender,Customer.dob,Customer.idproof,Customer.adress,Customer.checkin,Rooms.roomNo,Rooms.roomType,Rooms.bed,Rooms.price from Customer INNER JOIN Rooms on Customer.roomId = Rooms.roomId where cname like '"+txtName.Text + "%' and checkout ='NO'";
            DataSet ds = func.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }


        // This class takes the 0, 1 and 9 indexes from the user information displayed row by row and shows them to us. This corresponds to id, username and room number in our table.
        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCname.Text = (guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                txtRoomNumber.Text = (guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtCname.Text != "")
            {
                if (MessageBox.Show("Are You Sure ?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;

                    query = "update Customer set checkout = 'YES', chekout = '" + cdate+"' where cid = "+id+" update Rooms set booked = 'NO' where roomNo = '"+txtRoomNumber.Text+"'";


                    func.setData(query, "! Check Out Successfull !");
                    userControlCheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No Customer Selected.","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtCname.Clear();
            txtName.Clear();
            txtRoomNumber.Clear();
            txtCheckOutDate.ResetText();
        }

    }
}
