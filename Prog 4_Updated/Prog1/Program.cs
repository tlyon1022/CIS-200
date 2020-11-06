// Program 4
// CIS 200-01
// Due: 4/15/2020
// By: T7938

// File: Program.cs
// This file creates a small application that tests the LibraryItem sorting 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;
using static System.Console;

public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested using LINQ, demonstrating polymorphism
    public static void Main(string[] args)
    {
        //const int DAYSLATE = 14;     // Number of days late to test each object's CalcLateFee method
        //const int LOANEXTENSION = 7; // Number of days to extend loan period

        List<LibraryItem> items = new List<LibraryItem>();       // List of library items
        List<LibraryPatron> patrons = new List<LibraryPatron>(); // List of patrons

        //int p; // Patron index

        // Test data - Magic numbers allowed here
        items.Add(new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
            "ZZ25 3G", "Andrew Wright"));
        items.Add(new LibraryBook("Harriet Pooter", "Stealer Books", 2000, 21,
            "AB73 ZF", "IP Thief"));
        items.Add(new LibraryMovie("   Andrew's Super-Duper Movie   ", "   UofL Movies   ", 2019, 7,
            "MM33 2D", 92.5, "   Andrew L. Wright   ", LibraryMediaItem.MediaType.BLURAY,
            LibraryMovie.MPAARatings.PG)); // Trims?
        items.Add(new LibraryMovie("Pirates of the Carribean: The Curse of C#", "Disney Programming", 2012, 10,
            "MO93 4S", 122.5, "Steven Stealberg", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.G));
        items.Add(new LibraryMusic("C# - The Album", "UofL Music", 2020, 14,
            "CD44 4Z", 84.3, "Dr. A", LibraryMediaItem.MediaType.CD, 10));
        items.Add(new LibraryMusic("The Sounds of Programming", "Soundproof Music", 1996, 21,
            "VI64 1Z", 65.0, "Cee Sharpe", LibraryMediaItem.MediaType.VINYL, 12));
        items.Add(new LibraryJournal("Journal of C# Goodness", "UofL Journals", 2018, 14,
            "JJ12 7M", 1, 2, "Information Systems", "Andrew Wright"));
        items.Add(new LibraryJournal("Journal of VB Goodness", "UofL Journals", 2008, 14,
            "JJ34 3F", 8, 4, "Information Systems", "Alexander Williams"));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2017, 14,
            "MA53 9A", 16, 7));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2019, 14,
            "MA53 9B", 17, 1));
        items.Add(new LibraryMagazine("C# Monthly", "UofL Mags", 2019, 14,
            "MA53 9C", 17, 2));
        items.Add(new LibraryMagazine("     VB Magazine    ", "    UofL Mags   ", 2018, 14,
            "MA21 5V", 1, 1));

        // Add patrons
        patrons.Add(new LibraryPatron("Ima Reader", "12345"));
        patrons.Add(new LibraryPatron("Jane Doe", "11223"));
        patrons.Add(new LibraryPatron("   John Smith   ", "   654321   ")); // Trims?
        patrons.Add(new LibraryPatron("James T. Kirk", "98765"));
        patrons.Add(new LibraryPatron("Jean-Luc Picard", "33456"));

        WriteLine("List of items at start:\n");
        foreach (LibraryItem item in items)
            WriteLine("{0}\n", item);
        Pause();

        items.Sort(); // Sort - uses natural order
        WriteLine("Sorted list (natural order):");
        foreach (LibraryItem lib in items)
            WriteLine($"{lib}\n");
        WriteLine();
        Pause();

        items.Sort(new DescendingOrder()); // Sort - uses descending order
        WriteLine("Sorted list (descending natural order) using Comparer:");
        foreach (LibraryItem lib in items)
            WriteLine($"{lib} \n");
        WriteLine();
        Pause();


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