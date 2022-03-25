
namespace Inventory_System
{
    partial class frmCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddress = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.lblRequiredName = new System.Windows.Forms.Label();
            this.lblRequiredLastName = new System.Windows.Forms.Label();
            this.lblRequiredEmail = new System.Windows.Forms.Label();
            this.lblRequiredPhone = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRequiredAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(105, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.Location = new System.Drawing.Point(278, 146);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(290, 28);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(105, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // btnAddress
            // 
            this.btnAddress.BackColor = System.Drawing.Color.White;
            this.btnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddress.Location = new System.Drawing.Point(278, 417);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(256, 36);
            this.btnAddress.TabIndex = 4;
            this.btnAddress.Text = "Add Address";
            this.btnAddress.UseVisualStyleBackColor = false;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(105, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(278, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 28);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "you@example.com";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Green;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(97, 553);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(194, 36);
            this.btn.TabIndex = 5;
            this.btn.Text = "Save";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btnSave);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(105, 331);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(152, 24);
            this.lblPhoneNumber.TabIndex = 10;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtphoneNumber.Location = new System.Drawing.Point(278, 327);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(256, 28);
            this.txtphoneNumber.TabIndex = 3;
            this.txtphoneNumber.Text = "### ### ####";
            this.txtphoneNumber.Click += new System.EventHandler(this.txtphoneNumber_Click);
            this.txtphoneNumber.TextChanged += new System.EventHandler(this.txtphoneNumber_TextChanged);
            // 
            // lblRequiredName
            // 
            this.lblRequiredName.AutoSize = true;
            this.lblRequiredName.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredName.Location = new System.Drawing.Point(275, 102);
            this.lblRequiredName.Name = "lblRequiredName";
            this.lblRequiredName.Size = new System.Drawing.Size(109, 17);
            this.lblRequiredName.TabIndex = 34;
            this.lblRequiredName.Text = "Field is required";
            this.lblRequiredName.Visible = false;
            // 
            // lblRequiredLastName
            // 
            this.lblRequiredLastName.AutoSize = true;
            this.lblRequiredLastName.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredLastName.Location = new System.Drawing.Point(275, 177);
            this.lblRequiredLastName.Name = "lblRequiredLastName";
            this.lblRequiredLastName.Size = new System.Drawing.Size(109, 17);
            this.lblRequiredLastName.TabIndex = 35;
            this.lblRequiredLastName.Text = "Field is required";
            this.lblRequiredLastName.Visible = false;
            // 
            // lblRequiredEmail
            // 
            this.lblRequiredEmail.AutoSize = true;
            this.lblRequiredEmail.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredEmail.Location = new System.Drawing.Point(275, 262);
            this.lblRequiredEmail.Name = "lblRequiredEmail";
            this.lblRequiredEmail.Size = new System.Drawing.Size(109, 17);
            this.lblRequiredEmail.TabIndex = 36;
            this.lblRequiredEmail.Text = "Field is required";
            this.lblRequiredEmail.Visible = false;
            // 
            // lblRequiredPhone
            // 
            this.lblRequiredPhone.AutoSize = true;
            this.lblRequiredPhone.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredPhone.Location = new System.Drawing.Point(275, 358);
            this.lblRequiredPhone.Name = "lblRequiredPhone";
            this.lblRequiredPhone.Size = new System.Drawing.Size(109, 17);
            this.lblRequiredPhone.TabIndex = 37;
            this.lblRequiredPhone.Text = "Field is required";
            this.lblRequiredPhone.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(374, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnDelete);
            // 
            // lblRequiredAddress
            // 
            this.lblRequiredAddress.AutoSize = true;
            this.lblRequiredAddress.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredAddress.Location = new System.Drawing.Point(275, 456);
            this.lblRequiredAddress.Name = "lblRequiredAddress";
            this.lblRequiredAddress.Size = new System.Drawing.Size(131, 17);
            this.lblRequiredAddress.TabIndex = 38;
            this.lblRequiredAddress.Text = "Address is required";
            this.lblRequiredAddress.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(105, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(278, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(297, 28);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(769, 667);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRequiredAddress);
            this.Controls.Add(this.lblRequiredPhone);
            this.Controls.Add(this.lblRequiredEmail);
            this.Controls.Add(this.lblRequiredLastName);
            this.Controls.Add(this.lblRequiredName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtphoneNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.Label lblRequiredName;
        private System.Windows.Forms.Label lblRequiredLastName;
        private System.Windows.Forms.Label lblRequiredEmail;
        private System.Windows.Forms.Label lblRequiredPhone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRequiredAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
    }
}