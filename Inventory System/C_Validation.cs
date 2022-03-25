using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_System
{
    public class C_Validation
    {
        private const string DEFAULT_DATE = "MM/YYYY";
        private const string DEFAULT_CARD_NUMBER = "9999 9999 9999 9999";
        private const string DEFAULT_EMAIL = "you@example.com";
        private const string DEFAULT_PHONE = "### ### ####";
        private const string DEFAULT_CVV = "CVV";

        //*****************************************************************************************************

        public bool validString(TextBox txt, Label lbl)
        {
            string entry = txt.Text;
            bool valid = true;                                                               //Flag set to true    
            lbl.Text = "Field is required";

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
                    throw new Exception("Field is required");
                }
            }

            catch (Exception ex)                                                         //Catch the exceptions
            {
                lbl.Text = ex.Message;                                                   //Display this message box with a particular name
                lbl.Visible = true;
                //txt.Focus();                                                             //Focus on text box                
                valid = false;                                                           //Flag set to false
            }

            return valid;                                                                //return the flag
        }//End of validString

        //*****************************************************************************************************

        public bool validEmail(TextBox txt, Label lbl)
        {
            string entry = txt.Text;
            bool isValid = true;
            lbl.Text = "Field is required";           

            try                                                                          //Try-catch for the name
            {
                if (!String.IsNullOrWhiteSpace(entry) && entry != DEFAULT_EMAIL)          //If the name is not emty, null or all white spaces
                {
                    var addr = new System.Net.Mail.MailAddress(entry);                   
                }

                else                                                                     //Otherwise if is null, empty or all white spaces
                {
                    isValid = false;
                    txt.Text = DEFAULT_EMAIL;
                    lbl.Visible = true;                  
                }
            }

            catch (FormatException)                                                         //Catch the exceptions
            {
                lbl.Text = "Incorrect format.";                                                   //Display this message box with a particular name
                lbl.Visible = true;
                txt.Focus();                                                             //Focus on text box                
                isValid = false;                                                           //Flag set to false
            }

            /*
            catch (Exception ex)                                                         //Catch the exceptions
            {
                lbl.Text = ex.Message + ex.GetType();                                    //Display this message box with a particular name
                lbl.Visible = true;
                txt.Focus();                                                             //Focus on text box                
                isValid = false;                                                           //Flag set to false
            }*/

            return isValid;
        }//End of ValidEmail

        //*****************************************************************************************************

        public bool validPhoneNumber(TextBox txt, Label lbl)
        {
            string phone =txt.Text;
            bool isValid = true;
            int c = 0;
            lbl.Text = "Field is required";

            try                                                                          //Try-catch for the name
            {
                if (!String.IsNullOrWhiteSpace(phone) && phone != DEFAULT_PHONE)        //If the name is not emty, null or all white spaces
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
                }

                else                                                                     //Otherwise if is null, empty or all white spaces
                {
                    isValid = false;
                    txt.Text = DEFAULT_PHONE;
                    lbl.Visible = true;                   
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
        }

        //*****************************************************************************************************

        public bool validCardNumber(TextBox txt, Label lbl)
        {
            string entry = txt.Text;
            bool valid = true;
            int c = 0;
            lbl.Text = "Field is required";
            lbl.Visible = false;

            try                                                                          //Try-catch for the name
            {
                if (!String.IsNullOrWhiteSpace(entry) && entry != DEFAULT_CARD_NUMBER)     //If the name is not emty, null or all white spaces
                {
                    for (int i = 0; i < entry.Length; i++)                                   //Loops through the string name
                    {
                        if (!char.IsDigit(entry[i]) && !char.IsWhiteSpace(entry[i]))       //If the character is not a digit or a white space
                        {
                            throw new Exception("Field must contain digits only.");        //Throw an exception
                        }

                        if (Char.IsDigit(entry[i]))                                      //if the character is digit
                        {
                            c++;                                                         //Increase the counter
                        }
                    }

                    if (c != 16)
                    {
                        throw new Exception("Field must contain 16 digits.");
                    }

                    lbl.Visible = false;
                }

                else                                                                     //Otherwise if is null, empty or all white spaces
                {
                    lbl.Visible = true;
                    txt.Text = DEFAULT_CARD_NUMBER;
                    valid = false;
                }
            }

            catch (Exception ex)                                                         //Catch the exceptions
            {
                lbl.Text = ex.Message;                                                   //Display this message box with a particular name
                lbl.Visible = true;
                valid = false;                                                           //Flag set to false
            }

            return valid;
        }

        //*****************************************************************************************************
        public bool validCVV(TextBox txt, Label lbl)
        {
            string entry = txt.Text;
            bool valid = true;
            int c = 0;
            lbl.Text = "Field is required";
            lbl.Visible = false;

            try                                                                          //Try-catch for the name
            {
                if (!String.IsNullOrWhiteSpace(entry) && entry != DEFAULT_CVV)              //If the name is not emty, null or all white spaces
                {
                    for (int i = 0; i < entry.Length; i++)                                   //Loops through the string name
                    {
                        if (!char.IsDigit(entry[i]) && !char.IsWhiteSpace(entry[i]))       //If the character is not a digit or a white space
                        {
                            throw new Exception("Field must contain digits only.");        //Throw an exception
                        }

                        if (Char.IsDigit(entry[i]))                                        //if the character is digit
                        {
                            c++;                                                           //Increase the counter
                        }
                    }

                    if (c > 3)
                    {
                        throw new Exception("Field must contain 3 digits.");
                    }

                    lbl.Visible = false;
                }

                else                                                                     //Otherwise if is null, empty or all white spaces
                {
                    lbl.Visible = true;
                    valid = false;
                    txt.Text = DEFAULT_CVV;
                }
            }

            catch (Exception ex)                                                         //Catch the exceptions
            {
                lbl.Text = ex.Message;                                                   //Display this message box with a particular name
                lbl.Visible = true;

                valid = false;                                                           //Flag set to false
            }

            return valid;
        }

        //*****************************************************************************************************

        public bool isValidExpDate(TextBox txt, Label lbl)
        {
            string entry = txt.Text;
            bool isValid = true;
            lbl.Text = "Field is required";
            lbl.Visible = false;
            int month,
                year;

            if (!String.IsNullOrWhiteSpace(entry) && entry != DEFAULT_DATE)           //if the entry is not empty or does have the default text
            {
                try   
                {
                    string t = entry.Substring(2, 1);

                    if ((entry.Length == 7) && (entry.Substring(2, 1) == "/"))     
                    {
                        month = Convert.ToInt32(entry.Substring(0, 2));            //Convert the month part to integer
                        year = Convert.ToInt32(entry.Substring(3, 4));             //Convert the year part to integer  
                    }

                    else                                                           //Otherwise
                    {
                        lbl.Text = "Invalid Format.";                                //Update the text of the error label
                        lbl.Visible = true;                                          //show the label                        
                        isValid = false;                      
                    }
                }

                catch (Exception ex)                                                 //Catch the exceptions
                {
                    lbl.Text = ex.Message;                                //Update the text of the error label
                    lbl.Visible = true;                                          //show the label
                    txt.Text = DEFAULT_DATE;                                //Update text in text box
                    isValid = false;
                }
            }

            else
            {
                txt.Text = DEFAULT_DATE;                                  //Update text in text box
                lbl.Visible = true;
                isValid = false;                
            }

            return isValid;
        }

        //*****************************************************************************************************

        public bool isSelected(ComboBox cbo, Label lbl)
        {
            bool selected = true;
            lbl.Visible = false;

            lbl.Text = "Field is required";

            if (cbo.SelectedIndex == -1)                                              //if not item was selected
            {
                lbl.Visible = true;                                                  //display the warning label
                selected = false;                                                    //flag is false
            }

            return selected;                                                         //return flag
        }     

  
        //*****************************************************************************************************

        public bool validEntry(TextBox txt, Label warnLabel)
        {
            bool valid = true;                                                           //Flag set to true    
            warnLabel.Text = "Field is required.";
            warnLabel.Visible = false;
            string entry = txt.Text;

            if (String.IsNullOrWhiteSpace(entry))                                       //If the name is not emty, null or all white spaces
            {
                warnLabel.Visible = true;
                valid = false;
            }

            return valid;                                                                //return the flag

        }//End of validEntry      

      
        //*****************************************************************************************************
        public bool validZip(TextBox txt, Label warnLabel)
        {
            bool valid = true;                                                              //Flag set to true    
            warnLabel.Text = "Field is required.";
            warnLabel.Visible = false;
            string entry = txt.Text;
            int c = 0;

            try                                                                             //Try-catch for the name
            {
                if (!String.IsNullOrWhiteSpace(entry))                                       //If the name is not emty, null or all white spaces
                {
                    for (int i = 0; i < entry.Length; i++)                                   //Loops through the string name
                    {
                        if (!char.IsDigit(entry[i]))                                         //If the character is not a digit or a white space
                        {
                            throw new Exception("Field must contain digits only.");        //Throw an exception
                        }

                        if (char.IsDigit(entry[i]))                                        //if the character is digit
                        {
                            c++;                                                            //Increase the counter
                        }
                    }

                    if (c != 5)
                    {
                        throw new Exception("Field must contain 5 digits.");
                    }

                    warnLabel.Visible = false;
                }

                else                                                                        //Otherwise if is null, empty or all white spaces
                {
                    warnLabel.Visible = true;
                    valid = false;
                }
            }

            catch (Exception ex)                                                         //Catch the exceptions
            {
                warnLabel.Text = ex.Message;                                                   //Display this message box with a particular name
                warnLabel.Visible = true;
                txt.Focus();                                                             //Focus on text box                
                valid = false;                                                           //Flag set to false
            }
            return valid;

        }//End of validZip
    }
}
