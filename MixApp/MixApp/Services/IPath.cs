using System;
using System.Collections.Generic;
using System.Text;

namespace MixApp.Services
{
    public interface IPath
    {
        string GetDatabasePath(string filename);
    }
}
