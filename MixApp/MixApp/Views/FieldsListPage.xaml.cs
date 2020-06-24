using MixApp.ViewModels;
using Xamarin.Forms;

namespace MixApp.Views
{
    public partial class FieldsListPage : ContentPage
    {
        public FieldsListPage()
        {
            InitializeComponent();
            BindingContext = new FieldsListViewModel() { Navigation = this.Navigation };
        }
    }
}