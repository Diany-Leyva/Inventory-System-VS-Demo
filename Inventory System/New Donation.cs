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
    public partial class frmNewDonation : Form
    {
        private C_Customer donatingCustomer;
        private C_Donation newDonation = new C_Donation();
        private C_Payment newPayment;
        private List<C_Product> allProducts;
        private List<C_Customer> allCustomers;
        private List<C_Donation> allDonations;
        private List<C_Product> tempProducts = new List<C_Product>();
        private int numberItems = 0;       
        private int newID;
        private int tempID;
        private string strRequestType;      
        private double total = 0;

        public frmNewDonation(int id, C_Customer cust, List<C_Product> prod, List<C_Customer> custList, List<C_Donation> donation)
        {
            newID = id + 1;
            donatingCustomer = cust;
            allProducts = prod;
            allCustomers = custList;
            allDonations = donation;
            InitializeComponent();
        }

        private void frmNewDonation_Load(object sender, EventArgs e)
        {
            txtTotal.Text = "0";
            txtItems.Text = "0";
            txtCustomer.Text = donatingCustomer.fullName;            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblReqRequestType.Visible = false;
            lblReqProduct.Visible = false;
            lblReqPayment.Visible = false;

            //Still need to handle payment so eventually will make payment infor required
            if ((rdoDropOff.Checked || rdoPickUp.Checked) &&
                !isProductListEmpty())
            {
                try
                {
                    newDonation.DonationID = newID;
                    newDonation.CustomerName = txtCustomer.Text;
                    newDonation.ItemsDonated = Convert.ToInt32(txtItems.Text);
                    newDonation.DonationDate = dtRequestDate.Value;
                    newDonation.Total = Convert.ToDouble(txtTotal.Text);
                    newDonation.RequestType = strRequestType;
                    
                    foreach ( C_Product p in tempProducts)
                    {
                        allProducts.Add(p);
                    }                    

                    if (!allCustomers.Contains(donatingCustomer))
                    {
                        allCustomers.Add(donatingCustomer);
                    }

                    allDonations.Add(newDonation);
                    this.Close();                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);                   
                }                
            }

            else
            {
                if (!rdoDropOff.Checked && !rdoPickUp.Checked)
                {
                    lblReqRequestType.Visible = true;
                }

                if (newPayment == null)
                {
                    lblReqPayment.Visible = true;
                }

                if (tempProducts.Count == 0)
                {
                    lblReqProduct.Visible = true;
                }               
            }
        }

        private bool isProductListEmpty()
        {       
            return tempProducts.Count() == 0;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            C_Product tempProd;
            tempID = allProducts[allProducts.Count() - 1].ProductID;
            frmProduct newProduct = new frmProduct(tempID);
            newProduct.ShowDialog();            

            if (newProduct.Tag != null)
            {
                tempProd = (C_Product)newProduct.Tag;
                tempProducts.Add(tempProd);

                lstProductList.Items.Add(tempProd.Name);
                numberItems += tempProd.Quantity;
                txtItems.Text = numberItems.ToString();
                total += (tempProd.Fee * tempProd.Quantity);
                txtTotal.Text = total.ToString();
                lblReqProduct.Visible = false;               
                tempID = tempProd.ProductID;
            }
        }

        private void rdoPickUp_CheckedChanged(object sender, EventArgs e)
        {
            strRequestType = rdoPickUp.Text;
            lblReqRequestType.Visible = false;
        }

        private void rdoDropOff_CheckedChanged(object sender, EventArgs e)
        {
            strRequestType = rdoDropOff.Text;
            lblReqRequestType.Visible = false;
        }

        private void btnDeletProdt_Click(object sender, EventArgs e)
        {
            lblReqDeletProd.Visible = false;            

            if (tempProducts.Count() != 0)
            {
                if (lstProductList.SelectedIndex != -1)
                {
                    for (int i = 0; i < tempProducts.Count; i++)
                    {
                        if (tempProducts[i].Name == lstProductList.SelectedItem.ToString())
                        {
                            total -= (tempProducts[i].Fee * tempProducts[i].Quantity);
                            numberItems -= tempProducts[i].Quantity;
                            lstProductList.Items.Remove(tempProducts[i].Name);
                            tempProducts.Remove(tempProducts[i]);
                        }
                    }
                   
                    txtTotal.Text = total.ToString();
                    txtItems.Text = numberItems.ToString();
                }

                else
                {
                    lblReqDeletProd.Visible = true;
                }
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {         
            Close();
        }

        private void btnPaymentInfo_Click(object sender, EventArgs e)
        {
            frmPayment paymentInfo = new frmPayment(total);
            paymentInfo.ShowDialog();

            if (paymentInfo.Tag != null)
            {
                newPayment = (C_Payment)paymentInfo.Tag;
                lblReqPayment.Visible = false;
            }
        }
    }
}
