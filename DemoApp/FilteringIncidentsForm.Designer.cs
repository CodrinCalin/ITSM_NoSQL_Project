namespace DemoApp
{
    partial class FilteringIncidentsForm
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
            this.buttonGoBack = new System.Windows.Forms.Button();
            this.listViewIncidents = new System.Windows.Forms.ListView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDeadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSearchParameter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGoBack
            // 
            this.buttonGoBack.BackColor = System.Drawing.Color.Firebrick;
            this.buttonGoBack.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGoBack.Location = new System.Drawing.Point(12, 86);
            this.buttonGoBack.Name = "buttonGoBack";
            this.buttonGoBack.Size = new System.Drawing.Size(215, 59);
            this.buttonGoBack.TabIndex = 0;
            this.buttonGoBack.Text = "<   Go Back";
            this.buttonGoBack.UseVisualStyleBackColor = false;
            this.buttonGoBack.Click += new System.EventHandler(this.buttonGoBack_Click);
            // 
            // listViewIncidents
            // 
            this.listViewIncidents.BackColor = System.Drawing.Color.Gainsboro;
            this.listViewIncidents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDate,
            this.columnHeaderSubject,
            this.columnHeaderDescription,
            this.columnHeaderDeadline,
            this.columnHeaderPriority,
            this.columnHeaderStatus,
            this.columnHeaderType});
            this.listViewIncidents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewIncidents.GridLines = true;
            this.listViewIncidents.HideSelection = false;
            this.listViewIncidents.Location = new System.Drawing.Point(12, 211);
            this.listViewIncidents.Name = "listViewIncidents";
            this.listViewIncidents.Size = new System.Drawing.Size(942, 559);
            this.listViewIncidents.TabIndex = 1;
            this.listViewIncidents.UseCompatibleStateImageBehavior = false;
            this.listViewIncidents.View = System.Windows.Forms.View.Details;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("ROG Fonts", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Brown;
            this.labelTitle.Location = new System.Drawing.Point(238, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(551, 38);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Search for an Incident ";
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(407, 140);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(425, 39);
            this.textBoxInput.TabIndex = 3;
            this.textBoxInput.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Text = "Date";
            this.columnHeaderDate.Width = 100;
            // 
            // columnHeaderSubject
            // 
            this.columnHeaderSubject.Text = "Subject";
            this.columnHeaderSubject.Width = 200;
            // 
            // columnHeaderDescription
            // 
            this.columnHeaderDescription.Text = "Description";
            this.columnHeaderDescription.Width = 300;
            // 
            // columnHeaderDeadline
            // 
            this.columnHeaderDeadline.Text = "Deadline";
            this.columnHeaderDeadline.Width = 100;
            // 
            // columnHeaderPriority
            // 
            this.columnHeaderPriority.Text = "Priority";
            this.columnHeaderPriority.Width = 70;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 70;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 100;
            // 
            // labelSearchParameter
            // 
            this.labelSearchParameter.AutoSize = true;
            this.labelSearchParameter.Font = new System.Drawing.Font("ROG Fonts", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchParameter.Location = new System.Drawing.Point(430, 107);
            this.labelSearchParameter.Name = "labelSearchParameter";
            this.labelSearchParameter.Size = new System.Drawing.Size(379, 24);
            this.labelSearchParameter.TabIndex = 4;
            this.labelSearchParameter.Text = "Insert Search Parameter";
            // 
            // SearchingIncidentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 782);
            this.Controls.Add(this.labelSearchParameter);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listViewIncidents);
            this.Controls.Add(this.buttonGoBack);
            this.Name = "SearchingIncidentsForm";
            this.Text = "SearchingIncidentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGoBack;
        private System.Windows.Forms.ListView listViewIncidents;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderSubject;
        private System.Windows.Forms.ColumnHeader columnHeaderDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderDeadline;
        private System.Windows.Forms.ColumnHeader columnHeaderPriority;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelSearchParameter;
    }
}