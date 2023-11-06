﻿namespace DemoApp
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
            this.labelLicense.BackColor = System.Drawing.Color.White;
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
            this.buttonUserManagement.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonUserManagement.Enabled = false;
            this.buttonUserManagement.Location = new System.Drawing.Point(642, 129);
            this.buttonUserManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(324, 60);
            this.buttonUserManagement.TabIndex = 9;
            this.buttonUserManagement.Text = "User Management";
            this.buttonUserManagement.UseVisualStyleBackColor = false;
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
            this.buttonDashboard.Location = new System.Drawing.Point(2, 129);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(324, 60);
            this.buttonDashboard.TabIndex = 7;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 782);
            this.Controls.Add(this.pictureBoxGarden);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelNoDesk);
            this.Controls.Add(this.buttonUserManagement);
            this.Controls.Add(this.buttonIncidentManagement);
            this.Controls.Add(this.buttonDashboard);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserManagementForm";
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
    }
}