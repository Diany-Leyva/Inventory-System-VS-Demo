
namespace Inventory_System
{
    partial class frmNewDonation
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
            this.lblReqProduct = new System.Windows.Forms.Label();
            this.lblReqRequestType = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lstProductList = new System.Windows.Forms.ListBox();
            this.lblProdtList = new System.Windows.Forms.Label();
            this.grbRequestType = new System.Windows.Forms.GroupBox();
            this.rdoPickUp = new System.Windows.Forms.RadioButton();
            this.rdoDropOff = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtRequestDate = new System.Windows.Forms.DateTimePicker();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.btnDeletProdt = new System.Windows.Forms.Button();
            this.lblReqDeletProd = new System.Windows.Forms.Label();
            this.btnPaymentInfo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblReqPayment = new System.Windows.Forms.Label();
            this.grbRequestType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReqProduct
            // 
            this.lblReqProduct.AutoSize = true;
            this.lblReqProduct.ForeColor = System.Drawing.Color.Red;
            this.lblReqProduct.Location = new System.Drawing.Point(501, 387);
            this.lblReqProduct.Name = "lblReqProduct";
            this.lblReqProduct.Size = new System.Drawing.Size(132, 17);
            this.lblReqProduct.TabIndex = 75;
            this.lblReqProduct.Text = "Product is required.";
            this.lblReqProduct.Visible = false;
            // 
            // lblReqRequestType
            // 
            this.lblReqRequestType.AutoSize = true;
            this.lblReqRequestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReqRequestType.ForeColor = System.Drawing.Color.Red;
            this.lblReqRequestType.Location = new System.Drawing.Point(97, 252);
            this.lblReqRequestType.Name = "lblReqRequestType";
            this.lblReqRequestType.Size = new System.Drawing.Size(123, 17);
            this.lblReqRequestType.TabIndex = 76;
            this.lblReqRequestType.Text = "Selection required";
            this.lblReqRequestType.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(290, 569);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 24);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotal.Location = new System.Drawing.Point(352, 569);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(50, 28);
            this.txtTotal.TabIndex = 71;
            // 
            // lstProductList
            // 
            this.lstProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductList.ForeColor = System.Drawing.Color.DimGray;
            this.lstProductList.FormattingEnabled = true;
            this.lstProductList.ItemHeight = 22;
            this.lstProductList.Location = new System.Drawing.Point(91, 397);
            this.lstProductList.Name = "lstProductList";
            this.lstProductList.Size = new System.Drawing.Size(331, 114);
            this.lstProductList.TabIndex = 70;
            // 
            // lblProdtList
            // 
            this.lblProdtList.AutoSize = true;
            this.lblProdtList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdtList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblProdtList.Location = new System.Drawing.Point(92, 360);
            this.lblProdtList.Name = "lblProdtList";
            this.lblProdtList.Size = new System.Drawing.Size(119, 24);
            this.lblProdtList.TabIndex = 10;
            this.lblProdtList.Text = "Product List";
            // 
            // grbRequestType
            // 
            this.grbRequestType.Controls.Add(this.rdoPickUp);
            this.grbRequestType.Controls.Add(this.rdoDropOff);
            this.grbRequestType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRequestType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbRequestType.Location = new System.Drawing.Point(91, 129);
            this.grbRequestType.Name = "grbRequestType";
            this.grbRequestType.Size = new System.Drawing.Size(492, 120);
            this.grbRequestType.TabIndex = 67;
            this.grbRequestType.TabStop = false;
            this.grbRequestType.Text = "Request Type";
            // 
            // rdoPickUp
            // 
            this.rdoPickUp.AutoSize = true;
            this.rdoPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPickUp.Location = new System.Drawing.Point(61, 60);
            this.rdoPickUp.Name = "rdoPickUp";
            this.rdoPickUp.Size = new System.Drawing.Size(102, 28);
            this.rdoPickUp.TabIndex = 3;
            this.rdoPickUp.TabStop = true;
            this.rdoPickUp.Text = "Pick Up";
            this.rdoPickUp.UseVisualStyleBackColor = true;
            this.rdoPickUp.CheckedChanged += new System.EventHandler(this.rdoPickUp_CheckedChanged);
            // 
            // rdoDropOff
            // 
            this.rdoDropOff.AutoSize = true;
            this.rdoDropOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDropOff.Location = new System.Drawing.Point(281, 60);
            this.rdoDropOff.Name = "rdoDropOff";
            this.rdoDropOff.Size = new System.Drawing.Size(108, 28);
            this.rdoDropOff.TabIndex = 4;
            this.rdoDropOff.TabStop = true;
            this.rdoDropOff.Text = "Drop Off";
            this.rdoDropOff.UseVisualStyleBackColor = true;
            this.rdoDropOff.CheckedChanged += new System.EventHandler(this.rdoDropOff_CheckedChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(92, 298);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 24);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Date";
            // 
            // dtRequestDate
            // 
            this.dtRequestDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtRequestDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtRequestDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRequestDate.Location = new System.Drawing.Point(169, 298);
            this.dtRequestDate.Name = "dtRequestDate";
            this.dtRequestDate.RightToLeftLayout = true;
            this.dtRequestDate.Size = new System.Drawing.Size(196, 28);
            this.dtRequestDate.TabIndex = 5;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomer.Location = new System.Drawing.Point(94, 63);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(99, 24);
            this.lblCustomer.TabIndex = 8;
            this.lblCustomer.Text = "Customer";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.txtCustomer.Location = new System.Drawing.Point(216, 65);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(256, 28);
            this.txtCustomer.TabIndex = 77;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(152, 695);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(194, 36);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddProduct.BackColor = System.Drawing.Color.Green;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(504, 348);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(194, 36);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(87, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Items";
            // 
            // txtItems
            // 
            this.txtItems.BackColor = System.Drawing.SystemColors.Control;
            this.txtItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItems.ForeColor = System.Drawing.Color.DimGray;
            this.txtItems.Location = new System.Drawing.Point(152, 566);
            this.txtItems.Name = "txtItems";
            this.txtItems.Size = new System.Drawing.Size(50, 28);
            this.txtItems.TabIndex = 81;
            // 
            // btnDeletProdt
            // 
            this.btnDeletProdt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeletProdt.BackColor = System.Drawing.Color.Green;
            this.btnDeletProdt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletProdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletProdt.ForeColor = System.Drawing.Color.White;
            this.btnDeletProdt.Location = new System.Drawing.Point(504, 452);
            this.btnDeletProdt.Name = "btnDeletProdt";
            this.btnDeletProdt.Size = new System.Drawing.Size(194, 36);
            this.btnDeletProdt.TabIndex = 1;
            this.btnDeletProdt.Text = "Delete Product";
            this.btnDeletProdt.UseVisualStyleBackColor = false;
            this.btnDeletProdt.Click += new System.EventHandler(this.btnDeletProdt_Click);
            // 
            // lblReqDeletProd
            // 
            this.lblReqDeletProd.AutoSize = true;
            this.lblReqDeletProd.ForeColor = System.Drawing.Color.Red;
            this.lblReqDeletProd.Location = new System.Drawing.Point(93, 514);
            this.lblReqDeletProd.Name = "lblReqDeletProd";
            this.lblReqDeletProd.Size = new System.Drawing.Size(152, 17);
            this.lblReqDeletProd.TabIndex = 84;
            this.lblReqDeletProd.Text = "Select product from list";
            this.lblReqDeletProd.Visible = false;
            // 
            // btnPaymentInfo
            // 
            this.btnPaymentInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPaymentInfo.BackColor = System.Drawing.Color.Green;
            this.btnPaymentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentInfo.ForeColor = System.Drawing.Color.White;
            this.btnPaymentInfo.Location = new System.Drawing.Point(504, 557);
            this.btnPaymentInfo.Name = "btnPaymentInfo";
            this.btnPaymentInfo.Size = new System.Drawing.Size(194, 36);
            this.btnPaymentInfo.TabIndex = 2;
            this.btnPaymentInfo.Text = "Payment Info";
            this.btnPaymentInfo.UseVisualStyleBackColor = false;
            this.btnPaymentInfo.Click += new System.EventHandler(this.btnPaymentInfo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(459, 695);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblReqPayment
            // 
            this.lblReqPayment.AutoSize = true;
            this.lblReqPayment.ForeColor = System.Drawing.Color.Red;
            this.lblReqPayment.Location = new System.Drawing.Point(501, 596);
            this.lblReqPayment.Name = "lblReqPayment";
            this.lblReqPayment.Size = new System.Drawing.Size(138, 17);
            this.lblReqPayment.TabIndex = 87;
            this.lblReqPayment.Text = "Payment is required.";
            this.lblReqPayment.Visible = false;
            // 
            // frmNewDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(808, 815);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblReqPayment);
            this.Controls.Add(this.lblReqRequestType);
            this.Controls.Add(this.dtRequestDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPaymentInfo);
            this.Controls.Add(this.lblReqDeletProd);
            this.Controls.Add(this.btnDeletProdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItems);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblReqProduct);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lstProductList);
            this.Controls.Add(this.lblProdtList);
            this.Controls.Add(this.grbRequestType);
            this.Name = "frmNewDonation";
            this.Text = "New Donation";
            this.Load += new System.EventHandler(this.frmNewDonation_Load);
            this.grbRequestType.ResumeLayout(false);
            this.grbRequestType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReqProduct;
        private System.Windows.Forms.Label lblReqRequestType;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox lstProductList;
        private System.Windows.Forms.Label lblProdtList;
        private System.Windows.Forms.GroupBox grbRequestType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtRequestDate;
        private System.Windows.Forms.RadioButton rdoPickUp;
        private System.Windows.Forms.RadioButton rdoDropOff;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Button btnDeletProdt;
        private System.Windows.Forms.Label lblReqDeletProd;
        private System.Windows.Forms.Button btnPaymentInfo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblReqPayment;
    }
}