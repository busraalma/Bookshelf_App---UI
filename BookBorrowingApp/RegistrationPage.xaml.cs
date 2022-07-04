using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookBorrowingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreditCardPage());
            User user = new User();
            user.UserName = UserNameEntry.Text;
            user.UserMail = UserMailEntry.Text;
            user.UserPhoneNumber = UserPhoneNumberEntry.Text;
            user.UserPassword = UserPasswordEntry.Text;

            UserRepository.Users.Add(user);

        }


        private void Login_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}