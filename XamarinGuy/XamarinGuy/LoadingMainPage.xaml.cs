using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinGuy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingMainPage : ContentPage
    {
        public LoadingMainPage()
        {
            InitializeComponent();
        }

        private void browser_Navigating(object sender, WebNavigatingEventArgs e)
        {
            loading.IsVisible = true;
        }

        private void browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            loading.IsVisible = false;
        }
    }
}