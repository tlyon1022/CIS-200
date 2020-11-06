// Grade ID T7938
// Mar 8
// CIS 200-01
// Program 2 
// File: InsertBook.cs
// InsertBook.cs in Program 2 intializizes the dialog box, declares all necessary values for a book's attributes
// and provides validation.
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class InsertBook : Form
    {
        public InsertBook()
        {
            InitializeComponent();
        }
        internal string TitleValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in titleTxt is returned
            get { return titleTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in Title is set to specified value
            set
            {
                titleTxt.Text = value;
                
            }
        }
        internal string PublisherValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in pubTxt is returned
            get { return pubTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in pubTxt is set to specified value
            set { pubTxt.Text = value; }
        }
        internal string CopyrightValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in copyTxt is returned
            get { return copyTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in copyTxt is set to specified value
            set { copyTxt.Text = value; }
        }
        internal string LoanValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in loanTxt is returned
            get { return loanTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in loanTxt is set to specified value
            set { loanTxt.Text = value; }
        }
        internal string CallNumValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in cnTxt is returned
            get { return cnTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in cnTxt is set to specified value
            set { cnTxt.Text = value; }

        }
        internal string AuthorValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in authorTxt is returned
            get { return authorTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in authorTxt is set to specified value
            set { authorTxt.Text = value; }
        }
        // Precondition:  None
        // Postcondition: Text in titleTxt is validating to ensure there is an input
        private void titleTxt_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(titleTxt.Text))
            {
                e.Cancel = true;// IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                                //throw new ArgumentOutOfRangeException($"{nameof(titleTxt)}", titleTxt.Text,
                                //$"{nameof(titleTxt)} must not be null or empty");
                errorProvider1.SetError(titleTxt, "Enter a Title!");
            }// Set error message
            

        }
        // Precondition:  None
        // Postcondition: Text in titleTxt is validated. Error removed 
        private void titleTxt_Validated(object sender, EventArgs e)
        {
           
            errorProvider1.SetError(titleTxt, ""); // Clears error message
        }
       
        // Precondition:  None
        // Postcondition: Text in copyTxt is validating to ensure there is an int input >0
        private void copyTxt_Validating(object sender, CancelEventArgs e)
        {
            int number; // Value entered into inputTxt

            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(copyTxt.Text, out number))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider3.SetError(copyTxt, "Enter an integer!"); // Set error message

                copyTxt.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (number < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    errorProvider3.SetError(copyTxt, "Enter a non-negative integer!"); // Set error message

                    copyTxt.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }
        // Precondition:  Text is input according to standards
        // Postcondition: Text in copyTxt is validated. Error removed 
        private void copyTxt_Validated(object sender, EventArgs e)
        {
            errorProvider3.SetError(copyTxt, ""); // Clears error message
        }
        // Precondition:  None
        // Postcondition: Text in loanTxt is validating to ensure there is an int input >0
        private void loanTxt_Validating(object sender, CancelEventArgs e)
        {
            int number; // Value entered into inputTxt

            // Will try to parse text as int
            // If fails, TryParse returns false
            // If succeeds, TryParse returns true and number stores parsed value
            if (!int.TryParse(loanTxt.Text, out number))
            {
                e.Cancel = true; // Stops focus changing process
                                 // Will NOT proceed to Validated event

                errorProvider4.SetError(loanTxt, "Enter an integer!"); // Set error message

                loanTxt.SelectAll(); // Select all text in inputTxt to ease correction
            }
            else
            {
                if (number < 0)
                {
                    e.Cancel = true; // Stops focus changing process
                    // Will NOT proceed to Validated event

                    errorProvider4.SetError(loanTxt, "Enter a non-negative integer!"); // Set error message

                    loanTxt.SelectAll(); // Select all text in inputTxt to ease correction
                }
            }
        }
        // Precondition:  Text is input according to standards
        // Postcondition: Text in loanTxt is validated. Error removed 
        private void loanTxt_Validated(object sender, EventArgs e)
        {
            errorProvider4.SetError(loanTxt, ""); // Clears error message
        }
        // Precondition:  None
        // Postcondition: Text in cnTxt is validating to ensure there is an input
        private void cnTxt_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cnTxt.Text)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
            {
                e.Cancel = true;                                       //throw new ArgumentOutOfRangeException($"{nameof(titleTxt)}", titleTxt.Text,
                                                                       //$"{nameof(titleTxt)} must not be null or empty");
                errorProvider5.SetError(cnTxt, "Enter a Call Number!");
            } // Set error message

        }
        // Precondition:  Text is input according to standards
        // Postcondition: Text in cnTxt is validated. Error removed 
        private void cnTxt_Validated(object sender, EventArgs e)
        {
            errorProvider5.SetError(cnTxt, ""); // Clears error message
        }

        // Precondition:  All children validated
        // Postcondition: Items are all validated and the dialogresult Ok click event happens
        private void OkBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;

        }
        // Precondition:  None
        // Postcondition: Dialog result cancels and closes

        private void CancelBtn_Click(object sender, EventArgs e)
        {
                this.DialogResult = DialogResult.Cancel;
        }

     
    }
}



