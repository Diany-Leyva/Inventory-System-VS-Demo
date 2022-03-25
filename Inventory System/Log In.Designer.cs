
namespace Inventory_System
{
    partial class frmLog_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog_In));
            this.lblUserLogin = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lknForgotPasw = new System.Windows.Forms.LinkLabel();
            this.showHide = new System.Windows.Forms.LinkLabel();
            this.lblRequiredUserN = new System.Windows.Forms.Label();
            this.lblRequiredPasswd = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserNPasswd = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserLogin
            // 
            this.lblUserLogin.AutoSize = true;
            this.lblUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserLogin.Location = new System.Drawing.Point(240, 308);
            this.lblUserLogin.Name = "lblUserLogin";
            this.lblUserLogin.Size = new System.Drawing.Size(140, 29);
            this.lblUserLogin.TabIndex = 9;
            this.lblUserLogin.Text = "User Login";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Green;
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(217, 532);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(194, 36);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lknForgotPasw
            // 
            this.lknForgotPasw.AutoSize = true;
            this.lknForgotPasw.BackColor = System.Drawing.Color.Transparent;
            this.lknForgotPasw.LinkColor = System.Drawing.Color.Green;
            this.lknForgotPasw.Location = new System.Drawing.Point(218, 587);
            this.lknForgotPasw.Name = "lknForgotPasw";
            this.lknForgotPasw.Size = new System.Drawing.Size(122, 17);
            this.lknForgotPasw.TabIndex = 4;
            this.lknForgotPasw.TabStop = true;
            this.lknForgotPasw.Text = "Forgot Password?";
            this.lknForgotPasw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lknForgotPasw_LinkClicked);
            // 
            // showHide
            // 
            this.showHide.AutoSize = true;
            this.showHide.BackColor = System.Drawing.Color.Transparent;
            this.showHide.LinkColor = System.Drawing.Color.Green;
            this.showHide.Location = new System.Drawing.Point(365, 478);
            this.showHide.Name = "showHide";
            this.showHide.Size = new System.Drawing.Size(42, 17);
            this.showHide.TabIndex = 6;
            this.showHide.TabStop = true;
            this.showHide.Text = "Show";
            this.showHide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.showHide_LinkClicked);
            // 
            // lblRequiredUserN
            // 
            this.lblRequiredUserN.AutoSize = true;
            this.lblRequiredUserN.BackColor = System.Drawing.Color.Transparent;
            this.lblRequiredUserN.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredUserN.Location = new System.Drawing.Point(217, 427);
            this.lblRequiredUserN.Name = "lblRequiredUserN";
            this.lblRequiredUserN.Size = new System.Drawing.Size(148, 17);
            this.lblRequiredUserN.TabIndex = 7;
            this.lblRequiredUserN.Text = "Username is required.";
            this.lblRequiredUserN.Visible = false;
            // 
            // lblRequiredPasswd
            // 
            this.lblRequiredPasswd.AutoSize = true;
            this.lblRequiredPasswd.BackColor = System.Drawing.Color.Transparent;
            this.lblRequiredPasswd.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredPasswd.Location = new System.Drawing.Point(217, 504);
            this.lblRequiredPasswd.Name = "lblRequiredPasswd";
            this.lblRequiredPasswd.Size = new System.Drawing.Size(144, 17);
            this.lblRequiredPasswd.TabIndex = 8;
            this.lblRequiredPasswd.Text = "Password is required.";
            this.lblRequiredPasswd.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(217, 398);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 27);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(217, 475);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblUserNPasswd
            // 
            this.lblUserNPasswd.AutoSize = true;
            this.lblUserNPasswd.BackColor = System.Drawing.Color.Transparent;
            this.lblUserNPasswd.ForeColor = System.Drawing.Color.Red;
            this.lblUserNPasswd.Location = new System.Drawing.Point(219, 567);
            this.lblUserNPasswd.Name = "lblUserNPasswd";
            this.lblUserNPasswd.Size = new System.Drawing.Size(215, 17);
            this.lblUserNPasswd.TabIndex = 10;
            this.lblUserNPasswd.Text = "Incorrect username or password ";
            this.lblUserNPasswd.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsername.Location = new System.Drawing.Point(217, 372);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassword.Location = new System.Drawing.Point(217, 449);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password";
            // 
            // frmLog_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 689);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUserNPasswd);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblRequiredPasswd);
            this.Controls.Add(this.lblRequiredUserN);
            this.Controls.Add(this.showHide);
            this.Controls.Add(this.lknForgotPasw);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserLogin);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmLog_In";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserLogin;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.LinkLabel lknForgotPasw;
        private System.Windows.Forms.LinkLabel showHide;
        private System.Windows.Forms.Label lblRequiredUserN;
        private System.Windows.Forms.Label lblRequiredPasswd;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserNPasswd;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
    }
}

