using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;                     

namespace Inventory_System
{
    public partial class frmAddress : Form
    {      
        public frmAddress()
        {
            InitializeComponent();
        }

        private void Address_Load(object sender, EventArgs e)
        {
          /* CultureInfo[] getCountries = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
           

            foreach (CultureInfo c in getCountries)
            {
                RegionInfo getRegion = new RegionInfo(c.LCID);

                if (!countries.Contains(getRegion.EnglishName))
                {
                    countries.Add(getRegion.EnglishName);
                  
                }               
            }

            foreach (string s in countries)
            {
                cboCountries.Items.Add(s);
            }
          */
        }   

        private void btnAdd_Click(object sender, EventArgs e)
        {
            C_Validation vld = new C_Validation();
            string addressOutput;                                 

            if (vld.validEntry(txtAddress1, lblRequiredAddress1) &       
                vld.validString(txtCity, lblRequiredCity) &
                vld.validString(txtState, lblRequiredState) &
                vld.validZip(txtZipCode, lblRequiredZipCode))
            {           

                addressOutput = txtAddress1.Text + " " + txtAddress2.Text + ", " + txtCity.Text +     
                    ", " + txtState.Text + ", " + txtZipCode.Text;

                Tag = addressOutput;                                                     
                Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void txtAddress1_TextChanged(object sender, EventArgs e)
        {
            lblRequiredAddress1.Visible = false;
        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {
            lblRequiredAddress2.Visible = false;
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            lblRequiredCity.Visible = false;
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            lblRequiredState.Visible = false;
        }

        private void txtZipCode_TextChanged(object sender, EventArgs e)
        {
            lblRequiredZipCode.Visible = false;
        }
    }
}
