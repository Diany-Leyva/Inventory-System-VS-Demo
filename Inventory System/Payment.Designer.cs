
namespace Inventory_System
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddress = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCVVNumber = new System.Windows.Forms.Label();
            this.txtCVVNumber = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnProceed = new System.Windows.Forms.Button();
            this.grbBillingInfo = new System.Windows.Forms.GroupBox();
            this.lblReqName = new System.Windows.Forms.Label();
            this.lblReqAddress = new System.Windows.Forms.Label();
            this.lblReqPhone = new System.Windows.Forms.Label();
            this.lblReqEmail = new System.Windows.Forms.Label();
            this.grbCredirCardInfo = new System.Windows.Forms.GroupBox();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.lblReqCardName = new System.Windows.Forms.Label();
            this.lblReqCVCNumber = new System.Windows.Forms.Label();
            this.lblReqExpDate = new System.Windows.Forms.Label();
            this.lblReqCardNumber = new System.Windows.Forms.Label();
            this.rdoVisa = new System.Windows.Forms.RadioButton();
            this.rdoMasterCard = new System.Windows.Forms.RadioButton();
            this.rdoPaypal = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblRequiredMethod = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grbBillingInfo.SuspendLayout();
            this.grbCredirCardInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(87, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Choose payment method";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(33, 242);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(152, 24);
            this.lblPhoneNumber.TabIndex = 40;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtphoneNumber.Location = new System.Drawing.Point(34, 275);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(254, 28);
            this.txtphoneNumber.TabIndex = 5;
            this.txtphoneNumber.Text = "### ### ####";
            this.txtphoneNumber.Click += new System.EventHandler(this.txtphoneNumber_Click);
            this.txtphoneNumber.TextChanged += new System.EventHandler(this.txtphoneNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Email Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(32, 168);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(256, 28);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "you@example.com";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(32, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 28);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Full Name";
            // 
            // btnAddress
            // 
            this.btnAddress.BackColor = System.Drawing.Color.White;
            this.btnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddress.Location = new System.Drawing.Point(34, 354);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Size = new System.Drawing.Size(254, 34);
            this.btnAddress.TabIndex = 6;
            this.btnAddress.Text = "Billing Address";
            this.btnAddress.UseVisualStyleBackColor = false;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Card Number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtCardNumber.Location = new System.Drawing.Point(42, 164);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(256, 28);
            this.txtCardNumber.TabIndex = 8;
            this.txtCardNumber.Text = "9999 9999 9999 9999";
            this.txtCardNumber.Click += new System.EventHandler(this.txtCardNumber_Click);
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardNumber_TextChanged);
            // 
            // txtCardName
            // 
            this.txtCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardName.ForeColor = System.Drawing.Color.DimGray;
            this.txtCardName.Location = new System.Drawing.Point(42, 69);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(256, 28);
            this.txtCardName.TabIndex = 7;
            this.txtCardName.TextChanged += new System.EventHandler(this.txtCardName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Name on Card";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Expiration Date";
            // 
            // lblCVVNumber
            // 
            this.lblCVVNumber.AutoSize = true;
            this.lblCVVNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVVNumber.Location = new System.Drawing.Point(42, 338);
            this.lblCVVNumber.Name = "lblCVVNumber";
            this.lblCVVNumber.Size = new System.Drawing.Size(141, 24);
            this.lblCVVNumber.TabIndex = 51;
            this.lblCVVNumber.Text = "Security Code";
            // 
            // txtCVVNumber
            // 
            this.txtCVVNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCVVNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtCVVNumber.Location = new System.Drawing.Point(42, 370);
            this.txtCVVNumber.Name = "txtCVVNumber";
            this.txtCVVNumber.Size = new System.Drawing.Size(256, 28);
            this.txtCVVNumber.TabIndex = 10;
            this.txtCVVNumber.Text = "CVV";
            this.txtCVVNumber.Click += new System.EventHandler(this.txtCVVNumber_Click);
            this.txtCVVNumber.TextChanged += new System.EventHandler(this.txtCVVNumber_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(535, 767);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Green;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(286, 767);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(194, 36);
            this.btnProceed.TabIndex = 11;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // grbBillingInfo
            // 
            this.grbBillingInfo.Controls.Add(this.txtName);
            this.grbBillingInfo.Controls.Add(this.label8);
            this.grbBillingInfo.Controls.Add(this.txtEmail);
            this.grbBillingInfo.Controls.Add(this.label6);
            this.grbBillingInfo.Controls.Add(this.txtphoneNumber);
            this.grbBillingInfo.Controls.Add(this.lblPhoneNumber);
            this.grbBillingInfo.Controls.Add(this.btnAddress);
            this.grbBillingInfo.Controls.Add(this.lblReqName);
            this.grbBillingInfo.Controls.Add(this.lblReqAddress);
            this.grbBillingInfo.Controls.Add(this.lblReqPhone);
            this.grbBillingInfo.Controls.Add(this.lblReqEmail);
            this.grbBillingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBillingInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbBillingInfo.Location = new System.Drawing.Point(91, 212);
            this.grbBillingInfo.Name = "grbBillingInfo";
            this.grbBillingInfo.Size = new System.Drawing.Size(391, 453);
            this.grbBillingInfo.TabIndex = 54;
            this.grbBillingInfo.TabStop = false;
            this.grbBillingInfo.Text = "Billing Info";
            // 
            // lblReqName
            // 
            this.lblReqName.AutoSize = true;
            this.lblReqName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqName.ForeColor = System.Drawing.Color.Red;
            this.lblReqName.Location = new System.Drawing.Point(31, 104);
            this.lblReqName.Name = "lblReqName";
            this.lblReqName.Size = new System.Drawing.Size(109, 17);
            this.lblReqName.TabIndex = 64;
            this.lblReqName.Text = "Field is required";
            this.lblReqName.Visible = false;
            // 
            // lblReqAddress
            // 
            this.lblReqAddress.AutoSize = true;
            this.lblReqAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqAddress.ForeColor = System.Drawing.Color.Red;
            this.lblReqAddress.Location = new System.Drawing.Point(34, 391);
            this.lblReqAddress.Name = "lblReqAddress";
            this.lblReqAddress.Size = new System.Drawing.Size(109, 17);
            this.lblReqAddress.TabIndex = 70;
            this.lblReqAddress.Text = "Field is required";
            this.lblReqAddress.Visible = false;
            // 
            // lblReqPhone
            // 
            this.lblReqPhone.AutoSize = true;
            this.lblReqPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqPhone.ForeColor = System.Drawing.Color.Red;
            this.lblReqPhone.Location = new System.Drawing.Point(34, 310);
            this.lblReqPhone.Name = "lblReqPhone";
            this.lblReqPhone.Size = new System.Drawing.Size(109, 17);
            this.lblReqPhone.TabIndex = 67;
            this.lblReqPhone.Text = "Field is required";
            this.lblReqPhone.Visible = false;
            // 
            // lblReqEmail
            // 
            this.lblReqEmail.AutoSize = true;
            this.lblReqEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqEmail.ForeColor = System.Drawing.Color.Red;
            this.lblReqEmail.Location = new System.Drawing.Point(31, 199);
            this.lblReqEmail.Name = "lblReqEmail";
            this.lblReqEmail.Size = new System.Drawing.Size(109, 17);
            this.lblReqEmail.TabIndex = 66;
            this.lblReqEmail.Text = "Field is required";
            this.lblReqEmail.Visible = false;
            // 
            // grbCredirCardInfo
            // 
            this.grbCredirCardInfo.Controls.Add(this.txtExpDate);
            this.grbCredirCardInfo.Controls.Add(this.label5);
            this.grbCredirCardInfo.Controls.Add(this.txtCardName);
            this.grbCredirCardInfo.Controls.Add(this.txtCardNumber);
            this.grbCredirCardInfo.Controls.Add(this.label4);
            this.grbCredirCardInfo.Controls.Add(this.lblCVVNumber);
            this.grbCredirCardInfo.Controls.Add(this.txtCVVNumber);
            this.grbCredirCardInfo.Controls.Add(this.label9);
            this.grbCredirCardInfo.Controls.Add(this.lblReqCardName);
            this.grbCredirCardInfo.Controls.Add(this.lblReqCVCNumber);
            this.grbCredirCardInfo.Controls.Add(this.lblReqExpDate);
            this.grbCredirCardInfo.Controls.Add(this.lblReqCardNumber);
            this.grbCredirCardInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCredirCardInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbCredirCardInfo.Location = new System.Drawing.Point(577, 216);
            this.grbCredirCardInfo.Name = "grbCredirCardInfo";
            this.grbCredirCardInfo.Size = new System.Drawing.Size(391, 453);
            this.grbCredirCardInfo.TabIndex = 56;
            this.grbCredirCardInfo.TabStop = false;
            this.grbCredirCardInfo.Text = "Credit Card Info";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.ForeColor = System.Drawing.Color.DimGray;
            this.txtExpDate.Location = new System.Drawing.Point(42, 271);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(256, 28);
            this.txtExpDate.TabIndex = 9;
            this.txtExpDate.Text = "MM/YYYY";
            this.txtExpDate.Click += new System.EventHandler(this.txtExpDate_Click);
            this.txtExpDate.TextChanged += new System.EventHandler(this.txtExpDate_TextChanged);
            // 
            // lblReqCardName
            // 
            this.lblReqCardName.AutoSize = true;
            this.lblReqCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqCardName.ForeColor = System.Drawing.Color.Red;
            this.lblReqCardName.Location = new System.Drawing.Point(39, 100);
            this.lblReqCardName.Name = "lblReqCardName";
            this.lblReqCardName.Size = new System.Drawing.Size(109, 17);
            this.lblReqCardName.TabIndex = 65;
            this.lblReqCardName.Text = "Field is required";
            this.lblReqCardName.Visible = false;
            // 
            // lblReqCVCNumber
            // 
            this.lblReqCVCNumber.AutoSize = true;
            this.lblReqCVCNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqCVCNumber.ForeColor = System.Drawing.Color.Red;
            this.lblReqCVCNumber.Location = new System.Drawing.Point(39, 401);
            this.lblReqCVCNumber.Name = "lblReqCVCNumber";
            this.lblReqCVCNumber.Size = new System.Drawing.Size(109, 17);
            this.lblReqCVCNumber.TabIndex = 69;
            this.lblReqCVCNumber.Text = "Field is required";
            this.lblReqCVCNumber.Visible = false;
            // 
            // lblReqExpDate
            // 
            this.lblReqExpDate.AutoSize = true;
            this.lblReqExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqExpDate.ForeColor = System.Drawing.Color.Red;
            this.lblReqExpDate.Location = new System.Drawing.Point(39, 306);
            this.lblReqExpDate.Name = "lblReqExpDate";
            this.lblReqExpDate.Size = new System.Drawing.Size(109, 17);
            this.lblReqExpDate.TabIndex = 68;
            this.lblReqExpDate.Text = "Field is required";
            this.lblReqExpDate.Visible = false;
            // 
            // lblReqCardNumber
            // 
            this.lblReqCardNumber.AutoSize = true;
            this.lblReqCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqCardNumber.ForeColor = System.Drawing.Color.Red;
            this.lblReqCardNumber.Location = new System.Drawing.Point(39, 195);
            this.lblReqCardNumber.Name = "lblReqCardNumber";
            this.lblReqCardNumber.Size = new System.Drawing.Size(109, 17);
            this.lblReqCardNumber.TabIndex = 67;
            this.lblReqCardNumber.Text = "Field is required";
            this.lblReqCardNumber.Visible = false;
            // 
            // rdoVisa
            // 
            this.rdoVisa.AutoSize = true;
            this.rdoVisa.Location = new System.Drawing.Point(252, 120);
            this.rdoVisa.Name = "rdoVisa";
            this.rdoVisa.Size = new System.Drawing.Size(17, 16);
            this.rdoVisa.TabIndex = 0;
            this.rdoVisa.TabStop = true;
            this.rdoVisa.UseVisualStyleBackColor = true;
            this.rdoVisa.CheckedChanged += new System.EventHandler(this.rdoVisa_CheckedChanged);
            // 
            // rdoMasterCard
            // 
            this.rdoMasterCard.AutoSize = true;
            this.rdoMasterCard.Location = new System.Drawing.Point(418, 120);
            this.rdoMasterCard.Name = "rdoMasterCard";
            this.rdoMasterCard.Size = new System.Drawing.Size(17, 16);
            this.rdoMasterCard.TabIndex = 1;
            this.rdoMasterCard.TabStop = true;
            this.rdoMasterCard.UseVisualStyleBackColor = true;
            this.rdoMasterCard.CheckedChanged += new System.EventHandler(this.rdoMasterCard_CheckedChanged);
            // 
            // rdoPaypal
            // 
            this.rdoPaypal.AutoSize = true;
            this.rdoPaypal.Location = new System.Drawing.Point(579, 120);
            this.rdoPaypal.Name = "rdoPaypal";
            this.rdoPaypal.Size = new System.Drawing.Size(17, 16);
            this.rdoPaypal.TabIndex = 2;
            this.rdoPaypal.TabStop = true;
            this.rdoPaypal.UseVisualStyleBackColor = true;
            this.rdoPaypal.CheckedChanged += new System.EventHandler(this.rdoPaypal_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 37);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(456, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 37);
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(612, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(151, 37);
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // lblRequiredMethod
            // 
            this.lblRequiredMethod.AutoSize = true;
            this.lblRequiredMethod.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredMethod.Location = new System.Drawing.Point(254, 146);
            this.lblRequiredMethod.Name = "lblRequiredMethod";
            this.lblRequiredMethod.Size = new System.Drawing.Size(113, 17);
            this.lblRequiredMethod.TabIndex = 42;
            this.lblRequiredMethod.Text = "Field is required.";
            this.lblRequiredMethod.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotal.Location = new System.Drawing.Point(170, 712);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(55, 22);
            this.txtTotal.TabIndex = 72;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(99, 710);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 24);
            this.lblTotal.TabIndex = 71;
            this.lblTotal.Text = "Total";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1058, 896);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRequiredMethod);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdoPaypal);
            this.Controls.Add(this.rdoMasterCard);
            this.Controls.Add(this.rdoVisa);
            this.Controls.Add(this.grbCredirCardInfo);
            this.Controls.Add(this.grbBillingInfo);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Name = "frmPayment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.grbBillingInfo.ResumeLayout(false);
            this.grbBillingInfo.PerformLayout();
            this.grbCredirCardInfo.ResumeLayout(false);
            this.grbCredirCardInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCVVNumber;
        private System.Windows.Forms.TextBox txtCVVNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.GroupBox grbBillingInfo;
        private System.Windows.Forms.GroupBox grbCredirCardInfo;
        private System.Windows.Forms.RadioButton rdoVisa;
        private System.Windows.Forms.RadioButton rdoMasterCard;
        private System.Windows.Forms.RadioButton rdoPaypal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblReqName;
        private System.Windows.Forms.Label lblReqAddress;
        private System.Windows.Forms.Label lblReqPhone;
        private System.Windows.Forms.Label lblReqEmail;
        private System.Windows.Forms.Label lblReqCardName;
        private System.Windows.Forms.Label lblReqCVCNumber;
        private System.Windows.Forms.Label lblReqExpDate;
        private System.Windows.Forms.Label lblReqCardNumber;
        private System.Windows.Forms.Label lblRequiredMethod;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}