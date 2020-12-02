using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaReader
{
    class DataManager
    {
        private String dataPath;

        public DataManager(String dataPath)
        {
            this.dataPath = dataPath;
        }

        public List<String> GetFavorites()
        {
            string text = File.ReadAllText(Path.Combine(dataPath, "favorites.json");
            IList<Manga> favoritesList = JsonConvert.DeserializeObject<IList<Manga>>(text);
        }
    }
}
