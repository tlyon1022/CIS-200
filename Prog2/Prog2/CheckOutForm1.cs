// Grade ID T7938
// Mar 8
// CIS 200-01
// Program 2 
// File: CheckOutForm1.cs
// CheckOutForm1.cs in Program 2 intializizes the dialog box, populates the combo boxes and provides values for
// the two index values
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

    public partial class CheckOutForm1 : Form
    {
        
        private List<LibraryItem> _libList;//reference to library items list
        private List<LibraryPatron> _patronList;// reference to patrons list
         // Precondition: None
        // Postcondition: The library items and patrons list has been made local 
        public CheckOutForm1(List<LibraryItem> items, List<LibraryPatron> patrons)
        {
            InitializeComponent();
            _libList = items;
            _patronList = patrons;

           
        }

        // Precondition: None
        // Postcondition: The library items and patrons list has been added to respective combo
        // boxes
        private void CheckOutForm1_Load(object sender, EventArgs e)
        {
            
                foreach (var item in _libList)
                {

                    itemsCombo.Items.Add($"{item.Title} {item.CallNumber}");
                }
                foreach (var item in _patronList)
                {
                    patronsCombo.Items.Add($"{item.PatronName} {item.PatronID}");
                }
            
        }
        
        public int ItemIndex
        {
            // Precondition:  None
            // Postcondition: The selected index of itemsCombo has been returned
            get
            {
                return itemsCombo.SelectedIndex;
            }
            set
            // Precondition:  None
            // Postcondition: The selected index of itemsCombo has been set to the selected value
            {
                itemsCombo.SelectedIndex = value;
            }
        }
        public int PatronIndex
        {
            // Precondition:  None
            // Postcondition: The selected index of patronsCombo has been returned
            get
            {
                return patronsCombo.SelectedIndex;
            }
            // Precondition:  None
            // Postcondition: The selected index of patronsCombo has been set to the selected value
            set
            {
                patronsCombo.SelectedIndex = value;
            }
        }
        //allows index to be associated with selection
        private void ItemsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

