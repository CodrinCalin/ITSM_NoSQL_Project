namespace DemoApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonIncidentManagement = new System.Windows.Forms.Button();
            this.buttonUserManagement = new System.Windows.Forms.Button();
            this.labelNoDesk = new System.Windows.Forms.Label();
            this.labelLicense = new System.Windows.Forms.Label();
            this.pictureBoxGarden = new System.Windows.Forms.PictureBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelFogotLoginDetails = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Location = new System.Drawing.Point(2, 129);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(324, 60);
            this.buttonDashboard.TabIndex = 1;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // buttonIncidentManagement
            // 
            this.buttonIncidentManagement.Location = new System.Drawing.Point(321, 129);
            this.buttonIncidentManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonIncidentManagement.Name = "buttonIncidentManagement";
            this.buttonIncidentManagement.Size = new System.Drawing.Size(324, 60);
            this.buttonIncidentManagement.TabIndex = 2;
            this.buttonIncidentManagement.Text = "Incident Management";
            this.buttonIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // buttonUserManagement
            // 
            this.buttonUserManagement.Location = new System.Drawing.Point(642, 129);
            this.buttonUserManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserManagement.Name = "buttonUserManagement";
            this.buttonUserManagement.Size = new System.Drawing.Size(324, 60);
            this.buttonUserManagement.TabIndex = 3;
            this.buttonUserManagement.Text = "User Management";
            this.buttonUserManagement.UseVisualStyleBackColor = true;
            // 
            // labelNoDesk
            // 
            this.labelNoDesk.AutoSize = true;
            this.labelNoDesk.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoDesk.Location = new System.Drawing.Point(759, 6);
            this.labelNoDesk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoDesk.Name = "labelNoDesk";
            this.labelNoDesk.Size = new System.Drawing.Size(206, 57);
            this.labelNoDesk.TabIndex = 4;
            this.labelNoDesk.Text = "NoDesk";
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicense.Location = new System.Drawing.Point(614, 69);
            this.labelLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(351, 29);
            this.labelLicense.TabIndex = 5;
            this.labelLicense.Text = "Licensed to: The Garden Group";
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
            this.pictureBoxGarden.TabIndex = 6;
            this.pictureBoxGarden.TabStop = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(317, 501);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 22);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Password";
            // 
            // labelFogotLoginDetails
            // 
            this.labelFogotLoginDetails.AutoSize = true;
            this.labelFogotLoginDetails.Font = new System.Drawing.Font("SimSun", 9F);
            this.labelFogotLoginDetails.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelFogotLoginDetails.Location = new System.Drawing.Point(471, 573);
            this.labelFogotLoginDetails.Name = "labelFogotLoginDetails";
            this.labelFogotLoginDetails.Size = new System.Drawing.Size(206, 18);
            this.labelFogotLoginDetails.TabIndex = 8;
            this.labelFogotLoginDetails.Text = "Forgot Login Details ?";
            this.labelFogotLoginDetails.Click += new System.EventHandler(this.labelFogotLoginDetails_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(317, 416);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(98, 22);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelDescription.Location = new System.Drawing.Point(189, 315);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(586, 56);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "Please provide login credentials to login\r\nto NoDesk for The Garden Group";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("SimSun", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelTitle.Location = new System.Drawing.Point(368, 275);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(237, 40);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "NoDesk: TGG";
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Location = new System.Drawing.Point(321, 571);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(140, 24);
            this.checkBoxRememberMe.TabIndex = 12;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(321, 526);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = 'ツ';
            this.textBoxPassword.Size = new System.Drawing.Size(356, 35);
            this.textBoxPassword.TabIndex = 13;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(321, 441);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(356, 35);
            this.textBoxUsername.TabIndex = 14;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(392, 657);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(197, 63);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(299, 616);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(413, 24);
            this.labelError.TabIndex = 16;
            this.labelError.Text = "Incorrect Username or Password!";
            this.labelError.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 782);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelFogotLoginDetails);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.pictureBoxGarden);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.labelNoDesk);
            this.Controls.Add(this.buttonUserManagement);
            this.Controls.Add(this.buttonIncidentManagement);
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGarden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonIncidentManagement;
        private System.Windows.Forms.Button buttonUserManagement;
        private System.Windows.Forms.Label labelNoDesk;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.PictureBox pictureBoxGarden;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelFogotLoginDetails;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelError;
    }
}