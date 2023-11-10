namespace DemoApp
{
    partial class EditTicketForm
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
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSubject = new System.Windows.Forms.RichTextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.dateTimePickerCreation = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDeleteTicket = new System.Windows.Forms.Button();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(294, 281);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(298, 124);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.Text = "";
            // 
            // richTextBoxSubject
            // 
            this.richTextBoxSubject.Location = new System.Drawing.Point(294, 197);
            this.richTextBoxSubject.Name = "richTextBoxSubject";
            this.richTextBoxSubject.Size = new System.Drawing.Size(298, 63);
            this.richTextBoxSubject.TabIndex = 1;
            this.richTextBoxSubject.Text = "";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(294, 160);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(298, 26);
            this.textBoxType.TabIndex = 2;
            // 
            // dateTimePickerCreation
            // 
            this.dateTimePickerCreation.Location = new System.Drawing.Point(294, 84);
            this.dateTimePickerCreation.Name = "dateTimePickerCreation";
            this.dateTimePickerCreation.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerCreation.TabIndex = 3;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(294, 116);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(298, 26);
            this.dateTimePickerDeadline.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(2, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date and Time Of Creation";
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDeadline.Location = new System.Drawing.Point(2, 116);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(89, 25);
            this.labelDeadline.TabIndex = 7;
            this.labelDeadline.Text = "Deadline";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(2, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Priority";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDescription.Location = new System.Drawing.Point(2, 269);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(109, 25);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(2, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(84, 567);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 49);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(2, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(2, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(217, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(166, 37);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Edit Ticket";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(294, 423);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(298, 26);
            this.textBoxUserID.TabIndex = 17;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(2, 425);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(72, 25);
            this.labelUser.TabIndex = 18;
            this.labelUser.Text = "UserID";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(242, 567);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(115, 49);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDeleteTicket
            // 
            this.buttonDeleteTicket.Location = new System.Drawing.Point(392, 567);
            this.buttonDeleteTicket.Name = "buttonDeleteTicket";
            this.buttonDeleteTicket.Size = new System.Drawing.Size(115, 49);
            this.buttonDeleteTicket.TabIndex = 13;
            this.buttonDeleteTicket.Text = "Delete";
            this.buttonDeleteTicket.UseVisualStyleBackColor = true;
            this.buttonDeleteTicket.Click += new System.EventHandler(this.buttonDeleteTicket_Click);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            " Low",
            " Medium",
            " High",
            " Urgent"});
            this.comboBoxPriority.Location = new System.Drawing.Point(296, 516);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(298, 28);
            this.comboBoxPriority.TabIndex = 20;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            " Low",
            " Medium",
            " High",
            " Urgent"});
            this.comboBoxStatus.Location = new System.Drawing.Point(296, 465);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(298, 28);
            this.comboBoxStatus.TabIndex = 20;
            // 
            // EditTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 653);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDeleteTicket);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.dateTimePickerCreation);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.richTextBoxSubject);
            this.Controls.Add(this.richTextBoxDescription);
            this.Name = "EditTicketForm";
            this.Text = "CRUD_OperationsTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.RichTextBox richTextBoxSubject;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreation;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDeleteTicket;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}