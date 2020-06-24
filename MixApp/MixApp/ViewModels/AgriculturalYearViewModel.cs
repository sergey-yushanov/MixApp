using MixApp.Models;
using System;

namespace MixApp.ViewModels
{
    public class AgriculturalYearViewModel : BaseViewModel
    {
        AgriculturalYearsListViewModel lvm;

        public AgriculturalYear AgriculturalYear { get; private set; }

        public AgriculturalYearViewModel()
        {
            AgriculturalYear = new AgriculturalYear();
        }

        public AgriculturalYearsListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged(nameof(ListViewModel));
                }
            }
        }

        public string Name
        {
            get { return AgriculturalYear.Name; }
            set
            {
                if (AgriculturalYear.Name != value)
                {
                    AgriculturalYear.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public DateTime FinishDate
        {
            get { return AgriculturalYear.FinishDate; }
            set
            {
                if (AgriculturalYear.FinishDate != value)
                {
                    AgriculturalYear.FinishDate = value;
                    OnPropertyChanged(nameof(FinishDate));
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return (!string.IsNullOrEmpty(Name.Trim()));
            }
        }
    }
}
