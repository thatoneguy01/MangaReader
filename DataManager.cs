using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Security.AccessControl;

namespace MangaReader
{
    class DataManager
    {
        private static String dataPath;
        private static String favsImgPath;
        private static IList<Manga> favoritesData;

        public DataManager()
        {
            var appdataRoot = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var appdataPath = Path.Combine(appdataRoot, "MangaReader");
            if (!Directory.Exists(appdataPath))
            {
                Directory.CreateDirectory(appdataPath);
            }
            var favImgPath = Path.Combine(appdataPath, "favsCoverImages");
            if (!Directory.Exists(favImgPath)) 
            {
                Directory.CreateDirectory(favImgPath);
            }
            dataPath = appdataPath;
            favsImgPath = favImgPath;
        }

        public IList<Manga> GetFavorites()
        {
            if (favoritesData is null)
            {
                if (!File.Exists(Path.Combine(dataPath, "favorites.json")))
                {
                    File.WriteAllText(Path.Combine(dataPath, "favorites.json"), "[]");
                }
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
            File.WriteAllText(Path.Combine(dataPath, "favorites.json"), JsonConvert.SerializeObject(favoritesData));
        }

        public IList<String> GetFavoritesUrls()
        {
            var favorites = GetFavorites();
            return favorites.Select(favorite => favorite.url).ToList();
        }
        
        public void AddFavorite(Manga manga)
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(new Uri(manga.imageUrl), Path.Combine(favsImgPath, manga.id+".jpg"));
            }
            favoritesData.Add(manga);
        }

        public void UpdateFavorite(Manga manga)
        {
            var favorites = GetFavorites();
            var favCopyIndex = favoritesData.IndexOf(favoritesData.Where(fav => fav.id == manga.id).FirstOrDefault());
            favorites.ElementAt(favCopyIndex).chapters = manga.chapters;
        }

        public void RemoveFavorite(String name)
        {
            var favorites = GetFavorites();
            favorites = favorites.Where(manga => manga.title != name).ToList();
        }

        public Manga FavoriteWithUrl(String url)
        {
            var favorites = GetFavorites();
            return favorites.Where(fav => fav.url == url).First();
        }

        public string ImgPathForMangaId(String id)
        {
            return Path.Combine(favsImgPath, id + ".jpg");
        }
    }
}
