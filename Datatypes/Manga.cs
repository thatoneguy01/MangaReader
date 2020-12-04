using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaReader
{
    public class Manga : IEquatable<Manga>
    {
        public Manga(String url)
        {
            this.id = url.Substring(url.LastIndexOf('/') + 1);
            this.imageUrl = Scraper.GetMangaImage(url);
            var chapterUrls = Scraper.GetChapterUrls(url);
            this.chapters = chapterUrls.Select(chapterUrl => new Chapter(chapterUrl, true)).ToList();
        }

        public Manga(string name, string id, string url, string imageUrl, IList<Chapter> readChapters, IList<Chapter> unreadChapters)
        {
            this.name = name;
            this.id = id;
            this.url = url;
            this.imageUrl = imageUrl;
            this.chapters = readChapters;
        }

        public string name { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
        public IList<Chapter> chapters { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as Manga);
        }

        public bool Equals(Manga other)
        {
            return other != null &&
                   name == other.name &&
                   id == other.id &&
                   url == other.url &&
                   imageUrl == other.imageUrl &&
                   EqualityComparer<IList<Chapter>>.Default.Equals(chapters, other.chapters);
        }

        public override int GetHashCode()
        {
            int hashCode = -746865582;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(url);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(imageUrl);
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<Chapter>>.Default.GetHashCode(chapters);
            return hashCode;
        }

        public void GetNewChapters()
        {
            DataManager dm = new DataManager(Controller.dataPath);
            var currentChapterUrls = Scraper.GetChapterUrls(this.url);
            var currentChapters = currentChapterUrls.Select(chapterUrl => new Chapter(chapterUrl, true)).ToList();
            var unreadChapters = currentChapters.Except(this.chapters);
            foreach (Chapter ch in currentChapters)
            {
                if (unreadChapters.Contains(ch))
                {
                    currentChapters.ElementAt(currentChapters.IndexOf(ch)).read = false;
                }
            }
            this.chapters = currentChapters;
            dm.UpdateFavorite(this);
        }
    }
}
