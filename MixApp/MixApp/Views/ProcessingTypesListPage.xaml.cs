using Xamarin.Forms;
using MixApp.ViewModels;

namespace MixApp.Views
{
    public partial class ProcessingTypesListPage : ContentPage
    {
        public ProcessingTypesListPage()
        {
            InitializeComponent();
            BindingContext = new ProcessingTypesListViewModel() { Navigation = this.Navigation };
        }
    }
}