namespace DemoApp
{
    partial class PrioritySortingForm
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
            this.labelNoDesk = new System.Windows.Forms.Label();
            this.labelLicense = new System.Windows.Forms.Label();
            this.labelOverviewTickets = new System.Windows.Forms.Label();
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNoDesk
            // 
            this.labelNoDesk.AutoSize = true;
            this.labelNoDesk.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoDesk.Location = new System.Drawing.Point(607, 9);
            this.labelNoDesk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoDesk.Name = "labelNoDesk";
            this.labelNoDesk.Size = new System.Drawing.Size(202, 55);
            this.labelNoDesk.TabIndex = 11;
            this.labelNoDesk.Text = "NoDesk";
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicense.Location = new System.Drawing.Point(458, 64);
            this.labelLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(351, 29);
            this.labelLicense.TabIndex = 13;
            this.labelLicense.Text = "Licensed to: The Garden Group";
            // 
            // labelOverviewTickets
            // 
            this.labelOverviewTickets.AutoSize = true;
            this.labelOverviewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOverviewTickets.Location = new System.Drawing.Point(12, 9);
            this.labelOverviewTickets.Name = "labelOverviewTickets";
            this.labelOverviewTickets.Size = new System.Drawing.Size(401, 32);
            this.labelOverviewTickets.TabIndex = 14;
            this.labelOverviewTickets.Text = "Sort tickets based on priority";
            // 
            // listViewTickets
            // 
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(18, 105);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(808, 412);
            this.listViewTickets.TabIndex = 17;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "From low to urgent",
            "From urgent to low",
            "Low",
            "Medium",
            "High",
            "Urgent"});
            this.comboBoxPriority.Location = new System.Drawing.Point(82, 61);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(226, 28);
            this.comboBoxPriority.TabIndex = 18;
            this.comboBoxPriority.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPriority_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sort:";
            // 
            // PrioritySortingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.listViewTickets);
            this.Controls.Add(this.labelOverviewTickets);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelNoDesk);
            this.Name = "PrioritySortingForm";
            this.Text = "PrioritySortingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoDesk;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Label labelOverviewTickets;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label label1;
    }
}