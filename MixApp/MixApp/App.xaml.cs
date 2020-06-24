using MixApp.Repositories;
using MixApp.Services;
using MixApp.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MixApp
{
    public partial class App : Application
    {
        public const string DBFILENAME = "mixapp.db";
        //public static FieldRepository database;

        /*public static FieldRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new FieldRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DB_NAME));
                }
                return database;
            }
        }*/

        public App()
        {
            InitializeComponent();

            string dbPath = DependencyService.Get<IPath>().GetDatabasePath(DBFILENAME);
            using (var db = new ApplicationContext(dbPath))
            {
                // Создаем бд, если она отсутствует
                db.Database.EnsureCreated();
            }

            //DependencyService.Register<FieldDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
