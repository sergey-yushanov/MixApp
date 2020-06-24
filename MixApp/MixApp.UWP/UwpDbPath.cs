using MixApp.Services;
using MixApp.UWP;
using System;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(UwpDbPath))]
namespace MixApp.UWP
{
    public class UwpDbPath : IPath
    {
        public string GetDatabasePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }
    }
}
