namespace DemoApp
{
    partial class TransferTicket
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
            this.TransferBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TransferToEmployeeIDTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectedTicketIDLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransferBtn
            // 
            this.TransferBtn.Location = new System.Drawing.Point(106, 159);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Size = new System.Drawing.Size(179, 29);
            this.TransferBtn.TabIndex = 0;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.UseVisualStyleBackColor = true;
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transfer Ticket";
            // 
            // TransferToEmployeeIDTxtBox
            // 
            this.TransferToEmployeeIDTxtBox.Location = new System.Drawing.Point(275, 112);
            this.TransferToEmployeeIDTxtBox.Name = "TransferToEmployeeIDTxtBox";
            this.TransferToEmployeeIDTxtBox.Size = new System.Drawing.Size(100, 20);
            this.TransferToEmployeeIDTxtBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Transfer ticket to:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Selected Ticket ID: ";
            // 
            // SelectedTicketIDLbl
            // 
            this.SelectedTicketIDLbl.AutoSize = true;
            this.SelectedTicketIDLbl.Location = new System.Drawing.Point(275, 59);
            this.SelectedTicketIDLbl.Name = "SelectedTicketIDLbl";
            this.SelectedTicketIDLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SelectedTicketIDLbl.Size = new System.Drawing.Size(0, 13);
            this.SelectedTicketIDLbl.TabIndex = 10;
            // 
            // TransferTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 200);
            this.Controls.Add(this.SelectedTicketIDLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TransferToEmployeeIDTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TransferBtn);
            this.Name = "TransferTicket";
            this.Text = "TransferTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TransferBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TransferToEmployeeIDTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label SelectedTicketIDLbl;
    }
}