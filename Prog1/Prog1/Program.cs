// Program 1A
// CIS 200-01
// Due: 2/13/2020
// By: Andrew L. Wright (Students use Grading ID)

// File: Program.cs
// This file creates a small application that tests the LibraryItem hierarchy

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryItems;
using static System.Console;


public class Program
{
    // Precondition:  None
    // Postcondition: The LibraryItem hierarchy has been tested demonstrating polymorphism
    //                in CalcLateFee()
    public static void Main(string[] args)
    {
        const int DAYSLATE = 14; // Number of days late to test each object's CalcLateFee method
        const int LOAN_EXT = 7; //additional days for loan period to test adding 7 days to current period

        LibraryBook book1 = new LibraryBook("The Wright Guide to C#", "UofL Press", 2010, 14,
                "ZZ25 3G", "Andrew Wright");  //  test book
        LibraryItem book2 = new LibraryBook("My Favorite Book", "Lyon Publications", 1900, 14,
            " XX54 5P", "Lyon Publications");  //  test book2
        LibraryMediaItem movie1 = new LibraryMovie("MidSommer", "WB", 2017, 14,
            "XX54 4H", 80, "Some Director", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG13); //  test movie
        LibraryMediaItem movie2 = new LibraryMovie("The Talented Mr. Ripley", "W. W. Norton & Company", 1999, 14,
          "XX54 6C", 80, "Anthony Minghella", LibraryMediaItem.MediaType.DVD, LibraryMovie.MPAARatings.R); //  test movie 2
        LibraryMediaItem music1 = new LibraryMusic("Some SACD", "Some Publisher for SACD", 2015, 14,
            "XX54 7U", 80, "Some Artist for SACD", LibraryMediaItem.MediaType.SACD, 15); //  test cd
        LibraryMediaItem music2 = new LibraryMusic("Some CD", "Some Publisher for CD", 2018, 14,
           "XX54 0L", 80, "Some Artist for CD", LibraryMediaItem.MediaType.CD, 15); //  test cd 2
        LibraryPeriodical magazine1 = new LibraryMagazine("Time Magazine", "TIME USA, LLC", 2000, 14,
            "XX67 9J", 3, 2);    // test magazine1
        LibraryPeriodical magazine2 = new LibraryMagazine("National Geographic", "National Geographic Society", 2008, 14,
            "XX90 3Z", 8, 1);    // test magazine2
        LibraryPeriodical journal1 = new LibraryJournal("The American Economic Review", "American Economic Association", 1977,
            14,"CC87 8Y", 3, 2, "Economics", "Esther Duflo"); //  test journal 
        LibraryPeriodical journal2 = new LibraryJournal("Nature Communications", "ANature Comms, LLC", 1987,
           14, "CC09 4R", 4, 1, "Science", "Niki Scaplehorn"); //  test journal 
        LibraryPatron patron1 = new LibraryPatron("Ima Reader", "123456"); // 1st test patron
        LibraryPatron patron2 = new LibraryPatron("Jane Doe", "112233");  // 2nd test patron
        LibraryPatron patron3 = new LibraryPatron("   John Smith   ", "   654321   "); // 3rd test patron - Trims?
        LibraryPatron patron4 = new LibraryPatron("Muhammad Yussef", "989877");  // 24th test patron
        LibraryPatron patron5 = new LibraryPatron("Sara Russa", "887766");  // 5th test patron

        decimal lateFEE;//latefees created to test calclatefee method
        List<LibraryItem> items = new List<LibraryItem>();//library items List creation
        items.Add(book1);//item added to items list
        items.Add(movie1);//item added to items list
        items.Add(movie2);//item added to items list
        items.Add(book2);//item added to items list
        items.Add(music1);//item added to items list
        items.Add(music2);//item added to items list
        items.Add(journal2);//item added to items list
        items.Add(magazine1);//item added to items list
        items.Add(magazine2);//item added to items list
        items.Add(journal1);//item added to items list
        List<LibraryPatron> patrons = new List<LibraryPatron>();//library patron list creation
        patrons.Add(patron1);//patron added to patron list
        patrons.Add(patron2);//patron added to patron list
        patrons.Add(patron3);//patron added to patron list
        patrons.Add(patron4);//patron added to patron list
        patrons.Add(patron5);//patron added to patron list






        WriteLine("Original list of items");
        WriteLine("----------------------");
        //displays all the items
        foreach (var item in items)
        {
            Console.WriteLine($" {item}");
            WriteLine();
        }
        Pause();

        // Check out 5 items
        journal1.CheckOut(patron1);
        magazine1.CheckOut(patron2);
        movie1.CheckOut(patron3);
        book1.CheckOut(patron4);
        music1.CheckOut(patron5);
        //displays changes
        foreach (var item in items)
        {
            Console.WriteLine($"{item}");
            WriteLine();
        }
        Pause();
        //creates LINQ Query for checked out items
        var checkedOutItems =
           from i in items
           where i.IsCheckedOut()
           select i;
        //displays checked out items from LINQ query
        foreach (var item in checkedOutItems)
        {
            WriteLine($" {item}");
            WriteLine();
            //WriteLine(checkedCount);
        }
        WriteLine($"Number of items checked out: {checkedOutItems.Count()}");
        Pause();
        //filters checked out query by only media items
        var checkedMedia =
            from i in checkedOutItems
            where i is LibraryMediaItem
            select i;
        //displays checked out media items from LINQ query
        foreach (var i in checkedMedia)
        {
            Console.WriteLine($" {i}");
            WriteLine();
        }
        Pause();
        //LINQ Query for magazine items 
        var magazines =
           from i in items
           where i is LibraryMagazine
           select i.Title;
        //displays all distinct values of magazines
        foreach (var i in magazines.Distinct())
        {
            WriteLine($" {i}");
            WriteLine();
        }
        Pause();
        //applies a 14 day late fee to all items and displays it
        foreach (var i in items)
        {
            lateFEE = i.CalcLateFee(DAYSLATE);
            WriteLine($"Title: {i.Title}\nCallNumber: {i.CallNumber}\nFee: {lateFEE:C}");
        }
        Pause();
        //returns all items 
        journal1.ReturnToShelf();
        magazine1.ReturnToShelf();
        movie1.ReturnToShelf();
        music1.ReturnToShelf();
        book1.ReturnToShelf();
        WriteLine($"Number of items checked out: {checkedOutItems.Count()}");
        Pause();
        //Shows current loan period of all items, adds 7 days to it, and displays changes
        foreach (var i in items)
        {
            WriteLine($"{i.Title}'s current Loan Period: {i.LoanPeriod}");
            i.LoanPeriod += LOAN_EXT;
            WriteLine($"{i.Title}'s new Loan Period: {i.LoanPeriod}");

        }
        Pause();
        //Displays all items
        foreach (var item in items)
        {
            Console.WriteLine($" {item}");
            WriteLine();
        }
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