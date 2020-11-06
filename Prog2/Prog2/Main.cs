// Grade ID T7938
// Feb 12
// CIS 200-01
// Program 2 
// File: Main.cs
// Main.cs in Program 2 intializizes all seperate dialog boxes, runs their calculations and calls on their
// respective cs files for properties and validation methods
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

    public partial class Main : Form
    {
        private Library _lib;


        public Main()
        {
            _lib = new Library();


            InitializeComponent();



            _lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
                "ZZ25 3G", "Andrew Wright");//test item added
            _lib.AddLibraryBook("My Favorite Book", "Lyon Publications", 1900, 14,
            " XX54 5P", "Lyon Publications");//test item added
            _lib.AddLibraryMovie("MidSommer", "WB", 2017, 14,
            "XX54 4H", 80, "Some Director", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG13); //  test movie
            _lib.AddLibraryMovie("The Talented Mr. Ripley", "W. W. Norton & Company", 1999, 14,
              "XX54 6C", 80, "Anthony Minghella", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.R); //  test movie 2
            _lib.AddLibraryMusic("Some SACD", "Some Publisher for SACD", 2015, 14,
                "XX54 7U", 80, "Some Artist for SACD", LibraryMediaItem.MediaType.SACD, 15); //  test cd
            _lib.AddLibraryMusic("Some CD", "Some Publisher for CD", 2018, 14,
               "XX54 0L", 80, "Some Artist for CD", LibraryMediaItem.MediaType.CD, 15); //  test cd 2
            _lib.AddLibraryMagazine("Time Magazine", "TIME USA, LLC", 2000, 14,
                "XX67 9J", 3, 2);    // test magazine1
            _lib.AddLibraryMagazine("National Geographic", "National Geographic Society", 2008, 14,
                "XX90 3Z", 8, 1);    // test magazine2
            _lib.AddLibraryJournal("The American Economic Review", "American Economic Association", 1977,
                14, "CC87 8Y", 3, 2, "Economics", "Esther Duflo"); //  test journal 
            _lib.AddLibraryJournal("Nature Communications", "Nature Comms, LLC", 1987,
               14, "CC09 4R", 4, 1, "Science", "Niki Scaplehorn"); //  test journal 


            _lib.AddPatron("Ima Reader", "123456"); // test patron
            _lib.AddPatron("Jane Doe", "112233");  // test patron
            _lib.AddPatron("   John Smith   ", "   654321   "); //  test patron - Trims?
            _lib.AddPatron("Muhammad Yussef", "989877");  // test patron
            _lib.AddPatron("Sara Russa", "887766");//test patron added
        }

        //Displays information about the program on click event of 'About' control
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grade ID: T7938\nProgram 2\nDue: March 7th, 2020\n", "About", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


        }
        //Exits Application
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();//closes application
        }
        // Precondition:  All Book information that is required and follows validation found on InsertBook.cs
        // Postcondition: Book is inserted into the library items list
        private void InsertBook_Click(object sender, EventArgs e)
        {
            InsertBook insertBook = new InsertBook();//create new form
            DialogResult result;//result var to store dialog result
            result = insertBook.ShowDialog();//display dialog box
            int copyYear, //copyYear to parse text input and assign to new book object
                loanAmt; //loan period to parse text input and assign to new book object

            if (result == DialogResult.OK)
            {
                copyYear = int.Parse(insertBook.CopyrightValue); //Retrieve value from dialog box
                loanAmt = int.Parse(insertBook.LoanValue);// Retrieve value from dialog box
                _lib.AddLibraryBook(insertBook.TitleValue, insertBook.PublisherValue, copyYear,
                loanAmt, insertBook.CallNumValue, insertBook.AuthorValue);
            }
        }
        // Precondition:  All Patron information that is required and follows validation found on InsertBook.cs
        // Postcondition: Patron is inserted into the library ptarons list
        private void InsertPatron_Click(object sender, EventArgs e)
        {
            InsertPatron insertPatron = new InsertPatron();//create new form
            DialogResult result; //result var to store dialog result
            result = insertPatron.ShowDialog();//display dialog box

            if (result == DialogResult.OK)
            {
                _lib.AddPatron(insertPatron.NameValue, insertPatron.IDValue);//library patron added
            }
        }
        // Precondition:  None
        // Postcondition: List of all items is displayed in the textbox of the GUI
        private void ItemReport_Click(object sender, EventArgs e)
        {
            string result;//result var to store string for Items report
            result = $"There are {_lib._items.Count()} items in total...";
            result += Environment.NewLine;
            foreach (var i in _lib.GetItemsList())
            {
                result += Environment.NewLine;
                result += i.ToString();//loop index of items through result
                result += Environment.NewLine;
            }
            displayTxt.Text = result;//assign all items and newlines to the text box of the display area in the form

        }
        // Precondition:  None
        // Postcondition: List of all patrons is displayed in the textbox of the GUI
        private void PatronReport(object sender, EventArgs e)
        {
            string result;//result var to store strings of patrons for patron report
            result = $"There are {_lib._patrons.Count()} patrons in total...";
            result += Environment.NewLine;
            foreach (var i in _lib.GetPatronsList())
            {
                result += Environment.NewLine;
                result += i;//loop index of items through result
                result += Environment.NewLine;
            }
            displayTxt.Text = result;//assign all items and newlines to the text box of the display area in the form
        }
        // Precondition:  None
        // Postcondition: List of all checked out items is displayed in the textbox of the GUI
        private void CheckOutReport(object sender, EventArgs e)
        {
            string result;//result var to store strings of patrons for patron report
            result = $"There are {_lib.GetCheckedOutCount()} items checked out...";

            result += Environment.NewLine;
            foreach (var item in _lib._items)
            {
                if (item.IsCheckedOut())
                {
                    result += $"{item.Title} {item.CallNumber} {Environment.NewLine}" +
                        $"By: {item.Patron.PatronName} {item.Patron.PatronID}{Environment.NewLine}" +
                        $"{Environment.NewLine}";

                }

                displayTxt.Text = result;//assign all items and newlines to the text box of the display area in the form*/
            }
          
        }
        // Precondition:  Item must be in the list and be within the index count of the items
        // Postcondition: Selected item is checked out
        private void CheckOutItem(object sender, EventArgs e)
        {


            CheckOutForm1 checkOut = new CheckOutForm1(_lib.GetItemsList(), _lib.GetPatronsList());//create new form
            DialogResult result;//result for the DialogResult
            result = checkOut.ShowDialog();
            if (result == DialogResult.OK)
            {
                _lib.CheckOut(checkOut.ItemIndex, checkOut.PatronIndex);//Item is checked out

            }

        }
        // Precondition:  Item must be in the list and be within the index count of the items
        // Postcondition: Selected item is returned
        private void ReturnItem(object sender, EventArgs e)
        {
            ReturnItem returnItem = new ReturnItem(_lib.GetItemsList());//create new form
            DialogResult result;//results for the Dialog Result
            result = returnItem.ShowDialog();
            if (result == DialogResult.OK)
            {
                //for (int i=0; _lib._items.Count(); ) { }
                _lib.ReturnToShelf(returnItem.ReturnIndex);//item is returned

            }
        }

    }
}

    



        
        

     
