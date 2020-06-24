using MixApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MixApp.ViewModels
{
    public class ProcessingTypesListViewModel : BaseViewModel
    {
        public ObservableCollection<ProcessingTypeViewModel> ProcessingTypes { get; set; }

        public ICommand CreateProcessingTypeCommand { protected set; get; }
        public ICommand DeleteProcessingTypeCommand { protected set; get; }
        public ICommand SaveProcessingTypeCommand { protected set; get; }
        //public ICommand BackCommand { protected set; get; }
        ProcessingTypeViewModel selectedProcessingType;

        public INavigation Navigation { get; set; }

        public ProcessingTypesListViewModel()
        {
            ProcessingTypes = new ObservableCollection<ProcessingTypeViewModel>();
            CreateProcessingTypeCommand = new Command(CreateProcessingType);
            DeleteProcessingTypeCommand = new Command(DeleteProcessingType);
            SaveProcessingTypeCommand = new Command(SaveProcessingType);
        }

        public ProcessingTypeViewModel SelectedProcessingType
        {
            get { return selectedProcessingType; }
            set
            {
                if (selectedProcessingType != value)
                {
                    ProcessingTypeViewModel tempProcessingType = value;
                    selectedProcessingType = null;
                    OnPropertyChanged(nameof(SelectedProcessingType));
                    Navigation.PushAsync(new ProcessingTypePage(tempProcessingType));
                }
            }
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private void CreateProcessingType()
        {
            Navigation.PushAsync(new ProcessingTypePage(new ProcessingTypeViewModel() { ListViewModel = this }));
        }

        private void DeleteProcessingType(object ProcessingTypeObject)
        {
            ProcessingTypeViewModel ProcessingType = ProcessingTypeObject as ProcessingTypeViewModel;
            if (ProcessingType != null)
            {
                ProcessingTypes.Remove(ProcessingType);
            }
            Back();
        }

        private void SaveProcessingType(object ProcessingTypeInstance)
        {
            ProcessingTypeViewModel ProcessingType = ProcessingTypeInstance as ProcessingTypeViewModel;
            if (ProcessingType != null && ProcessingType.IsValid)
            {
                ProcessingTypes.Add(ProcessingType);
            }
            Back();
        }
    }
}
