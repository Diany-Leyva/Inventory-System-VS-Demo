using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class frmCustomer : Form
    {       
        private C_Customer newCustomer = new C_Customer();         
        private string strAddress;                                                 
        private int newID;                                                 

        public frmCustomer(int id)
        {
            newID = id + 1;                                                          
            InitializeComponent();
        }       

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            lblRequiredAddress.Visible = false;
            Form newAddress = new frmAddress();                                     
            newAddress.ShowDialog();

            if (newAddress.Tag != null)
            {
                strAddress = newAddress.Tag.ToString();                                 
            }            
        }     
        
        private void btnSave(object sender, EventArgs e)
        {
            C_Validation vld = new C_Validation();            
            lblRequiredAddress.Visible = false;

            if (vld.validString(txtName, lblRequiredName) &
                vld.validString(txtLastName, lblRequiredLastName) &
                vld.validEmail(txtEmail, lblRequiredEmail) &
                vld.validPhoneNumber(txtphoneNumber, lblRequiredPhone) &
                strAddress != null)
            {               
                newCustomer.custID = newID;
                newCustomer.fullName = txtName.Text + " " + txtLastName.Text;                
                newCustomer.Email = txtEmail.Text;
                newCustomer.Phone = txtphoneNumber.Text;

                string[] tempAddress = strAddress.Split(',');

                newCustomer.Address = tempAddress[0];
                newCustomer.City = tempAddress[1];
                newCustomer.State = tempAddress[2];
                newCustomer.Zip= tempAddress[3];
                
                Tag = newCustomer;                  
                Close();
            }

            if (strAddress == null)
            {
                lblRequiredAddress.Visible = true;
            }
        }

        private void btnDelete(object sender, EventArgs e)                                //change to cancel
        {
            Close();
        }        

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "you@example.com")                //If the name is not emty, null or all white spaces
            {
                txtEmail.Text = "";
            }
        }

        private void txtphoneNumber_Click(object sender, EventArgs e)
        {
            if (txtphoneNumber.Text == "### ### ####")     //If the name is not emty, null or all white spaces
            {
                txtphoneNumber.Text = "";
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
