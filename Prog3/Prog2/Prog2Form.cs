// Program 3
// CIS 200-01
// 4/3/2020
// By: T7938

// File: Prog2Form.cs
// This class creates the main GUI for Program 2. It provides a
// File menu with About and Exit items, an Insert menu with Patron and
// Book items, an Item menu with Check Out and Return items, and a
// Report menu with Patron List, Item List, and Checked Out Items items.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace LibraryItems
{
    [Serializable]
    public partial class Prog2Form : Form
    {
        FileStream input;
        FileStream output;
        private Library _lib; // The library

        // Precondition:  None
        // Postcondition: The form's GUI is prepared for display. A few test items and patrons
        //                are added to the library
        public Prog2Form()
        {
            InitializeComponent();

            _lib = new Library(); // Create the library

            // Insert test data - Magic numbers allowed here
            //_lib.AddLibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14, "ZZ25 3G", "Andrew Wright");
            //_lib.AddLibraryBook("Harriet Pooter", "Stealer Books", 2000, 21, "AB73 ZF", "IP Thief");
            //_lib.AddLibraryMovie("Andrew's Super-Duper Movie", "UofL Movies", 2011, 7,
            //"MM33 2D", 92.5, "Andrew L. Wright", LibraryMediaItem.MediaType.BLURAY,
            //LibraryMovie.MPAARatings.PG);
            //_lib.AddLibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            //"MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G);
            //_lib.AddLibraryMusic("C# - The Album", "UofL Music", 2014, 14,
            //"CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10);
            //_lib.AddLibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            //"VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12);
            //_lib.AddLibraryJournal("Journal of C# Goodness", "UofL Journals", 2017, 14,
            //"JJ12 7M", 1, 2, "Information Systems", "Andrew Wright");
            //_lib.AddLibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            //"JJ34 3F", 8, 4, "Information Systems", "Alexander Williams");
            //_lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA53 9A", 16, 7);
            //_lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA53 9B", 16, 8);
            //_lib.AddLibraryMagazine("C# Monthly", "UofL Mags", 2019, 14, "MA53 9C", 16, 9);
            //_lib.AddLibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14, "MA21 5V", 1, 1);

            //// Add 5 Patrons
            //_lib.AddPatron("Ima Reader", "12345");
            //_lib.AddPatron("Jane Doe", "11223");
            //_lib.AddPatron("   John Smith   ", "   654321   ");
            //_lib.AddPatron("James T. Kirk", "98765");
            //_lib.AddPatron("Jean-Luc Picard", "33456");
        }

        // Precondition:  File, About menu item activated
        // Postcondition: Information about author displayed in dialog box
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string NL = Environment.NewLine; // NewLine shortcut

            MessageBox.Show($"Program 2{NL}By: Andrew L. Wright{NL}CIS 200-01{NL}Spring 2020",
                "About Program 2");
        }

        // Precondition:  File, Exit menu item activated
        // Postcondition: The application is exited
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition:  Report, Patron List menu item activated
        // Postcondition: The list of patrons is displayed in the reportTxt
        //                text box
        private void patronListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryPatron> patrons;     // List of patrons
            string NL = Environment.NewLine; // NewLine shortcut

            patrons = _lib.GetPatronsList();

            reportTxt.Text = $"Patron List - {patrons.Count} patrons{NL}{NL}";

            foreach (LibraryPatron p in patrons)
                reportTxt.AppendText($"{p}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Item List menu item activated
        // Postcondition: The list of items is displayed in the reportTxt
        //                text box
        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;         // List of library items
            string NL = Environment.NewLine; // NewLine shortcut

            items = _lib.GetItemsList();

            reportTxt.Text = $"Item List - {items.Count} items{NL}{NL}";

            foreach (LibraryItem item in items)
                reportTxt.AppendText($"{item}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Report, Checked Out Items menu item activated
        // Postcondition: The list of checked out items is displayed in the
        //                reportTxt text box
        private void checkedOutItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;         // List of library items
            string NL = Environment.NewLine; // NewLine shortcut

            items = _lib.GetItemsList();

            // LINQ: selects checked out items
            var checkedOutItems =
                from item in items
                where item.IsCheckedOut()
                select item;

            reportTxt.Text = $"Checked Out Items - {checkedOutItems.Count()} items{NL}{NL}";

            foreach (LibraryItem item in checkedOutItems)
                reportTxt.AppendText($"{item}{NL}{NL}");

            // Put cursor at start of report
            reportTxt.SelectionStart = 0;
        }

        // Precondition:  Insert, Patron menu item activated
        // Postcondition: The Patron dialog box is displayed. If data entered
        //                are OK, a LibraryPatron is created and added to the library
        private void patronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatronForm patronForm = new PatronForm(); // The patron dialog box form

            DialogResult result = patronForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                // Use form's properties to get patron info to send to library
                _lib.AddPatron(patronForm.PatronName, patronForm.PatronID);
            }

            patronForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Insert, Book menu item activated
        // Postcondition: The Book dialog box is displayed. If data entered
        //                are OK, a LibraryBook is created and added to the library
        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(); // The book dialog box form

            DialogResult result = bookForm.ShowDialog(); // Show form as dialog and store result

            if (result == DialogResult.OK) // Only add if OK
            {
                try
                {
                    // Use form's properties to get book info to send to library
                    _lib.AddLibraryBook(bookForm.ItemTitle, bookForm.ItemPublisher, int.Parse(bookForm.ItemCopyrightYear),
                        int.Parse(bookForm.ItemLoanPeriod), bookForm.ItemCallNumber, bookForm.BookAuthor);
                }

                catch (FormatException) // This should never happen if form validation works!
                {
                    MessageBox.Show("Problem with Book Validation!", "Validation Error");
                }
            }

            bookForm.Dispose(); // Good .NET practice - will get garbage collected anyway
        }

        // Precondition:  Item, Check Out menu item activated
        // Postcondition: The Checkout dialog box is displayed. If data entered
        //                are OK, an item is checked out from the library by a patron
        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items
            List<LibraryPatron> patrons; // List of patrons

            items = _lib.GetItemsList();
            patrons = _lib.GetPatronsList();

            if (((items.Count - _lib.GetCheckedOutCount()) == 0) || (patrons.Count() == 0)) // Must have items and patrons
                MessageBox.Show("Must have items and patrons to check out!", "Check Out Error");
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(items, patrons); // The check out dialog box form

                DialogResult result = checkoutForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.CheckOut(checkoutForm.ItemIndex, checkoutForm.PatronIndex);
                }

                checkoutForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        // Precondition:  Item, Return menu item activated
        // Postcondition: The Return dialog box is displayed. If data entered
        //                are OK, an item is returned to the library
        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<LibraryItem> items;     // List of library items

            items = _lib.GetItemsList();

            if ((_lib.GetCheckedOutCount() == 0)) // Must have items to return
                MessageBox.Show("Must have items to return!", "Return Error");
            else
            {
                ReturnForm returnForm = new ReturnForm(items); // The return dialog box form

                DialogResult result = returnForm.ShowDialog(); // Show form as dialog and store result

                if (result == DialogResult.OK) // Only add if OK
                {
                    _lib.ReturnToShelf(returnForm.ItemIndex);
                }

                returnForm.Dispose(); // Good .NET practice - will get garbage collected anyway
            }
        }

        private void SaveLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter writer = new BinaryFormatter(); // Binary Foramatter var created for serializing

            DialogResult result; // Show form as dialog and store result
            string fileName; // string for OpenFileDialog() to assign file name to
                             //Opens FileDialog
            using (var fileChooser = new SaveFileDialog())
            {
                fileChooser.CheckFileExists = false; // let user create file
                result = fileChooser.ShowDialog();
                fileName = fileChooser.FileName; // assigns name of file to save data
            }
            if (result == DialogResult.OK) // add only if ok
            {
                if (string.IsNullOrEmpty(fileName)) // Ensures there is an actual file name
                {
                    MessageBox.Show("Enter File Name");
                }
                else
                {
                    try
                    {
                        output = new FileStream(fileName, FileMode.Create, FileAccess.Write); // defines the File Stream
                        writer.Serialize(output, _lib); // writes the file

                    }
                    catch (IOException) // Exception for IO
                    {
                        MessageBox.Show("Error saving file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        output?.Close(); // closes file
                    }
                }
            }

        }

        private void OpenLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter reader = new BinaryFormatter(); // Binary Foramatter var created for deserializing
            DialogResult result; // Show form as dialog and store result
            string fileName; // string for OpenFileDialog() to assign file name to

            //Opens FileDialog
            using (OpenFileDialog fileChooser = new OpenFileDialog())
            {
                result = fileChooser.ShowDialog(); // Show form as dialog and store result
                fileName = fileChooser.FileName; //assigns the chosen file from OpenDialog to the fileName var 
            }
            // 
            if (result == DialogResult.OK) // Only add if OK
            {
                if (string.IsNullOrEmpty(fileName)) // Ensures there is an actual file name
                {
                    MessageBox.Show("Enter File Name");
                }
                else
                {
                    try
                    {
                        input = new FileStream(fileName, FileMode.Open, FileAccess.Read); //defines the File Stream
                        _lib = reader.Deserialize(input) as Library; // Reads the file

                    }
                    catch (IOException) // IO Exception
                    {
                        MessageBox.Show("Error opeing file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally // Closes File
                    {
                        input?.Close();
                    }
                }
            }
        }

        private void PatronToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            EditPatron editPatron = new EditPatron(_lib._patrons); // creates new EditPatron form

            DialogResult result = editPatron.ShowDialog(); // Show form as dialog and store result 

            if (result == DialogResult.OK) // Only add if OK 
            {
                LibraryPatron p = _lib._patrons[editPatron.PatronIndex]; // new patron object stored from selected item in list of EditPatron instance
                PatronForm patronForm = new PatronForm(); // new Patrong form
                patronForm.PatronName = p.PatronName; // assign Patron form's items with selected index
                patronForm.PatronID = p.PatronID; // assign Patron form's items with selected index
                DialogResult result1 = patronForm.ShowDialog(); // Show form as dialog and store result
                if (result1 == DialogResult.OK) // Only add if OK
                {
                    p.PatronName = patronForm.PatronName; // reassign patron object with updated fields
                    p.PatronID = patronForm.PatronID; // reassign patron object with updated fields
                }
                editPatron.Dispose();
            }
        }




        private void BookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
                List<LibraryItem> items; // Library Items local
                items = _lib.GetItemsList(); // get list items


                EditBook editBook = new EditBook(items); // create new edit book form and send items 
                DialogResult result = editBook.ShowDialog(); // Show form as dialog and store result
                if (result == DialogResult.OK) // Only add if OK
                {
                    LibraryBook lb = _lib._items[editBook.BookIndex] as LibraryBook;// new book object stored from selected item in list of EditBook instance
                    BookForm newBookForm = new BookForm();
                    newBookForm.ItemTitle = lb.Title; // assign book form's items with selected index
                    newBookForm.ItemPublisher = lb.Publisher; // assign book form's items with selected index
                    newBookForm.ItemCopyrightYear = $"{lb.CopyrightYear}"; // assign book form's items with selected index
                    newBookForm.ItemLoanPeriod = $"{lb.LoanPeriod}"; // assign book form's items with selected index
                    newBookForm.BookAuthor = lb.Author; // assign book form's items with selected index
                    newBookForm.ItemCallNumber = lb.CallNumber; // assign book form's items with selected index


                    // newBookForm.ItemLoanPeriod = lb.LoanPeriod;
                    DialogResult result1 = newBookForm.ShowDialog(); // Show form as dialog and store result
                    if (result1 == DialogResult.OK) // Only add if OK
                    {
                        lb.Title = newBookForm.ItemTitle; // reassign book object with updated fields
                        lb.Publisher = newBookForm.ItemPublisher; // reassign book object with updated fields
                        lb.CopyrightYear = int.Parse(newBookForm.ItemCopyrightYear); // reassign book object with updated fields
                        lb.LoanPeriod = int.Parse(newBookForm.ItemLoanPeriod); // reassign book object with updated fields
                        lb.Author = newBookForm.BookAuthor; // reassign book object with updated fields
                        lb.CallNumber = newBookForm.ItemCallNumber; // reassign book object with updated fields
                    }
                editBook.Dispose();
            }
           

        }
            
    }
    
}


        
    

