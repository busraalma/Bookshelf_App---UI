using System;
using System.Collections.Generic;
using System.Text;

namespace BookBorrowingApp
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserAddress { get; set; }
        public string UserPassword { get; set; }
        public List<Book> Books { get; set; }
        public Book BorrowedBook { get; set; }
    }
}
