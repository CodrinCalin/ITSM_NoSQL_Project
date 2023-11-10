﻿namespace DemoApp
{
    partial class CreateTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTicketForm));
            this.labelNoDesk = new System.Windows.Forms.Label();
            this.labelLicense = new System.Windows.Forms.Label();
            this.pictureBoxGarden = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.subjectOfIncidentBox = new System.Windows.Forms.TextBox();
            this.typeOfIncidentBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.reportedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deadlineBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitTicketButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNoDesk
            // 
            this.labelNoDesk.AutoSize = true;
            this.labelNoDesk.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoDesk.Location = new System.Drawing.Point(425, 9);
            this.labelNoDesk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoDesk.Name = "labelNoDesk";
            this.labelNoDesk.Size = new System.Drawing.Size(206, 57);
            this.labelNoDesk.TabIndex = 11;
            this.labelNoDesk.Text = "NoDesk";
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicense.Location = new System.Drawing.Point(299, 66);
            this.labelLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(351, 29);
            this.labelLicense.TabIndex = 12;
            this.labelLicense.Text = "Licensed to: The Garden Group";
            // 
            // pictureBoxGarden
            // 
            this.pictureBoxGarden.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGarden.Image")));
            this.pictureBoxGarden.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxGarden.InitialImage")));
            this.pictureBoxGarden.Location = new System.Drawing.Point(13, 9);
            this.pictureBoxGarden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxGarden.Name = "pictureBoxGarden";
            this.pictureBoxGarden.Size = new System.Drawing.Size(219, 120);
            this.pictureBoxGarden.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGarden.TabIndex = 13;
            this.pictureBoxGarden.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Create a new incident ticket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date/time reported:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Subject of incident:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Type of incident:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Priority:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Deadline/follow-up:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Description:";
            // 
            // subjectOfIncidentBox
            // 
            this.subjectOfIncidentBox.Location = new System.Drawing.Point(203, 258);
            this.subjectOfIncidentBox.Name = "subjectOfIncidentBox";
            this.subjectOfIncidentBox.Size = new System.Drawing.Size(292, 26);
            this.subjectOfIncidentBox.TabIndex = 23;
            // 
            // typeOfIncidentBox
            // 
            this.typeOfIncidentBox.Location = new System.Drawing.Point(203, 304);
            this.typeOfIncidentBox.Name = "typeOfIncidentBox";
            this.typeOfIncidentBox.Size = new System.Drawing.Size(292, 26);
            this.typeOfIncidentBox.TabIndex = 24;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(203, 486);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(292, 110);
            this.descriptionBox.TabIndex = 27;
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "Normal",
            "Low",
            "High",
            "Urgent"});
            this.priorityBox.Location = new System.Drawing.Point(203, 362);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(292, 28);
            this.priorityBox.TabIndex = 28;
            // 
            // reportedDateTimePicker
            // 
            this.reportedDateTimePicker.Location = new System.Drawing.Point(203, 216);
            this.reportedDateTimePicker.Name = "reportedDateTimePicker";
            this.reportedDateTimePicker.Size = new System.Drawing.Size(292, 26);
            this.reportedDateTimePicker.TabIndex = 29;
            // 
            // deadlineBox
            // 
            this.deadlineBox.FormattingEnabled = true;
            this.deadlineBox.Items.AddRange(new object[] {
            "7 days, 14 days, 28 days, 6 month"});
            this.deadlineBox.Location = new System.Drawing.Point(203, 427);
            this.deadlineBox.Name = "deadlineBox";
            this.deadlineBox.Size = new System.Drawing.Size(292, 28);
            this.deadlineBox.TabIndex = 30;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cancelButton.Location = new System.Drawing.Point(203, 643);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(110, 35);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitTicketButton
            // 
            this.submitTicketButton.BackColor = System.Drawing.Color.Aqua;
            this.submitTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submitTicketButton.Location = new System.Drawing.Point(385, 643);
            this.submitTicketButton.Name = "submitTicketButton";
            this.submitTicketButton.Size = new System.Drawing.Size(110, 35);
            this.submitTicketButton.TabIndex = 32;
            this.submitTicketButton.Text = "Submit";
            this.submitTicketButton.UseVisualStyleBackColor = false;
            this.submitTicketButton.Click += new System.EventHandler(this.submitTicketButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(522, 216);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 26);
            this.numericUpDown1.TabIndex = 33;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(604, 216);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 26);
            this.numericUpDown2.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "time";
            // 
            // CreateTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 710);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.submitTicketButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deadlineBox);
            this.Controls.Add(this.reportedDateTimePicker);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.typeOfIncidentBox);
            this.Controls.Add(this.subjectOfIncidentBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxGarden);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelNoDesk);
            this.Name = "CreateTicketForm";
            this.Text = "CreateTicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoDesk;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.PictureBox pictureBoxGarden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox subjectOfIncidentBox;
        private System.Windows.Forms.TextBox typeOfIncidentBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.DateTimePicker reportedDateTimePicker;
        private System.Windows.Forms.ComboBox deadlineBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitTicketButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label9;
    }
}