//Program 0
//Due: 1/27/2020
//CIS 200-01
//Grading ID: T7938
// File: Program.cs
// This file creates a simple test application class that creates patron objects and
// an array of LibraryBook objects and tests them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryBook class has been tested
    public static void Main()
    {
        LibraryBook book1 = new LibraryBook("The Wright Guide to C#   ", "Andrew Wright", "UofL Press",
            2011, "ZZ25 3G");  // 1st test book
        LibraryBook book2 = new LibraryBook("Harriet Pooter", "IP Thief", "Stealer Books",
            2001, "AG773 ZF,"); // 2nd test book
        LibraryBook book3 = new LibraryBook("The Color Mauve", "Mary Smith", "Beautiful Books Ltd.",
            1986, "JJ438 4T"); // 3rd test book
        LibraryBook book4 = new LibraryBook("The Guan Guide to SQL", "Jeff Guan", "UofL Press",
            2019, "ZZ24 4F");  // 4th test book
        LibraryBook book5 = new LibraryBook("The Big Book of Doughnuts", "Homer Simpson", "Doh Books",
            2004, "AE842 7A"); // 5th test book
        LibraryPatron patron1 = new LibraryPatron("Bobby Hansen", "12345");//1st patron 
        LibraryPatron patron2 = new LibraryPatron("                   John Smith"/*whitespace to test Trim()*/, "54321");//2nd patron
        LibraryPatron patron3 = new LibraryPatron("Allen Robertson", "98765");//3rd patron

        //Assigns each book object to the LibraryBook List<> 
        List<LibraryBook> books;
        books = new List<LibraryBook>();
        books.Add(book1);//add book1 to list
        books.Add(book2);//add book2 to list
        books.Add(book3);//add book3 to list
        books.Add(book4);//add book4 to list
        books.Add(book5);//add book5 to list




        /* LibraryBook[] theBooks = { book1, book2, book3, book4, book5 }; // Test array of books*/


        WriteLine("Original list of books");
        WriteLine("----------------------");
        PrintBooks(books);
        
        Pause();

        // Make changes
        book1.CheckOut(patron1);//Patron1 checks out book1
        book2.Publisher = "Borrowed Books";
        book3.CheckOut(patron2);//Patron2 checks out book3
        book4.CallNumber = "AB123 4A";
        book5.CheckOut(patron3);//Patron3 checks out book5
        book5.CopyrightYear = 1234; // Attempt invalid year

        WriteLine("After changes");
        WriteLine("-------------");
        PrintBooks(books);
        Pause();

        // Return the books
        book1.ReturnToShelf();
        book3.ReturnToShelf();
        book5.ReturnToShelf();

        WriteLine("After returning the books");
        WriteLine("-------------------------");
        PrintBooks(books);
    }

    // Precondition:  None
    // Postcondition: The books have been printed to the console
    public static void PrintBooks(List<LibraryBook> books)
    {
        foreach (LibraryBook b in books)
        {
            WriteLine(b);
            WriteLine();
           
        }
      
    }

    // Precondition:  None
    // Postcondition: Pauses program execution until user presses Enter and
    //                then clears the screen
    public static void Pause()
    {
        WriteLine("Press Enter to Continue...");
        ReadLine();

        Clear(); // Clear screen
    }
}
