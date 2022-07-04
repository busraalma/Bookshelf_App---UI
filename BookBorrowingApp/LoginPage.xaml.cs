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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            //string userMail = MailEntry.Text;
            //string password = PasswordEntry.Text;

            //if (userMail != null && password != null)
            //{
            //    Navigation.PushAsync(new TabbedPage1());
            //}
            //else
            //{
            //    label1.Text = "Please enter your mail and password";
            //}

            Navigation.PushAsync(new TabbedPage1());
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}