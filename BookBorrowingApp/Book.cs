using System;
using System.Collections.Generic;
using System.Text;

namespace BookBorrowingApp
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public User Owner { get; set; }
        public User Borrower { get; set; }
        public string ImageUrl { get; set; }
    }
}
