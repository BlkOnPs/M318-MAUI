using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaJson.Helpers
{
    internal class PathHelper
    {
        public static string GetConfigJsonPath ( )
        {
            string folderPath = Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine (folderPath, "videogames.json");
            return filePath;
        }
    }
}
