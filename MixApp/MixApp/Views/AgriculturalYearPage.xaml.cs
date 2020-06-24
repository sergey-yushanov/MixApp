using Xamarin.Forms;
using MixApp.ViewModels;

namespace MixApp.Views
{
    public partial class AgriculturalYearPage : ContentPage
    {
        public AgriculturalYearViewModel ViewModel { get; private set; }
        public AgriculturalYearPage(AgriculturalYearViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}