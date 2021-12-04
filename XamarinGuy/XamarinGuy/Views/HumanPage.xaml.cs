
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinGuy.ViewModels;

namespace XamarinGuy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HumanPage : ContentPage
    {
        public HumanPage()
        {
            InitializeComponent();
            BindingContext = new HumanViewModels();
        }
    }
}