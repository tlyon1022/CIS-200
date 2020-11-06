// Grade ID T7938
// Mar 8
// CIS 200-01
// Program 2 
// File: InsertPatron.cs
// InsertPatron.cs in Program 2 intializizes insert patron dialog boxes, declares values for patron attributes
// and validates their input.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class InsertPatron : Form
    {
        public InsertPatron()
        {
            InitializeComponent();
        }
        internal string NameValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in inputTxt is returned
            get { return patronNameTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in inputTxt is set to specified value
            set { patronNameTxt.Text = value; }
        }
        internal string IDValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in inputTxt is returned
            get { return patronIDTxt.Text; }

            // Precondition:  None
            // Postcondition: Text in inputTxt is set to specified value
            set { patronIDTxt.Text = value; }
        }
        private void patronNameTxt_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrWhiteSpace(patronNameTxt.Text))
            {
                e.Cancel = true;// IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
                                //throw new ArgumentOutOfRangeException($"{nameof(titleTxt)}", titleTxt.Text,
                                //$"{nameof(titleTxt)} must not be null or empty");
                errorProvider1.SetError(patronNameTxt, "Enter a Patron Name!");
            }// Set error message


        }
        private void patronNameTxt_Validated(object sender, EventArgs e)
        {

            errorProvider1.SetError(patronNameTxt, ""); // Clears error message
        }
        private void patronIDTxt_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(patronIDTxt.Text)) // IsNullOrWhiteSpace includes tests for null, empty, or all whitespace
            {
                e.Cancel = true;                                       //throw new ArgumentOutOfRangeException($"{nameof(titleTxt)}", titleTxt.Text,
                                                                       //$"{nameof(titleTxt)} must not be null or empty");
                errorProvider2.SetError(patronIDTxt, "Enter an ID!");
            } // Set error message

        }
        private void patronIDTxt_Validated(object sender, EventArgs e)
        {
            errorProvider2.SetError(patronIDTxt, ""); // Clears error message
        }
        private void InsertPatron_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = DialogResult.OK;
        }
    }
}
