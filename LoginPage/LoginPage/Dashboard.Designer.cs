namespace LoginPage
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelToggle = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControlAddRoom1 = new LoginPage.All_User_Control.userControlAddRoom();
            this.userControlCheckOut1 = new LoginPage.All_User_Control.userControlCheckOut();
            this.userControlCustomerDetail1 = new LoginPage.All_User_Control.userControlCustomerDetail();
            this.userControlCustomerRegister1 = new LoginPage.All_User_Control.userControlCustomerRegister();
            this.cancelButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.minimizeButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ucAddRoom = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UC_CustomerRegis = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UCCheckOut = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ucCustomerDetail = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ucEmployee = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userControlEmployee1 = new LoginPage.All_User_Control.userControlEmployee();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panelToggle);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerDetails);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCustomerRegistration);
            this.panel1.Controls.Add(this.btnAddRoom);
            this.panel1.Location = new System.Drawing.Point(63, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 133);
            this.panel1.TabIndex = 0;
            // 
            // panelToggle
            // 
            this.panelToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelToggle.Location = new System.Drawing.Point(17, 97);
            this.panelToggle.Name = "panelToggle";
            this.panelToggle.Size = new System.Drawing.Size(236, 5);
            this.panelToggle.TabIndex = 3;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Silver;
            this.btnEmployee.BorderRadius = 26;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployee.Location = new System.Drawing.Point(1034, 17);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(245, 85);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BackColor = System.Drawing.Color.Silver;
            this.btnCustomerDetails.BorderRadius = 26;
            this.btnCustomerDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerDetails.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetails.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDetails.Image")));
            this.btnCustomerDetails.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCustomerDetails.Location = new System.Drawing.Point(775, 17);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(236, 85);
            this.btnCustomerDetails.TabIndex = 3;
            this.btnCustomerDetails.Text = "Customer Details";
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Silver;
            this.btnCheckOut.BorderRadius = 26;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckOut.Image")));
            this.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckOut.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCheckOut.Location = new System.Drawing.Point(522, 17);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(236, 85);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "   Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.BackColor = System.Drawing.Color.Silver;
            this.btnCustomerRegistration.BorderRadius = 26;
            this.btnCustomerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRegistration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRegistration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCustomerRegistration.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCustomerRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRegistration.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRegistration.Image")));
            this.btnCustomerRegistration.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerRegistration.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCustomerRegistration.Location = new System.Drawing.Point(268, 17);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Size = new System.Drawing.Size(236, 85);
            this.btnCustomerRegistration.TabIndex = 1;
            this.btnCustomerRegistration.Text = "Customer Registration";
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.Silver;
            this.btnAddRoom.BorderRadius = 26;
            this.btnAddRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddRoom.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnAddRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddRoom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddRoom.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAddRoom.ForeColor = System.Drawing.Color.White;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddRoom.Location = new System.Drawing.Point(18, 17);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(236, 85);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.userControlEmployee1);
            this.panel2.Controls.Add(this.userControlAddRoom1);
            this.panel2.Controls.Add(this.userControlCheckOut1);
            this.panel2.Controls.Add(this.userControlCustomerDetail1);
            this.panel2.Controls.Add(this.userControlCustomerRegister1);
            this.panel2.Location = new System.Drawing.Point(12, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1344, 520);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // userControlAddRoom1
            // 
            this.userControlAddRoom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userControlAddRoom1.Location = new System.Drawing.Point(140, 3);
            this.userControlAddRoom1.Name = "userControlAddRoom1";
            this.userControlAddRoom1.Size = new System.Drawing.Size(1094, 489);
            this.userControlAddRoom1.TabIndex = 4;
            // 
            // userControlCheckOut1
            // 
            this.userControlCheckOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userControlCheckOut1.Location = new System.Drawing.Point(22, 3);
            this.userControlCheckOut1.Name = "userControlCheckOut1";
            this.userControlCheckOut1.Size = new System.Drawing.Size(1308, 493);
            this.userControlCheckOut1.TabIndex = 2;
            this.userControlCheckOut1.Visible = false;
            // 
            // userControlCustomerDetail1
            // 
            this.userControlCustomerDetail1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userControlCustomerDetail1.Location = new System.Drawing.Point(96, 3);
            this.userControlCustomerDetail1.Name = "userControlCustomerDetail1";
            this.userControlCustomerDetail1.Size = new System.Drawing.Size(1225, 480);
            this.userControlCustomerDetail1.TabIndex = 3;
            this.userControlCustomerDetail1.Visible = false;
            // 
            // userControlCustomerRegister1
            // 
            this.userControlCustomerRegister1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userControlCustomerRegister1.Location = new System.Drawing.Point(51, 2);
            this.userControlCustomerRegister1.Name = "userControlCustomerRegister1";
            this.userControlCustomerRegister1.Size = new System.Drawing.Size(1242, 515);
            this.userControlCustomerRegister1.TabIndex = 1;
            this.userControlCustomerRegister1.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cancelButton.FillColor = System.Drawing.Color.Empty;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageSize = new System.Drawing.Size(40, 40);
            this.cancelButton.Location = new System.Drawing.Point(12, 22);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cancelButton.Size = new System.Drawing.Size(44, 38);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizeButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizeButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizeButton.FillColor = System.Drawing.Color.Empty;
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageSize = new System.Drawing.Size(40, 40);
            this.minimizeButton.Location = new System.Drawing.Point(12, 76);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.minimizeButton.Size = new System.Drawing.Size(44, 38);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // ucAddRoom
            // 
            this.ucAddRoom.TargetControl = this.panel2;
            // 
            // UC_CustomerRegis
            // 
            this.UC_CustomerRegis.BorderRadius = 30;
            this.UC_CustomerRegis.TargetControl = this.panel2;
            // 
            // UCCheckOut
            // 
            this.UCCheckOut.BorderRadius = 30;
            // 
            // ucCustomerDetail
            // 
            this.ucCustomerDetail.BorderRadius = 30;
            // 
            // ucEmployee
            // 
            this.ucEmployee.BorderRadius = 30;
            // 
            // userControlEmployee1
            // 
            this.userControlEmployee1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.userControlEmployee1.Location = new System.Drawing.Point(51, 25);
            this.userControlEmployee1.Name = "userControlEmployee1";
            this.userControlEmployee1.Size = new System.Drawing.Size(1230, 492);
            this.userControlEmployee1.TabIndex = 5;
            this.userControlEmployee1.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1384, 710);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CircleButton cancelButton;
        private Guna.UI2.WinForms.Guna2CircleButton minimizeButton;
        private Guna.UI2.WinForms.Guna2Button btnAddRoom;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRegistration;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnCustomerDetails;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private System.Windows.Forms.Panel panelToggle;
        private Guna.UI2.WinForms.Guna2Elipse ucAddRoom;
        private Guna.UI2.WinForms.Guna2Elipse UC_CustomerRegis;
        private All_User_Control.userControlCustomerRegister userControlCustomerRegister1;
        private Guna.UI2.WinForms.Guna2Elipse UCCheckOut;
        private All_User_Control.userControlCheckOut userControlCheckOut1;
        private Guna.UI2.WinForms.Guna2Elipse ucCustomerDetail;
        private All_User_Control.userControlCustomerDetail userControlCustomerDetail1;
        private All_User_Control.userControlAddRoom userControlAddRoom1;
        private Guna.UI2.WinForms.Guna2Elipse ucEmployee;
        private All_User_Control.userControlEmployee userControlEmployee1;
    }
}