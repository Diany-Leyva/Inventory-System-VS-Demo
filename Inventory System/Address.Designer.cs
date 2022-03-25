
namespace Inventory_System
{
    partial class frmAddress
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
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRequiredAddress1 = new System.Windows.Forms.Label();
            this.lblRequiredAddress2 = new System.Windows.Forms.Label();
            this.lblRequiredCity = new System.Windows.Forms.Label();
            this.lblRequiredState = new System.Windows.Forms.Label();
            this.lblRequiredZipCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblState.Location = new System.Drawing.Point(99, 292);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(56, 24);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.ForeColor = System.Drawing.Color.DimGray;
            this.txtState.Location = new System.Drawing.Point(331, 288);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(173, 28);
            this.txtState.TabIndex = 3;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCity.Location = new System.Drawing.Point(99, 214);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 24);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.DimGray;
            this.txtCity.Location = new System.Drawing.Point(331, 210);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(173, 28);
            this.txtCity.TabIndex = 2;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.BackColor = System.Drawing.Color.Transparent;
            this.lblZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblZipCode.Location = new System.Drawing.Point(99, 367);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(96, 24);
            this.lblZipCode.TabIndex = 11;
            this.lblZipCode.Text = "Zip Code";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtZipCode.Location = new System.Drawing.Point(331, 363);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(173, 28);
            this.txtZipCode.TabIndex = 4;
            this.txtZipCode.TextChanged += new System.EventHandler(this.txtZipCode_TextChanged);
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddress2.Location = new System.Drawing.Point(97, 141);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(150, 24);
            this.lblAddress2.TabIndex = 8;
            this.lblAddress2.Text = "Address Line 2";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddress2.Location = new System.Drawing.Point(331, 137);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(256, 28);
            this.txtAddress2.TabIndex = 1;
            this.txtAddress2.TextChanged += new System.EventHandler(this.txtAddress2_TextChanged);
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddress1.Location = new System.Drawing.Point(96, 68);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(150, 24);
            this.lblAddress1.TabIndex = 7;
            this.lblAddress1.Text = "Address Line 1";
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.ForeColor = System.Drawing.Color.DimGray;
            this.txtAddress1.Location = new System.Drawing.Point(331, 65);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(256, 28);
            this.txtAddress1.TabIndex = 0;
            this.txtAddress1.TextChanged += new System.EventHandler(this.txtAddress1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(116, 482);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 36);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Save";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(379, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(194, 36);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRequiredAddress1
            // 
            this.lblRequiredAddress1.AutoSize = true;
            this.lblRequiredAddress1.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredAddress1.Location = new System.Drawing.Point(328, 96);
            this.lblRequiredAddress1.Name = "lblRequiredAddress1";
            this.lblRequiredAddress1.Size = new System.Drawing.Size(113, 17);
            this.lblRequiredAddress1.TabIndex = 35;
            this.lblRequiredAddress1.Text = "Field is required.";
            this.lblRequiredAddress1.Visible = false;
            // 
            // lblRequiredAddress2
            // 
            this.lblRequiredAddress2.AutoSize = true;
            this.lblRequiredAddress2.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredAddress2.Location = new System.Drawing.Point(328, 168);
            this.lblRequiredAddress2.Name = "lblRequiredAddress2";
            this.lblRequiredAddress2.Size = new System.Drawing.Size(113, 17);
            this.lblRequiredAddress2.TabIndex = 36;
            this.lblRequiredAddress2.Text = "Field is required.";
            this.lblRequiredAddress2.Visible = false;
            // 
            // lblRequiredCity
            // 
            this.lblRequiredCity.AutoSize = true;
            this.lblRequiredCity.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredCity.Location = new System.Drawing.Point(328, 241);
            this.lblRequiredCity.Name = "lblRequiredCity";
            this.lblRequiredCity.Size = new System.Drawing.Size(113, 17);
            this.lblRequiredCity.TabIndex = 37;
            this.lblRequiredCity.Text = "Field is required.";
            this.lblRequiredCity.Visible = false;
            // 
            // lblRequiredState
            // 
            this.lblRequiredState.AutoSize = true;
            this.lblRequiredState.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredState.Location = new System.Drawing.Point(328, 319);
            this.lblRequiredState.Name = "lblRequiredState";
            this.lblRequiredState.Size = new System.Drawing.Size(113, 17);
            this.lblRequiredState.TabIndex = 38;
            this.lblRequiredState.Text = "Field is required.";
            this.lblRequiredState.Visible = false;
            // 
            // lblRequiredZipCode
            // 
            this.lblRequiredZipCode.AutoSize = true;
            this.lblRequiredZipCode.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredZipCode.Location = new System.Drawing.Point(328, 394);
            this.lblRequiredZipCode.Name = "lblRequiredZipCode";
            this.lblRequiredZipCode.Size = new System.Drawing.Size(113, 17);
            this.lblRequiredZipCode.TabIndex = 40;
            this.lblRequiredZipCode.Text = "Field is required.";
            this.lblRequiredZipCode.Visible = false;
            // 
            // frmAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(707, 626);
            this.Controls.Add(this.lblRequiredZipCode);
            this.Controls.Add(this.lblRequiredState);
            this.Controls.Add(this.lblRequiredCity);
            this.Controls.Add(this.lblRequiredAddress2);
            this.Controls.Add(this.lblRequiredAddress1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtAddress1);
            this.Name = "frmAddress";
            this.Text = "Address";
            this.Load += new System.EventHandler(this.Address_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRequiredAddress1;
        private System.Windows.Forms.Label lblRequiredAddress2;
        private System.Windows.Forms.Label lblRequiredCity;
        private System.Windows.Forms.Label lblRequiredState;
        private System.Windows.Forms.Label lblRequiredZipCode;
    }
}