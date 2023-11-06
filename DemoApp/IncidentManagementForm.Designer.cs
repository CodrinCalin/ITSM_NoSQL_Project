namespace DemoApp
{
    partial class IncidentManagementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncidentManagementForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "asdf",
            "gfdsla",
            "23-11-2023",
            "dd"}, -1);
            this.pictureBoxGarden = new System.Windows.Forms.PictureBox();
            this.labelLicense = new System.Windows.Forms.Label();
            this.labelNoDesk = new System.Windows.Forms.Label();
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.buttonIncidentManagement = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.labelOverviewTickets = new System.Windows.Forms.Label();
            this.textBoxSubjectFiltering = new System.Windows.Forms.TextBox();
            this.buttonCreateTicket = new System.Windows.Forms.Button();
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGarden
            // 
            this.pictureBoxGarden.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGarden.Image")));
            this.pictureBoxGarden.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGarden.InitialImage")));
            this.pictureBoxGarden.Location = new System.Drawing.Point(2, 2);
            this.pictureBoxGarden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxGarden.Name = "pictureBoxGarden";
            this.pictureBoxGarden.Size = new System.Drawing.Size(300, 128);
            this.pictureBoxGarden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGarden.TabIndex = 12;
            this.pictureBoxGarden.TabStop = false;
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicense.Location = new System.Drawing.Point(614, 69);
            this.labelLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(351, 29);
            this.labelLicense.TabIndex = 11;
            this.labelLicense.Text = "Licensed to: The Garden Group";
            // 
            // labelNoDesk
            // 
            this.labelNoDesk.AutoSize = true;
            this.labelNoDesk.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoDesk.Location = new System.Drawing.Point(759, 6);
            this.labelNoDesk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoDesk.Name = "labelNoDesk";
            this.labelNoDesk.Size = new System.Drawing.Size(206, 57);
            this.labelNoDesk.TabIndex = 10;
            this.labelNoDesk.Text = "NoDesk";
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.Location = new System.Drawing.Point(642, 129);
            this.buttonUserManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(324, 60);
            this.buttonUserManagement.TabIndex = 9;
            this.buttonUserManagement.Text = "User Management";
            this.buttonUserManagement.UseVisualStyleBackColor = true;
            // 
            // buttonIncidentManagement
            // 
            this.buttonIncidentManagement.Location = new System.Drawing.Point(321, 129);
            this.buttonIncidentManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIncidentManagement.Name = "buttonIncidentManagement";
            this.buttonIncidentManagement.Size = new System.Drawing.Size(324, 60);
            this.buttonIncidentManagement.TabIndex = 8;
            this.buttonIncidentManagement.Text = "Incident Management";
            this.buttonIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(2, 129);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(324, 60);
            this.buttonDashboard.TabIndex = 7;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // labelOverviewTickets
            // 
            this.labelOverviewTickets.AutoSize = true;
            this.labelOverviewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverviewTickets.Location = new System.Drawing.Point(12, 205);
            this.labelOverviewTickets.Name = "labelOverviewTickets";
            this.labelOverviewTickets.Size = new System.Drawing.Size(236, 32);
            this.labelOverviewTickets.TabIndex = 13;
            this.labelOverviewTickets.Text = "Overview tickets";
            // 
            // textBoxSubjectFiltering
            // 
            this.textBoxSubjectFiltering.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxSubjectFiltering.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubjectFiltering.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxSubjectFiltering.Location = new System.Drawing.Point(382, 210);
            this.textBoxSubjectFiltering.Name = "textBoxSubjectFiltering";
            this.textBoxSubjectFiltering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSubjectFiltering.Size = new System.Drawing.Size(227, 31);
            this.textBoxSubjectFiltering.TabIndex = 14;
            this.textBoxSubjectFiltering.Text = "filter by subject";
            this.textBoxSubjectFiltering.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCreateTicket
            // 
            this.buttonCreateTicket.BackColor = System.Drawing.Color.Aqua;
            this.buttonCreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTicket.Location = new System.Drawing.Point(727, 205);
            this.buttonCreateTicket.Name = "buttonCreateTicket";
            this.buttonCreateTicket.Size = new System.Drawing.Size(194, 36);
            this.buttonCreateTicket.TabIndex = 15;
            this.buttonCreateTicket.Text = "CREATE INCIDENT";
            this.buttonCreateTicket.UseVisualStyleBackColor = false;
            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Subject,
            this.User,
            this.Date,
            this.Status});
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewTickets.Location = new System.Drawing.Point(18, 261);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(936, 392);
            this.listViewTickets.TabIndex = 16;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 100;
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 280;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 180;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 180;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 150;
            // 
            // IncidentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 782);
            this.Controls.Add(this.listViewTickets);
            this.Controls.Add(this.buttonCreateTicket);
            this.Controls.Add(this.textBoxSubjectFiltering);
            this.Controls.Add(this.labelOverviewTickets);
            this.Controls.Add(this.pictureBoxGarden);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelNoDesk);
            this.Controls.Add(this.buttonUserManagement);
            this.Controls.Add(this.buttonIncidentManagement);
            this.Controls.Add(this.buttonDashboard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IncidentManagementForm";
            this.Text = "IncidentManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).EndInit();
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
        private System.Windows.Forms.Label labelOverviewTickets;
        private System.Windows.Forms.TextBox textBoxSubjectFiltering;
        private System.Windows.Forms.Button buttonCreateTicket;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
    }
}