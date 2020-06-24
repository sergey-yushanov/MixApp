using System;
using System.IO;
using MixApp.Droid;
using MixApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(AndroidDbPath))]
namespace MixApp.Droid
{
    public class AndroidDbPath : IPath
    {
        public string GetDatabasePath(string filename)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), filename);
        }
    }
}