using Xamarin.Forms;
using MixApp.ViewModels;

namespace MixApp.Views
{
    public partial class FieldPage : ContentPage
    {
        public FieldViewModel ViewModel { get; private set; }
        public FieldPage(FieldViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}