using MixApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MixApp.ViewModels
{
    public class ProcessingTypeViewModel : BaseViewModel
    {
        ProcessingTypesListViewModel lvm;

        public ProcessingType ProcessingType { get; private set; }

        public ProcessingTypeViewModel()
        {
            ProcessingType = new ProcessingType();
        }

        public ProcessingTypesListViewModel ListViewModel
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
            get { return ProcessingType.Name; }
            set
            {
                if (ProcessingType.Name != value)
                {
                    ProcessingType.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Code
        {
            get { return ProcessingType.Code; }
            set
            {
                if (ProcessingType.Code != value)
                {
                    ProcessingType.Code = value;
                    OnPropertyChanged(nameof(Code));
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
