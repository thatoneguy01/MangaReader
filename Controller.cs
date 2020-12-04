using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaReader
{
    class Controller
    {
        public static String dataPath = null;
        public static void Startup()
        {
            var appdataRoot = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appdataPath = Path.Combine(appdataRoot, "MangaReader");
            Directory.CreateDirectory(appdataPath);
            dataPath = appdataPath;
        }

        public void Refresh()
        {

        }

    }
}
