namespace DemoApp
{
    partial class UserManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            this.pictureBoxGarden = new System.Windows.Forms.PictureBox();
            this.labelLicense = new System.Windows.Forms.Label();
            this.labelNoDesk = new System.Windows.Forms.Label();
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.buttonIncidentManagement = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.filterByEmailTxtBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tickets = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateNewUserPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.emailAddressTxtBox = new System.Windows.Forms.TextBox();
            this.locationTxtBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.TypeOfUserTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.infolbl = new System.Windows.Forms.Label();
            this.SuperDeskCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.UsernameTxtBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).BeginInit();
            this.CreateNewUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxGarden
            // 
            this.pictureBoxGarden.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGarden.Image")));
            this.pictureBoxGarden.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGarden.InitialImage")));
            this.pictureBoxGarden.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxGarden.Name = "pictureBoxGarden";
            this.pictureBoxGarden.Size = new System.Drawing.Size(200, 83);
            this.pictureBoxGarden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGarden.TabIndex = 12;
            this.pictureBoxGarden.TabStop = false;
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.BackColor = System.Drawing.Color.White;
            this.labelLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicense.Location = new System.Drawing.Point(409, 45);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(233, 20);
            this.labelLicense.TabIndex = 11;
            this.labelLicense.Text = "Licensed to: The Garden Group";
            // 
            // labelNoDesk
            // 
            this.labelNoDesk.AutoSize = true;
            this.labelNoDesk.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoDesk.Location = new System.Drawing.Point(506, 4);
            this.labelNoDesk.Name = "labelNoDesk";
            this.labelNoDesk.Size = new System.Drawing.Size(139, 39);
            this.labelNoDesk.TabIndex = 10;
            this.labelNoDesk.Text = "NoDesk";
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonUserManagement.Enabled = false;
            this.buttonUserManagement.Location = new System.Drawing.Point(428, 84);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(216, 39);
            this.buttonUserManagement.TabIndex = 9;
            this.buttonUserManagement.Text = "User Management";
            this.buttonUserManagement.UseVisualStyleBackColor = false;
            // 
            // buttonIncidentManagement
            // 
            this.buttonIncidentManagement.Location = new System.Drawing.Point(214, 84);
            this.buttonIncidentManagement.Name = "buttonIncidentManagement";
            this.buttonIncidentManagement.Size = new System.Drawing.Size(216, 39);
            this.buttonIncidentManagement.TabIndex = 8;
            this.buttonIncidentManagement.Text = "Incident Management";
            this.buttonIncidentManagement.UseVisualStyleBackColor = true;
            this.buttonIncidentManagement.Click += new System.EventHandler(this.buttonIncidentManagement_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(1, 84);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(216, 39);
            this.buttonDashboard.TabIndex = 7;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.AllowColumnReorder = true;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Email,
            this.FirstName,
            this.LastName,
            this.tickets});
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(12, 228);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(620, 268);
            this.listViewUsers.TabIndex = 13;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // filterByEmailTxtBox
            // 
            this.filterByEmailTxtBox.Location = new System.Drawing.Point(12, 179);
            this.filterByEmailTxtBox.Name = "filterByEmailTxtBox";
            this.filterByEmailTxtBox.Size = new System.Drawing.Size(205, 20);
            this.filterByEmailTxtBox.TabIndex = 14;
            this.filterByEmailTxtBox.Text = "Filter by Email";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 147);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(94, 13);
            this.InfoLabel.TabIndex = 15;
            this.InfoLabel.Text = "User Management";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.Lime;
            this.btnAddNewUser.Location = new System.Drawing.Point(509, 161);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(123, 38);
            this.btnAddNewUser.TabIndex = 16;
            this.btnAddNewUser.Text = "+ ADD NEW USER ";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 40;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 200;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Fist Name";
            this.FirstName.Width = 140;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 140;
            // 
            // tickets
            // 
            this.tickets.Text = "Phone Number";
            this.tickets.Width = 100;
            // 
            // CreateNewUserPanel
            // 
            this.CreateNewUserPanel.Controls.Add(this.UsernameTxtBox);
            this.CreateNewUserPanel.Controls.Add(this.label9);
            this.CreateNewUserPanel.Controls.Add(this.SuperDeskCheckBox);
            this.CreateNewUserPanel.Controls.Add(this.infolbl);
            this.CreateNewUserPanel.Controls.Add(this.label8);
            this.CreateNewUserPanel.Controls.Add(this.passwordTxtBox);
            this.CreateNewUserPanel.Controls.Add(this.FirstNameTxtBox);
            this.CreateNewUserPanel.Controls.Add(this.TypeOfUserTxtBox);
            this.CreateNewUserPanel.Controls.Add(this.phoneNumberTxtBox);
            this.CreateNewUserPanel.Controls.Add(this.locationTxtBox);
            this.CreateNewUserPanel.Controls.Add(this.emailAddressTxtBox);
            this.CreateNewUserPanel.Controls.Add(this.LastNameTxtBox);
            this.CreateNewUserPanel.Controls.Add(this.btnAddUser);
            this.CreateNewUserPanel.Controls.Add(this.btnCancel);
            this.CreateNewUserPanel.Controls.Add(this.label7);
            this.CreateNewUserPanel.Controls.Add(this.label6);
            this.CreateNewUserPanel.Controls.Add(this.label5);
            this.CreateNewUserPanel.Controls.Add(this.label4);
            this.CreateNewUserPanel.Controls.Add(this.label3);
            this.CreateNewUserPanel.Controls.Add(this.label2);
            this.CreateNewUserPanel.Controls.Add(this.label1);
            this.CreateNewUserPanel.Location = new System.Drawing.Point(1, 130);
            this.CreateNewUserPanel.Name = "CreateNewUserPanel";
            this.CreateNewUserPanel.Size = new System.Drawing.Size(645, 366);
            this.CreateNewUserPanel.TabIndex = 17;
            this.CreateNewUserPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type Of User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Location/Branch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(213, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddUser.Location = new System.Drawing.Point(338, 313);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(91, 36);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(213, 82);
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(216, 20);
            this.LastNameTxtBox.TabIndex = 9;
            // 
            // emailAddressTxtBox
            // 
            this.emailAddressTxtBox.Location = new System.Drawing.Point(213, 142);
            this.emailAddressTxtBox.Name = "emailAddressTxtBox";
            this.emailAddressTxtBox.Size = new System.Drawing.Size(216, 20);
            this.emailAddressTxtBox.TabIndex = 10;
            // 
            // locationTxtBox
            // 
            this.locationTxtBox.Location = new System.Drawing.Point(213, 205);
            this.locationTxtBox.Name = "locationTxtBox";
            this.locationTxtBox.Size = new System.Drawing.Size(216, 20);
            this.locationTxtBox.TabIndex = 11;
            // 
            // phoneNumberTxtBox
            // 
            this.phoneNumberTxtBox.Location = new System.Drawing.Point(213, 176);
            this.phoneNumberTxtBox.Name = "phoneNumberTxtBox";
            this.phoneNumberTxtBox.Size = new System.Drawing.Size(216, 20);
            this.phoneNumberTxtBox.TabIndex = 12;
            // 
            // TypeOfUserTxtBox
            // 
            this.TypeOfUserTxtBox.Location = new System.Drawing.Point(213, 112);
            this.TypeOfUserTxtBox.Name = "TypeOfUserTxtBox";
            this.TypeOfUserTxtBox.Size = new System.Drawing.Size(216, 20);
            this.TypeOfUserTxtBox.TabIndex = 13;
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(213, 53);
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(216, 20);
            this.FirstNameTxtBox.TabIndex = 14;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(213, 236);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(216, 20);
            this.passwordTxtBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Create New User";
            // 
            // infolbl
            // 
            this.infolbl.AutoSize = true;
            this.infolbl.Location = new System.Drawing.Point(70, 294);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(112, 13);
            this.infolbl.TabIndex = 17;
            this.infolbl.Text = "Super Desk Employee";
            // 
            // SuperDeskCheckBox
            // 
            this.SuperDeskCheckBox.AutoSize = true;
            this.SuperDeskCheckBox.Location = new System.Drawing.Point(213, 290);
            this.SuperDeskCheckBox.Name = "SuperDeskCheckBox";
            this.SuperDeskCheckBox.Size = new System.Drawing.Size(44, 17);
            this.SuperDeskCheckBox.TabIndex = 18;
            this.SuperDeskCheckBox.Text = "Yes";
            this.SuperDeskCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Username";
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.Location = new System.Drawing.Point(213, 266);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(216, 20);
            this.UsernameTxtBox.TabIndex = 20;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(225, 179);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(54, 23);
            this.SearchBtn.TabIndex = 18;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 508);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CreateNewUserPanel);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.filterByEmailTxtBox);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.pictureBoxGarden);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelNoDesk);
            this.Controls.Add(this.buttonUserManagement);
            this.Controls.Add(this.buttonIncidentManagement);
            this.Controls.Add(this.buttonDashboard);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "o";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).EndInit();
            this.CreateNewUserPanel.ResumeLayout(false);
            this.CreateNewUserPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGarden;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Label labelNoDesk;
        private System.Windows.Forms.Button buttonUserManagement;
        private System.Windows.Forms.Button buttonIncidentManagement;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.TextBox filterByEmailTxtBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader tickets;
        private System.Windows.Forms.Panel CreateNewUserPanel;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.TextBox TypeOfUserTxtBox;
        private System.Windows.Forms.TextBox phoneNumberTxtBox;
        private System.Windows.Forms.TextBox locationTxtBox;
        private System.Windows.Forms.TextBox emailAddressTxtBox;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.CheckBox SuperDeskCheckBox;
        private System.Windows.Forms.TextBox UsernameTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button SearchBtn;
    }
}