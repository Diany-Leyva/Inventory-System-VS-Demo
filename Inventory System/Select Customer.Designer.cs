
namespace Inventory_System
{
    partial class frmSelectCustomer
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
            this.lblReqSearchCust = new System.Windows.Forms.Label();
            this.rdoExistCust = new System.Windows.Forms.RadioButton();
            this.rdoNewCust = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCustomers = new System.Windows.Forms.ComboBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnSearchCust = new System.Windows.Forms.Button();
            this.lblradioReq = new System.Windows.Forms.Label();
            this.lblReqNewCust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.btnAddDonation = new System.Windows.Forms.Button();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReqSearchCust
            // 
            this.lblReqSearchCust.AutoSize = true;
            this.lblReqSearchCust.ForeColor = System.Drawing.Color.Red;
            this.lblReqSearchCust.Location = new System.Drawing.Point(38, 181);
            this.lblReqSearchCust.Name = "lblReqSearchCust";
            this.lblReqSearchCust.Size = new System.Drawing.Size(109, 17);
            this.lblReqSearchCust.TabIndex = 47;
            this.lblReqSearchCust.Text = "Field is required";
            this.lblReqSearchCust.Visible = false;
            // 
            // rdoExistCust
            // 
            this.rdoExistCust.AutoSize = true;
            this.rdoExistCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoExistCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoExistCust.Location = new System.Drawing.Point(41, 36);
            this.rdoExistCust.Name = "rdoExistCust";
            this.rdoExistCust.Size = new System.Drawing.Size(200, 28);
            this.rdoExistCust.TabIndex = 1;
            this.rdoExistCust.TabStop = true;
            this.rdoExistCust.Text = "Existing Customer";
            this.rdoExistCust.UseVisualStyleBackColor = true;
            this.rdoExistCust.CheckedChanged += new System.EventHandler(this.rdoExistCust_CheckedChanged);
            // 
            // rdoNewCust
            // 
            this.rdoNewCust.AutoSize = true;
            this.rdoNewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNewCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdoNewCust.Location = new System.Drawing.Point(299, 36);
            this.rdoNewCust.Name = "rdoNewCust";
            this.rdoNewCust.Size = new System.Drawing.Size(168, 28);
            this.rdoNewCust.TabIndex = 2;
            this.rdoNewCust.TabStop = true;
            this.rdoNewCust.Text = "New Customer";
            this.rdoNewCust.UseVisualStyleBackColor = true;
            this.rdoNewCust.CheckedChanged += new System.EventHandler(this.rdoNewCust_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCustomers);
            this.groupBox1.Controls.Add(this.btnAddCust);
            this.groupBox1.Controls.Add(this.btnSearchCust);
            this.groupBox1.Controls.Add(this.lblradioReq);
            this.groupBox1.Controls.Add(this.lblReqNewCust);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCustomer);
            this.groupBox1.Controls.Add(this.lblReqSearchCust);
            this.groupBox1.Controls.Add(this.rdoNewCust);
            this.groupBox1.Controls.Add(this.rdoExistCust);
            this.groupBox1.Location = new System.Drawing.Point(102, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 345);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // cboCustomers
            // 
            this.cboCustomers.Enabled = false;
            this.cboCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomers.ForeColor = System.Drawing.Color.DimGray;
            this.cboCustomers.FormattingEnabled = true;
            this.cboCustomers.Location = new System.Drawing.Point(41, 148);
            this.cboCustomers.Name = "cboCustomers";
            this.cboCustomers.Size = new System.Drawing.Size(223, 30);
            this.cboCustomers.TabIndex = 69;
            this.cboCustomers.SelectedIndexChanged += new System.EventHandler(this.cboCustomers_SelectedIndexChanged);
            // 
            // btnAddCust
            // 
            this.btnAddCust.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCust.BackColor = System.Drawing.Color.Green;
            this.btnAddCust.Enabled = false;
            this.btnAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCust.ForeColor = System.Drawing.Color.White;
            this.btnAddCust.Location = new System.Drawing.Point(299, 251);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(194, 36);
            this.btnAddCust.TabIndex = 67;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearchCust
            // 
            this.btnSearchCust.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearchCust.BackColor = System.Drawing.Color.Green;
            this.btnSearchCust.Enabled = false;
            this.btnSearchCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCust.ForeColor = System.Drawing.Color.White;
            this.btnSearchCust.Location = new System.Drawing.Point(299, 144);
            this.btnSearchCust.Name = "btnSearchCust";
            this.btnSearchCust.Size = new System.Drawing.Size(194, 36);
            this.btnSearchCust.TabIndex = 66;
            this.btnSearchCust.Text = "Search";
            this.btnSearchCust.UseVisualStyleBackColor = false;
            this.btnSearchCust.Click += new System.EventHandler(this.btnSearchCust_Click);
            // 
            // lblradioReq
            // 
            this.lblradioReq.AutoSize = true;
            this.lblradioReq.ForeColor = System.Drawing.Color.Red;
            this.lblradioReq.Location = new System.Drawing.Point(38, 67);
            this.lblradioReq.Name = "lblradioReq";
            this.lblradioReq.Size = new System.Drawing.Size(123, 17);
            this.lblradioReq.TabIndex = 65;
            this.lblradioReq.Text = "Selection required";
            this.lblradioReq.Visible = false;
            // 
            // lblReqNewCust
            // 
            this.lblReqNewCust.AutoSize = true;
            this.lblReqNewCust.ForeColor = System.Drawing.Color.Red;
            this.lblReqNewCust.Location = new System.Drawing.Point(298, 290);
            this.lblReqNewCust.Name = "lblReqNewCust";
            this.lblReqNewCust.Size = new System.Drawing.Size(170, 17);
            this.lblReqNewCust.TabIndex = 64;
            this.lblReqNewCust.Text = "New Customer is required";
            this.lblReqNewCust.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(37, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Add Customer";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomer.Location = new System.Drawing.Point(37, 111);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(171, 24);
            this.lblCustomer.TabIndex = 54;
            this.lblCustomer.Text = "Search Customer";
            // 
            // btnAddDonation
            // 
            this.btnAddDonation.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddDonation.BackColor = System.Drawing.Color.Green;
            this.btnAddDonation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDonation.ForeColor = System.Drawing.Color.White;
            this.btnAddDonation.Location = new System.Drawing.Point(401, 479);
            this.btnAddDonation.Name = "btnAddDonation";
            this.btnAddDonation.Size = new System.Drawing.Size(194, 36);
            this.btnAddDonation.TabIndex = 0;
            this.btnAddDonation.Text = "New Donation";
            this.btnAddDonation.UseVisualStyleBackColor = false;
            this.btnAddDonation.Click += new System.EventHandler(this.BtnAddDonation);
            // 
            // txtCustomer
            // 
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustomer.Location = new System.Drawing.Point(143, 487);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomer.Size = new System.Drawing.Size(223, 28);
            this.txtCustomer.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(139, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 68;
            this.label2.Text = "Customer";
            // 
            // frmSelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(718, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.btnAddDonation);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSelectCustomer";
            this.Text = "Select Customer";
            this.Load += new System.EventHandler(this.frmSelectCustomer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblReqSearchCust;
        private System.Windows.Forms.RadioButton rdoExistCust;
        private System.Windows.Forms.RadioButton rdoNewCust;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblradioReq;
        private System.Windows.Forms.Label lblReqNewCust;
        private System.Windows.Forms.Button btnSearchCust;
        private System.Windows.Forms.Button btnAddDonation;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCustomers;
    }
}