// Program 0
//Due: 1/27/2020
//CIS 200-01
//Grading ID: T7938
// This file creates a simple LibraryBook class capable of tracking
// the book's title, author, publisher, copyright year, call number,
// and checked out status that uses a patron object reference and maintains a HAS A relationship
//with LibraryPatron

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryBook
{
    public readonly int DEFAULT_YEAR = DateTime.Now.Year; // Default copyright year is current year

    private string _title;      // The book's title
    private string _author;     // The book's author
    private string _publisher;  // The book's publisher
    private int _copyrightYear; // The book's year of copyright
    private string _callNumber; // The book's call number in the library
    private bool _checkedOut;   // The book's checked out status
    public LibraryPatron Patron { get; private set; }//The Book's HAS A relationship with Patron 

    // Precondition:  theCopyrightYear >= 0
    // Postcondition: The library book has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryBook(String theTitle, String theAuthor, String thePublisher,
        int theCopyrightYear, String theCallNumber)
    {
        Title = theTitle;
        Author = theAuthor;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        CallNumber = theCallNumber;
    }

    public string Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return _title;
        }

        // Precondition: Title value must be provided as a string
        // Postcondition: The title has been set to the specified value
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(Title), value, $"{Title} must be set");
            }
            else
                _title = value.Trim();//reomoves any whitespace from the value
        }
        
    }

    public string Author
    {
        // Precondition:  None
        // Postcondition: The author has been returned
        get
        {
            return _author;
        }

        // Precondition:  None
        // Postcondition: The author has been set to the specified value
        set
        {
            _author = value.Trim();//reomoves any whitespace from the value
        }
    }

    public string Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return _publisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            _publisher = value.Trim();//reomoves any whitespace from the value
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return _copyrightYear;
        }

        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        set
        {
            if (value >= 0)
                _copyrightYear = value;
            else
                throw new ArgumentOutOfRangeException(nameof(CopyrightYear), value, $"{CopyrightYear} must be set");
        }
    }

    public string CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return _callNumber;
        }

        // Precondition:  Call number value must be provided as a string
        // Postcondition: The call number has been set to the specified value
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentOutOfRangeException(nameof(CallNumber), value, $"{CallNumber} must be set");
            }
            else
                _callNumber = value.Trim();//reomoves any whitespace from the value
        }
        
    }

    // Precondition:  Patron object must be constructed and will be passed as reference
    // Postcondition: The book is checked out
    public void CheckOut(LibraryPatron P)//Parameter LibraryPatron Object P provided to assign object reference to Patron when True
    {
        _checkedOut = true;
        Patron=P;
        
        
    }

    // Precondition:  Check out value must have a patron object otherwise it is already null
    // Postcondition: The book is not checked out
    public void ReturnToShelf()
    {
        _checkedOut = false;
        Patron=null;
         
    }
    //Precondition: none
    //Postcondition: reference of patron object is returned otherwise null is returned
    public bool IsCheckedOut()
    {
        return _checkedOut;

        

;           
    }
    // Precondition:  None
    // Postcondition: A string is returned representing the libary book's
    //                data on separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // Newline shortcut
        if(_checkedOut==true)
       return $"Title: {Title}{NL}Author: {Author}{NL}Publisher: {Publisher}{NL}" +
            $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}Checked Out by:{NL}{Patron}";
        else
            return $"Title: {Title}{NL}Author: {Author}{NL}Publisher: {Publisher}{NL}" +
                 $"Copyright: {CopyrightYear}{NL}Call Number: {CallNumber}{NL}Not Checked Out";
    }
}
