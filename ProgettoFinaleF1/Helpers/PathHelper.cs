using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoFinaleF1.Helpers
{
    class PathHelper
    {
        public static string GetConfigJsonPath ( )
        {
            string folderpath = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments), "drivers.json");
            return folderpath;
        }
    }
}
