using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Main_Form : Form
    {
        //Last Update 3/25    
        private string customerPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Customers.txt");
        private string productPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Products.txt");
        private string donationPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Donations.txt");
        
        private List<C_Customer> allCustomers = new List<C_Customer>();
        private List<C_Product> allProducts = new List<C_Product>();
        private List<C_Donation> allDonations = new List<C_Donation>();

        private C_Customer cust;
        private C_Product prod;
        private C_Donation donation;

        public Main_Form()
        {           
            InitializeComponent();
        }

        private void frmMain_Form_Load(object sender, EventArgs e)
        {
            try
            {
                readCustomersFile();
                readProductsFile();
                readDonationsFile();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Form newCustomer = new frmCustomer(allCustomers[allCustomers.Count() - 1].custID);   
            newCustomer.ShowDialog();

            if (newCustomer.Tag != null)
            {
                allCustomers.Add((C_Customer)newCustomer.Tag);

                int c = allCustomers.Count() - 1;
                int num = customerTable.Rows.Add();
                populateCustTable(num, c);
            }           
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            Form newProduct = new frmProduct(allProducts[allProducts.Count() - 1].ProductID);   
            newProduct.ShowDialog();

            if (newProduct.Tag != null)
            {
                allProducts.Add((C_Product)newProduct.Tag);

                int c = allProducts.Count() - 1;
                int num = productTable.Rows.Add();
                populateProdTable(num, c);
            }
        }

        private void btnNewDonation_Click(object sender, EventArgs e)
        {
            int currentCust = allCustomers.Count();
            frmSelectCustomer selectCustomer = new frmSelectCustomer(allCustomers, allProducts, allDonations);
            selectCustomer.ShowDialog();

            DonationTable.Rows.Clear();

            for (int i = 0; i < allDonations.Count(); i++)
            {
                int dnum = DonationTable.Rows.Add();
                populateDonationTable(dnum, i);
            }

            productTable.Rows.Clear();

            for (int i = 0; i < allProducts.Count(); i++)
            {
                int pnum = productTable.Rows.Add();
                populateProdTable(pnum, i);
            }

            if (currentCust < allCustomers.Count())
            {
                int c = allCustomers.Count() - 1;
                int cnum = customerTable.Rows.Add();
                populateCustTable(cnum, c);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string updCust = txtSearchCustomer.Text;
            lblwarning_label.Visible = false;            
            bool found = false;

            if (updCust != "Type Customer Name or ID" && updCust != "")
            {
                for (int i = 0; (!found) && (i < allCustomers.Count); i++)
                {
                    if ((allCustomers[i].fullName == updCust) ||
                        (allCustomers[i].custID.ToString() == updCust))
                    {
                        found = true;
                        Form updateCust = new frmUpdateCust(allCustomers[i]);
                        updateCust.ShowDialog();

                        if (updateCust.Tag != null)
                        {
                            allCustomers[i] = (C_Customer)updateCust.Tag;

                            populateCustTable(i, i);
                        }
                    }
                }

                if (!found)
                {
                    lblwarning_label.Text = "Not found";
                    lblwarning_label.Visible = true;
                }
            }

            else
            {
                lblwarning_label.Text = "Type Customer Name or ID";
                lblwarning_label.Visible = true;
            }
        }

        private void btnUpdateProduct_Click_1(object sender, EventArgs e)
        {
            string updtProd = txtSearcProduct.Text;
            lblRequiredProduct.Visible = false;        
            bool found = false;

            if (updtProd != "Type Product Name or ID" && updtProd != "")
            {
                for (int i = 0; (!found) && (i < allProducts.Count); i++)
                {
                    if ((allProducts[i].Name == updtProd) ||
                        (allProducts[i].ProductID.ToString() == updtProd))
                    {
                        found = true;
                        Form updateProd = new frmUpdate_Product(allProducts[i]);
                        updateProd.ShowDialog();

                        if (updateProd.Tag != null)
                        {
                            allProducts[i] = (C_Product)updateProd.Tag;

                            populateProdTable(i, i);
                        }
                    }
                }

                if (!found)
                {
                    lblRequiredProduct.Text = "Not found";
                    lblRequiredProduct.Visible = true;
                }
            }

            else
            {
                lblRequiredProduct.Text = "Type Product Name or ID";
                lblRequiredProduct.Visible = true;
            }
        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string deltCust = txtSearchCustomer.Text;
            lblwarning_label.Visible = false;       
            bool found = false;
            int num;

            if (deltCust != "Type Customer Name or ID" && deltCust != "")
            {
                for (int i = 0; (!found) && (i < allCustomers.Count()); i++)
                {
                    if ((allCustomers[i].fullName == deltCust) ||
                        (allCustomers[i].custID.ToString() == deltCust))
                    {
                        found = true;
                        customerTable.Rows[i].Cells[0].Selected = true;

                        DialogResult button = MessageBox.Show("Do you want to delete this data?", "Delete",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question,
                                           MessageBoxDefaultButton.Button2);

                        if (button == DialogResult.Yes)
                        {
                            allCustomers.RemoveAt(i);
                            customerTable.Rows.Clear();

                            for (int j = 0; j < allCustomers.Count(); j++)                                                               //Populate the table with elements in the collections
                            {
                                num = customerTable.Rows.Add();
                                populateCustTable(num, j);
                            }
                        }
                    }
                }

                if (!found)
                {
                    lblwarning_label.Text = "Not found";
                    lblwarning_label.Visible = true;
                }
            }

            else
            {
                lblwarning_label.Text = "Type Customer Name or ID";
                lblwarning_label.Visible = true;
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string deltProdt = txtSearcProduct.Text;
            lblRequiredProduct.Visible = false;            
            bool found = false;
            int num;

            if (deltProdt != "Type Product Name or ID" && deltProdt != "")
            {
                for (int i = 0; (!found) && (i < allProducts.Count()); i++)
                {
                    if ((allProducts[i].Name == deltProdt) ||
                        (allProducts[i].ProductID.ToString() == deltProdt))
                    {
                        found = true;
                        productTable.Rows[i].Cells[0].Selected = true;

                        DialogResult button = MessageBox.Show("Do you want to delete this data?", "Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button2);

                        if (button == DialogResult.Yes)
                        {
                            allProducts.RemoveAt(i);

                            productTable.Rows.Clear();

                            for (int j = 0; j < allProducts.Count(); j++)                                                               //Populate the table with elements in the collections
                            {
                                num = productTable.Rows.Add();
                                populateProdTable(num, j);
                            }
                        }
                    }
                }

                if (!found)
                {
                    lblRequiredProduct.Text = "Not found";
                    lblRequiredProduct.Visible = true;
                }
            }

            else
            {
                lblRequiredProduct.Text = "Type Product Name or ID";
                lblRequiredProduct.Visible = true;
            }
        }

        private void btnDeleteDonation_Click(object sender, EventArgs e)
        {
            string deltDonat = txtSearchDonation.Text;
            lblReqDonation.Visible = false;    
            bool found = false;
            int num;

            if (deltDonat != "Type Donation ID or Customer Name" && deltDonat != "")
            {
                for (int i = 0; (!found) && (i < allDonations.Count()); i++)
                {
                    if ((allDonations[i].CustomerName == deltDonat) ||
                        (allDonations[i].DonationID.ToString() == deltDonat))
                    {
                        found = true;
                        DonationTable.Rows[i].Cells[0].Selected = true;

                        DialogResult button = MessageBox.Show("Do you want to delete this data?", "Delete",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question,
                                               MessageBoxDefaultButton.Button2);

                        if (button == DialogResult.Yes)
                        {
                            allDonations.RemoveAt(i);

                            DonationTable.Rows.Clear();

                            for (int j = 0; j < allDonations.Count(); j++)                                                               //Populate the table with elements in the collections
                            {
                                num = DonationTable.Rows.Add();
                                populateDonationTable(num, j);
                            }
                        }
                    }
                }

                if (!found)
                {
                    lblReqDonation.Text = "Not found";
                    lblReqDonation.Visible = true;
                }
            }

            else
            {
                lblReqDonation.Text = "Type Donation ID or Customer Name";
                lblReqDonation.Visible = true;
            }
        }


        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            bool found = false;
            lblwarning_label.Visible = false;
            string input = txtSearchCustomer.Text;

            if (input != "Type Customer Name or ID" && input != "")
            {
                for (int i = 0; i < allCustomers.Count; i++)
                {
                    if (allCustomers[i].fullName == input ||
                        allCustomers[i].custID.ToString() == input)
                    {
                        found = true;
                        customerTable.Rows[i].Cells[0].Selected = true;
                    }
                }

                if (!found)
                {
                    lblwarning_label.Text = "Not found";
                    lblwarning_label.Visible = true;
                }
            }

            else
            {
                lblwarning_label.Text = "Type Customer Name or ID";
                lblwarning_label.Visible = true;
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            bool found = false;
            lblRequiredProduct.Visible = false;
            string input = txtSearcProduct.Text;

            if (input != "Type Product Name or ID" && input != "")
            {
                for (int i = 0; i < allProducts.Count; i++)
                {
                    if (allProducts[i].Name == input ||
                        allProducts[i].ProductID.ToString() == input)
                    {
                        found = true;
                        productTable.Rows[i].Cells[0].Selected = true;
                    }
                }

                if (!found)
                {
                    lblRequiredProduct.Text = "Not found";
                    lblRequiredProduct.Visible = true;
                }
            }

            else
            {
                lblRequiredProduct.Text = "Type Product Name or ID";
                lblRequiredProduct.Visible = true;
            }            
        }


        private void btnSearchDonation_Click(object sender, EventArgs e)
        {
            bool found = false;
            lblReqDonation.Visible = false;
            string input = txtSearchDonation.Text;

            if (input != "Type Donation ID or Customer Name" && input != "")
            {
                for (int i = 0; i < allDonations.Count; i++)
                {
                    if (allDonations[i].CustomerName == input ||
                        allDonations[i].DonationID.ToString() == input)
                    {
                        found = true;
                        DonationTable.Rows[i].Cells[0].Selected = true;
                    }
                }

                if (!found)
                {
                    lblReqDonation.Text = "Not found";
                    lblReqDonation.Visible = true;
                }
            }

            else
            {
                lblReqDonation.Text = "Type Donation ID or Customer Name";
                lblReqDonation.Visible = true;
            }            
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile = new StreamWriter(
                                new FileStream(customerPath, FileMode.Create, FileAccess.Write));

                if (File.Exists(customerPath))
                {
                    foreach (C_Customer customer in allCustomers)
                    {
                        outputFile.Write(customer.custID + "," + customer.fullName + "," +
                                         customer.Email + "," + customer.Phone + "," +
                                         customer.Address + "," + customer.City + "," +
                                         customer.State + "," + customer.Zip + "\n");
                    }

                    outputFile.Close();
                    MessageBox.Show("Customer Data saved!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile = new StreamWriter(
                                new FileStream(productPath, FileMode.Create, FileAccess.Write));

                if (File.Exists(productPath))
                {
                    foreach (C_Product product in allProducts)
                    {
                        outputFile.Write(product.ProductID + "," + product.Name + "," +
                                         product.Brand + "," + product.Category + "," +
                                         product.Functional + "," +
                                         product.Weight + "," + product.Quantity + "," +
                                         product.Status + "," + product.Fee + "\n");
                    }

                    outputFile.Close();
                    MessageBox.Show("Product Data saved!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSaveDonation_Click(object sender, EventArgs e)
        {
            btnSaveCustomer_Click(sender, e);
            btnSaveProduct_Click(sender, e);    

            try
            {
                StreamWriter outputFile = new StreamWriter(
                                new FileStream(donationPath, FileMode.Create, FileAccess.Write));

                if (File.Exists(donationPath))
                {
                    foreach (C_Donation donation in allDonations)
                    {
                        outputFile.Write(donation.DonationID + "," + donation.CustomerName + "," +
                                         donation.ItemsDonated + "," + donation.DonationDate + "," +
                                         donation.Total + "," + donation.RequestType + "\n");
                    }

                    outputFile.Close();
                    MessageBox.Show("Donation Data saved!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }     
        }

       

        private void txtSearchCustomer_Click(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text == "Type Customer Name or ID")
            {
                txtSearchCustomer.Clear();
            }
        }

       
        private void txtSearcProduct__Click(object sender, EventArgs e)
        {
            if (txtSearcProduct.Text == "Type Product Name or ID")
            {
                txtSearcProduct.Clear();
            }
        }

        private void txtSearchDonation_Click(object sender, EventArgs e)
        {
            if (txtSearchDonation.Text == "Type Donation ID or Customer Name")
            {
                txtSearchDonation.Clear();
            }
        }
             
        private void populateCustTable(int num, int index)
        {
            customerTable.Rows[num].Cells[0].Value = allCustomers[index].custID;
            customerTable.Rows[num].Cells[1].Value = allCustomers[index].fullName;
            customerTable.Rows[num].Cells[2].Value = allCustomers[index].Email;
            customerTable.Rows[num].Cells[3].Value = allCustomers[index].Phone;
            customerTable.Rows[num].Cells[4].Value = allCustomers[index].Address;
            customerTable.Rows[num].Cells[5].Value = allCustomers[index].City;
            customerTable.Rows[num].Cells[6].Value = allCustomers[index].State;
            customerTable.Rows[num].Cells[7].Value = allCustomers[index].Zip;
        }

        private void populateProdTable(int num, int index)
        {
            productTable.Rows[num].Cells[0].Value = allProducts[index].ProductID;
            productTable.Rows[num].Cells[1].Value = allProducts[index].Name;
            productTable.Rows[num].Cells[2].Value = allProducts[index].Brand;
            productTable.Rows[num].Cells[3].Value = allProducts[index].Category;
            productTable.Rows[num].Cells[4].Value = allProducts[index].Functional;          
            productTable.Rows[num].Cells[5].Value = allProducts[index].Weight;
            productTable.Rows[num].Cells[6].Value = allProducts[index].Quantity;
            productTable.Rows[num].Cells[7].Value = allProducts[index].Status;
            productTable.Rows[num].Cells[8].Value = allProducts[index].Fee;
        }

        private void populateDonationTable(int num, int index)
        {
            DonationTable.Rows[num].Cells[0].Value = allDonations[index].DonationID;
            DonationTable.Rows[num].Cells[1].Value = allDonations[index].CustomerName;
            DonationTable.Rows[num].Cells[2].Value = allDonations[index].ItemsDonated;
            DonationTable.Rows[num].Cells[3].Value = allDonations[index].DonationDate.ToString("MM/dd/yyyy");       
            DonationTable.Rows[num].Cells[4].Value = allDonations[index].Total;
            DonationTable.Rows[num].Cells[5].Value = allDonations[index].RequestType;         
        }       

        private void readCustomersFile()
        {
            StreamReader custFileInput = new StreamReader(
                    new FileStream(customerPath, FileMode.OpenOrCreate, FileAccess.Read));

            string custReading;                   
            int num;

            while (custFileInput.Peek() != -1)                                                  
            {
                custReading = custFileInput.ReadLine();
                string[] temp = custReading.Split(',');

                cust = new C_Customer();
                cust.custID = Convert.ToInt32(temp[0]);
                cust.fullName = temp[1];            
                cust.Email = temp[2];
                cust.Phone = temp[3];
                cust.Address = temp[4];
                cust.City = temp[5];
                cust.State = temp[6];
                cust.Zip = temp[7];

                allCustomers.Add(cust);
            }

            custFileInput.Close();

            for (int i = 0; i < allCustomers.Count(); i++)                                                               
            {
                num = customerTable.Rows.Add();
                populateCustTable(num, i);               
            }
        }

        private void readProductsFile()
        {          
            StreamReader prodFileInput = new StreamReader(
            new FileStream(productPath, FileMode.OpenOrCreate, FileAccess.Read));

            string prodReading;
            int num;

            while (prodFileInput.Peek() != -1)                                                  
            {
                prodReading = prodFileInput.ReadLine();
                string[] temp = prodReading.Split(',');

                prod = new C_Product ();
                prod .ProductID= Convert.ToInt32(temp[0]);
                prod.Name = temp[1];             
                prod.Brand = temp[2];
                prod.Category = temp[3];
                prod.Functional = temp[4];           
                prod.Weight = Double.Parse(temp[5]);
                prod.Quantity = Convert.ToInt32(temp[6]);
                prod.Status = temp[7];
                prod.Fee = Double.Parse(temp[8]);

                allProducts.Add(prod);
            }

            prodFileInput.Close();

            for (int i = 0; i < allProducts.Count(); i++)                                                              
            {
                num = productTable.Rows.Add();
                populateProdTable(num, i);               
            }
        }

        private void readDonationsFile()
        {
            StreamReader donationFileInput = new StreamReader(
                    new FileStream(donationPath, FileMode.OpenOrCreate, FileAccess.Read));

            string donationReading;
            int num;

            while (donationFileInput.Peek() != -1)                                                  
            {
                donationReading = donationFileInput.ReadLine();
                string[] temp = donationReading.Split(',');

                donation = new C_Donation();
                donation.DonationID = Convert.ToInt32(temp[0]);
                donation.CustomerName = temp[1];                
                donation.ItemsDonated = Convert.ToInt32(temp[2]);
                donation.DonationDate = DateTime.Parse(temp[3]);            
                donation.Total = Convert.ToDouble(temp[4]);
                donation.RequestType = temp[5];               

                allDonations.Add(donation);
            }

            donationFileInput.Close();

            for (int i = 0; i < allDonations.Count(); i++)                                                  
            {
                num = DonationTable.Rows.Add();
                populateDonationTable(num, i);
            }
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            lblwarning_label.Visible = false;
        }

        private void txtSearcProduct_TextChanged(object sender, EventArgs e)
        {
            lblRequiredProduct.Visible = false;
        }

        private void txtSearchDonation_TextChanged(object sender, EventArgs e)
        {
            lblReqDonation.Visible = false;
        }


        private void btnPDFCustomers_Click(object sender, EventArgs e)
        {
            savePDFFile(customerTable, "Customers.pdf");            
        }


        private void btnPDFProducts_Click(object sender, EventArgs e)
        {
            savePDFFile(productTable, "Products.pdf");
        }

        private void btnPDFDonations_Click(object sender, EventArgs e)
        {
            savePDFFile(DonationTable, "Donations.pdf");
        }

        private void savePDFFile(DataGridView dgv, string name)  
        {          
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = name;
                bool fileError = false;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }

                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show(ex.Message);
                        }
                    }

                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                           
                            MessageBox.Show("Data Exported Successfully!", "Info");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("No Record To Export!", "Info");
            }
          
        }

        private void customerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            txtSearchCustomer.Text = customerTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }

        private void productTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
            txtSearcProduct.Text = productTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }

        private void DonationTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearchDonation.Text = DonationTable.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }
    }
}
