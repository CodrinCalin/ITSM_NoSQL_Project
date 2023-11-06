namespace DemoApp
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.pictureBoxGarden = new System.Windows.Forms.PictureBox();
            this.labelLicense = new System.Windows.Forms.Label();
            this.labelNoDesk = new System.Windows.Forms.Label();
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.buttonIncidentManagement = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonShowList = new System.Windows.Forms.Button();
            this.labelPastDeadlineInc = new System.Windows.Forms.Label();
            this.labelClosedInc = new System.Windows.Forms.Label();
            this.labelResolvedInc = new System.Windows.Forms.Label();
            this.labelOpenIncidents = new System.Windows.Forms.Label();
            this.labelTicketProgress = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.progressBarPastDeadline = new System.Windows.Forms.ProgressBar();
            this.progressBarClosed = new System.Windows.Forms.ProgressBar();
            this.progressBarResolved = new System.Windows.Forms.ProgressBar();
            this.progressBarOpen = new System.Windows.Forms.ProgressBar();
            this.labelOpenProgress = new System.Windows.Forms.Label();
            this.labelResolvedProgress = new System.Windows.Forms.Label();
            this.labelClosedProgress = new System.Windows.Forms.Label();
            this.labelPastDeadlineProgress = new System.Windows.Forms.Label();
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
            this.buttonUserManagement.Click += new System.EventHandler(this.buttonUserManagement_Click);
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
            this.buttonIncidentManagement.Click += new System.EventHandler(this.buttonIncidentManagement_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonDashboard.Enabled = false;
            this.buttonDashboard.Location = new System.Drawing.Point(2, 129);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(324, 60);
            this.buttonDashboard.TabIndex = 7;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            // 
            // buttonShowList
            // 
            this.buttonShowList.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonShowList.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonShowList.Location = new System.Drawing.Point(100, 607);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.Size = new System.Drawing.Size(144, 54);
            this.buttonShowList.TabIndex = 33;
            this.buttonShowList.Text = "Show List";
            this.buttonShowList.UseVisualStyleBackColor = false;
            this.buttonShowList.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // labelPastDeadlineInc
            // 
            this.labelPastDeadlineInc.AutoSize = true;
            this.labelPastDeadlineInc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPastDeadlineInc.Location = new System.Drawing.Point(18, 502);
            this.labelPastDeadlineInc.Name = "labelPastDeadlineInc";
            this.labelPastDeadlineInc.Size = new System.Drawing.Size(122, 28);
            this.labelPastDeadlineInc.TabIndex = 29;
            this.labelPastDeadlineInc.Text = "Past dealine";
            // 
            // labelClosedInc
            // 
            this.labelClosedInc.AutoSize = true;
            this.labelClosedInc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClosedInc.Location = new System.Drawing.Point(18, 420);
            this.labelClosedInc.Name = "labelClosedInc";
            this.labelClosedInc.Size = new System.Drawing.Size(220, 28);
            this.labelClosedInc.TabIndex = 30;
            this.labelClosedInc.Text = "Closed without resolve";
            // 
            // labelResolvedInc
            // 
            this.labelResolvedInc.AutoSize = true;
            this.labelResolvedInc.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolvedInc.Location = new System.Drawing.Point(18, 337);
            this.labelResolvedInc.Name = "labelResolvedInc";
            this.labelResolvedInc.Size = new System.Drawing.Size(94, 28);
            this.labelResolvedInc.TabIndex = 31;
            this.labelResolvedInc.Text = "Resolved";
            // 
            // labelOpenIncidents
            // 
            this.labelOpenIncidents.AutoSize = true;
            this.labelOpenIncidents.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenIncidents.Location = new System.Drawing.Point(18, 256);
            this.labelOpenIncidents.Name = "labelOpenIncidents";
            this.labelOpenIncidents.Size = new System.Drawing.Size(62, 28);
            this.labelOpenIncidents.TabIndex = 32;
            this.labelOpenIncidents.Text = "Open";
            // 
            // labelTicketProgress
            // 
            this.labelTicketProgress.AutoSize = true;
            this.labelTicketProgress.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTicketProgress.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTicketProgress.Location = new System.Drawing.Point(55, 203);
            this.labelTicketProgress.Name = "labelTicketProgress";
            this.labelTicketProgress.Size = new System.Drawing.Size(241, 32);
            this.labelTicketProgress.TabIndex = 28;
            this.labelTicketProgress.Text = "Progress of Incidents";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelRole.Location = new System.Drawing.Point(555, 320);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(148, 32);
            this.labelRole.TabIndex = 27;
            this.labelRole.Text = "Your role is: ";
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Yu Gothic UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelWelcome.Location = new System.Drawing.Point(553, 203);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(239, 90);
            this.labelWelcome.TabIndex = 26;
            this.labelWelcome.Text = "Welcome back,\r\nperson !";
            // 
            // progressBarPastDeadline
            // 
            this.progressBarPastDeadline.ForeColor = System.Drawing.Color.Firebrick;
            this.progressBarPastDeadline.Location = new System.Drawing.Point(16, 533);
            this.progressBarPastDeadline.Name = "progressBarPastDeadline";
            this.progressBarPastDeadline.Size = new System.Drawing.Size(316, 45);
            this.progressBarPastDeadline.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPastDeadline.TabIndex = 22;
            // 
            // progressBarClosed
            // 
            this.progressBarClosed.ForeColor = System.Drawing.Color.Orange;
            this.progressBarClosed.Location = new System.Drawing.Point(16, 450);
            this.progressBarClosed.Name = "progressBarClosed";
            this.progressBarClosed.Size = new System.Drawing.Size(316, 45);
            this.progressBarClosed.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarClosed.TabIndex = 23;
            // 
            // progressBarResolved
            // 
            this.progressBarResolved.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBarResolved.Location = new System.Drawing.Point(16, 368);
            this.progressBarResolved.Name = "progressBarResolved";
            this.progressBarResolved.Size = new System.Drawing.Size(316, 45);
            this.progressBarResolved.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarResolved.TabIndex = 24;
            // 
            // progressBarOpen
            // 
            this.progressBarOpen.BackColor = System.Drawing.Color.Black;
            this.progressBarOpen.Location = new System.Drawing.Point(16, 287);
            this.progressBarOpen.Name = "progressBarOpen";
            this.progressBarOpen.Size = new System.Drawing.Size(316, 45);
            this.progressBarOpen.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarOpen.TabIndex = 25;
            // 
            // labelOpenProgress
            // 
            this.labelOpenProgress.AutoSize = true;
            this.labelOpenProgress.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenProgress.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelOpenProgress.Location = new System.Drawing.Point(338, 294);
            this.labelOpenProgress.Name = "labelOpenProgress";
            this.labelOpenProgress.Size = new System.Drawing.Size(61, 38);
            this.labelOpenProgress.TabIndex = 34;
            this.labelOpenProgress.Text = "0/0";
            // 
            // labelResolvedProgress
            // 
            this.labelResolvedProgress.AutoSize = true;
            this.labelResolvedProgress.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolvedProgress.ForeColor = System.Drawing.Color.Green;
            this.labelResolvedProgress.Location = new System.Drawing.Point(338, 375);
            this.labelResolvedProgress.Name = "labelResolvedProgress";
            this.labelResolvedProgress.Size = new System.Drawing.Size(61, 38);
            this.labelResolvedProgress.TabIndex = 35;
            this.labelResolvedProgress.Text = "0/0";
            // 
            // labelClosedProgress
            // 
            this.labelClosedProgress.AutoSize = true;
            this.labelClosedProgress.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClosedProgress.ForeColor = System.Drawing.Color.Orange;
            this.labelClosedProgress.Location = new System.Drawing.Point(338, 457);
            this.labelClosedProgress.Name = "labelClosedProgress";
            this.labelClosedProgress.Size = new System.Drawing.Size(61, 38);
            this.labelClosedProgress.TabIndex = 36;
            this.labelClosedProgress.Text = "0/0";
            // 
            // labelPastDeadlineProgress
            // 
            this.labelPastDeadlineProgress.AutoSize = true;
            this.labelPastDeadlineProgress.Font = new System.Drawing.Font("Yu Gothic UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPastDeadlineProgress.ForeColor = System.Drawing.Color.Crimson;
            this.labelPastDeadlineProgress.Location = new System.Drawing.Point(338, 540);
            this.labelPastDeadlineProgress.Name = "labelPastDeadlineProgress";
            this.labelPastDeadlineProgress.Size = new System.Drawing.Size(61, 38);
            this.labelPastDeadlineProgress.TabIndex = 37;
            this.labelPastDeadlineProgress.Text = "0/0";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 782);
            this.Controls.Add(this.labelPastDeadlineProgress);
            this.Controls.Add(this.labelClosedProgress);
            this.Controls.Add(this.labelResolvedProgress);
            this.Controls.Add(this.labelOpenProgress);
            this.Controls.Add(this.buttonShowList);
            this.Controls.Add(this.labelPastDeadlineInc);
            this.Controls.Add(this.labelClosedInc);
            this.Controls.Add(this.labelResolvedInc);
            this.Controls.Add(this.labelOpenIncidents);
            this.Controls.Add(this.labelTicketProgress);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.progressBarPastDeadline);
            this.Controls.Add(this.progressBarClosed);
            this.Controls.Add(this.progressBarResolved);
            this.Controls.Add(this.progressBarOpen);
            this.Controls.Add(this.pictureBoxGarden);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelNoDesk);
            this.Controls.Add(this.buttonUserManagement);
            this.Controls.Add(this.buttonIncidentManagement);
            this.Controls.Add(this.buttonDashboard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardForm";
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
        private System.Windows.Forms.Button buttonShowList;
        private System.Windows.Forms.Label labelPastDeadlineInc;
        private System.Windows.Forms.Label labelClosedInc;
        private System.Windows.Forms.Label labelResolvedInc;
        private System.Windows.Forms.Label labelOpenIncidents;
        private System.Windows.Forms.Label labelTicketProgress;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.ProgressBar progressBarPastDeadline;
        private System.Windows.Forms.ProgressBar progressBarClosed;
        private System.Windows.Forms.ProgressBar progressBarResolved;
        private System.Windows.Forms.ProgressBar progressBarOpen;
        private System.Windows.Forms.Label labelOpenProgress;
        private System.Windows.Forms.Label labelResolvedProgress;
        private System.Windows.Forms.Label labelClosedProgress;
        private System.Windows.Forms.Label labelPastDeadlineProgress;
    }
}