using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJSON.Helpers
{
    internal class PathHelper
    {
        public static string GetConfigJsonPath()
        {
            string folderpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Libreria.json");
            return folderpath;
        }
    }
}
