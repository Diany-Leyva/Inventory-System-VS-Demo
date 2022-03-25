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
    public partial class frmSelectCustomer : Form
    {
        private C_Customer tempCust;  
        private List<C_Donation> allDonations = new List<C_Donation>();
        private List<C_Customer> allCustomers = new List<C_Customer>();
        private List<C_Product> allProducts = new List<C_Product>();

        public frmSelectCustomer(List<C_Customer> cust, List<C_Product> prod, List<C_Donation> donation  )
        {         
            allCustomers = cust;  
            allProducts = prod;
            allDonations = donation;
            InitializeComponent();
        }

        private void frmSelectCustomer_Load(object sender, EventArgs e)
        {
            foreach (C_Customer cust in allCustomers)
            {
                cboCustomers.Items.Add(cust.fullName);
            }
        }

        private void rdoExistCust_CheckedChanged(object sender, EventArgs e)
        {
            cboCustomers.Enabled = true;
            btnSearchCust.Enabled = true;
            btnAddCust.Enabled = false;
            cboCustomers.Focus();
            txtCustomer.Clear();
            lblradioReq.Visible = false;
            lblReqNewCust.Visible = false;
        }

        private void rdoNewCust_CheckedChanged(object sender, EventArgs e)
        {
            cboCustomers.Enabled = false;
            btnAddCust.Enabled = true;
            btnSearchCust.Enabled = false;
            btnAddCust.Focus();
            txtCustomer.Clear();
            lblradioReq.Visible = false;
            lblReqSearchCust.Visible = false;
            cboCustomers.SelectedIndex = -1;
        }

        private void btnSearchCust_Click(object sender, EventArgs e)
        {
            bool found = false;
            lblReqSearchCust.Visible = false;
            lblReqSearchCust.Text = "Field is required";
            string input = cboCustomers.Text;                                                 //Hold the user search input

            foreach (C_Customer cust in allCustomers)
            {            
                if (cust.fullName == input)
                {
                    found = true;
                    tempCust = cust;
                    rdoExistCust.Checked = false;
                    cboCustomers.Enabled = false;
                    btnSearchCust.Enabled = false;
                    txtCustomer.BackColor = Color.White;
                    txtCustomer.Text = tempCust.fullName;
                    btnAddDonation.Focus();
                }
            }            

            if (!found)
            {
                lblReqSearchCust.Text = "Not found!";
                lblReqSearchCust.Visible = true;
            }
        }

        private void BtnAddDonation(object sender, EventArgs e)
        {
            lblReqSearchCust.Visible = false;
            lblReqNewCust.Visible = false;
            lblradioReq.Visible = false;

            if (txtCustomer.Text != "")
            {
                frmNewDonation newDonation = new frmNewDonation(allDonations[allDonations.Count() - 1].DonationID, tempCust, allProducts, allCustomers, allDonations);
               this.Hide();
               newDonation.ShowDialog();                             
            }

            else
            {
                if (rdoExistCust.Checked)
                {
                    lblReqSearchCust.Visible = true;
                }

                else if (rdoNewCust.Checked)
                {
                    lblReqNewCust.Visible = true;
                }

                else
                {
                    lblradioReq.Visible = true;
                }                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            frmCustomer newCustomer = new frmCustomer(allCustomers[allCustomers.Count() - 1].custID);
            newCustomer.ShowDialog();

            if (newCustomer.Tag != null)
            {
                tempCust = (C_Customer)newCustomer.Tag;
                allCustomers.Add(tempCust);              
                rdoNewCust.Checked = false;
                btnAddCust.Enabled = false;
                btnAddDonation.Focus();
                txtCustomer.Text = tempCust.fullName;
            }
        }

        private void cboCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblReqSearchCust.Visible = false;
        }
    }
}
