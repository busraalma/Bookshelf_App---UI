﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BookBorrowingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BorrowedBooks : ContentPage
    {
        public BorrowedBooks()
        {
            InitializeComponent();
        }
    }
}