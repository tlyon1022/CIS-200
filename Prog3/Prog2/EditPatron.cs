// Program 3
// CIS 200-01
// 4/3/2020
// By: T7938

// File: EditPatron.cs
// This form provides a list of patrons to be selected and edited. 
// This provides validation that item was selected and index translation
// EditPatron is a Form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryItems
{
    public partial class EditPatron : Form
    {
        private List<LibraryPatron> _patron; // List of patrons

// Precondition:  List patronList is populated with the available LibraryPatrons to choose from
// Postcondition: The form's GUI is prepared for display.
        public EditPatron(List<LibraryPatron> _patronList)
        {
            InitializeComponent();

           _patron = _patronList; 
            
        }
        // Precondition:  None
        // Postcondition: The lists of patrons are used to populate the patron list boxes
        private void EditPatron_Load(object sender, EventArgs e)
        {
            foreach (LibraryPatron patron in _patron)
              patronEditLb.Items.Add($"{patron.PatronName}, {patron.PatronID}");
        }
        public int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item list box has been returned
            get
            {
                return patronEditLb.SelectedIndex;
            }
        }
        private void patronLb_Validating(object sender, CancelEventArgs e)
        {
            if (patronEditLb.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(patronEditLb, "Please Select Item");
            }
        }
        private void patronLb_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(patronEditLb, "");
        }
        // Precondition:  User clicked on okBtn
        // Postcondition: return OK and close form.
        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Causes form to close and return OK result

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

          //  if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
