using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BookBorrowingApp
{
    public static class UserRepository
    {
        public static IList<User> Users { get; set; }

        static UserRepository()
        {
            Users = new ObservableCollection<User>
            {
                new User
                 {
                UserId = 1,
                UserName = "Ted Mosby",
                UserPhoneNumber = "+90 555 666 88 99",
                UserMail = "ted@gmail.com",
                UserPassword = "12345"
                }
            };

        }
    }
}
