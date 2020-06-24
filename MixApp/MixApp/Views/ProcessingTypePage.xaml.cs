using Xamarin.Forms;
using MixApp.ViewModels;

namespace MixApp.Views
{
    public partial class ProcessingTypePage : ContentPage
    {
        public ProcessingTypeViewModel ViewModel { get; private set; }
        public ProcessingTypePage(ProcessingTypeViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}