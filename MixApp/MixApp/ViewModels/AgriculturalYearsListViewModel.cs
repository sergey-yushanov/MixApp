using MixApp.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace MixApp.ViewModels
{
    public class AgriculturalYearsListViewModel : BaseViewModel
    {
        public ObservableCollection<AgriculturalYearViewModel> AgriculturalYears { get; set; }

        public ICommand CreateAgriculturalYearCommand { protected set; get; }
        public ICommand DeleteAgriculturalYearCommand { protected set; get; }
        public ICommand SaveAgriculturalYearCommand { protected set; get; }
        //public ICommand BackCommand { protected set; get; }
        AgriculturalYearViewModel selectedAgriculturalYear;

        public INavigation Navigation { get; set; }

        public AgriculturalYearsListViewModel()
        {
            AgriculturalYears = new ObservableCollection<AgriculturalYearViewModel>();
            CreateAgriculturalYearCommand = new Command(CreateAgriculturalYear);
            DeleteAgriculturalYearCommand = new Command(DeleteAgriculturalYear);
            SaveAgriculturalYearCommand = new Command(SaveAgriculturalYear);
        }

        public AgriculturalYearViewModel SelectedAgriculturalYear
        {
            get { return selectedAgriculturalYear; }
            set
            {
                if (selectedAgriculturalYear != value)
                {
                    AgriculturalYearViewModel tempAgriculturalYear = value;
                    selectedAgriculturalYear = null;
                    OnPropertyChanged(nameof(selectedAgriculturalYear));
                    Navigation.PushAsync(new AgriculturalYearPage(tempAgriculturalYear));
                }
            }
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private void CreateAgriculturalYear()
        {
            Navigation.PushAsync(new AgriculturalYearPage(new AgriculturalYearViewModel() { ListViewModel = this }));
        }

        private void DeleteAgriculturalYear(object agriculturalYearObject)
        {
            AgriculturalYearViewModel agriculturalYear = agriculturalYearObject as AgriculturalYearViewModel;
            if (agriculturalYear != null)
            {
                AgriculturalYears.Remove(agriculturalYear);
            }
            Back();
        }

        private void SaveAgriculturalYear(object agriculturalYearInstance)
        {
            AgriculturalYearViewModel agriculturalYear = agriculturalYearInstance as AgriculturalYearViewModel;
            if (agriculturalYear != null && agriculturalYear.IsValid)
            {
                AgriculturalYears.Add(agriculturalYear);
            }
            Back();
        }
    }
}
