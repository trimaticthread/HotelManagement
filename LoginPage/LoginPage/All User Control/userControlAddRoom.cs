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
    public partial class userControlAddRoom : UserControl
    {
        functionDb fn = new functionDb();
        String query;



        public userControlAddRoom()
        {
            InitializeComponent();
        }

        private void userControlAddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from Rooms";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if(txtRoomNumber.Text!="" && txtRoomType.Text!="" && txtBed.Text!="" && txtPrice.Text != "")
            {
                String roomno = txtRoomNumber.Text;
                String type = txtRoomType.Text;
                String bed = txtBed.Text;   
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into Rooms (roomNo,roomType,bed,price) values ('"+roomno+"','"+type+"','"+bed+"','"+price+"')";
                fn.setData(query,"Room Added. ");

                userControlAddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill Every Field.", "! Warning ! ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtRoomNumber.Clear();
            txtRoomType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void userControlAddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void userControlAddRoom_Enter(object sender, EventArgs e)
        {
            userControlAddRoom_Load(this, null);
        }
    }
}
