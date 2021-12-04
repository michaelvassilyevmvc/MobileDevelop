
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinGuy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        Image splashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "https://www.designbust.com/download/635/png/twitter_logo_transparent_background512.png",
                WidthRequest = 200,
                HeightRequest = 200
            };

            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            sub.Children.Add(splashImage);
            this.BackgroundColor = Color.FromHex("#ffffff");
            this.Content = sub;

            //InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new MainPage();
        }
    }
}