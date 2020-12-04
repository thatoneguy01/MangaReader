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
        private static IList<Manga> favoritesData = null;

        public DataManager(String dataPath)
        {
            this.dataPath = dataPath;
        }

        public IList<Manga> GetFavorites()
        {
            if (favoritesData is null)
            {
                string text = File.ReadAllText(Path.Combine(dataPath, "favorites.json"));
                IList<Manga> favoritesList = JsonConvert.DeserializeObject<IList<Manga>>(text);
                favoritesData = favoritesList;
                return favoritesList;
            }
            else
            {
                return favoritesData;
            }
        }

        public void SaveFavorites()
        {
            File.WriteAllText(dataPath, JsonConvert.SerializeObject(favoritesData));
        }

        public IList<String> GetFavoritesUrls()
        {
            var favorites = GetFavorites();
            return favorites.Select(favorite => favorite.url).ToList();
        }
        
        public void AddFavorite(Manga manga)
        {
            favoritesData.Add(manga);
        }

        public void UpdateFavorite(Manga manga)
        {
            var favCopyIndex = favoritesData.IndexOf(favoritesData.Where(fav => fav.id == manga.id).FirstOrDefault());
            favoritesData.ElementAt(favCopyIndex).chapters = manga.chapters;
        }

        public void RemoveFavorite(String name)
        {
            favoritesData = favoritesData.Where(manga => manga.name != name).ToList();
        }

    }
}
