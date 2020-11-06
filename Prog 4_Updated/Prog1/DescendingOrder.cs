// Program 4
// CIS 200-01
// Due: 4/15/2020
// By: T7938

// File: DescendingOrder.cs
// This file creates a small application that sorts the LibraryItems in desc order
// Based on copyright year
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryItems
{
    class DescendingOrder : Comparer<LibraryItem>
    {
        // Precondition:  None
        // Postcondition: Reverses natural time order, so descending
        //                When item1 < item2, method returns positive #
        //                When item1 == item2, method returns zero
        //                When item1 > item2, method returns negative #
        public override int Compare(LibraryItem item1, LibraryItem item2)
        {
            // Ensure correct handling of null values (in .NET, null less than anything)
            if (item1 == null && item2 == null) // Both null?
                return 0;                 // Equal

            if (item1 == null) // only item1 is null?
                return -1;  // null is less than any actual time

            if (item2 == null) // only item2 is null?
                return 1;   // Any actual time is greater than null

            return (-1) * item1.CopyrightYear.CompareTo(item2.CopyrightYear);// reverse the order
        }
    }
}
