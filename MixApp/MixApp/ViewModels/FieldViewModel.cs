using MixApp.Models;

namespace MixApp.ViewModels
{
    public class FieldViewModel : BaseViewModel
    {
        FieldsListViewModel fieldsLvm;

        public Field field { get; private set; }

        public FieldViewModel()
        {
            field = new Field();
        }

        public FieldsListViewModel ListViewModel
        {
            get { return fieldsLvm; }
            set
            {
                if (fieldsLvm != value)
                {
                    fieldsLvm = value;
                    OnPropertyChanged(nameof(ListViewModel));
                }
            }
        }

        public string Name
        {
            get { return field.Name; }
            set
            {
                if (field.Name != value)
                {
                    field.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Code
        {
            get { return field.Code; }
            set
            {
                if (field.Code != value)
                {
                    field.Code = value;
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
