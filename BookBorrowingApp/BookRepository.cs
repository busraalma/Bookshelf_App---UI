using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BookBorrowingApp
{
    class BookRepository
    {
        public static IList<Book> Books { get; set; }

        static BookRepository()
        {
            Books = new ObservableCollection<Book>
            {
                new Book
                {
                    BookId = 1,
                    BookName = "The Grapes of Warth",
                    BookAuthor = "John Steinbeck",
                    Owner = UserRepository.Users[0],
                    ImageUrl = "https://wikiimg.tojsiabtv.com/wikipedia/commons/thumb/a/ad/The_Grapes_of_Wrath_(1939_1st_ed_cover).jpg/440px-The_Grapes_of_Wrath_(1939_1st_ed_cover).jpg"

                },

                new Book
                {
                    BookId = 2,
                    BookName = "The Autobiography of Malcolm X",
                    BookAuthor = "Malcolm X",
                    Owner = UserRepository.Users[0],
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51K6Bsvbn6L._SY344_BO1,204,203,200_QL70_ML2_.jpg"
                },

                new Book
                {
                    BookId = 7,
                    BookName = "Ghost in the Wires",
                    BookAuthor = "Kevin Mitnick",
                    Owner = UserRepository.Users[0],
                    ImageUrl = "https://m.media-amazon.com/images/I/51HthxU2L3L._SY346_.jpg"
                },

                new Book
                {
                    BookId = 4,
                    BookName = "To Kill a Mockingbird",
                    BookAuthor = "Harper Lee",
                    Owner = UserRepository.Users[0],
                    ImageUrl = "https://kbimages1-a.akamaihd.net/2a758fb8-849e-464c-bb29-6f8c523231fa/353/569/90/False/to-kill-a-mockingbird-4.jpg"
                },

                new Book
                {
                    BookId = 5,
                    BookName = "The Catcher in the Rye",
                    BookAuthor = "J. D. Salinger",
                    Owner = UserRepository.Users[0],
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51lprH3LF4L._SX323_BO1,204,203,200_.jpg"
                },

                new Book
                {
                    BookId = 6,
                    BookName = "Lord of the Flies",
                    BookAuthor = "William Golding",
                    Owner = UserRepository.Users[0],
                    ImageUrl = "https://images-eu.ssl-images-amazon.com/images/I/51R1HZ-LERL._SY291_BO1,204,203,200_QL40_ML2_.jpg"
                },

                new Book
                {
                    BookId = 3,
                    BookName = "1984",
                    BookAuthor = "George Orwell",
                    Owner = UserRepository.Users[0],
                    ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41DoIQLHzlL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg"
                }
            };
        }
    }
}
