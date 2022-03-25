using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmUpdate_Product : Form
    {
        private List<string> categories = new List<string> { "TV", "Tablet", "Desktop Computer", "Printer", "Stereo",
                                           "Wifi", "Game Console", "Laptop", "DVD Player", "Mouse", "Parts",
                                           "Speaker", "USB drivers", "Smartphone", "Battery", "Laptop" };

        private C_Product product = new C_Product();

        public frmUpdate_Product(C_Product prod)
        {
            product = prod;
            InitializeComponent();
        }

        private void frmUpdate_Product_Load(object sender, EventArgs e)
        {
            foreach (string category in categories)       //Populate the gategories table
            {
                cboCategory.Items.Add(category);
            }

            cboCondition.Items.Add("Yes");
            cboCondition.Items.Add("No");


            cboStatus.Items.Add("Processing");
            cboStatus.Items.Add("Refurbish");
            cboStatus.Items.Add("Donation");
            cboStatus.Items.Add("On Sale");

            txtName.Text = product.Name;
            txtBrand.Text = product.Brand;            
            cboCategory.SelectedItem = product.Category;
            cboCondition.SelectedItem = product.Functional;           
            cboStatus.SelectedItem = product.Status;
            dtaTable.Rows[0].Cells[0].Value = product.Weight;
            dtaTable.Rows[0].Cells[1].Value = product.Quantity;
            dtaTable.Rows[0].Cells[2].Value = product.Fee;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            C_Validation vld = new C_Validation();

            if (vld.validEntry(txtName, lblRequiredName) &
                vld.validEntry(txtBrand, lblReqBrand) &
                vld.isSelected(cboCategory, lblRequitedCategory) &
                vld.isSelected(cboCondition, lblRequiredFunctionality) &
                vld.isSelected(cboStatus, lblRequiredStatus) &
                getTableData())
            {               
                product.Name = txtName.Text;
                product.Brand = txtBrand.Text;
                product.Category = cboCategory.Text;              
                product.Functional = cboCondition.Text;                
                product.Status = cboStatus.Text;              

                Tag = product;              
                Close();               
            }
        }

        /*
        //The method accepts a string to validate the name entered by the user. 
        //*****************************************************************************************************
        public bool validName(string entry, TextBox txt, Label lbl)
        {
            bool valid = true;                                                               //Flag set to true    
            lbl.Text = "Name is required.";

            try                                                                              //Try-catch for the name
            {
                if (!String.IsNullOrWhiteSpace(entry))                                       //If the name is not emty, null or all white spaces
                {
                    for (int i = 0; i < entry.Length; i++)                                   //Loops through the string name
                    {
                        if (!char.IsLetter(entry[i]) && !char.IsWhiteSpace(entry[i]))       //If the character is not a letter or a white space
                        {
                            throw new Exception("Field must contain letters only.");        //Throw an exception
                        }
                    }

                    lbl.Visible = false;
                }

                else                                                                       //Otherwise if is null, empty or all white spaces
                {
                    lbl.Visible = true;
                    valid = false;
                }
            }

            catch (Exception ex)                                                         //Catch the exceptions
            {
                lbl.Text = ex.Message;                                                   //Display this message box with a particular name
                lbl.Visible = true;
                txt.Focus();                                                             //Focus on text box                
                valid = false;                                                           //Flag set to false
            }

            return valid;                                                                //return the flag
        }

        public bool isSelected(ComboBox cbo, Label lbl)
        {
            bool selected = true;
            lbl.Visible = false;

            lbl.Text = "Field is required.";

            if (cbo.SelectedIndex == -1)                                              //if not item was selected
            {
                lbl.Visible = true;                                                  //display the warning label
                selected = false;                                                    //flag is false
            }

            return selected;                                                         //return flag
        }*/

        private bool getTableData()
        {
            bool success = false;

            if (dtaTable.Rows[0].Cells[0].Value == null | dtaTable.Rows[0].Cells[1].Value == null |
                            dtaTable.Rows[0].Cells[2].Value == null)
            {
                lblRequiredTable.Text = "Fields are required.";
                lblRequiredTable.Visible = true;
            }

            else
            {
                try
                {
                    product.Weight = Convert.ToDouble(dtaTable.Rows[0].Cells[0].Value);        //gets the data from the table
                    product.Quantity = Convert.ToInt32(dtaTable.Rows[0].Cells[1].Value);
                    product.Fee = Convert.ToDouble(dtaTable.Rows[0].Cells[2].Value);                    

                    lblRequiredTable.Visible = false;
                    success = true;
                    // MessageBox.Show("Saved!");
                }

                catch (FormatException)
                {
                    lblRequiredTable.Text = "Fields must contain numbers only.";
                }
            }

            return success;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblRequiredName.Visible = false;
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            lblReqBrand.Visible = false;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRequitedCategory.Visible = false;
        }

        private void cboCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRequiredFunctionality.Visible = false;
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblRequiredStatus.Visible = false;
        }
    }
}
