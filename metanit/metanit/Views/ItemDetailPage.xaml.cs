﻿using metanit.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace metanit.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}