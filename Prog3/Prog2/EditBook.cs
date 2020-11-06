// Program 3
// CIS 200-01
// 4/3/2020
// By: T7938

// File: EditBook.cs
// This form provides a list of book items to be selected and edited. 
// This provides validation that item was selected and index translation
// EditBook is a Form
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
    public partial class EditBook : Form
    {
        internal List<LibraryItem> _items;
        private List<int> bookIndicies; // List of index values of items checked out

        // Precondition:  List _itemList is populated with the available LibraryPatrons to choose from
        // Postcondition: The form's GUI is prepared for display.
        public EditBook(List<LibraryItem> _itemList)
        {
            _items = _itemList;
            bookIndicies = new List<int>();

            InitializeComponent();
        }
        // Precondition:  None
        // Postcondition: The lists of books are used to populate the patron list boxes
        private void EditBook_Load(object sender, EventArgs e)
        {
                for (int i = 0; i < _items.Count; ++i)
                {
                    if (_items[i] is LibraryBook)
                    {

                        editBookLb.Items.Add(_items[i].Title);
                        bookIndicies.Add(i);
                    }
                }
        }

        private void bookLb_Validating(object sender, CancelEventArgs e)
        {
            if (editBookLb.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(editBookLb,"Please Select Item");
            }
        }
        private void bookLb_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(editBookLb, "");
        }
        internal int BookIndex
        {
            // Precondition:  None
            // Postcondition: The index of form's selected item list box has been returned
            get
            {
                //return bookIndicies[editBookLb.SelectedIndex]; // Lookup correct index
                if (editBookLb.SelectedIndex != -1)
                   return bookIndicies[editBookLb.SelectedIndex];
                return -1;
            }
        }

        private void OkBtn_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren())
                this.DialogResult = DialogResult.OK; // Causes form to close and return OK result

        }

        private void CnclBtn_Click(object sender, EventArgs e)
        {
            // This handler uses MouseDown instead of Click event because
            // Click won't be allowed if other field's validation fails

           // if (e.Button == MouseButtons.Left) // Was it a left-click?
                this.DialogResult = DialogResult.Cancel;
        }
    }
}
