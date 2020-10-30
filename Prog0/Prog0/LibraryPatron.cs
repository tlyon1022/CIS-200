// Program 0
//Due: 1/27/2020
//CIS 200-01
//Grading ID: T7938
//Library Patron Class creates the patron object to be composited into the library book class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class LibraryPatron
{
    private string _patronName; // Name of the patron
    private string _patronID;   // ID of the patron
    
    

    // Precondition:  None
    // Postcondition: The patron has been initialized with the specified name
    //                and ID
    public LibraryPatron(string name, string id)
    {
        PatronName = name;
        PatronID = id;
    }

    public string PatronName
    {
        // Precondition:  None
        // Postcondition: The patron's name has been returned
        get
        {
            return _patronName;
        }

        // Precondition: Patron name value must be provided as a string
        // Postcondition: The patron's name has been set to the specified value
        set//Exception created if Patron Name is left empty or has 
        {
            if (string.IsNullOrWhiteSpace(value))
            {//creates new Exception object when value isn't a PatronName string
                throw new ArgumentOutOfRangeException(nameof(PatronName), value, $"{PatronName} must be set to a proper value");
                }
            else
            _patronName = value.Trim();//reomoves any whitespace from the value
        }
    }

    public string PatronID
    {
        // Precondition:  None
        // Postcondition: The patron's ID has been returned
        get
        {
            return _patronID;
        }

        // Precondition:  Patron ID value must be provided as a string
        // Postcondition: The patron's ID has been set to the specified value
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {//creates new Exception object when value isn't a PatronID string
                throw new ArgumentOutOfRangeException(nameof(PatronID), value, $"{PatronID} must be set to a proper value");
            }
            else
                _patronID = value.Trim();//reomoves any whitespace from the value
        }
        
    }

    // Precondition:  None
    // Postcondition: A string is returned presenting the libary patron's data on
    //                separate lines
    public override string ToString()
    {
        string NL = Environment.NewLine; // NewLine shortcut

        return $"Name: {PatronName}{NL}ID: {PatronID}";
    }

}

