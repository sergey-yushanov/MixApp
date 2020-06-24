using MixApp.ViewModels;
using Xamarin.Forms;

namespace MixApp.Views
{
    public partial class AgriculturalYearsListPage : ContentPage
    {
        public AgriculturalYearsListPage()
        {
            InitializeComponent();
            BindingContext = new AgriculturalYearsListViewModel() { Navigation = this.Navigation };
        }
    }
}