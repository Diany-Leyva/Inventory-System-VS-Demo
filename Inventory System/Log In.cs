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
    public partial class frmLog_In : Form
    {
        //Can be in a file instead with the rest of employees login info
        private SortedList<string, string> loginInfo = new SortedList<string, string>                //Sorted List to hold the current employees login info
        { { "D", "1" }};                                                                             //User Name and password
       
        public frmLog_In()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text,                                                       //Holds the username entered
                password = txtPassword.Text;                                                          //Holds the password entered             
           
            if (validLoginInfo(userName, password))                                                   //If credentials are valid
            {
                this.Hide();                                                                          //Hides the login in form so user can focus on second form
                Form newForm = new Main_Form();                                                    //creates an object of the new form
                newForm.ShowDialog();                                                                 //Moves controls to the new form      
            }            
        }

        //The method validLoginInfo accepts two strings to validate the name entered by the user. 
        //*****************************************************************************************************
        private bool validLoginInfo(string userName, string passwd)
        {
            bool valid = true;                                                           //Flag set to true  
            lblRequiredUserN.Visible = false;                                            //Warning labels to false
            lblRequiredPasswd.Visible = false;                                          

            if (String.IsNullOrWhiteSpace(userName))                                     //If the username box is empty, null or all white spaces 
            {
                lblRequiredUserN.Visible = true;                                        //Show the warning label              
                valid = false;                                                           //Flag to false
            }

            if (String.IsNullOrWhiteSpace(passwd))                                      //If the password are empty, null or all white spaces 
            {
                lblRequiredPasswd.Visible = true;                                      //Show the warning label               
                valid = false;                                                         //flag to false
            }

            else                                                                       //Otherwise
            {              
                if (!loginInfo.ContainsKey(userName))                                  //If the collections does not has a key that match the username
                {
                    lblUserNPasswd.Text = "Incorrect username.";                       //Update label info
                    lblUserNPasswd.Visible = true;                                      //Show warning label
                    valid = false;                                                      //flag to false
                }

                else                                                                    //If the username was found in the collection
                {
                    for (int i = 0; i < loginInfo.Count; i++)                          //Loop through the collection
                    {
                        if (passwd != loginInfo[userName])                             //If is not the corrsponding password
                        {                           
                            lblUserNPasswd.Text = "Incorrect password.";               //Update label
                            lblUserNPasswd.Visible = true;                             //Show label     
                            valid = false;                                             //flag to false
                        }
                    }
                }                
            }

            return valid;                                                                //return flag
        }//End of validLoginInfo

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")                                                 //If an username was entered
            {
                lblRequiredUserN.Visible = false;                                       //Hide the label
            }
                       
            if (showHide.Text == "Show")                                                 //If link label says show
            {
                txtPassword.PasswordChar = '*';                                          //Hides the password using *
            }          
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                lblRequiredPasswd.Visible = false;
            }          
        }

        private void showHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {                      
            if (showHide.Text == "Show")                                           //If lable text is show
            {
                if (String.IsNullOrWhiteSpace(txtPassword.Text) )                  //If the password textbox is empty, null or all white spaces 
                {
                    lblRequiredPasswd.Visible = true;                              //show the warning label
                }

                else                                                            //otherwise
                {
                    lblRequiredPasswd.Visible = false;                          //hide warning label
                    showHide.Text = "Hide";                                     //Change label to hide
                    txtPassword.PasswordChar = (char)0;                         //Change the value to 0 to be able to show the password
                }                
            }

            else if (showHide.Text == "Hide")                                  //If label text is hide
            {
                if(String.IsNullOrWhiteSpace(txtPassword.Text))                //If the password textbox is empty, null or all white spaces 
                {
                    lblRequiredPasswd.Visible = true;                          //Show label
                }

                else                                                           //otherwise
                {
                    lblRequiredPasswd.Visible = false;                         //hide warning label
                    showHide.Text = "Show";                                     //Change label to hide                                  
                    txtPassword.PasswordChar = '*';                             //Hide the password
                }                
            }
        }

        private void lknForgotPasw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Pending
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblRequiredUserN.Visible = false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblRequiredPasswd.Visible = false;
        }

    }
}
