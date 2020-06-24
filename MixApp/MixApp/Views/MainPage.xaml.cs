using MixApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MixApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();
            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Mixtures, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    //case (int)MenuItemType.Applicators:
                        //MenuPages.Add(id, new NavigationPage(new ProcessingTypesListPage()));
                        //break;
                    case (int)MenuItemType.ProcessingTypes:
                        MenuPages.Add(id, new NavigationPage(new ProcessingTypesListPage()));
                        break;
                    case (int)MenuItemType.AgriculturalYears:
                        MenuPages.Add(id, new NavigationPage(new AgriculturalYearsListPage()));
                        break;
                    case (int)MenuItemType.Fields:
                        MenuPages.Add(id, new NavigationPage(new FieldsListPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}