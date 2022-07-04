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
    public partial class CreditCardPage : ContentPage
    {
        public CreditCardPage()
        {
            InitializeComponent();
        }

        private void Back_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TabbedPage1());
        }
    }
}