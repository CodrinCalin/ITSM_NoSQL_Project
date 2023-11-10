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
            this.buttonCreateTicket = new System.Windows.Forms.Button();
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonEscalate = new System.Windows.Forms.Button();
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
            this.buttonIncidentManagement.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonIncidentManagement.Enabled = false;
            this.buttonIncidentManagement.Location = new System.Drawing.Point(321, 129);
            this.buttonIncidentManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIncidentManagement.Name = "buttonIncidentManagement";
            this.buttonIncidentManagement.Size = new System.Drawing.Size(324, 60);
            this.buttonIncidentManagement.TabIndex = 8;
            this.buttonIncidentManagement.Text = "Incident Management";
            this.buttonIncidentManagement.UseVisualStyleBackColor = false;
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
            // buttonCreateTicket
            // 
            this.buttonCreateTicket.BackColor = System.Drawing.Color.Aqua;
            this.buttonCreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCreateTicket.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTicket.Location = new System.Drawing.Point(760, 209);
            this.buttonCreateTicket.Name = "buttonCreateTicket";
            this.buttonCreateTicket.Size = new System.Drawing.Size(194, 36);
            this.buttonCreateTicket.TabIndex = 15;
            this.buttonCreateTicket.Text = "CREATE INCIDENT";
            this.buttonCreateTicket.UseVisualStyleBackColor = false;
            this.buttonCreateTicket.Click += new System.EventHandler(this.buttonCreateTicket_Click);
            // 
            // listViewTickets
            // 
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewTickets.Location = new System.Drawing.Point(18, 271);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(936, 392);
            this.listViewTickets.TabIndex = 16;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(272, 194);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(150, 29);
            this.buttonFilter.TabIndex = 17;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(428, 195);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 29);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(584, 195);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(150, 29);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonCloseTicket_Click);
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Location = new System.Drawing.Point(272, 230);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(150, 29);
            this.buttonTransfer.TabIndex = 17;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(428, 230);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(150, 29);
            this.buttonSort.TabIndex = 17;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonEscalate
            // 
            this.buttonEscalate.Location = new System.Drawing.Point(584, 230);
            this.buttonEscalate.Name = "buttonEscalate";
            this.buttonEscalate.Size = new System.Drawing.Size(150, 29);
            this.buttonEscalate.TabIndex = 17;
            this.buttonEscalate.Text = "Escalate";
            this.buttonEscalate.UseVisualStyleBackColor = true;
            // 
            // IncidentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 782);
            this.Controls.Add(this.buttonEscalate);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.listViewTickets);
            this.Controls.Add(this.buttonCreateTicket);
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
        private System.Windows.Forms.Button buttonCreateTicket;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonEscalate;
    }
}