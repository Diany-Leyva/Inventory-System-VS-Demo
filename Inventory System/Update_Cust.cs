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
    public partial class frmUpdateCust : Form
    {      
        private C_Customer newCustomer = new C_Customer();
        private string strAddress;                                                
          
        public frmUpdateCust(C_Customer cust)
        {
            newCustomer = cust;
            InitializeComponent();
        }      

        private void frmUpdateCust_Load(object sender, EventArgs e)
        {
            string[] name = newCustomer.fullName.Split(' ');
            txtName.Text = name[0];
            txtLastName.Text = name[1];
            txtEmail.Text = newCustomer.Email;
            txtphoneNumber.Text = newCustomer.Phone;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            C_Validation vld = new C_Validation();

            if (vld.validString(txtName, lblRequiredName) &
                vld.validString(txtLastName, lblRequiredLastName) &
                vld.validEmail(txtEmail, lblRequiredEmail) &
                vld.validPhoneNumber(txtphoneNumber, lblRequiredPhone)) //need to check that the address and company was entered
            {               
                newCustomer.fullName = txtName.Text + " " + txtLastName.Text;
                newCustomer.Email = txtEmail.Text;
                newCustomer.Phone = txtphoneNumber.Text;                

                if (strAddress!= null)
                {
                    string[] tempAddress = strAddress.Split(',');

                    newCustomer.Address = tempAddress[0];
                    newCustomer.City = tempAddress[1];
                    newCustomer.State = tempAddress[2];
                    newCustomer.Zip = tempAddress[3];
                }              
                                
                Tag = newCustomer;     
                //MessageBox.Show("Data was successfully updated.");
                Close();
            }           
        }

        /*
        //The method accepts a string to validate the name entered by the user. 
        //*****************************************************************************************************
        private bool validString(string entry, TextBox txt, Label lbl)
        {
            bool valid = true;                                                               //Flag set to true    
            lbl.Text = "Field is required.";

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

                else                                                                     //Otherwise if is null, empty or all white spaces
                {
                    lbl.Visible = true;

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
        }//End of validString

        //Method for email address validation
        private bool validEmail(string entry, TextBox txt, Label lbl)
        {
            bool isValid = false;
            lbl.Text = "Email is required.";

            try                                                                          //Try-catch for the name
            {
                if (!String.IsNullOrWhiteSpace(entry) && entry != "you@example.com")     //If the name is not emty, null or all white spaces
                {
                    var addr = new System.Net.Mail.MailAddress(entry);
                    isValid = true;
                    //return addr.Address == entry;
                    lbl.Visible = false;
                }

                else                                                                     //Otherwise if is null, empty or all white spaces
                {
                    lbl.Visible = true;
                    txtEmail.Text = "you@example.com";

                }
            }

            catch (FormatException)                                                         //Catch the exceptions
            {
                lbl.Text = "Email is not in correct format.";                                                   //Display this message box with a particular name
                lbl.Visible = true;
                txt.Focus();                                                             //Focus on text box                
                isValid = false;                                                           //Flag set to false
            }

            catch (Exception ex)                                                         //Catch the exceptions
            {
                lbl.Text = ex.Message + ex.GetType();                                                   //Display this message box with a particular name
                lbl.Visible = true;
                txt.Focus();                                                             //Focus on text box                
                isValid = false;                                                           //Flag set to false
            }

            return isValid;
        }

        //Method to validate phone number format
        private bool validPhoneNumber(string phone, TextBox txt, Label lbl)
        {
            bool isValid = false;
            int c = 0;
            lbl.Text = "Phone Number is required.";

            try                                                                          //Try-catch for the name
            {
                if (!String.IsNullOrWhiteSpace(phone) && phone != "### ### ####")        //If the name is not emty, null or all white spaces
                {
                    for (int i = 0; i < phone.Length; i++)                                   //Loops through the string name
                    {
                        if (!char.IsDigit(phone[i]) && !char.IsWhiteSpace(phone[i]))       //If the character is not a digit or a white space
                        {
                            throw new Exception("Field must contain digits only.");        //Throw an exception
                        }

                        if (Char.IsDigit(phone[i]))                                        //if the character is digit
                        {
                            c++;                                                           //Increase the counter
                        }
                    }

                    if (c > 10)
                    {
                        throw new Exception("Field must contain 10 digits.");
                    }

                    lbl.Visible = false;
                    isValid = true;
                }

                else                                                                     //Otherwise if is null, empty or all white spaces
                {
                    lbl.Visible = true;
                    txtphoneNumber.Text = "### ### ####";
                    //throw new Exception("Entry is a required field.");                   //Throw an exception    
                }
            }

            catch (Exception ex)                                                         //Catch the exceptions
            {
                lbl.Text = ex.Message;                                                   //Display this message box with a particular name
                lbl.Visible = true;
                txt.Focus();                                                             //Focus on text box                
                isValid = false;                                                           //Flag set to false
            }

            return isValid;
        }*/

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtEmail.Text == "you@example.com")                //If the name is not emty, null or all white spaces
            {
                txtEmail.Text = "";
            }
        }

        private void txtphoneNumber_Click(object sender, EventArgs e)
        {
            if (txtphoneNumber.Text == "" || txtphoneNumber.Text == "### ### ####")     //If the name is not emty, null or all white spaces
            {
                txtphoneNumber.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {          
            Form newAddress = new frmAddress();                                     //New object of the address form
            newAddress.ShowDialog();                                                //Move controls to the form

            if (newAddress.Tag != null)
            {
                strAddress = newAddress.Tag.ToString();                                 //retreive the data using tag
            }            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblRequiredName.Visible = false;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblRequiredLastName.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblRequiredEmail.Visible = false;
        }

        private void txtphoneNumber_TextChanged(object sender, EventArgs e)
        {
            lblRequiredPhone.Visible = false;
        }
    }
}

    


