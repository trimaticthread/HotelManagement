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
    public partial class userControlCustomerDetail : UserControl
    {
        functionDb fn = new functionDb();
        String query;

        public userControlCustomerDetail()
        {
            InitializeComponent();
        }

        private void txtSearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Shows every customer history
            if(txtSearchCategory.SelectedIndex == 0)
            {
                query = "Select Customer.cid,Customer.cname,Customer.mobile,Customer.nationality,Customer.gender,Customer.dob,Customer.idproof,Customer.adress,Customer.checkin,Customer.chekout,Rooms.roomNo,Rooms.roomType,Rooms.bed,Rooms.price from Customer inner join Rooms on Customer.roomId = Rooms.roomId";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }  
            else if(txtSearchCategory.SelectedIndex == 1)// Shows which customers are still in the hotel.
            {
                query = "Select Customer.cid,Customer.cname,Customer.mobile,Customer.nationality,Customer.gender,Customer.dob,Customer.idproof,Customer.adress,Customer.checkin,Customer.chekout,Rooms.roomNo,Rooms.roomType,Rooms.bed,Rooms.price from Customer inner join Rooms on Customer.roomId = Rooms.roomId where chekout is null";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtSearchCategory.SelectedIndex == 2)
            {
                query = "Select Customer.cid,Customer.cname,Customer.mobile,Customer.nationality,Customer.gender,Customer.dob,Customer.idproof,Customer.adress,Customer.checkin,Customer.chekout,Rooms.roomNo,Rooms.roomType,Rooms.bed,Rooms.price from Customer inner join Rooms on Customer.roomId = Rooms.roomId where chekout is not null";
                DataSet ds = fn.getData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }
     

    }
}
