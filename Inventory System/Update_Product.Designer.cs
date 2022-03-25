
namespace Inventory_System
{
    partial class frmUpdate_Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblReqBrand = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRequiredStatus = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblRequitedCategory = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.cboCondition = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtaTable = new System.Windows.Forms.DataGridView();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPicture = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRequiredName = new System.Windows.Forms.Label();
            this.lblRequiredFunctionality = new System.Windows.Forms.Label();
            this.lblRequiredTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.DimGray;
            this.txtBrand.Location = new System.Drawing.Point(278, 148);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(256, 28);
            this.txtBrand.TabIndex = 1;
            this.txtBrand.TextChanged += new System.EventHandler(this.txtBrand_TextChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBrand.Location = new System.Drawing.Point(102, 148);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(65, 24);
            this.lblBrand.TabIndex = 80;
            this.lblBrand.Text = "Brand";
            // 
            // lblReqBrand
            // 
            this.lblReqBrand.AutoSize = true;
            this.lblReqBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblReqBrand.ForeColor = System.Drawing.Color.Red;
            this.lblReqBrand.Location = new System.Drawing.Point(275, 173);
            this.lblReqBrand.Name = "lblReqBrand";
            this.lblReqBrand.Size = new System.Drawing.Size(116, 17);
            this.lblReqBrand.TabIndex = 81;
            this.lblReqBrand.Text = "Name is required";
            this.lblReqBrand.Visible = false;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(278, 392);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(256, 30);
            this.cboStatus.TabIndex = 4;
            this.cboStatus.Text = "Selection";
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(102, 392);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(66, 24);
            this.lblStatus.TabIndex = 76;
            this.lblStatus.Text = "Status";
            // 
            // lblRequiredStatus
            // 
            this.lblRequiredStatus.AutoSize = true;
            this.lblRequiredStatus.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredStatus.Location = new System.Drawing.Point(282, 425);
            this.lblRequiredStatus.Name = "lblRequiredStatus";
            this.lblRequiredStatus.Size = new System.Drawing.Size(109, 17);
            this.lblRequiredStatus.TabIndex = 78;
            this.lblRequiredStatus.Text = "Field is required";
            this.lblRequiredStatus.Visible = false;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDetails.Location = new System.Drawing.Point(102, 576);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(72, 24);
            this.lblDetails.TabIndex = 73;
            this.lblDetails.Text = "Details";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblImage.Location = new System.Drawing.Point(102, 489);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(67, 24);
            this.lblImage.TabIndex = 71;
            this.lblImage.Text = "Image";
            // 
            // lblRequitedCategory
            // 
            this.lblRequitedCategory.AutoSize = true;
            this.lblRequitedCategory.ForeColor = System.Drawing.Color.Red;
            this.lblRequitedCategory.Location = new System.Drawing.Point(275, 255);
            this.lblRequitedCategory.Name = "lblRequitedCategory";
            this.lblRequitedCategory.Size = new System.Drawing.Size(109, 17);
            this.lblRequitedCategory.TabIndex = 70;
            this.lblRequitedCategory.Text = "Field is required";
            this.lblRequitedCategory.Visible = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategory.Location = new System.Drawing.Point(102, 225);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(93, 24);
            this.lblCategory.TabIndex = 69;
            this.lblCategory.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.ForeColor = System.Drawing.Color.DimGray;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(278, 222);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(256, 30);
            this.cboCategory.TabIndex = 2;
            this.cboCategory.Text = "Selection";
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // cboCondition
            // 
            this.cboCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCondition.ForeColor = System.Drawing.Color.DimGray;
            this.cboCondition.FormattingEnabled = true;
            this.cboCondition.Location = new System.Drawing.Point(278, 305);
            this.cboCondition.Name = "cboCondition";
            this.cboCondition.Size = new System.Drawing.Size(256, 30);
            this.cboCondition.TabIndex = 3;
            this.cboCondition.Text = "Selection";
            this.cboCondition.SelectedIndexChanged += new System.EventHandler(this.cboCondition_SelectedIndexChanged);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCondition.Location = new System.Drawing.Point(102, 305);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(108, 24);
            this.lblCondition.TabIndex = 63;
            this.lblCondition.Text = "Functional";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Green;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(452, 731);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(168, 731);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 36);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtaTable
            // 
            this.dtaTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtaTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtaTable.ColumnHeadersHeight = 29;
            this.dtaTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Weight,
            this.Quantity,
            this.Cost});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtaTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtaTable.Location = new System.Drawing.Point(278, 576);
            this.dtaTable.Name = "dtaTable";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtaTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtaTable.RowHeadersWidth = 51;
            this.dtaTable.RowTemplate.Height = 24;
            this.dtaTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtaTable.Size = new System.Drawing.Size(370, 63);
            this.dtaTable.TabIndex = 6;
            // 
            // Weight
            // 
            this.Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Weight.Width = 98;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "QOH";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 70;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Fee";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 50;
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPicture.Location = new System.Drawing.Point(278, 489);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(194, 36);
            this.btnPicture.TabIndex = 5;
            this.btnPicture.Text = "Choose File";
            this.btnPicture.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.DimGray;
            this.txtName.Location = new System.Drawing.Point(278, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(256, 28);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(102, 74);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(143, 24);
            this.lblName.TabIndex = 58;
            this.lblName.Text = "Product Name";
            // 
            // lblRequiredName
            // 
            this.lblRequiredName.AutoSize = true;
            this.lblRequiredName.BackColor = System.Drawing.Color.Transparent;
            this.lblRequiredName.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredName.Location = new System.Drawing.Point(275, 102);
            this.lblRequiredName.Name = "lblRequiredName";
            this.lblRequiredName.Size = new System.Drawing.Size(116, 17);
            this.lblRequiredName.TabIndex = 65;
            this.lblRequiredName.Text = "Name is required";
            this.lblRequiredName.Visible = false;
            // 
            // lblRequiredFunctionality
            // 
            this.lblRequiredFunctionality.AutoSize = true;
            this.lblRequiredFunctionality.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFunctionality.Location = new System.Drawing.Point(275, 338);
            this.lblRequiredFunctionality.Name = "lblRequiredFunctionality";
            this.lblRequiredFunctionality.Size = new System.Drawing.Size(109, 17);
            this.lblRequiredFunctionality.TabIndex = 66;
            this.lblRequiredFunctionality.Text = "Field is required";
            this.lblRequiredFunctionality.Visible = false;
            // 
            // lblRequiredTable
            // 
            this.lblRequiredTable.AutoSize = true;
            this.lblRequiredTable.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredTable.Location = new System.Drawing.Point(275, 642);
            this.lblRequiredTable.Name = "lblRequiredTable";
            this.lblRequiredTable.Size = new System.Drawing.Size(127, 17);
            this.lblRequiredTable.TabIndex = 67;
            this.lblRequiredTable.Text = "Fields are required";
            this.lblRequiredTable.Visible = false;
            // 
            // frmUpdate_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(811, 842);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblReqBrand);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblRequiredStatus);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblRequitedCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboCondition);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtaTable);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRequiredName);
            this.Controls.Add(this.lblRequiredFunctionality);
            this.Controls.Add(this.lblRequiredTable);
            this.Name = "frmUpdate_Product";
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.frmUpdate_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblReqBrand;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRequiredStatus;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblRequitedCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.ComboBox cboCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtaTable;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRequiredName;
        private System.Windows.Forms.Label lblRequiredFunctionality;
        private System.Windows.Forms.Label lblRequiredTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}