using MixApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MixApp.ViewModels
{
    public class FieldsListViewModel : BaseViewModel
    {
        public ObservableCollection<FieldViewModel> fields { get; set; }

        public ICommand CreateFieldCommand { protected set; get; }
        public ICommand DeleteFieldCommand { protected set; get; }
        public ICommand SaveFieldCommand { protected set; get; }
        //public ICommand BackCommand { protected set; get; }
        FieldViewModel selectedField;

        public INavigation Navigation { get; set; }

        public FieldsListViewModel()
        {
            fields = new ObservableCollection<FieldViewModel>();
            CreateFieldCommand = new Command(CreateField);
            DeleteFieldCommand = new Command(DeleteField);
            SaveFieldCommand = new Command(SaveField);
        }

        public FieldViewModel SelectedField
        {
            get { return selectedField; }
            set
            {
                if (selectedField != value)
                {
                    FieldViewModel tempField = value;
                    selectedField = null;
                    OnPropertyChanged(nameof(SelectedField));
                    Navigation.PushAsync(new FieldPage(tempField));
                }
            }
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private void CreateField()
        {
            Navigation.PushAsync(new FieldPage(new FieldViewModel() { ListViewModel = this }));
        }

        private void DeleteField(object fieldInstance)
        {
            FieldViewModel field = fieldInstance as FieldViewModel;
            if (field != null)
            {
                fields.Remove(field);
            }
            Back();
        }

        private void SaveField(object fieldInstance)
        {
            FieldViewModel field = fieldInstance as FieldViewModel;
            if (field != null && field.IsValid)
            {
                fields.Add(field);
            }
            Back();
        }
    }
}
