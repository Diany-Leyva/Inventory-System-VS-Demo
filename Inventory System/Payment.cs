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
    public partial class frmPayment : Form
    {      
        private C_Payment paymentInfo = new C_Payment();                                   //new object of type payment
        private string methodChecked;                                                     //flag for the method of payment
        private string address;                                                           //Hold the billing address
        private double total;

        public frmPayment(double t)
        {
            total = t;
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            C_Validation vld = new C_Validation();

            if (isChecked(rdoVisa, rdoMasterCard, rdoPaypal, lblRequiredMethod) &
                vld.validString(txtName, lblReqName) &
                vld.validString(txtCardName, lblReqCardName) &
                vld.validEmail(txtEmail, lblReqEmail) &
                vld.validPhoneNumber(txtphoneNumber, lblReqPhone) &
                vld.validCardNumber(txtCardNumber, lblReqCardNumber) &              
                vld.isValidExpDate(txtExpDate, lblReqExpDate) &
                vld.validCVV(txtCVVNumber, lblReqCVCNumber))
            {
                paymentInfo.Method = methodChecked;                                          //Store the data in the object of type Payment
                paymentInfo.Name = txtName.Text;
                paymentInfo.CardName = txtCardName.Text;
                paymentInfo.Email = txtEmail.Text;
                paymentInfo.Phone = txtphoneNumber.Text;
                paymentInfo.CardNumber = txtCardNumber.Text;
                paymentInfo.CVVNumber = Convert.ToInt32(txtCVVNumber.Text);
                paymentInfo.ExpDate = txtExpDate.Text;
                paymentInfo.Address = address;

                Tag = paymentInfo;                                                           //store the object of type Payment in the tag
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdoVisa_CheckedChanged(object sender, EventArgs e)
        {
            methodChecked = rdoVisa.Name;                                                     //stores the name of the radio button
            lblRequiredMethod.Visible = false;
        }

        private void rdoMasterCard_CheckedChanged(object sender, EventArgs e)
        {
            methodChecked = rdoMasterCard.Text;
            lblRequiredMethod.Visible = false;
        }

        private void rdoPaypal_CheckedChanged(object sender, EventArgs e)
        {
            methodChecked = rdoPaypal.Text;
            lblRequiredMethod.Visible = false;
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            Form newAddress = new frmAddress();
            newAddress.ShowDialog();

            if (newAddress.Tag != null)
            {
                address = newAddress.Tag.ToString();
            }            
        }

        //Method to check if at least one radio button is checked
        private bool isChecked(RadioButton r1, RadioButton r2, RadioButton r3, Label lbl)
        {
            bool isRadioChecked = true;

            lbl.Visible = false; 

            if ((r1.Checked == false) &&        
                (r2.Checked == false) &&
                (r3.Checked == false))
            {
                lbl.Visible = true;           
                isRadioChecked = false;
            }

            return isRadioChecked;
        }
        
        private void frmPayment_Load(object sender, EventArgs e)
        {
            txtTotal.Text = total.ToString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            lblReqName.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            lblReqEmail.Visible = false;
        }

        private void txtphoneNumber_TextChanged(object sender, EventArgs e)
        {
            lblReqPhone.Visible = false;
        }

        private void txtCardName_TextChanged(object sender, EventArgs e)
        {
            lblReqCardName.Visible = false;
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            lblReqCardNumber.Visible = false;
        }

        private void txtExpDate_TextChanged(object sender, EventArgs e)
        {
            lblReqExpDate.Visible = false;
        }

        private void txtCVVNumber_TextChanged(object sender, EventArgs e)
        {
            lblReqCVCNumber.Visible = false;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "you@example.com")              
            {
                txtEmail.Text = "";
            }
        }

        private void txtphoneNumber_Click(object sender, EventArgs e)
        {
            if (txtphoneNumber.Text == "### ### ####")     
            {
                txtphoneNumber.Text = "";
            }
        }

        private void txtCardNumber_Click(object sender, EventArgs e)
        {
            if (txtCardNumber.Text == "9999 9999 9999 9999")     
            {
                txtCardNumber.Text = "";
            }
        }

        private void txtCVVNumber_Click(object sender, EventArgs e)
        {
            if (txtCVVNumber.Text == "CVV")     
            {
                txtCVVNumber.Text = "";
            }
        }

        private void txtExpDate_Click(object sender, EventArgs e)
        {           
            if (txtExpDate.Text == "MM/YYYY")     
            {
                txtExpDate.Text = "";
            }
        }

    }    
}
