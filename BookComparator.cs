using System;
using System.Collections.Generic;

namespace BookComparator
{
    class Program
    {
        public static void Main()
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);
        }

        public class BookComparator : IComparer<Book>
        {
            public int Compare(Book x, Book y)
            {
                int result = x.Title.CompareTo(y.Title);
                if (result == 0)
                {
                    result = y.Year.CompareTo(x.Year);
                }
                return result;
            }
        }
    }
}
